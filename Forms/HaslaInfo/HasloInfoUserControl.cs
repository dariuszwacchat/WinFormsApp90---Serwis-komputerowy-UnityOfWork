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

namespace WinFormsApp90.Forms.HaslaInfo
{
    public partial class HasloInfoUserControl : BaseUserControl
    {
        public HasloInfoUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayHasla ();
            DisplayNazwyFirm(toolStripComboBoxFirmyHasla);
            SetDataGridViewStyles (dataGridViewHasla);
        }


        private void DisplayHasla ()
        {
            Index = 0;
            var hasla = _unityOfWork.HaslaInfosRepository.GetAll ();
            // Filtrowanie
            if (toolStripComboBoxFirmyHasla.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmyHasla.SelectedItem.ToString ();
                hasla = hasla.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            }
            dataGridViewHasla.DataSource = (from f in hasla
                                            select new
                                            {
                                                HasloInfoId = f.HasloInfoId,
                                                Lp = IndexCounter,
                                                Login = f.Login,
                                                Haslo = f.Haslo,
                                                Sprzet = f.Sprzet.Nazwa,
                                                Uwagi = f.Uwagi
                                            }).ToList();
        }
        private void dataGridViewHasla_CellMouseClick_1 (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    HasloInfoId = dataGridViewHasla.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewHasla_SelectionChanged_1 (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewHasla.SelectedRows.Count > 0)
                    HasloInfoId = dataGridViewHasla.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButtonDodajHasloInfo_Click (object sender, EventArgs e)
        {
            HasloInfoCreate hic = new HasloInfoCreate (_unityOfWork);
            hic.ShowDialog ();
        }

        private void toolStripButtonUsunHasloInfo_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikujHasloInfo_Click (object sender, EventArgs e)
        { 
            if (!string.IsNullOrEmpty(HasloInfoId))
            {
                HasloInfoEdit hie = new HasloInfoEdit (HasloInfoId,_unityOfWork);
                hie.ShowDialog ();
            }
        }

        private void toolStripComboBoxFirmyHasla_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplayHasla ();
        }
    }
}
