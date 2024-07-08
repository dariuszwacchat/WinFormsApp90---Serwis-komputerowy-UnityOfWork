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

namespace WinFormsApp90.Forms.Preferencje.LicencjaWolna
{
    public partial class LicencjeWolneUserControl : BaseUserControl
    {
        public LicencjeWolneUserControl ()
        {
            InitializeComponent();

            DisplayWolneLicencje ();
            
        }

        private void DisplayWolneLicencje ()
        {
            var wolneLicencje = _unityOfWork.WolneLicencjeRepository.GetAll ();
            dataGridViewWolneLicencje.DataSource = wolneLicencje;

        }
        private void dataGridViewWolneLicencje_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            { 
                if (e.RowIndex >= 0)
                    WolnaLicencjaId = dataGridViewWolneLicencje.Rows[e.RowIndex].Cells[0].Value.ToString();                
            }
            catch { }
        }

        private void dataGridViewWolneLicencje_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewWolneLicencje.SelectedRows.Count > 0)
                    WolnaLicencjaId = dataGridViewWolneLicencje.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButtonDodaj_Click (object sender, EventArgs e)
        {
            LicencjaCreate lc = new LicencjaCreate ();
            lc.ShowDialog ();
        }

        private void toolStripButtonUsun_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikuj_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (WolnaLicencjaId))
            {
                LicencjaEdit le = new LicencjaEdit (WolnaLicencjaId);
                le.ShowDialog ();
            }
        }

        private void toolStripButton1_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(WolnaLicencjaId))
            {
                Przypisz p = new Przypisz ();
                p.ShowDialog();
            }
        }
    }
}
