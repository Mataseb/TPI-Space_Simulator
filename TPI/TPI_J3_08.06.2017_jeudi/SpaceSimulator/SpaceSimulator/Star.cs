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

        public Star(int id, string name, double ray, Image image)
        {
            this.RatioRay = 10000;
            this.Id = id;
            this.Name = name;
            this.Ray = ray;
            this.Image = image;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public double DistanceFromPoint(Point point)
        {
            int distanceX = Math.Abs(this.Center.X - point.X);
            int distanceY = Math.Abs(this.Center.Y - point.Y);
            return Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
        }

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
