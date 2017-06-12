/*
#--------------------------------------------------------------------------
# TPI 2017 - Auteur : Mata Sebastian
# Nom du fichier : Space Simulator : Moon.cs
# Date : 19 juin 2017
#--------------------------------------------------------------------------
# Objet Lune
# Squelette des Lunes, hérite de planète, contient toutes les données nécessaires au programme ainsi que toutes les fonctions
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
    public class Moon : Planet
    {
        /// <summary>
        /// Crée une lune
        /// </summary>
        /// <param name="orbitCenter">la planète référentielle</param>
        /// <param name="id">l'identifiant en base</param>
        /// <param name="name">le nom</param>
        /// <param name="ray">le rayon</param>
        /// <param name="period">la durée d'une révolution</param>
        /// <param name="distanceOrbitCenter">la distance au centre de l'orbite</param>
        /// <param name="image">l'image représentant la lune</param>
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