using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms
{
    public partial class DisplayPhoto : BaseForm
    {

        public DisplayPhoto (byte[] data)
        {
            InitializeComponent();

            try
            {
                pictureBox1.Image = GetImageFromBytes(data);
            }
            catch { }
        }

        private void DisplayPhoto_Load (object sender, EventArgs e)
        {

        }
    }
}
