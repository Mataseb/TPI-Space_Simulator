/*
#--------------------------------------------------------------------------
# TPI 2017 - Auteur : Mata Sebastian
# Nom du fichier : Space Simulator : SpaceManagement.cs
# Date : 19 juin 2017
#--------------------------------------------------------------------------
# Interface d'interactions avec la base de données
# Permet toutes les modifications de la base de données par l'utilisateur.
#
# Version 1.0 : 19 juin 2017
#--------------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceSimulator
{
    public partial class SpaceManagement : Form
    {
        SpaceModel _model;

        Planet _updatingPlanet;
        Moon _updatingMoon;
        bool _insertPlanet;

        /// <summary>
        /// Si la fenêtre est ouverte en mode insert
        /// </summary>
        /// <param name="model">le modèle de l'application</param>
        /// <param name="insertPlanet">Est-ce que l'insertion concerne une planète</param>
        public SpaceManagement(SpaceModel model, bool insertPlanet)
        {
            InitializeComponent();
            this._model = model;
            _insertPlanet = insertPlanet;
            //mode d'insertion de planète
            if (insertPlanet)
            {
                cbxOrbitCenter.Items.Add(_model.Star);
                cbxOrbitCenter.SelectedItem = _model.Star;
                cbxOrbitCenter.Enabled = false;

            }
            //Mode d'insertion de lune
            else
            {
                foreach (Planet planet in _model.Star.Planets)
                {
                    cbxOrbitCenter.Items.Add(planet);
                }
            }
        }

        /// <summary>
        /// Si la fenêtre est ouverte en mode update (avec un satellite), pré-rempli les champs avec les données du satellite
        /// </summary>
        /// <param name="model"></param>
        /// <param name="satellite"></param>
        public SpaceManagement(SpaceModel model, Planet satellite)
        {
            InitializeComponent();
            this._model = model;

            _updatingPlanet = satellite;
            lblId.Text = _updatingPlanet.Id.ToString();
            tbxName.Text = _updatingPlanet.Name;
            tbxRay.Text = _updatingPlanet.Ray.ToString();
            tbxPeriod.Text = _updatingPlanet.Period.ToString();
            tbxDistanceToOrbit.Text = _updatingPlanet.DistanceOrbitCenter.ToString();
            pbxImage.Image = _updatingPlanet.Image;
            cbxOrbitCenter.Items.Add(_model.Star);
            cbxOrbitCenter.SelectedItem = _model.Star;
            cbxOrbitCenter.Enabled = false;

        }

        /// <summary>
        /// Si la fenêtre est ouverte en mode update (avec une lune), pré-rempli les champs avec les données de la lune
        /// </summary>
        /// <param name="model">le modèle de l'application</param>
        /// <param name="moon">la lune à modifier</param>
        public SpaceManagement(SpaceModel model, Moon moon)
        {
            InitializeComponent();
            this._model = model;

            _updatingMoon = moon;
            lblId.Text = _updatingMoon.Id.ToString();
            tbxName.Text = _updatingMoon.Name;
            tbxRay.Text = _updatingMoon.Ray.ToString();
            tbxPeriod.Text = _updatingMoon.Period.ToString();
            tbxDistanceToOrbit.Text = _updatingMoon.DistanceOrbitCenter.ToString();
            pbxImage.Image = _updatingMoon.Image;
            foreach (Planet planet in _model.Star.Planets)
            {
                cbxOrbitCenter.Items.Add(planet);
            }
            cbxOrbitCenter.SelectedItem = _updatingMoon.OrbitCenter;
        }
        
        // Parcourt l'ordinateur à la recherche d'images
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                pbxImage.Image = Image.FromFile(openFileDialogImage.FileName);
            }
        }

        /// <summary>
        /// si les champs sont rempli correctement
        /// Mode insert: crée la planète en fonction des données voulues.
        /// Mode update: modifie la planète en fonction des données voulues
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {

            //Mode insert
            if (this._updatingPlanet == null && this._updatingMoon == null)
            {
                if ((tbxName.Text != "")
                    && (tbxRay.Text != "")
                    && (tbxPeriod.Text != "")
                    && (tbxDistanceToOrbit.Text != "")
                    && (pbxImage.Image != null))
                {
                    //Insert planet

                    if (this._insertPlanet)
                    {
                        if (MessageBox.Show("Êtes-vous sûr de vouloir créer la planète suivante:" + Environment.NewLine +
                       "nom : " + tbxName.Text + Environment.NewLine +
                       "rayon : " + tbxRay.Text + " kilomètres" + Environment.NewLine +
                       "période : " + tbxPeriod.Text + " jours" + Environment.NewLine +
                       "distance entre la planète et l'orbite: " + tbxDistanceToOrbit.Text + " gigamètres" + "?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            this._model.CreatePlanet(tbxName.Text,
                            Convert.ToDouble(tbxRay.Text),
                            Convert.ToDouble(tbxPeriod.Text),
                            Convert.ToDouble(tbxDistanceToOrbit.Text),
                            pbxImage.Image,
                            this._model.Star.Id);
                            this.Close();
                        }
                    }

                    //Insert moon
                    else
                    {
                        if (MessageBox.Show("Êtes-vous sûr de vouloir créer la lune suivante:" + Environment.NewLine +
                       "nom : " + tbxName.Text + Environment.NewLine +
                       "rayon : " + tbxRay.Text + " kilomètres" + Environment.NewLine +
                       "période : " + tbxPeriod.Text + " jours" + Environment.NewLine +
                       "distance entre la lune et " + cbxOrbitCenter.SelectedItem.ToString() + ": " + tbxDistanceToOrbit.Text + " gigamètres", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            this._model.CreateMoon(tbxName.Text,
                        Convert.ToDouble(tbxRay.Text),
                        Convert.ToDouble(tbxPeriod.Text),
                        Convert.ToDouble(tbxDistanceToOrbit.Text),
                        pbxImage.Image,
                        (cbxOrbitCenter.SelectedItem as Planet).Id);
                            this.Close();
                        }
                    }
                }
            }
            //Update planet
            else if (this._updatingMoon == null && this._updatingPlanet != null)
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir enregistrer la planète avec les données suivantes:" + Environment.NewLine +
                       "nom : " + tbxName.Text + Environment.NewLine +
                       "rayon : " + tbxRay.Text + " kilomètres" + Environment.NewLine +
                       "période : " + tbxPeriod.Text + " jours" + Environment.NewLine +
                       "distance entre la planète et l'orbite: " + tbxDistanceToOrbit.Text + " gigamètres" + "?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (tbxName.Text != "")
                    {
                        this._updatingPlanet.Name = tbxName.Text;
                    }
                    if (tbxRay.Text != "")
                    {
                        this._updatingPlanet.Ray = Convert.ToDouble(tbxRay.Text);
                    }
                    if (tbxPeriod.Text != "")
                    {
                        this._updatingPlanet.Period = Convert.ToDouble(tbxPeriod.Text);
                    }
                    if (tbxDistanceToOrbit.Text != "")
                    {
                        this._updatingPlanet.DistanceOrbitCenter = Convert.ToDouble(tbxDistanceToOrbit.Text);
                    }
                    if (pbxImage.Image != null)
                    {
                        this._updatingPlanet.Image = pbxImage.Image;
                    }
                    if (_updatingPlanet is Planet)
                    {
                        this._model.UpdatePlanet(_updatingPlanet);
                    }
                    this.Close();
                }
            }
            //Update moon
            else
            {
                if (MessageBox.Show("Êtes-vous sûr de vouloir enregistrer la lune avec les données suivantes:" + Environment.NewLine +
                       "nom : " + tbxName.Text + Environment.NewLine +
                       "rayon : " + tbxRay.Text + " kilomètres" + Environment.NewLine +
                       "période : " + tbxPeriod.Text + " jours" + Environment.NewLine +
                       "distance entre la planète et l'orbite: " + tbxDistanceToOrbit.Text + " gigamètres" + "?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (tbxName.Text != "")
                    {
                        this._updatingMoon.Name = tbxName.Text;
                    }
                    if (tbxRay.Text != "")
                    {
                        this._updatingMoon.Ray = Convert.ToDouble(tbxRay.Text);
                    }
                    if (tbxPeriod.Text != "")
                    {
                        this._updatingMoon.Period = Convert.ToDouble(tbxPeriod.Text);
                    }
                    if (tbxDistanceToOrbit.Text != "")
                    {
                        this._updatingMoon.DistanceOrbitCenter = Convert.ToDouble(tbxDistanceToOrbit.Text);
                    }
                    if (pbxImage.Image != null)
                    {
                        this._updatingMoon.Image = pbxImage.Image;
                    }
                    if (_updatingMoon is Moon)
                    {
                        foreach (Planet planet in _model.Star.Planets)
                        {
                            planet.Moons.Remove(_updatingMoon);
                        }
                        this._updatingMoon.OrbitCenter = (cbxOrbitCenter.SelectedItem as Planet);
                        _model.Star.Planets[(cbxOrbitCenter.SelectedItem as Planet).Id - 1].Moons.Add(_updatingMoon);
                        this._model.UpdateMoon(_updatingMoon);
                        this.Close();
                    }
                }
            }
        }
        
        #region protection des zones de texte
        private void tbxDistanceToOrbit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbxPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbxRay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
