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

namespace WinFormsApp90.Forms.Archiwizacje
{
    public partial class ArchiwizacjeUserControl : BaseUserControl
    {
        public ArchiwizacjeUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayArchiwizacje ();
            DisplayNazwyFirm(toolStripComboBoxFirmyArchiwizacja);
            S.SetDataGridViewStyles (dataGridViewArchiwizacje);
        }


        private void DisplayArchiwizacje ()
        {
            Index = 0;
            var archiwizacje = _unityOfWork.ArchiwizacjeRepository.GetAll ();
            // Filtrowanie
            if (toolStripComboBoxFirmyArchiwizacja.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmyArchiwizacja.SelectedItem.ToString ();
                archiwizacje = archiwizacje.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            }
            dataGridViewArchiwizacje.DataSource = (from f in archiwizacje
                                                   select new
                                                   {
                                                       ArchiwizacjaId = f.ArchiwizacjaId,
                                                       Lp = IndexCounter,
                                                       DataArchiwizacji = f.DataArchiwizacji,
                                                       DaneDoArchiwizacji = f.DaneDoArchiwizacji,
                                                       KopiaPrzekazana = f.KopiaPrzekazana,
                                                       NosnikArchiwizacji = f.NosnikArchiwizacji,
                                                       CzestotliwoscArchiwizacji = f.CzestotliwoscArchiwizacji,
                                                       Sprzet = f.Sprzet.Nazwa
                                                   }).ToList();
        }

        private void dataGridViewArchiwizacje_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    ArchiwizacjaId = dataGridViewArchiwizacje.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewArchiwizacje_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewArchiwizacje.SelectedRows.Count > 0)
                    ArchiwizacjaId = dataGridViewArchiwizacje.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButtonDodajArchiwizacja_Click (object sender, EventArgs e)
        {
            ArchiwizacjaCreate ac = new ArchiwizacjaCreate (_unityOfWork);
            ac.ShowDialog ();
        }

        private void toolStripButtonUsunArchiwizacja_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikujArchiwizacja_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (ArchiwizacjaId))
            {
                ArchiwizacjaEdit ae = new ArchiwizacjaEdit (ArchiwizacjaId, _unityOfWork);
                ae.ShowDialog ();
            }
        }

        private void dataGridViewArchiwizacje_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripComboBoxFirmyArchiwizacja_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplayArchiwizacje ();
        }
    }
}
