/*
#--------------------------------------------------------------------------
# TPI 2017 - Auteur : Mata Sebastian
# Nom du fichier : Space Simulator : DataAcessObject.cs
# Date : 19 juin 2017
#--------------------------------------------------------------------------
# Objet d'accès à la base de données
# Toutes les intéractions en lecture et en écriture entre le programme et la base de données sont effectuées ici
#
# Version 1.0 : 19 juin 2017
#--------------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;

namespace SpaceSimulator
{
    class DataAccessObject
    {
        static SQLiteConnection myConnection;

        /// <summary>
        /// Si la connexion à la base de donnée n'est pas faite, la fait
        /// </summary>
        static private void StartConnection()
        {
            if (myConnection == null)
            {
                myConnection = new SQLiteConnection(@"Data Source=Space.sqlite;Version=3;");
            }

            if (myConnection.State != ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        /// <summary>
        /// Converti une image en tableau de bytes
        /// </summary>
        /// <param name="img">image à convertir</param>
        /// <returns></returns>
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        /// <summary>
        /// (READ)
        /// à partir de l'identifiant donné, trouve dans la base l'étoile correspondante et la crée
        /// </summary>
        /// <param name="idStar"></param>
        /// <returns>Un objet étoile dont les données correspondent à l'enregistrement en base</returns>
        public static Star GetStarFromId(int idStar)
        {
            Star myStar = null;
            StartConnection();

            string SQLrequest = String.Format("SELECT * FROM stars WHERE id = {0}", idStar);

            SQLiteCommand command = new SQLiteCommand(SQLrequest, myConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            reader.Read();

            MemoryStream ms = new MemoryStream((byte[])reader["image"]);

            myStar = new Star
            (Convert.ToInt32(reader["id"].ToString()),
            reader["name"].ToString(),
            Convert.ToDouble(reader["ray"].ToString()),
            Image.FromStream(ms));

            myConnection.Close();

            return myStar;
        }

        #region CRUD Planet

        /// <summary>
        /// (CREATE)
        /// Insère une planète du programme dans la base de données
        /// </summary>
        /// <param name="name">nom</param>
        /// <param name="ray">rayon</param>
        /// <param name="period">durée d'une révolution</param>
        /// <param name="distanceOrbitCenter">distance entre le centre de la planète et le centre de l'orbite</param>
        /// <param name="image">image à afficher</param>
        /// <param name="orbitCenterId">id du référentiel autour duquel la planète orbite</param>
        public static void InsertPlanet(string name, double ray, double period, double distanceOrbitCenter, Image image, int orbitCenterId)
        {
            StartConnection();

            byte[] img = null;
            img = DataAccessObject.ImageToByte(image);

            string SQLrequest = String.Format("INSERT INTO planets ('name', 'ray', 'period', 'distanceToOrbitCenter', 'image', 'idStar') VALUES ('{0}', '{1}', '{2}', '{3}', @image, '{4}')",
                name, ray, period, distanceOrbitCenter, orbitCenterId);

            SQLiteCommand command = new SQLiteCommand(SQLrequest, myConnection);

            command.Parameters.Add("@image", DbType.Binary, 20).Value = img;

            command.ExecuteNonQuery();

            myConnection.Close();
        }


        /// <summary>
        /// (READ)
        /// à partir d'une étoile, trouve dans la base de données toutes les planètes qui orbitent autour de la dite étoile 
        /// et pour chaque enregistrement crée un objet planète dont les données correspondant à l'enregistrement
        /// </summary>
        /// <param name="star"></param>
        /// <returns>Une liste des planètes qui orbitent autour de l'étoile donnée</returns>
        public static List<Planet> GetPlanetsFromStar(Star star)
        {
            List<Planet> orbitingPlanets = new List<Planet>();
            StartConnection();

            string SQLrequest = String.Format("SELECT * FROM planets WHERE idStar = {0}", star.Id);


            SQLiteCommand command = new SQLiteCommand(SQLrequest, myConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MemoryStream ms = new MemoryStream((byte[])reader["image"]);
                {
                    orbitingPlanets.Add(new Planet(
                        star,
                        Convert.ToInt32(reader["id"]),
                        reader["name"].ToString(),
                        Convert.ToDouble(reader["ray"]),
                        Convert.ToDouble(reader["period"]),
                        Convert.ToDouble(reader["distanceToOrbitCenter"]),
                        Image.FromStream(ms)));
                }
            }

            myConnection.Close();
            return orbitingPlanets;
        }

        /// <summary>
        /// (READ)
        /// à partir du nom et d'une étoile, trouve dans la base de données la planète du dit nom qui orbite autour de la dite étoile
        /// et crée un objet planète dont les données correspondant à l'enregistrement
        /// </summary>
        /// <param name="star"></param>
        /// <returns>Une planète qui orbite autour de l'étoile donnée</returns>
        public static Planet GetPlanetFromName(string name, Star star)
        {
            Planet tmp;
            StartConnection();

            string SQLrequest = String.Format("SELECT * FROM planets WHERE idStar = {0} AND Name = '{1}'", star.Id, name);

            SQLiteCommand command = new SQLiteCommand(SQLrequest, myConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            reader.Read();


            MemoryStream ms = new MemoryStream((byte[])reader["image"]);
            {
                tmp = new Planet(
                    star,
                    Convert.ToInt32(reader["id"]),
                    reader["name"].ToString(),
                    Convert.ToDouble(reader["ray"]),
                    Convert.ToDouble(reader["period"]),
                    Convert.ToDouble(reader["distanceToOrbitCenter"]),
                    Image.FromStream(ms));
            }

            myConnection.Close();
            return tmp;
        }


        /// <summary>
        /// (UPDATE) 
        /// Modifie une planète dans la base de donnée
        /// </summary>
        /// <param name="updatedPlanet"></param>
        public static void UpdatePlanet(Planet updatedPlanet)
        {
            StartConnection();

            byte[] img = null;
            img = DataAccessObject.ImageToByte(updatedPlanet.Image);

            string SQLrequest = string.Format("UPDATE planets SET name = '{0}', ray='{1}', period='{2}', distanceToOrbitCenter ='{3}', image=@image WHERE id = {4}",
                updatedPlanet.Name, updatedPlanet.Ray, updatedPlanet.Period, updatedPlanet.DistanceOrbitCenter, updatedPlanet.Id);

            SQLiteCommand command = new SQLiteCommand(SQLrequest, myConnection);
            command.Parameters.Add("@image", DbType.Binary, 20).Value = img;

            command.ExecuteNonQuery();
            myConnection.Close();
        }

        /// <summary>
        /// (DELETE)
        /// Supprime une planète de la base de données
        /// </summary>
        /// <param name="destroyedPlanet">planète à supprimer</param>
        public static void DeletePlanet(Planet destroyedPlanet)
        {
            StartConnection();

            string SQLrequest = String.Format("DELETE FROM planets WHERE id = {0}", destroyedPlanet.Id);

            SQLiteCommand command = new SQLiteCommand(SQLrequest, myConnection);
            command.ExecuteNonQuery();

            myConnection.Close();
        }


        #endregion

        #region CRUD moon

        /// <summary>
        /// (CREATE)
        /// Insère une lune du programme dans la base de données
        /// </summary>
        /// <param name="name">nom</param>
        /// <param name="ray">rayon</param>
        /// <param name="period">durée d'une révolution</param>
        /// <param name="distanceOrbitCenter">distance entre le centre de la lune et le centre de l'orbite</param>
        /// <param name="image">image à afficher</param>
        /// <param name="PlanetId">id du référentiel autour duquel la lune orbite</param>
        public static void InsertMoon(string name, double ray, double period, double distanceOrbitCenter, Image image, int PlanetId)
        {
            StartConnection();

            byte[] img = null;
            img = DataAccessObject.ImageToByte(image);

            string SQLrequest = String.Format("INSERT INTO moons ('name', 'ray', 'period', 'distanceToOrbitCenter', 'image', 'idPlanet') VALUES ('{0}', '{1}', '{2}', '{3}', @image, '{4}')",
                name, ray, period, distanceOrbitCenter, PlanetId);

            SQLiteCommand command = new SQLiteCommand(SQLrequest, myConnection);

            command.Parameters.Add("@image", DbType.Binary, 20).Value = img;

            command.ExecuteNonQuery();

            myConnection.Close();
        }
        
        /// <summary>
        /// (READ)
        /// à partir d'une planète, trouve dans la base de données toutes les lunes qui orbitent autour de la dite planète 
        /// et pour chaque enregistrement crée un objet lune dont les données correspondant à l'enregistrement
        /// </summary>
        /// <param name="satellite"></param>
        /// <returns></returns>
        public static List<Moon> GetMoonsFromPlanet(Planet satellite)
        {
            List<Moon> orbitingMoons = new List<Moon>();
            StartConnection();

            string SQLrequest = String.Format("SELECT * FROM Moons WHERE idPlanet = {0}", satellite.Id);


            SQLiteCommand command = new SQLiteCommand(SQLrequest, myConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MemoryStream ms = new MemoryStream((byte[])reader["image"]);
                {
                    orbitingMoons.Add(new Moon(
                        satellite,
                        Convert.ToInt32(reader["id"]),
                        reader["name"].ToString(),
                        Convert.ToDouble(reader["ray"]),
                        Convert.ToDouble(reader["period"]),
                        Convert.ToDouble(reader["distanceToOrbitCenter"]),
                        Image.FromStream(ms)));
                }
            }

            myConnection.Close();
            return orbitingMoons;
        }

        /// <summary>
        /// (READ)
        /// à partir du nom et d'une planète, trouve dans la base de données la lune du dit nom qui orbite autour de la dite planète
        /// et crée un objet dont les données correspondant à l'enregistrement
        /// </summary>
        /// <param name="star"></param>
        /// <returns>Une planète qui orbite autour de l'étoile donnée</returns>
        public static Moon GetMoonFromName(string name, Planet planet)
        {
            Moon tmp;
            StartConnection();

            string SQLrequest = String.Format("SELECT * FROM moons WHERE idPlanet = {0} AND Name = '{1}'", planet.Id, name);

            SQLiteCommand command = new SQLiteCommand(SQLrequest, myConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            reader.Read();

            MemoryStream ms = new MemoryStream((byte[])reader["image"]);

            tmp = (new Moon(
                planet,
                Convert.ToInt32(reader["id"]),
                reader["name"].ToString(),
                Convert.ToDouble(reader["ray"]),
                Convert.ToDouble(reader["period"]),
                Convert.ToDouble(reader["distanceToOrbitCenter"]),
                Image.FromStream(ms)));


            myConnection.Close();
            return tmp;
        }

        /// <summary>
        /// (UPDATE) 
        /// Modifie une lune dans la base de donnée
        /// </summary>
        /// <param name="updatedMoon"></param>
        public static void UpdateMoon(Moon updatedMoon)
        {
            StartConnection();

            byte[] img = null;
            img = DataAccessObject.ImageToByte(updatedMoon.Image);

            string SQLrequest = string.Format("UPDATE moons SET name = '{0}', ray='{1}', period='{2}', distanceToOrbitCenter ='{3}', image=@image, idPlanet = '{4}' WHERE id = {5}",
                updatedMoon.Name, updatedMoon.Ray, updatedMoon.Period, updatedMoon.DistanceOrbitCenter, updatedMoon.OrbitCenter.Id, updatedMoon.Id);

            SQLiteCommand command = new SQLiteCommand(SQLrequest, myConnection);
            command.Parameters.Add("@image", DbType.Binary, 20).Value = img;

            command.ExecuteNonQuery();
            myConnection.Close();
        }

        /// <summary>
        /// (DELETE)
        /// Supprime une lune de la base de données
        /// </summary>
        /// <param name="destroyedMoon">lune à supprimer</param>
        public static void DeleteMoon(Moon destroyedMoon)
        {
            StartConnection();

            string SQLrequest = String.Format("DELETE FROM moons WHERE id = {0}", destroyedMoon.Id);

            SQLiteCommand command = new SQLiteCommand(SQLrequest, myConnection);
            command.ExecuteNonQuery();

            myConnection.Close();
        }

        #endregion
    }
}
