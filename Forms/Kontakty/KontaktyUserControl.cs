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

namespace WinFormsApp90.Forms.Kontakty
{
    public partial class KontaktyUserControl : BaseUserControl
    {
        public KontaktyUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayKontakty ();
            DisplayNazwyFirm (toolStripComboBoxFirmyKontakty);
            SetDataGridViewStyles (dataGridViewKontakty);
        }


        private void DisplayKontakty ()
        {
            Index = 0;
            var kontakty = _unityOfWork.KontaktyRepository.GetAll ();
            // Filtrowanie
            if (toolStripComboBoxFirmyKontakty.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmyKontakty.SelectedItem.ToString ();
                kontakty = kontakty.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            }
            dataGridViewKontakty.DataSource = (from f in kontakty
                                               select new
                                               {
                                                   KontaktId = f.KontaktId,
                                                   Lp = IndexCounter,
                                                   Adres = f.Adres,
                                                   AdresEmail = f.AdresEmail,
                                                   OsobaKontaktowa = f.OsobaKontaktowa,
                                                   NumerTelefonu = f.NumerTelefonu,
                                               }).ToList();
        }

        private void dataGridViewKontakty_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    KontaktId = dataGridViewKontakty.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewKontakty_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewKontakty.SelectedRows.Count > 0)
                    KontaktId = dataGridViewKontakty.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButton1_Click (object sender, EventArgs e)
        {
            KontaktCreate kc = new KontaktCreate (_unityOfWork);
            kc.ShowDialog ();
        }

        private void toolStripButton2_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (KontaktId))
            {
                KontaktEdit ke = new KontaktEdit (KontaktId,_unityOfWork);
                ke.ShowDialog ();
            }
        }

        private void toolStripComboBoxFirmyKontakty_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplayKontakty ();
        }
    }
}
