using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceSimulator
{
    public class Moon : Planet
    {

        public Moon(Planet orbitCenter, int id, string name, double ray, double period, double distanceOrbitCenter, Image image) : base(orbitCenter, id, name, ray, period, distanceOrbitCenter, image)
        {
            this.RatioDistanceOrbitCenter = 25;
            this.RatioRay = 2500;
            this.OrbitCenter = orbitCenter;
            this.Id = id;
            this.Name = name;
            this.Ray = ray;
            this.Period = period;
            this.DistanceOrbitCenter = distanceOrbitCenter;
            this.Image = image;
        }
    }
}