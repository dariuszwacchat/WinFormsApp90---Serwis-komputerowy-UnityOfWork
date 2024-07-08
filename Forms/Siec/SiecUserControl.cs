using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Data;
using WinFormsApp90.Forms.Sprzety;
using WinFormsApp90.Models;
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms.Siec
{
    public partial class SiecUserControl : BaseUserControl
    {
        public SiecUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            DisplayFieldsUrzadzeniaSieciowe ();
            DisplayNazwyFirm(toolStripComboBox4);
            SetDataGridViewStyles (dataGridViewUrzadzeniaSieciowe); 
            SetDataGridViewStyles(dataGridViewTablicaAdresowIPurzadzenia);
        }


        private void DisplaySprzetSieciowy ()
        {
            var sprzet = _unityOfWork.SprzetyRepository.GetAll ()
                        .Where (i=> i.UrzadzenieSieciowe == true)
                        .ToList ();


            dataGridViewUrzadzeniaSieciowePola.Visible = false; 

            // Filtrowanie 
            /*if (toolStripComboBoxRodzajeSprzetow.SelectedItem != null &&
                toolStripComboBoxFirmySprzet.SelectedItem != null)
                    {
                string wybranyRodzajSprzetu = toolStripComboBoxRodzajeSprzetow.SelectedItem.ToString ();
                string wybranaNazwaFirmy = toolStripComboBoxFirmySprzet.SelectedItem.ToString ();
                if (wybranyRodzajSprzetu != "Wszystko")
                    sprzet = sprzet.Where(w => w.RodzajSprzetu.Nazwa == wybranyRodzajSprzetu && w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
                else
                    sprzet = sprzet.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            } */

            if (toolStripComboBox4.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBox4.SelectedItem.ToString ();
                sprzet = sprzet.Where(w => w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();
            }

            
            if (sprzet.Count > 0)
                dataGridViewUrzadzeniaSieciowePola.Visible = true;
            else
                dataGridViewUrzadzeniaSieciowePola.Visible = false;


            dataGridViewUrzadzeniaSieciowe.DataSource = (from f in sprzet
                                                         select new
                                                         {
                                                             SprzetId = f.SprzetId,
                                                             Lp = IndexCounter,
                                                             Nazwa = f.Nazwa
                                                         }).ToList();

            DisplayTablicaAdresowIPurzadzenia ();
        }


        private void DisplayFieldsUrzadzeniaSieciowe ()
        {
            if (Sprzet != null)
                if (Sprzet.Pola != null) 
                    dataGridViewUrzadzeniaSieciowePola.DataSource = (from f in Sprzet.Pola.ToList()
                                                                     select new
                                                                     {
                                                                         Name = f.Name,
                                                                         Wartosc = f.Wartosc
                                                                     }).ToList(); 
        }


        private void DisplayTablicaAdresowIPurzadzenia ()
        {
            Index = 0;
            var sprzety = _unityOfWork.SprzetyRepository.GetAll ();

            // Filtr
            if (toolStripComboBox4.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBox4.SelectedItem.ToString ();
                sprzety = sprzety.Where (w=> w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList (); 
            }
             
            // Sprawdza, które pole zawiera adres IP 
            dataGridViewTablicaAdresowIPurzadzenia.Rows.Clear ();
            foreach (Sprzet sprzet in sprzety)
            {
                foreach (Pole pole in sprzet.Pola.ToList())
                {
                    if (IsAdressIP(pole.Wartosc))
                    { 
                        dataGridViewTablicaAdresowIPurzadzenia.Rows.Add("");
                        dataGridViewTablicaAdresowIPurzadzenia.Rows[Index].Cells[0].Value = sprzet.Nazwa;
                        dataGridViewTablicaAdresowIPurzadzenia.Rows[Index].Cells[1].Value = pole.Wartosc;

                        Index++;
                    }
                }
            }
        }

        private bool IsAdressIP (string tekst)
        {
            bool b = false;
            try
            {
                tekst = tekst.TrimStart();
                if (tekst.Length >= 3)
                {
                    if (Char.IsDigit(tekst[0]) &&
                        Char.IsDigit(tekst[1]) &&
                        Char.IsDigit(tekst[2]) &&
                        tekst[3] == '.')
                    {
                        b = true;
                    }
                    else
                        b = false;
                }
            }
            catch { }
            return b;
        }
         

        private void toolStripButtonUrzadzeniaSiecioweDodaj_Click (object sender, EventArgs e)
        {
            SprzetCreate sc = new SprzetCreate ();
            sc.ShowDialog();
        }

        private void toolStripButtonUrzadzeniaSiecioweUsun_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonUrzadzeniaSiecioweModyfikuj_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SprzetId))
            {
                SprzetEdit se = new SprzetEdit (SprzetId,_unityOfWork);
                se.ShowDialog();
            }
        }

        private void dataGridViewUrzadzeniaSieciowe_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    SprzetId = dataGridViewUrzadzeniaSieciowe.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(SprzetId))
                    {
                        Sprzet = _unityOfWork.SprzetyRepository.Get (SprzetId);


                        if (Sprzet != null)
                        { 
                            DisplayFieldsUrzadzeniaSieciowe();
                        }
                    }
                }
            }
            catch { }
        }

        private void dataGridViewUrzadzeniaSieciowe_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUrzadzeniaSieciowe.SelectedRows.Count > 0)
                {
                    SprzetId = dataGridViewUrzadzeniaSieciowe.Rows[0].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(SprzetId))
                        Sprzet = _unityOfWork.SprzetyRepository.Get (SprzetId);
                }
            }
            catch { }
        }

        private void button5_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (textBoxAdresIP.Text))
            {
                Ping ping = new Ping ();
                PingReply pr = ping.Send (textBoxAdresIP.Text);
                MessageBox.Show (pr.Status.ToString ());
            }
        }

        private void button4_Click (object sender, EventArgs e)
        {
        }

        private void toolStripComboBox4_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplaySprzetSieciowy(); 
        }
    }
}
