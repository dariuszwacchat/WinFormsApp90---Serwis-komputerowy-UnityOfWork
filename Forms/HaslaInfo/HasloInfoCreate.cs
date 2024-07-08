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
using WinFormsApp90.Models;
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms.HaslaInfo
{
    public partial class HasloInfoCreate : BaseForm
    {
        public HasloInfoCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent(); 
            Firma = null;
            Sprzet = null;
            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (Firma != null && Sprzet != null)
                {
                    HasloInfo hasloInfo = new HasloInfo ()
                    {
                        HasloInfoId = Guid.NewGuid ().ToString (),
                        Login = textBoxLogin.Text,
                        Haslo = textBoxHaslo.Text,
                        Uwagi = textBoxUwagi.Text,
                        SprzetId = SprzetId,
                        FirmaId = FirmaId
                    };

                    _unityOfWork.HaslaInfosRepository.Create (hasloInfo);
                    _unityOfWork.SaveChanges ();
                }

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void HasloInfoCreate_Load (object sender, EventArgs e)
        {

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
