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
    public partial class HostingUserControl : BaseUserControl
    {
        public HostingUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayHosting ();
            DisplayNazwyFirm(toolStripComboBoxFirmyHosting);
            SetDataGridViewStyles (dataGridViewHostingi);
        }

        private void DisplayHosting ()
        {
            Index = 0;
            var hosting = _unityOfWork.HostingiRepository.GetAll ();
            // Filtrowanie
            if (toolStripComboBoxFirmyHosting.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmyHosting.SelectedItem.ToString ();
                hosting = hosting.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            }
            dataGridViewHostingi.DataSource = (from f in hosting
                                               select new
                                               {
                                                   HostingId = f.HostingId,
                                                   Lp = IndexCounter,
                                                   Information = f.Information
                                               }).ToList();
        }


        private void dataGridViewHostingi_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    HostingId = dataGridViewHostingi.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewHostingi_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewHostingi.SelectedRows.Count > 0)
                    HostingId = dataGridViewHostingi.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButtonDodajHosting_Click (object sender, EventArgs e)
        {
            HostingCreate hc = new HostingCreate (_unityOfWork);
            hc.ShowDialog ();
        }

        private void toolStripButtonUsunHosting_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikujHosting_Click (object sender, EventArgs e)
        { 
            if (!string.IsNullOrEmpty(HostingId))
            {
                HostingEdit he = new HostingEdit (KontaktId,_unityOfWork);
                he.ShowDialog ();
            }
        }

        private void toolStripComboBoxFirmyHosting_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplayHosting ();
        }
    }
}
