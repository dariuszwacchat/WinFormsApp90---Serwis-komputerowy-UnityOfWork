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

namespace WinFormsApp90.Forms.Umowy
{
    public partial class UmowyUserControl : BaseUserControl
    {
        public UmowyUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayUmowy ();
            DisplayNazwyFirm(toolStripComboBoxFirmyUmowy);
            S.SetDataGridViewStyles (dataGridViewUmowy);
        }


        private void DisplayUmowy ()
        {
            Index = 0;
            var umowy = _unityOfWork.UmowyRepository.GetAll ();
            // Filtrowanie
            if (toolStripComboBoxFirmyUmowy.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmyUmowy.SelectedItem.ToString ();
                umowy = umowy.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            }
            dataGridViewUmowy.DataSource = (from f in umowy
                                            select new
                                            {
                                                UmowaId = f.UmowaId,
                                                Lp = IndexCounter,
                                                NumerUmowy = f.NumerUmowy,
                                                DataRozpoczecia = f.DataRozpoczecia,
                                                DataZakonczenia = f.DataZakonczenia,
                                                CzasNieokreslony = f.CzasNieokreslony,
                                                OkresWypowiedzenia = f.OkresWypowiedzenia,
                                                Uwagi = f.Uwagi
                                            }).ToList();

        }

        private void dataGridViewUmowy_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    UmowaId = dataGridViewUmowy.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewUmowy_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUmowy.SelectedRows.Count > 0)
                    UmowaId = dataGridViewUmowy.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButtonUmowyDodaj_Click (object sender, EventArgs e)
        {
            UmowaCreate uc = new UmowaCreate (_unityOfWork);
            uc.ShowDialog ();
        }

        private void toolStripButtonUmowyUsun_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonUmowyModyfikuj_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UmowaId))
            {
                UmowaEdit ue = new UmowaEdit (UmowaId,_unityOfWork);
                ue.ShowDialog ();
            }
        }

        private void toolStripComboBoxFirmyUmowy_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplayUmowy ();
        }
    }
}
