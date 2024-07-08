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
using WinFormsApp90.Forms.Umowy;
using WinFormsApp90.Models;
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms.Firmy
{
    public partial class FirmaCreate : BaseForm
    {   
        public FirmaCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent(); 
        }

        private void FirmaCreate_Load (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Firma firma = new Firma ()
                {
                    FirmaId = Guid.NewGuid ().ToString (),
                    PelnaNazwa = textBoxPelnaNazwa.Text,
                    SkroconaNazwa = textBoxSkroconaNazwa.Text,
                    Adres = textBoxAdres.Text,
                    Nip = textBoxNIP.Text,
                    Uwagi = textBoxUwagiFirma.Text
                };
                _unityOfWork.FirmyRepository.Create (firma);
                _unityOfWork.SaveChanges ();
                   

            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                Close ();
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            Close ();
        }

        private void button3_Click (object sender, EventArgs e)
        {
            UmowaCreate uc = new UmowaCreate (_unityOfWork);
            uc.ShowDialog ();
        }
    }
}
