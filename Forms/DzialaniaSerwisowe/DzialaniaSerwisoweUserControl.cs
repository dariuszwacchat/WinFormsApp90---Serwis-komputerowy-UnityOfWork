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

namespace WinFormsApp90.Forms.DzialaniaSerwisowe
{
    public partial class DzialaniaSerwisoweUserControl : BaseUserControl
    {
        public DzialaniaSerwisoweUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayDzialaniaSerwisowe ();
            DisplayNazwyFirm(toolStripComboBoxFirmyDzialaniaSerwisowe);
            SetDataGridViewStyles (dataGridViewDzialaniaSerwisowe);
        }


        private void DisplayDzialaniaSerwisowe ()
        {
            Index = 0;
            var dzialaniaSerwisowe = _unityOfWork.SerwisyRepository.GetAll ();
            // Filtrowanie
            if (toolStripComboBoxFirmyDzialaniaSerwisowe.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmyDzialaniaSerwisowe.SelectedItem.ToString ();
                dzialaniaSerwisowe = dzialaniaSerwisowe.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            }
            dataGridViewDzialaniaSerwisowe.DataSource = (from f in dzialaniaSerwisowe
                                                         select new
                                                         {
                                                             SerwisId = f.SerwisId,
                                                             Lp = IndexCounter,
                                                             Data = f.Data,
                                                             GodzinaRozpoczecia = f.GodzinaRozpoczecia,
                                                             GodzinaZakonczenia = f.GodzinaZakonczenia,
                                                             CzasTrwaniaSerwisu = f.CzasTrwaniaSerwisu,
                                                             // SerwisZalaczniki = f.SerwisZalaczniki.Count,
                                                             SprawaZakonczona = CzyZakonczona(f.SprawaZakonczona),
                                                             Sprzet = f.Sprzet.Nazwa
                                                         }).ToList();
        }

        private string CzyZakonczona (bool sprawaZakonczona)
        {
            if (sprawaZakonczona)
                return "Tak";
            else
                return "Nie";
        }

        private void dataGridViewDzialaniaSerwisowe_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    SerwisId = dataGridViewDzialaniaSerwisowe.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewDzialaniaSerwisowe_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDzialaniaSerwisowe.SelectedRows.Count > 0)
                    SerwisId = dataGridViewDzialaniaSerwisowe.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButtonDodajDzialanieSerwisowe_Click (object sender, EventArgs e)
        {
            DzialanieSerwisoweCreate dsc = new DzialanieSerwisoweCreate (_unityOfWork);
            dsc.ShowDialog ();
        }

        private void toolStripButtonUsunDzialanieSerwisowe_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikujDzialanieSerwisowe_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (SerwisId))
            {
                DzialanieSerwisoweEdit dse = new DzialanieSerwisoweEdit (SerwisId,_unityOfWork);
                dse.ShowDialog ();
            }
        }

        private void toolStripComboBoxFirmyDzialaniaSerwisowe_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplayDzialaniaSerwisowe ();
        }
    }
}
