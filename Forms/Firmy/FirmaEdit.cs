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

namespace WinFormsApp90.Forms.Firmy
{
    public partial class FirmaEdit : BaseForm
    {
        public FirmaEdit (string firmaId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            FirmaId = firmaId;
            Zalaczniki.Clear ();
            Firma = _unityOfWork.FirmyRepository.Get (FirmaId); 

            // SetDataGridViewStyles (dataGridViewUmowy);
        }

        private void FirmaEdit_Load (object sender, EventArgs e)
        {
            if (Firma != null)
            {
                textBoxPelnaNazwa.Text = Firma.PelnaNazwa;
                textBoxSkroconaNazwa.Text = Firma.SkroconaNazwa;
                textBoxAdres.Text = Firma.Adres;
                textBoxNIP.Text = Firma.Nip;
                textBoxUwagiFirma.Text = Firma.Uwagi;

                
                /*
                if (Firma.Umowy != null)
                {
                    Index = 0;
                    var umowy = Firma.Umowy.ToList ();
                    dataGridViewUmowy.DataSource = (from f in umowy
                                                    select new
                                                    {
                                                        UmowaId = f.UmowaId,
                                                        Lp = IndexCounter,
                                                        DataRozpoczecia = f.DataRozpoczecia,
                                                        DataZakonczenia = f.DataZakonczenia,
                                                        CzasNieokreslony = f.CzasNieokreslony,
                                                        NumerUmowy = f.NumerUmowy,
                                                        HaOkresWypowiedzeniaslo = f.OkresWypowiedzenia,
                                                        Firma = f.Firma.SkroconaNazwa,
                                                        Uwagi = f.Uwagi
                                                    }).ToList();
                }*/
            }
             
        }

         
/*
        private void DisplayDetails ()
        { 
            if (Umowa != null)
            {
                textBoxNumerUmowy.Text = Umowa.NumerUmowy;
                dateTimePickerDataRozpoczecia.Value = DateTime.Parse (Umowa.DataRozpoczecia);
                dateTimePickerDataZakonczenia.Value = DateTime.Parse (Umowa.DataZakonczenia);
                textBoxOkresWypowiedzenia.Text = Umowa.OkresWypowiedzenia.ToString();
                checkBoxCzasNieokreslony.Checked = Umowa.CzasNieokreslony;
                textBoxKwotaMiesieczna.Text = Umowa.KwotaMiesieczna.ToString();
                textBoxUwagiUmowa.Text = Umowa.Uwagi;


                // Wyświetle załączniki
                if (Umowa.UmowaZalaczniki != null)
                {

                }
            }
        }
*/


        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                if (Firma != null)
                {
                    Cursor = Cursors.WaitCursor;

                    Firma.PelnaNazwa = textBoxPelnaNazwa.Text;
                    Firma.SkroconaNazwa = textBoxSkroconaNazwa.Text;
                    Firma.Adres = textBoxAdres.Text;
                    Firma.Nip = textBoxNIP.Text;
                    Firma.Uwagi = textBoxUwagiFirma.Text;

                    _unityOfWork.FirmyRepository.Update (Firma);
                    _unityOfWork.SaveChanges (); 


                    MessageBox.Show ("Dane zapisane poprawnie");
                    Close ();
                    Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            Close ();
        }

/*
        private void buttonDodaj_Click (object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog open = new OpenFileDialog() { Multiselect = true })
                {
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        Zalaczniki.Clear();
                        Zalaczniki = open.FileNames.ToList();
                        DisplayItemsInListBox(open.FileNames, listBoxZalaczniki);
                    }
                }
            }
            catch { }
        }

        private void buttonUsun_Click (object sender, EventArgs e)
        {
            listBoxZalaczniki.Items.RemoveAt(listBoxZalaczniki.SelectedIndex);
        }

        private void dataGridViewUmowy_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    UmowaId = dataGridViewUmowy.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty (UmowaId))
                    {
                        Umowa = _unityOfWork.Umowy
                            .Include (i=> i.UmowaZalaczniki)
                            .FirstOrDefault (f=> f.UmowaId == UmowaId);
                        if (Umowa != null)
                            DisplayDetails ();
                    }
                } 
            }
            catch { }
        }

        private void dataGridViewUmowy_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUmowy.SelectedRows.Count > 0)
                {
                    UmowaId = dataGridViewUmowy.Rows[0].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(UmowaId))
                    {
                        Umowa = _unityOfWork.Umowy
                            .Include(i => i.UmowaZalaczniki)
                            .FirstOrDefault(f => f.UmowaId == UmowaId);
                        if (Umowa != null)
                            DisplayDetails();
                    }
                }
            }
            catch { }
        }
*/

    }
}
