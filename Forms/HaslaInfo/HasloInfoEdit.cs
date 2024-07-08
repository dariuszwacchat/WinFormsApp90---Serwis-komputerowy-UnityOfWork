using Microsoft.EntityFrameworkCore;
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
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms.HaslaInfo
{
    public partial class HasloInfoEdit : BaseForm
    {
        public HasloInfoEdit (string hasloInfoId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            HasloInfoId = hasloInfoId;
            Firma = null;
            Sprzet = null;
            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet();


            HasloInfo = _unityOfWork.HaslaInfosRepository.Get (HasloInfoId);

        }

        private void HasloInfoEdit_Load (object sender, EventArgs e)
        {
            if (HasloInfo != null)
            {
                comboBoxFirmy.SelectedItem = HasloInfo.Firma.SkroconaNazwa;
                comboBoxSprzet.SelectedItem = HasloInfo.Sprzet.Nazwa;

                textBoxLogin.Text = HasloInfo.Login;
                textBoxHaslo.Text = HasloInfo.Haslo;
                textBoxUwagi.Text = HasloInfo.Uwagi;
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            { 
                if (HasloInfo != null)
                {
                    HasloInfo.Login = textBoxLogin.Text;
                    HasloInfo.Haslo = textBoxHaslo.Text;
                    HasloInfo.Uwagi = textBoxUwagi.Text;

                    _unityOfWork.HaslaInfosRepository.Update (HasloInfo);
                    _unityOfWork.SaveChanges ();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            Close ();
        }

        private void comboBoxFirmy_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindFirma(comboBoxFirmy);
            comboBoxSprzet.DataSource = DisplayNazwySprzet();
        }

        private void comboBoxSprzet_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindSprzet(comboBoxSprzet);
        }
    }
}
