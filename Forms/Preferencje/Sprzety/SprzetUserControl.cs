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

namespace WinFormsApp90.Forms.Preferencje.Sprzety
{
    public partial class SprzetUserControl : BaseUserControl
    {  
        public SprzetUserControl (IUnityOfWork unityOfWork) : base (unityOfWork)
        {
            InitializeComponent(); 
        }

        private void SprzetUserControl_Load (object sender, EventArgs e)
        {
            DisplaySprzety();
        }


        private void DisplaySprzety ()
        {
            Index = 0;
            var sprzety = _unityOfWork.SprzetItemsRepository.GetAll ();
            dataGridViewSprzety.DataSource = (from f in sprzety
                                              select new
                                              {
                                                  SprzetItemId = f.SprzetItemId,
                                                  Lp = IndexCounter,
                                                  Nazwa = f.Nazwa
                                              }).ToList ();
        }

        private void DisplayDetails ()
        {
            if (SprzetItem.PolaItems != null)
            {
                Index = 0; 
                dataGridViewPola.DataSource = (from f in SprzetItem.PolaItems.ToList()
                                               select new
                                               {
                                                   Lp = IndexCounter,
                                                   Name = f.Name,
                                               }).ToList ();
            }
        }
         

        private void tabPage1_Click (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        { 
            SprzetCreate sc = new SprzetCreate ();
            sc.ShowDialog ();
        }


        private void dataGridViewSprzety_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    SprzetItemId = dataGridViewSprzety.Rows[e.RowIndex].Cells[0].Value.ToString();                      
                    SprzetItem = _unityOfWork.SprzetItemsRepository.Get (SprzetItemId);
                    DisplayDetails();
                }
            }
            catch { }
        }

        private void dataGridViewSprzety_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSprzety.SelectedRows.Count > 0)
                {
                    SprzetItemId = dataGridViewSprzety.Rows[0].Cells[0].Value.ToString();
                    SprzetItem = _unityOfWork.SprzetItemsRepository.Get (SprzetItemId);
                }
            }
            catch { }
        }
          

        private void button2_Click (object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty (SprzetItemId))
                {
                    SprzetEdit se = new SprzetEdit (SprzetItemId);
                    se.ShowDialog ();
                }
            }
            catch { }
        }
    }
}
