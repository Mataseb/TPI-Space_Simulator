using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceSimulator
{
    public class SpaceModel
    {
        const double Puissance_ZOOM = 0.1; 
        public const int ID_STAR = 1;

        Star _star; //L'étoile référentielle du système
        Star _focus; //Le corps celeste sur lequel est concentrée la vue

        bool _timeDirection; //Le temps passe ou recule
        int _SpaceDayAge; //Le nombre de jours écoulés depuis la date actuelle
        int _timeSpeed; //La vitesse à laquelle les jours passent
        double _zoom; //Le niveau de zoom auquel l'espace est affiché
        Point _view; //Le point de vue
        bool _ellipses; //Les orbites des planètes sont-elles dessinées

        #region Properties
        internal Star Star
        {
            get
            {
                return _star;
            }

            set
            {
                _star = value;
            }
        }

        public bool TimeDirection
        {
            get
            {
                return _timeDirection;
            }

            set
            {
                _timeDirection = value;
            }
        }

        public int SpaceDayAge
        {
            get
            {
                return _SpaceDayAge;
            }

            set
            {
                _SpaceDayAge = value;
            }
        }

        public int TimeSpeed
        {
            get
            {
                return _timeSpeed;
            }

            set
            {
                _timeSpeed = value;
            }
        }

        public double Zoom
        {
            get
            {
                return _zoom;
            }

            set
            {
                _zoom = value * Puissance_ZOOM;
            }
        }

        public Point View
        {
            get
            {
                return _view;
            }

            set
            {
                _view = value;
            }
        }

        public Star Focus
        {
            get
            {
                return _focus;
            }

            set
            {
                _focus = value;
            }
        }

        public bool Ellipses
        {
            get
            {
                return _ellipses;
            }

            set
            {
                _ellipses = value;
            }
        }
        #endregion

        public SpaceModel()
        {
            SpaceDayAge = 0;
            Zoom = 50;
            TimeSpeed = 1;
            Ellipses = true;
            Star = DataAccessObject.GetStarFromId(ID_STAR);
            Star.Planets = DataAccessObject.GetPlanetsFromStar(Star);
            foreach (Planet planet in Star.Planets)
            {
                planet.Moons = DataAccessObject.GetMoonsFromPlanet(planet);
            }
            Focus = Star;
        }

        #region CRUD
        /// <summary>
        /// Insère un objet dans la base de données, puis crée un objet planète à partir de l'objet ajouté à la base.
        /// </summary>
        /// <param name="name">nom</param>
        /// <param name="ray">rayon en kilomètres</param>
        /// <param name="period">durée d'une révolution en cours</param>
        /// <param name="distanceOrbitCenter">la distance entre le centre de l'orbite de la planète et le centre de la planète</param>
        /// <param name="image">l'image à afficher pour représenter la planète</param>
        /// <param name="orbitCenterId">l'idenditifant du corps autour duquel orbite le satellite</param>
        public void CreatePlanet(string name, double ray, double period, double distanceOrbitCenter, Image image, int orbitCenterId)
        {
            DataAccessObject.InsertPlanet(name, ray, period, distanceOrbitCenter, image, orbitCenterId);
            Star.Planets.Add(DataAccessObject.GetPlanetFromName(name, Star));
        }

        /// <summary>
        /// les données d'une planète ont été modifiées. Envoie cette planète au DAO qui recherche les anciennes données correspondantes à travers l'id.
        /// Modifie ensuite les données de la base en conséquence.
        /// </summary>
        /// <param name="updatedPlanet"></param>
        public void UpdatePlanet(Planet updatedPlanet)
        {
            DataAccessObject.UpdatePlanet(updatedPlanet);
        }
        public void DeletePlanet(Planet destroyedPlanet)
        {
            Star.Planets.Remove(destroyedPlanet);
            DataAccessObject.DeletePlanet(destroyedPlanet);
        }

        public void CreateMoon(string name, double ray, double period, double distanceOrbitCenter, Image image, int orbitCenterId)
        {
            DataAccessObject.InsertMoon(name, ray, period, distanceOrbitCenter, image, orbitCenterId);
            Star.Planets[orbitCenterId-1].Moons.Add(DataAccessObject.GetMoonFromName(name, Star.Planets[orbitCenterId-1]));
        }

        /// <summary>
        /// Met à jour la lune dans la base de donnée
        /// </summary>
        /// <param name="updatedMoon">lune modifiée</param>
        public void UpdateMoon(Moon updatedMoon)
        {
            DataAccessObject.UpdateMoon(updatedMoon);
        }

        /// <summary>
        /// Supprime la lune de la liste des lunes de la planète autour de laquelle elle orbitait et de la base de données
        /// </summary>
        /// <param name="destroyedMoon">lune à détruire</param>
        public void DeleteMoon(Moon destroyedMoon)
        {
            Star.Planets[destroyedMoon.OrbitCenter.Id-1].Moons.Remove(destroyedMoon);
            DataAccessObject.DeleteMoon(destroyedMoon);
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="click">Position du click de la souris</param>
        /// <returns></returns>
        public Star ClickIsOn(Point click)
        {
            if (Star.ContainsPoint(click, Zoom))
            {
                return Star;
            }
            Star.ContainsPoint(click, Zoom);
            foreach (Planet planet in Star.Planets)
            {
                if (planet.ContainsPoint(click, Zoom))
                {
                    return planet;
                }
                foreach (Moon moon in planet.Moons)
                {
                    if (moon.ContainsPoint(click, Zoom))
                    {
                        return moon;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// Les jours avancent à la vitesse du temps.
        /// </summary>
        public void TimeForward()
        {
            SpaceDayAge += TimeSpeed;
        }

        /// <summary>
        /// Les jours reculent à la vitesse du temps.
        /// </summary>
        public void TimeBackwards()
        {
            SpaceDayAge -= TimeSpeed;
        }

        /// <summary>
        /// Centre la vue autour de l'objet suivi. 
        /// Dessine l'étoile, chacune de ses planètes, et pour chaque planète chacune de ses lunes si elle en a.
        /// </summary>
        /// <param name="canvas">graphique sur lequel dessiner</param>
        /// <param name="widthContainer">la largeur de l'affichage</param>
        /// <param name="heigtContainer">la hauteur de l'affichage</param>
        public void Paint(Graphics canvas, int widthContainer, int heigtContainer)
        {
            View = new Point(-(Focus.Center.X - Star.Center.X), -(Focus.Center.Y - Star.Center.Y)-25);
            Star.Paint(canvas, View, Zoom, widthContainer, heigtContainer);

            foreach (Planet planet in Star.Planets)
            {
                planet.Paint(SpaceDayAge, Zoom, View, Ellipses, canvas);
                foreach (Moon moon in planet.Moons)
                {
                    moon.Paint(SpaceDayAge, Zoom, View, Ellipses, canvas);
                }
            }
        }
    }
}
