using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Data;
using WinFormsApp90.Forms.Preferencje.LicencjaWolna;
using WinFormsApp90.Forms.Preferencje.RodzajeSprzetow;
using WinFormsApp90.Forms.Preferencje.Sprzety;
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms.Preferencje
{
    public partial class PreferencjeForm : BaseForm
    {
        public PreferencjeForm (IUnityOfWork unityOfWork) : base (unityOfWork)
        {
            InitializeComponent();

            S.SetColor (panelNavigation);
            S.SetColors (panelNavigation);
            S.ClearPanelContainer(panelContainer);

            SprzetUserControl sprzetUserControl = new SprzetUserControl (_unityOfWork);
            sprzetUserControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(sprzetUserControl);
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.White;
             
        }

        private void PreferencjeForm_Load (object sender, EventArgs e)
        {

        }
         

        private void button1_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainer);
            SprzetUserControl sprzetUserControl = new SprzetUserControl (_unityOfWork);
            sprzetUserControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(sprzetUserControl);
        }


        private void button2_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainer);
            RodzajeSprzetuUserControl rodzajeSprzetuUserControl = new RodzajeSprzetuUserControl ();
            rodzajeSprzetuUserControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(rodzajeSprzetuUserControl);
        }

        private void button3_Click (object sender, EventArgs e)
        {
            S.ClearPanelContainer(panelContainer);
            LicencjeWolneUserControl licencjeWolneUserControl = new LicencjeWolneUserControl ();
            licencjeWolneUserControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(licencjeWolneUserControl);
        }
    }
}
