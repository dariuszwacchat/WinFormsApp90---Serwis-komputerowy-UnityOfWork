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

namespace WinFormsApp90.Forms.SprzetLicencje
{
    public partial class SprzetLicencjeUserControl : BaseUserControl
    {
        public SprzetLicencjeUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplaySprzetLicencje ();
            DisplayNazwyFirm(toolStripComboBoxFirmyLicencje);
            SetDataGridViewStyles (dataGridViewLicencje);
        }


        private void DisplaySprzetLicencje ()
        {
            Index = 0;
            var sprzetLicencje = _unityOfWork.SprzetLicencjeRepository.GetAll ();

            // Filtrowanie
            if (toolStripComboBoxFirmyLicencje.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmyLicencje.SelectedItem.ToString ();
                sprzetLicencje = sprzetLicencje.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            }

            dataGridViewLicencje.DataSource = (from f in sprzetLicencje
                                               select new
                                               {
                                                   SprzetLicencjaId = f.SprzetLicencjaId,
                                                   Lp = IndexCounter,
                                                   DataWaznosci = f.KluczLicencji,
                                                   DataZakupu = f.NazwaProgramu,
                                                   IloscLicencji = f.SprzetId,
                                                   KluczLicencji = f.Uwagi,
                                                   Uwagi = f.Uwagi
                                               }).ToList();
        }

        private void dataGridViewLicencje_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    SprzetLicencjaId = dataGridViewLicencje.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(LicencjaId))
                        SprzetLicencja = _unityOfWork.SprzetLicencjeRepository.Get (SprzetLicencjaId);
                }
            }
            catch { }
        }

        private void dataGridViewLicencje_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewLicencje.SelectedRows.Count > 0)
                    if (!string.IsNullOrEmpty(SprzetLicencjaId))
                        SprzetLicencja = _unityOfWork.SprzetLicencjeRepository.Get (SprzetLicencjaId);
            }
            catch { }
        }

        private void toolStripButtonDodajLicencje_Click (object sender, EventArgs e)
        {
            SprzetLicencjaCreate slc = new SprzetLicencjaCreate (_unityOfWork);
            slc.ShowDialog ();
        }

        private void toolStripButtonUsunLicencje_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonLicencje_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SprzetLicencjaId))
            {
                SprzetLicencjaEdit sle = new SprzetLicencjaEdit (SprzetLicencjaId,_unityOfWork);
                sle.ShowDialog ();
            }
        }

        private void toolStripComboBoxFirmyLicencje_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplaySprzetLicencje ();
        }
    }
}
