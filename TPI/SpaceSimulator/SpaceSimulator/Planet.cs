/*
#--------------------------------------------------------------------------
# TPI 2017 - Auteur : Mata Sebastian
# Nom du fichier : Space Simulator : Planet.cs
# Date : 19 juin 2017
#--------------------------------------------------------------------------
# Objet Planète
# Squelette des planètes, hérite d'étoile, contient toutes les données nécessaires au programme ainsi que toutes les fonctions
#
# Version 1.0 : 19 juin 2017
#--------------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceSimulator
{
    public class Planet : Star
    {
        int _ratioDistanceOrbitCenter;
        Star _orbitCenter;
        double _distanceOrbitCenter;
        double _period;
        double _positionOnPeriod;
        List<Moon> _moons;

        #region Properties
        internal Star OrbitCenter
        {
            get
            {
                return _orbitCenter;
            }

            set
            {
                _orbitCenter = value;
            }
        }

        public double DistanceOrbitCenter
        {
            get
            {
                return _distanceOrbitCenter;
            }

            set
            {
                _distanceOrbitCenter = value;
            }
        }

        public int DrawingDistanceOrbitCenter
        {
            get
            {
                return Convert.ToInt32(_distanceOrbitCenter / RatioDistanceOrbitCenter);
            }
        }

        public double Period
        {
            get
            {
                return _period;
            }

            set
            {
                _period = value;
            }
        }

        public new double DrawingRay
        {
            get
            {
                return this.Ray / this.RatioRay;
            }
        }
        public double PositionOnPeriod
        {
            get
            {
                return _positionOnPeriod;
            }

            set
            {
                _positionOnPeriod = value;
            }
        }
        public double Angle
        {
            get
            {
                double degrees;
                double angle;
                double indice = Convert.ToDouble(Period) / Convert.ToDouble(PositionOnPeriod);

                degrees = 360 / indice;
                angle = Math.PI * degrees / 180; //Convertion en radiants

                return angle;
            }
        }

        internal List<Moon> Moons
        {
            get
            {
                return _moons;
            }

            set
            {
                _moons = value;
            }
        }

        public int RatioDistanceOrbitCenter
        {
            get
            {
                return _ratioDistanceOrbitCenter;
            }

            set
            {
                _ratioDistanceOrbitCenter = value;
            }
        }
        #endregion

        /// <summary>
        /// Crée une planète, hérite d'étoile
        /// </summary>
        /// <param name="orbitCenter">l'étoile référentielle</param>
        /// <param name="id">l'dentifiant en base</param>
        /// <param name="name">le nom</param>
        /// <param name="ray">le rayon</param>
        /// <param name="period">la période</param>
        /// <param name="distanceOrbitCenter">La distance au centre de l'orbite</param>
        /// <param name="image">l'image représentant la planète</param>
        public Planet(Star orbitCenter, int id, string name, double ray, double period, double distanceOrbitCenter, Image image) : base(id, name, ray, image)
        {
            Moons = new List<Moon>();
            this.RatioDistanceOrbitCenter = 5;
            this.RatioRay = 2500;
            this.OrbitCenter = orbitCenter;
            this.Id = id;
            this.Name = name;
            this.Ray = ray;
            this.Period = period;
            this.DistanceOrbitCenter = distanceOrbitCenter;
            this.Image = image;
        }

        /// <summary>
        /// Défini la position actuelle de la planète en fonction du zoom
        /// </summary>
        /// <param name="zoom"></param>
        public void SetCenterLivePosition(double zoom)
        {
            double adjacent;
            double oppose;

            //L'angle donne la direction dans laquelle la planète se trouve par rapport à son référentiel
            adjacent = Math.Cos(Angle) * (DrawingDistanceOrbitCenter + OrbitCenter.DrawingRay);
            oppose = Math.Sin(Angle) * (DrawingDistanceOrbitCenter + OrbitCenter.DrawingRay);

            int X = OrbitCenter.Center.X + (int)(adjacent * zoom);
            int Y = OrbitCenter.Center.Y + (int)(oppose * zoom);
            this.Center = new Point(X, Y);
        }
        
        /// <summary>
        /// Dessine la planète
        /// </summary>
        /// <param name="date">la date actuelle de l'univers</param>
        /// <param name="zoom">le niveau de zoom actuel de l'univers</param>
        /// <param name="view">la vue actuelle de l'univers</param>
        /// <param name="drawEllipse">faut-il dessiner les ellipses?</param>
        /// <param name="canvas">la toile sur laquelle dessiner</param>
        public void Paint(double date, double zoom, Point view, bool drawEllipse, Graphics canvas)
        {
            /*
            PositionOnPeriod = date % Period;
            SetCenterLivePosition(zoom);
            
            //Dessine l'ellipse sur laquelle la planète orbite
            if (drawEllipse)
            {
                canvas.DrawEllipse(Pens.Gray,
                (OrbitCenter.Center.X - (int)((zoom * ((DrawingDistanceOrbitCenter) + OrbitCenter.DrawingRay)))),
                (OrbitCenter.Center.Y - (int)((zoom * ((DrawingDistanceOrbitCenter) + OrbitCenter.DrawingRay)))),
                (int)(2 * (zoom * (DrawingDistanceOrbitCenter + OrbitCenter.DrawingRay))),
                (int)(2 * (zoom * (DrawingDistanceOrbitCenter + OrbitCenter.DrawingRay))));
            }
            
            //Dessine la planète
            canvas.DrawImage(this.Image,
                (Center.X - (int)(zoom * (this.DrawingRay))),
                (Center.Y - (int)(zoom * (this.DrawingRay))),
                (int)(2 * ((zoom * (this.DrawingRay)))),
                (int)(2 * ((zoom * (this.DrawingRay)))));
                */
        }
    }
}
