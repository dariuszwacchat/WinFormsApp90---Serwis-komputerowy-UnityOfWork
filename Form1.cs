using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Data;
using WinFormsApp90.Forms;
using WinFormsApp90.Forms.Preferencje;
using WinFormsApp90.Models;
using WinFormsApp90.Services;

namespace WinFormsApp90
{
    public partial class Form1 : Form
    {  
        private readonly ApplicationDbContext _context;
        private readonly IUnityOfWork _unityOfWork;

        public Form1 ()
        {
            InitializeComponent(); 

            _context = new ApplicationDbContext ();
            _unityOfWork = new UnityOfWork (_context);

              
            if (LoginService.ZalogowanyUser != null)
                toolStripStatusLabelZalogowanyUzytkownik.Text = $"Zalogowany użytkownik: {LoginService.ZalogowanyUser.Email}";
             

            panelContainerNavigation.Controls.Clear ();
            ITUserControl itUserControl = new ITUserControl (_unityOfWork) { Dock = DockStyle.Fill };
            panelContainerNavigation.Controls.Add(itUserControl); 
        }
         

        private void Form1_Load (object sender, EventArgs e)
        { 

        }
          



        private void preferencjeToolStripMenuItem_Click (object sender, EventArgs e)
        {
            PreferencjeForm pf = new PreferencjeForm (_unityOfWork);
            pf.ShowDialog ();
        }

        private void toolStripButton1_Click (object sender, EventArgs e)
        {
            panelContainerNavigation.Controls.Clear();
            ITUserControl itUserControl = new ITUserControl (_unityOfWork) { Dock = DockStyle.Fill };
            panelContainerNavigation.Controls.Add(itUserControl);
        }

        private void toolStripButton2_Click (object sender, EventArgs e)
        {
            panelContainerNavigation.Controls.Clear();
            KontaktZklientemCRMUserControl kontaktZklientemCRMUserControl = new KontaktZklientemCRMUserControl () { Dock = DockStyle.Fill };
            panelContainerNavigation.Controls.Add(kontaktZklientemCRMUserControl);
        }

        private void toolStripButton3_Click (object sender, EventArgs e)
        {
            panelContainerNavigation.Controls.Clear();
            AndroidUserControl androidUserControl = new AndroidUserControl () { Dock = DockStyle.Fill };
            panelContainerNavigation.Controls.Add(androidUserControl);
        }

        private void toolStripButton4_Click (object sender, EventArgs e)
        {
            panelContainerNavigation.Controls.Clear();
            LogiUserControl logiUserControl = new LogiUserControl () { Dock = DockStyle.Fill };
            panelContainerNavigation.Controls.Add(logiUserControl);
        }

        private void toolStripButton5_Click (object sender, EventArgs e)
        {
            Close ();
        }
    }
}
