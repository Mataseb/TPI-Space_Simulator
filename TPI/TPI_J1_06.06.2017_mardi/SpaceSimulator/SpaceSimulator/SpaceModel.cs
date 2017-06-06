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
        public const int DISTANCE_VIEW_MOVE = 10;
        public const int ID_STAR = 1;

        Star _star; //L'étoile référentielle du système

        bool _timeDirection; //Le temps passe ou recule
        int _SpaceDayAge; //Le nombre de jours écoulés depuis la date actuelle
        int _timeSpeed; //La vitesse à laquelle les jours passent
        double _zoom; //Le niveau de zoom auquel l'espace est affiché
        Point _view; //Le point de vue

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
        #endregion

        public SpaceModel()
        {
            SpaceDayAge = 0;
            Zoom = 10;
            TimeSpeed = 10;

            Star = DataAccessObject.GetStarFromId(ID_STAR);
            Star.Planets = DataAccessObject.GetPlanetsFromStar(Star);
        }
        
        /// <summary>
        /// Insère un objet dans la base de données, puis crée un objet planète à partir de l'objet ajouté à la base.
        /// </summary>
        /// <param name="name">nom</param>
        /// <param name="ray">rayon en kilomètres</param>
        /// <param name="period">durée d'une révolution en cours</param>
        /// <param name="distanceOrbitCenter"></param>
        /// <param name="image"></param>
        /// <param name="orbitCenterId"></param>
        public void CreatePlanet(string name, double ray, double period, double distanceOrbitCenter, Image image, int orbitCenterId)
        {
            DataAccessObject.InsertPlanet(name, ray, period, distanceOrbitCenter, image, orbitCenterId);
            Star.Planets.Add(DataAccessObject.GetPlanetFromName(name, Star));
        }
        public void UpdatePlanet(Planet updatedPlanet)
        {
            DataAccessObject.UpdatePlanet(updatedPlanet);
        }
        public void DeletePlanet(Planet destroyedPlanet)
        {
            Star.Planets.Remove(destroyedPlanet);
            DataAccessObject.DeletePlanet(destroyedPlanet);
        }

        public void MoveUp()
        {
            //View = new Point(View.X, View.Y - DISTANCE_VIEW_MOVE);
        }
        public void MoveDown()
        {
            //View = new Point(View.X, View.Y + DISTANCE_VIEW_MOVE);
        }
        public void MoveRight()
        {
            //View = new Point(View.X + DISTANCE_VIEW_MOVE, View.Y);
        }
        public void MoveLeft()
        {
            //View = new Point(View.X - DISTANCE_VIEW_MOVE, View.Y);
        }
        public string ClickIsOn(Point click)
        {
            if (Star.ContainsPoint(click, Zoom))
            {
                return Star.ToString();
            }
            Star.ContainsPoint(click, Zoom);
            foreach (Planet satellite in Star.Planets)
            {
                if(satellite.ContainsPoint(click, Zoom))
                {
                    return satellite.ToString();
                }
            }
            return "Space";
        }

        /*public void TimeForward()
        {
            SpaceDayAge += TimeSpeed;
        }

        public void TimeBackwards()
        {
            SpaceDayAge -= TimeSpeed;
        }
        */
        public void Paint(Graphics canvas, int widthContainer, int heigtContainer)
        {
            //Star.Paint(canvas, View, Zoom, widthContainer, heigtContainer);
            //foreach (Planet satellite in Star.Planets)
            //{
            //    satellite.Paint(SpaceDayAge, Zoom, View, canvas);
            //}
        }
    }
}
