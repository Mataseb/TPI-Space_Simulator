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
        AboutSpaceSimulator _about;
        SpaceManagement _insert;
        SpaceManagement _update;

        SpaceModel _model;

        PictureBox _pbxSpaceView;

        ToolTip _ttInfo;

        List<Label> _hiddenLabels;
        List<Label> _visibleLabels;
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

            _hiddenLabels = new List<Label>();
            _visibleLabels = new List<Label>();
            _hiddenLabels.Add(lblInfo);
            _hiddenLabels.Add(lblInfoAge);
            _visibleLabels.Add(lblInfoSpeed);
            _visibleLabels.Add(lblInfoZoom);

            #region crée les aides pour chaque composant
            _ttInfo = new ToolTip();
            _ttInfo.IsBalloon = true;
            _ttInfo.ToolTipTitle = "Aide";
            _ttInfo.ToolTipIcon = ToolTipIcon.Info;
            _ttInfo.SetToolTip(btnPlayBackwards, "Lance le temps à reculons");
            _ttInfo.SetToolTip(btnPause, "Arrête le temps");
            _ttInfo.SetToolTip(btnPlay, "Lance le temps");
            _ttInfo.SetToolTip(tbSpeed, "Règle la vitesse à laquelle le temps défile");
            _ttInfo.SetToolTip(tbZoom, "Règle le niveau de zoom à laquelle on observe l'espace");
            _ttInfo.SetToolTip(btnSaveImage, "Sauvegarde le dessin actuel de l'application (au format: .png");
            _ttInfo.SetToolTip(dtPicker, "Affiche la date actuelle à laquelle l'univers se situe," + Environment.NewLine + " il est possible de la modifier afin d'observer une date précise");
            _ttInfo.SetToolTip(lblInfoAge, "Affiche l'age de l'univers depuis la date actuelle");
            _ttInfo.SetToolTip(lblInfoSpeed, "Affiche la vitesse à laquelle l'espace est réglé");
            _ttInfo.SetToolTip(lblInfoZoom, "Affiche le niveau de zoom actuel de l'espace");
            #endregion

            UpdateMenu();
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        // Met à jour tout les labels, les textes et les affichages de la vue
        private void UpdateView()
        {
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
            lblInfoAge.Text = DaysToText(_model.SpaceDayAge);
            lblInfoSpeed.Text = "speed : " + _model.TimeSpeed;
            lblInfoZoom.Text = "zoom : " + _model.Zoom / 2;
        }

        //Efface et recrée le menu en fonction des objets du programme
        private void UpdateMenu()
        {
            showTSMI.DropDownItems.Clear();
            hideTSMI.DropDownItems.Clear();

            foreach (Label lbl in _hiddenLabels)
            {
                ToolStripMenuItem tsShowlbl = new ToolStripMenuItem();
                tsShowlbl.Text = lbl.Name;
                tsShowlbl.Tag = lbl;
                tsShowlbl.Click += TsShowlbl_Click;
                showTSMI.DropDownItems.Add(tsShowlbl);
            }
            foreach (Label lbl in _visibleLabels)
            {
                ToolStripMenuItem tsHidelbl = new ToolStripMenuItem();
                tsHidelbl.Text = lbl.Name;
                tsHidelbl.Tag = lbl;
                tsHidelbl.Click += TsHidelbl_Click; ;
                showTSMI.DropDownItems.Add(tsHidelbl);
            }
            if (_hiddenLabels.Count>0)
            {
                showTSMI.Visible = true;
            }else
            {
                showTSMI.Visible = false;
            }
            if (_visibleLabels.Count > 0)
            {
                hideTSMI.Visible = true;
            }
            else
            {
                hideTSMI.Visible = false;
            }
            helpTSMI.DropDownItems.Clear();
            if (_ttInfo.Active)
            {
                ToolStripMenuItem tsDisableHelp = new ToolStripMenuItem();
                tsDisableHelp.Text = "désactiver";
                tsDisableHelp.Click += TsDisableHelp_Click;
                helpTSMI.DropDownItems.Add(tsDisableHelp);
            }
            else
            {
                ToolStripMenuItem tsEnableHelp = new ToolStripMenuItem();
                tsEnableHelp.Text = "activer";
                tsEnableHelp.Click += TsEnableHelp_Click; ;
                helpTSMI.DropDownItems.Add(tsEnableHelp);
            }
            foreach (ToolStripMenuItem item in updateTSMI.DropDownItems)
            {
                item.DropDownItems.Clear();
            }
            updateTSMI.DropDownItems.Clear();
            foreach (ToolStripMenuItem item in deleteTSMI.DropDownItems)
            {
                item.DropDownItems.Clear();
            }
            deleteTSMI.DropDownItems.Clear();

            followTSMI.DropDownItems.Clear();
            ToolStripMenuItem tsFollowStar = new ToolStripMenuItem();
            tsFollowStar.Text = _model.Star.ToString();
            tsFollowStar.Tag = _model.Star;
            tsFollowStar.Click += TsFollow_Click;
            followTSMI.DropDownItems.Add(tsFollowStar);
            foreach (Planet satellite in _model.Star.Planets)
            {
                ToolStripMenuItem tsDeletePlanet = new ToolStripMenuItem();
                tsDeletePlanet.Text = satellite.ToString();
                tsDeletePlanet.Tag = satellite;
                tsDeletePlanet.Click += TsDeletePlanet_Click;
                deleteTSMI.DropDownItems.Add(tsDeletePlanet);

                ToolStripMenuItem tsUpdatePlanet = new ToolStripMenuItem();
                tsUpdatePlanet.Text = satellite.ToString();
                tsUpdatePlanet.Tag = satellite;
                tsUpdatePlanet.Click += TsUpdatePlanet_Click;
                updateTSMI.DropDownItems.Add(tsUpdatePlanet);

                ToolStripMenuItem tsFollow = new ToolStripMenuItem();
                tsFollow.Text = satellite.ToString();
                tsFollow.Tag = satellite;
                tsFollow.Click += TsFollow_Click;
                followTSMI.DropDownItems.Add(tsFollow);
                if (satellite.Moons != null)
                {
                    foreach (Moon moon in satellite.Moons)
                    {
                        ToolStripMenuItem tsDeleteMoon = new ToolStripMenuItem();
                        tsDeleteMoon.Text = moon.ToString();
                        tsDeleteMoon.Tag = moon;
                        tsDeleteMoon.Click += TsDeleteMoon_Click;
                        tsDeletePlanet.DropDownItems.Add(tsDeleteMoon);

                        ToolStripMenuItem tsUpdateMoon = new ToolStripMenuItem();
                        tsUpdateMoon.Text = moon.ToString();
                        tsUpdateMoon.Tag = moon;
                        tsUpdateMoon.Click += TsUpdateMoon_Click;
                        tsUpdatePlanet.DropDownItems.Add(tsUpdateMoon);
                    }
                }
            }
        }

        //Rend le label lié caché
        private void TsHidelbl_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Tag is Label)
            {
                Label lbl = ((sender as ToolStripMenuItem).Tag as Label);
                lbl.Visible = false;
                _hiddenLabels.Add(lbl);
                _visibleLabels.Remove(lbl);
                UpdateMenu();
                UpdateView();
            }
        }

        //Rend le label lié visible
        private void TsShowlbl_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Tag is Label)
            {
                Label lbl = ((sender as ToolStripMenuItem).Tag as Label);
                lbl.Visible = true;
                _hiddenLabels.Remove(lbl);
                _visibleLabels.Add(lbl);
                UpdateMenu();
                UpdateView();
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
        private void SavePicture(string filename)
        {
            Bitmap bmp = new Bitmap(_pbxSpaceView.Width, _pbxSpaceView.Height);
            Graphics bmpGraphics = Graphics.FromImage(bmp);
            bmpGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            _model.Paint(bmpGraphics, _pbxSpaceView.Width, _pbxSpaceView.Height);
            bmp.Save(filename, ImageFormat.Png);
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

        //à chaque fréquence change l'age de l'espace et met à jour la vue
        private void Time_Tick(object sender, EventArgs e)
        {
            if (_model.TimeDirection)
            {
                _model.TimeForward();
            }
            else
            {
                _model.TimeBackwards();
            }
            UpdateView();
        }

        //Au clic sur la zone de dessin, récupère la position du clic et affiche les données détaillées récupérées en fonction de la position
        private void _pbxSpaceView_MouseDown(object sender, MouseEventArgs e)
        {
            Point MousePosition = new Point(e.X, e.Y);
            if ((_model.ClickIsOn(MousePosition)) != null)
            {
                string toDisplay = _model.ClickIsOn(MousePosition).Name + Environment.NewLine +
                    "Rayon : " + _model.ClickIsOn(MousePosition).Ray + " (en km)" + Environment.NewLine;
                if (_model.ClickIsOn(MousePosition) is Planet)
                {
                    toDisplay += "Durée d'une révolution : " + (_model.ClickIsOn(MousePosition) as Planet).Period.ToString() + " (en jours)" + Environment.NewLine +
                        "Orbite autour de : " + (_model.ClickIsOn(MousePosition) as Planet).OrbitCenter.ToString();
                }
                lblInfo.Visible = true;
                lblInfo.Text = toDisplay;
            }
            else
            {
                lblInfo.Visible = false;
            }
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        // Dessine l'image de la vue
        private void _pbxSpaceView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            _model.Paint(e.Graphics, _pbxSpaceView.Width, _pbxSpaceView.Height);
        }

        //Au changement de la valeur de la barre de zoom, change la valeur dans le modèle
        private void tbZoom_ValueChanged(object sender, EventArgs e)
        {
            _model.Zoom = tbZoom.Value;
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        //Au changement de la valeur de la barre de vitesse, change la valeur dans le modèle
        private void tbSpeed_ValueChanged(object sender, EventArgs e)
        {
            _model.TimeSpeed = tbSpeed.Value;
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        //Au lancement de la fenêtre ajuste les valeurs à celles du modèle
        private void SpaceView_Load(object sender, EventArgs e)
        {
            tbSpeed.Value = _model.TimeSpeed;
            tbZoom.Value = Convert.ToInt32(_model.Zoom);
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        //Au changement des dimensions de la fenêtre met à jour la vue
        private void SpaceView_Resize(object sender, EventArgs e)
        {
            if (!Time.Enabled)
            {
                UpdateView();
            }
        }

        //à la fermeture de la fenêtre, demande une confirmation
        private void SpaceView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr de vouloir quitter l'application?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region TSMI

        //Sauvegarde l'image de la vue
        private void saveViewTSMI_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SavePicture(saveFileDialog.FileName);
            }
        }

        //Ouvre la fenêtre d'ajout de planète
        private void addPlanetTSMI_Click(object sender, EventArgs e)
        {
            _insert = new SpaceManagement(this._model, true);
            _insert.Location = new Point(this.Location.X + this.Width / 2 - _insert.Width / 2, this.Location.Y + this.Height / 2 - _insert.Height / 2);
            this.Hide();
            _insert.ShowDialog();
            this.Show();
            this.UpdateMenu();
            if (!Time.Enabled)
            {
                this.UpdateView();
            }
        }

        //Ouvre la fenêtre d'ajout de lune
        private void addMoonTSMI_Click(object sender, EventArgs e)
        {
            _insert = new SpaceManagement(this._model, false);
            _insert.Location = new Point(this.Location.X + this.Width / 2 - _insert.Width / 2, this.Location.Y + this.Height / 2 - _insert.Height / 2);
            this.Hide();
            _insert.ShowDialog();
            this.Show();
            this.UpdateMenu();
            if (!Time.Enabled)
            {
                this.UpdateView();
            }
        }

        //Modifie la lune ciblée
        private void TsUpdateMoon_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Tag is Moon)
            {
                Moon satellite = ((sender as ToolStripMenuItem).Tag as Moon);

                _update = new SpaceManagement(this._model, satellite);
                _update.Location = new Point(this.Location.X + this.Width / 2 - _update.Width / 2, this.Location.Y + this.Height / 2 - _update.Height / 2);
                this.Hide();
                _update.ShowDialog();
                this.Show();
                if (!Time.Enabled)
                {
                    UpdateView();
                }
                this.UpdateMenu();
            }
        }

        //Supprime la lune liée
        private void TsDeleteMoon_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Tag is Moon)
            {
                Moon satellite = ((sender as ToolStripMenuItem).Tag as Moon);
                _model.DeleteMoon(satellite);
                UpdateMenu();
                if (!Time.Enabled)
                {
                    UpdateView();
                }
            }
        }

        //Fixe la vue sur le corp ciblé
        private void TsFollow_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Tag is Planet)
            {
                Planet satellite = ((sender as ToolStripMenuItem).Tag as Planet);
                _model.Focus = satellite;
            }
            else if ((sender as ToolStripMenuItem).Tag is Star)
            {
                Star star = ((sender as ToolStripMenuItem).Tag as Star);
                _model.Focus = star;
            }
            if (!Time.Enabled)
            {
                UpdateView();
            }

        }

        //Ouvre la fenêtre de modification de la planète liée
        private void TsUpdatePlanet_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Tag is Planet)
            {
                Planet satellite = ((sender as ToolStripMenuItem).Tag as Planet);

                _update = new SpaceManagement(this._model, satellite);
                _update.Location = new Point(this.Location.X + this.Width / 2 - _update.Width / 2, this.Location.Y + this.Height / 2 - _update.Height / 2);
                this.Hide();
                _update.ShowDialog();
                this.Show();
                this.UpdateMenu();
                if (!Time.Enabled)
                {
                    UpdateView();
                }
            }
        }

        //Supprime la planète liée
        private void TsDeletePlanet_Click(object sender, EventArgs e)
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

        //Quitte l'application
        private void quitTSMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Active l'aide
        private void TsEnableHelp_Click(object sender, EventArgs e)
        {
            _ttInfo.Active = true;
            UpdateMenu();
        }

        //Désactive l'aide
        private void TsDisableHelp_Click(object sender, EventArgs e)
        {
            _ttInfo.Active = false;
            UpdateMenu();
        }

        //Ouvre une fenêtre about
        private void aboutTSMI_Click(object sender, EventArgs e)
        {
            _about = new AboutSpaceSimulator();
            _about.ShowDialog();
        }

        #endregion

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
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                SavePicture(saveFileDialog.FileName);
            }
        }
        #endregion

        #endregion
    }
}
