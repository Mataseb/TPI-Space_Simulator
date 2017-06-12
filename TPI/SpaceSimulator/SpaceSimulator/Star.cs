/*
#--------------------------------------------------------------------------
# TPI 2017 - Auteur : Mata Sebastian
# Nom du fichier : Space Simulator : Star.cs
# Date : 19 juin 2017
#--------------------------------------------------------------------------
# Objet Étoile
# Squelette des étoiles, contient toutes les données nécessaires au programme ainsi que toutes les fonctions
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
    public class Star
    {
        int _ratioRay;
        int _id;
        string _name;
        double _ray;
        Point _center;
        Point _drawingPosition;
        Image _image;
        List<Planet> _planets;

        #region Properties
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public double Ray
        {
            get
            {
                return _ray;
            }

            set
            {
                _ray = value;
            }
        }

        public int DrawingRay
        {
            get
            {
                return Convert.ToInt32(_ray / RatioRay);
            }
        }

        public Point Center
        {
            get
            {
                return _center;
            }

            set
            {
                _center = value;
            }
        }
        

        public Image Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        }

        internal List<Planet> Planets
        {
            get
            {
                return _planets;
            }

            set
            {
                _planets = value;
            }
        }

        public Point DrawingPosition
        {
            get
            {
                return _drawingPosition;
            }

            set
            {
                _drawingPosition = value;
            }
        }

        public int RatioRay
        {
            get
            {
                return _ratioRay;
            }

            set
            {
                _ratioRay = value;
            }
        }
        #endregion

        /// <summary>
        /// Crée une étoile
        /// </summary>
        /// <param name="id">son identifiant en base</param>
        /// <param name="name">le nom</param>
        /// <param name="ray">le rayon</param>
        /// <param name="image">l'image</param>
        public Star(int id, string name, double ray, Image image)
        {
            this.RatioRay = 10000;
            this.Id = id;
            this.Name = name;
            this.Ray = ray;
            this.Image = image;
        }

        /// <summary>
        /// Obtient le nom de l'étoile
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }

        /// <summary>
        /// Obtient la distance entre un point et le centre de l'étoile
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public double DistanceFromPoint(Point point)
        {
            int distanceX = Math.Abs(this.Center.X - point.X);
            int distanceY = Math.Abs(this.Center.Y - point.Y);
            return Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
        }

        /// <summary>
        /// Détérmine si l'étoile contient le point
        /// </summary>
        /// <param name="point">Le point à comparer.</param>
        /// <param name="zoom">Le niveau de zoom actuel de l'univers</param>
        /// <returns></returns>
        public bool ContainsPoint(Point point, Double zoom)
        {
            if (this.DistanceFromPoint(point) < (this.DrawingRay * zoom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Dessine l'étoile
        /// </summary>
        /// <param name="canvas">Le canvas sur lequel l'étoile doit être dessinée</param>
        /// <param name="view">Le point en fonction duquel l'étoile doit être dessinée</param>
        /// <param name="zoom">Le niveau de zoom actuelle de l'univers</param>
        /// <param name="widthContainer">La largeur du container</param>
        /// <param name="heightContainer">La hauteur du container</param>
        public void Paint(Graphics canvas, Point view, double zoom, int widthContainer, int heightContainer)
        {
            this.Center = new Point(
                (view.X + (widthContainer / 2)),
                (view.Y + (heightContainer / 2)));

            this.DrawingPosition = new Point(
                (Center.X - (int)(zoom * this.DrawingRay)),
                (Center.Y - (int)(zoom * this.DrawingRay)));

            canvas.DrawImage(
                this.Image,
                this.DrawingPosition.X,
                this.DrawingPosition.Y,
                (int)(2 * (this.DrawingRay * zoom)),
                (int)(2 * (this.DrawingRay * zoom)));
        }
    }
}
