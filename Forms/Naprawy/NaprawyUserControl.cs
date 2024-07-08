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

namespace WinFormsApp90.Forms.Naprawy
{
    public partial class NaprawyUserControl : BaseUserControl
    {
        public NaprawyUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayNaprawy ();
            DisplayNazwyFirm(toolStripComboBoxFirmyNaprawy);
            SetDataGridViewStyles (dataGridViewNaprawy);
        }

        private void DisplayNaprawy ()
        {
            Index = 0;
            var naprawy = _unityOfWork.NaprawyRepository.GetAll ()
                            .OrderByDescending (o=> o.DataNaprawy)
                            .ToList ();
            // Filtrowanie
            if (toolStripComboBoxFirmyNaprawy.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmyNaprawy.SelectedItem.ToString ();
                naprawy = naprawy.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            }
            dataGridViewNaprawy.DataSource = (from f in naprawy
                                              select new
                                              {
                                                  NaprawaId = f.NaprawaId,
                                                  Lp = IndexCounter,
                                                  DataNaprawy = f.DataNaprawy,
                                                  CzasUdzielonejGwarancji = f.CzasUdzielonejGwarancji,
                                                  DataZakonczeniaGwarancji = f.DataZakonczeniaGwarancji,
                                                  Sprzet = f.Sprzet.Nazwa,
                                                  Uwagi = f.Uwagi
                                              }).ToList();
        }


        private void dataGridViewNaprawy_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    NaprawaId = dataGridViewNaprawy.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewNaprawy_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewNaprawy.SelectedRows.Count > 0)
                    NaprawaId = dataGridViewNaprawy.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButtonDodajNaprawy_Click (object sender, EventArgs e)
        {
            NaprawaCreate nc = new NaprawaCreate (_unityOfWork);
            nc.ShowDialog ();
        }

        private void toolStripButtonUsunNaprawy_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikujNaprawy_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(KontaktId))
            {
                NaprawaEdit ne = new NaprawaEdit (KontaktId,_unityOfWork);
                ne.ShowDialog ();
            }
        }

        private void toolStripComboBoxFirmyNaprawy_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplayNaprawy ();
        }
    }
}
