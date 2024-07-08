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
using WinFormsApp90.Models;
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms.Firmy.FirmaDetails.Sprzety
{
    public partial class SprzetyUserControl : BaseUserControl
    {
        public SprzetyUserControl ()
        {
            InitializeComponent(); 

            SetDataGridViewStyles (dataGridViewSprzet);
        }

        private void SprzetyUserControl_Load (object sender, EventArgs e)
        {
            DisplaySprzet ();
        }

        private void DisplaySprzet ()
        {
            var sprzet = _unityOfWork.SprzetyRepository.GetAll ();
            dataGridViewSprzet.DataSource = sprzet;
        }

        private void DisplayFields ()
        {
            if (Sprzet != null)
                if (Sprzet.Pola != null)
                    dataGridViewPola.DataSource = (from f in Sprzet.Pola.ToList()
                                                   select new
                                                   {
                                                       Name = f.Name,
                                                       Wartosc = f.Wartosc
                                                   }).ToList();
        }



        private void dataGridViewSprzet_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    SprzetId = dataGridViewSprzet.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(SprzetId))
                        Sprzet = _unityOfWork.SprzetyRepository.Get (SprzetId);
                    DisplayFields();
                }
            }
            catch { }
        }

        private void dataGridViewSprzet_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSprzet.SelectedRows.Count > 0)
                {
                    SprzetId = dataGridViewSprzet.Rows[0].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(SprzetId))
                        Sprzet = _unityOfWork.SprzetyRepository.Get (SprzetId);
                }
            }
            catch { }
        }




    }
}
