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

namespace WinFormsApp90.Forms.Hostingi
{
    public partial class HostingCreate : BaseForm
    {
        public HostingCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent(); 
            Firma = null; 
            comboBoxFirmy.DataSource = DisplayNazwyFirm(); 
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (Firma != null)
                {
                    Hosting hosting = new Hosting ()
                    {
                        HostingId = Guid.NewGuid ().ToString (),
                        Information = textBoxInformacje.Text,
                        FirmaId = FirmaId
                    };

                    _unityOfWork.HostingiRepository.Create (hosting);
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

        private void comboBoxFirmy_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindFirma (comboBoxFirmy);
        }
    }
}
