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

namespace WinFormsApp90.Forms.Preferencje.RodzajeSprzetow
{
    public partial class RodzajeSprzetuCreate : BaseForm
    { 
        public RodzajeSprzetuCreate ()
        {
            InitializeComponent(); 
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                RodzajSprzetu rodzajSprzetu = new RodzajSprzetu ()
                {
                    RodzajSprzetuId = Guid.NewGuid ().ToString (),
                    Nazwa = textBoxNazwa.Text
                };
                _unityOfWork.RodzajeSprzetowRepository.Create (rodzajSprzetu);
                _unityOfWork.SaveChanges ();
                MessageBox.Show("Nowa kategoria dodana poprawnie");
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
    }
}
