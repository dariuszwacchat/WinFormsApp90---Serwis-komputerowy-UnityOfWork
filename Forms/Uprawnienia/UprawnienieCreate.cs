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

namespace WinFormsApp90.Forms.Uprawnienia
{
    public partial class UprawnienieCreate : BaseForm
    {
        public UprawnienieCreate (IUnityOfWork unityOfWork) : base (unityOfWork)
        {
            InitializeComponent();
        }
        private void UprawnienieCreate_Load (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                ApplicationRole role = new ApplicationRole ()
                {
                    Id = Guid.NewGuid ().ToString (),
                    Name = textBoxNazwaRoli.Text
                };
                _unityOfWork.RolesRepository.Create (role);
                _unityOfWork.SaveChanges ();

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

    }
}
