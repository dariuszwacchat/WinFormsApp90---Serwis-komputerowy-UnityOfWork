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

namespace WinFormsApp90.Forms.Gwarancje
{
    public partial class GwarancjeUserControl : BaseUserControl
    {
        public GwarancjeUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayGrawancje ();
            DisplayNazwyFirm(toolStripComboBoxFirmyGwarancje);
            SetDataGridViewStyles (dataGridViewGwarancje);
        }


        private void DisplayGrawancje ()
        {
            Index = 0;
            var gwarancje = _unityOfWork.GwarancjeRepository.GetAll ();
            // Filtrowanie
            if (toolStripComboBoxFirmyGwarancje.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmyGwarancje.SelectedItem.ToString ();
                gwarancje = gwarancje.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            }
            dataGridViewGwarancje.DataSource = (from f in gwarancje
                                                select new
                                                {
                                                    GwarancjaId = f.GwarancjaId,
                                                    Lp = IndexCounter,
                                                    DataRozpoczeciaGwarancji = f.DataRozpoczeciaGwarancji,
                                                    DataZakonczeniaGwarancji = f.DataZakonczeniaGwarancji,
                                                    CzasGwarancji = f.CzasGwarancji,
                                                    Sprzet = f.Sprzet.Nazwa,
                                                    Uwagi = f.Uwagi
                                                }).ToList();
        }
        private void dataGridViewGwarancje_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    GwarancjaId = dataGridViewGwarancje.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewGwarancje_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewGwarancje.SelectedRows.Count > 0)
                    GwarancjaId = dataGridViewGwarancje.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButtonDodajGwarancje_Click (object sender, EventArgs e)
        {
            GwarancjaCreate gc = new GwarancjaCreate (_unityOfWork);
            gc.ShowDialog ();
        }

        private void toolStripButtonUsunGwarancje_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikujGwarancje_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(GwarancjaId))
            { 
                GwarancjaEdit ge = new GwarancjaEdit (GwarancjaId,_unityOfWork);
                ge.ShowDialog ();
            }
        }

        private void toolStripComboBoxFirmyGwarancje_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplayGrawancje ();
        }
    }
}
