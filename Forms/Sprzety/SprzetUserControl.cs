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

namespace WinFormsApp90.Forms.Sprzety
{
    public partial class SprzetUserControl : BaseUserControl
    {
        public SprzetUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplaySprzet ();
            DisplayNazwyFirm(toolStripComboBoxFirmySprzet);
            SetDataGridViewStyles (dataGridViewSprzet);
        }


        private void DisplaySprzet ()
        {
            Index = 0;
            var sprzet = _unityOfWork.SprzetyRepository.GetAll () 
                            .Where (w=> w.UrzadzenieSieciowe == false)
                            .OrderBy (o=> o.Nazwa)
                            .ToList ();

            // Filtrowanie 
            /*
                        if (toolStripComboBoxRodzajeSprzetow.SelectedItem != null &&
                            toolStripComboBoxFirmySprzet.SelectedItem != null)
                        {
                            string wybranyRodzajSprzetu = toolStripComboBoxRodzajeSprzetow.SelectedItem.ToString ();
                            string wybranaNazwaFirmy = toolStripComboBoxFirmySprzet.SelectedItem.ToString ();
                            if (wybranyRodzajSprzetu != "Wszystko")
                                sprzet = sprzet.Where(w => w.RodzajSprzetu.Nazwa == wybranyRodzajSprzetu && w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
                            else
                                sprzet = sprzet.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
                        }*/

            if (toolStripComboBoxFirmySprzet.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmySprzet.SelectedItem.ToString ();
                sprzet = sprzet.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            }


            dataGridViewSprzet.DataSource = (from f in sprzet
                                             select new
                                             {
                                                 SprzetId = f.SprzetId,
                                                 Lp = IndexCounter,
                                                 Nazwa = f.Nazwa
                                             }).ToList ();
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
                        Sprzet = _unityOfWork.SprzetyRepository.Get(SprzetId);
                }
            }
            catch { }
        }

        private void toolStripButtonDodaj_Click (object sender, EventArgs e)
        {
            SprzetCreate sc = new SprzetCreate ();
            sc.ShowDialog ();
        }

        private void toolStripButtonUsun_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikuj_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (SprzetId))
            {
                SprzetEdit se = new SprzetEdit (SprzetId,_unityOfWork);
                se.ShowDialog ();
            }
        }

        private void toolStripComboBoxFirmySprzet_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplaySprzet ();
        }
    }
}
