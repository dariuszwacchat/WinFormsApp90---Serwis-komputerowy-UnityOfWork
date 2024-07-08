using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Forms.Firmy.FirmaDetails.Sprzety;
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms.Firmy.FirmaDetails
{
    public partial class FirmaDetailsForm : BaseForm
    {
        public FirmaDetailsForm ()
        {
            InitializeComponent(); ClearPanelContainer();

            ClearPanelContainer();
            SprzetyUserControl sprzetyUserControl = new SprzetyUserControl ();
            sprzetyUserControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(sprzetyUserControl);
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.White;
        }


        private void ClearPanelContainer ()
        {
            panelContainer.Controls.Clear();
        }


        // Ustawienie koloru dla jednego buttona
        private void SetColor ()
        {
            foreach (Control control in panelNavigation.Controls)
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.Click += (s, e) =>
                    {
                        SetColors();
                        Button b = (Button) s;
                        b.BackColor = Color.Gray;
                        b.ForeColor = Color.White;
                    };
                }
            }
        }

        // Ustawienie kolorów dla wszystkich buttonów
        private void SetColors ()
        {
            foreach (Control control in panelNavigation.Controls)
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.BackColor = Color.FromArgb(220, 220, 220);
                    button.ForeColor = Color.Black;
                }
            }

        }

        private void button1_Click (object sender, EventArgs e)
        {
            ClearPanelContainer();
            SprzetyUserControl sprzetyUserControl = new SprzetyUserControl ();
            sprzetyUserControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(sprzetyUserControl);
        }
         
    }
}
