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

namespace WinFormsApp90.Forms.Uprawnienia
{
    public partial class UprawnieniaUserControl : BaseUserControl
    {
        public UprawnieniaUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayUprawnienia ();
            SetDataGridViewStyles (dataGridViewRoles);
        }


        private void DisplayUprawnienia ()
        {
            Index = 0;
            var roles = _unityOfWork.RolesRepository.GetAll ();
            dataGridViewRoles.DataSource = (from f in roles
                                            select new
                                            {
                                                Id = f.Id,
                                                Lp = IndexCounter,
                                                Name = f.Name
                                            }).ToList();
        }

        private void toolStripButtonDodajUprawnienie_Click (object sender, EventArgs e)
        {
            UprawnienieCreate uc = new UprawnienieCreate (_unityOfWork);
            uc.ShowDialog ();
        }

        private void toolStripButtonUsunUprawnienie_Click (object sender, EventArgs e)
        {

        }
    }
}
