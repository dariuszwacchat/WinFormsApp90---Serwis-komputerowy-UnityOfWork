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

namespace WinFormsApp90.Forms.Hostingi
{
    public partial class HostingEdit : BaseForm
    {
        public HostingEdit (string hostingId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            HostingId = hostingId;
            Hosting = _unityOfWork.HostingiRepository.Get (HostingId);
        }

        private void HostingEdit_Load (object sender, EventArgs e)
        {
            try
            {
                if (Hosting != null)
                {
                    comboBoxFirmy.Text = Hosting.Firma.SkroconaNazwa;
                    textBoxInformacje.Text = Hosting.Information;
                }
            }
            catch { }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                if (Hosting != null)
                {
                    Hosting.Information = textBoxInformacje.Text;

                    _unityOfWork.HostingiRepository.Update (Hosting);
                    _unityOfWork.SaveChanges ();

                    Close ();
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

    }
}
