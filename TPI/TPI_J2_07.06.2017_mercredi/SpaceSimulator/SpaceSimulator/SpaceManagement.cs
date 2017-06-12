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

        /// <summary>
        /// Si la fenêtre est ouverte en mode insert, pré-rempli le champ avec l'identifiant de l'étoile
        /// </summary>
        /// <param name="model"></param>
        public SpaceManagement(SpaceModel model)
        {
            InitializeComponent();
            this._model = model;
            
            tbxStarId.Text = _model.Star.Id.ToString();
        }

        /// <summary>
        /// Si la fenêtre est ouverte en mode update (avec un satellite), pré-rempli les champs avec les données du satellite
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        /// <param name="satellite"></param>
        public SpaceManagement(SpaceModel model, Planet satellite)
        {
            InitializeComponent();
            this._model = model;

            _updatingPlanet = this._model.Star.Planets.Find(planet => planet.Id == satellite.Id);
            lblId.Text = _updatingPlanet.Id.ToString();
            tbxName.Text = _updatingPlanet.Name;
            tbxRay.Text = _updatingPlanet.Ray.ToString();
            tbxPeriod.Text = _updatingPlanet.Period.ToString();
            tbxDistanceToOrbit.Text = _updatingPlanet.DistanceOrbitCenter.ToString();
            pbxImage.Image = _updatingPlanet.Image;
            tbxStarId.Text = _updatingPlanet.OrbitCenter.Id.ToString();
            tbxStarId.ReadOnly = true;
        }

        /// <summary>
        /// Parcourt l'ordinateur à la recherche d'images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (this._updatingPlanet == null)
            {
                if ((tbxName.Text != "")
                    && (tbxRay.Text != "")
                    && (tbxPeriod.Text != "")
                    && (tbxDistanceToOrbit.Text != "")
                    && (pbxImage.Image != null))
                {
                    this._model.CreatePlanet(tbxName.Text,
                        Convert.ToDouble(tbxRay.Text),
                        Convert.ToDouble(tbxPeriod.Text),
                        Convert.ToDouble(tbxDistanceToOrbit.Text),
                        pbxImage.Image,
                        this._model.Star.Id);
                }
            }
            else
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
                this._model.UpdatePlanet(_updatingPlanet);
            }
            this.Close();
        }

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
    }
}
