using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceSimulator
{
    public partial class SpaceView : Form
    {
        SpaceManagement insert;
        SpaceManagement update;

        SpaceModel _model;

        PictureBox _pbxSpaceView;
        public SpaceView()
        {
            InitializeComponent();
            _model = new SpaceModel();

            _pbxSpaceView = new PictureBox();
            _pbxSpaceView.Parent = this;
            _pbxSpaceView.Size = this.Size;
            _pbxSpaceView.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top;
            _pbxSpaceView.Paint += _pbxSpaceView_Paint;
            _pbxSpaceView.MouseDown += _pbxSpaceView_MouseDown;

            UpdateMenu();
        }

        

        /// <summary>
        /// Met à jour tout les labels, les textes et les affichages de la vue
        /// </summary>
        private void UpdateView()
        {
            lblInfoAge.Text = DaysToText(_model.SpaceDayAge);
            lblInfoSpeed.Text = "speed : " + _model.TimeSpeed;
            lblInfoZoom.Text = "zoom : " + _model.Zoom;
            if (Time.Enabled)
            {
                dtPicker.Value = DateTime.Today.AddDays(_model.SpaceDayAge);
                if (dtPicker.Value.Year >= 9995)
                {
                    Time.Stop();
                    MessageBox.Show("Futur imprécis");
                }
                if (dtPicker.Value.Year <= 1755)
                {
                    Time.Stop();
                    MessageBox.Show("Passé imprécis");
                }
            }
            _pbxSpaceView.Invalidate();
        }

        private void UpdateMenu()
        {
            foreach (Planet satellite in _model.Star.Planets)
            {
                ToolStripMenuItem tsDelete = new ToolStripMenuItem();
                tsDelete.Text = satellite.ToString();
                tsDelete.Tag = satellite;
                tsDelete.Click += TsDelete_Click;
                deleteTSMI.DropDownItems.Add(tsDelete);

                ToolStripMenuItem tsUpdate = new ToolStripMenuItem();
                tsUpdate.Text = satellite.ToString();
                tsUpdate.Tag = satellite;
                tsUpdate.Click += TsUpdate_Click;
                updateTSMI.DropDownItems.Add(tsUpdate);
            }
        }

        private void TsUpdate_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Tag is Planet)
            {
                Planet satellite = ((sender as ToolStripMenuItem).Tag as Planet);

                update = new SpaceManagement(this._model, satellite);
                update.Location = new Point(this.Location.X + this.Width / 2 - update.Width / 2, this.Location.Y + this.Height / 2 - update.Height / 2);
                this.Hide();
                update.ShowDialog();
                this.Show();
                this.UpdateMenu();
                if (!Time.Enabled)
                {
                    UpdateView();
                }
            }
        }

        private void TsDelete_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Tag is Planet)
            {
                Planet satellite = ((sender as ToolStripMenuItem).Tag as Planet);
                _model.DeletePlanet(satellite);
                UpdateMenu();
                this.UpdateMenu();
                if (!Time.Enabled)
                {
                    UpdateView();
                }
            }
        }
        /// <summary>
        /// Lance le temps et met à jour l'état des boutons
        /// </summary>
        private void Play()
        {
            _model.TimeDirection = true;
            if (!Time.Enabled)
            {
                Time.Start(); 
            }
            btnPause.Enabled = true;
        }

        /// <summary>
        /// Arrête le temps et met à jour les états des boutons
        /// </summary>
        private void Pause()
        {
            if (Time.Enabled)
            {
                Time.Stop();
            }
            btnPause.Enabled = false;
            UpdateView();
        }

        /// <summary>
        /// Lance le temps à reculons et met à jour les états des boutons
        /// </summary>
        private void PlayBackwards()
        {
            _model.TimeDirection = false;
            if (!Time.Enabled)
            {
                Time.Start();
            }
            btnPause.Enabled = true;
        }

        /// <summary>
        /// Enregistre une image au format png de la vue actuelle
        /// </summary>
        private void SavePicture()
        {
            Bitmap bmp = new Bitmap(_pbxSpaceView.Width, _pbxSpaceView.Height);
            Graphics bmpGraphics = Graphics.FromImage(bmp);
            bmpGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            _model.Paint(bmpGraphics, _pbxSpaceView.Width, _pbxSpaceView.Height);
            bmp.Save("SpaceView.png", ImageFormat.Png);
        }

        /// <summary>
        /// Transforme un nombre de jour en chaine de charactères gérant les accords pour la rendre lisible aisément
        /// </summary>
        /// <param name="days">le nombre de jour à convertir</param>
        /// <returns></returns>
        private string DaysToText(int days)
        {
            string tmpString;

            if (days < 0)
            {
                tmpString = "-";
            }
            else
            {
                tmpString = "";
            }

            if (((int)(days / 365.25)) > 1 || ((int)(days / 365.25)) < -1)
            {
                tmpString += Math.Abs((int)(days / 365.25)).ToString() + " ans et ";
            }
            else
            {
                if (((int)(days / 365.25)) == 1 || ((int)(days / 365.25)) == -1)
                {
                    tmpString += Math.Abs((int)(days / 365.25)).ToString() + " an et ";
                }
            }

            if (((int)(days % 365.25)) > 1 || ((int)(days % 365.25)) < -1)
            {
                tmpString += Math.Abs((int)(days % 365.25)).ToString() + " jours";
            }
            else
            {
                tmpString += Math.Abs((int)(days % 365.25)).ToString() + " jour";
            }

            return tmpString;
        }

        #region events
        private void _pbxSpaceView_MouseDown(object sender, MouseEventArgs e)
        {
            Point MousePosition = new Point(e.X, e.Y);
            if ((_model.ClickIsOn(MousePosition)) != null)
            {
                lblInfoAge.Text = _model.ClickIsOn(MousePosition);
            }
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        private void _pbxSpaceView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            _model.Paint(e.Graphics, _pbxSpaceView.Width, _pbxSpaceView.Height);
        }

        #region button clicks
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Sécurité concernant les limites du composant DateTimePicker
            if (dtPicker.Value.Year < 9995)
            {
                Play();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void btnPlayBackwards_Click(object sender, EventArgs e)
        {
            //Sécurité concernant les limites du composant DateTimePicker
            if (dtPicker.Value.Year > 1755)
            {
                PlayBackwards();
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SavePicture();
        }
        #endregion
        private void SpaceView_Resize(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void SpaceView_Load(object sender, EventArgs e)
        {
            tbSpeed.Value = _model.TimeSpeed;
            tbZoom.Value = Convert.ToInt32(_model.Zoom);
            UpdateView();
        }

        private void tbZoom_ValueChanged(object sender, EventArgs e)
        {
            _model.Zoom = tbZoom.Value;

            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            _model.TimeSpeed = tbSpeed.Value;
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        private void addTSMI_Click(object sender, EventArgs e)
        {
            insert = new SpaceManagement(this._model);
            insert.Location = new Point(this.Location.X + this.Width / 2 - insert.Width / 2, this.Location.Y + this.Height / 2 - insert.Height / 2);
            this.Hide();
            insert.ShowDialog();
            this.Show();
            this.UpdateMenu();
            if (!Time.Enabled)
            {
                this.UpdateView();
            }
        }
        private void Time_Tick(object sender, EventArgs e)
        {
            /*
            if (_model.TimeDirection)
            {
                _model.TimeForward();
            }else
            {
                _model.TimeBackwards();
            }
            */
            UpdateView();
        }
        #endregion

        private void btnUp_Click(object sender, EventArgs e)
        {
            _model.MoveUp();
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            _model.MoveDown();
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            _model.MoveRight();
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            _model.MoveLeft();
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }
    }
}
