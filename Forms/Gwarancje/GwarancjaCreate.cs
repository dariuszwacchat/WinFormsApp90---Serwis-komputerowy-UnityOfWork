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

namespace WinFormsApp90.Forms.Gwarancje
{
    public partial class GwarancjaCreate : BaseForm
    {
        public GwarancjaCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            Zalaczniki.Clear();
            Firma = null;
            Sprzet = null; 
            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (Firma != null && Sprzet != null)
                { 
                    Gwarancja gwarancja = new Gwarancja ()
                    {
                        GwarancjaId = Guid.NewGuid ().ToString (),
                        CzasGwarancji = int.Parse (textBoxCzasGwarancji.Text),
                        DataRozpoczeciaGwarancji = dateTimePickerDataRozpoczeciaGwarancji.Value,
                        DataZakonczeniaGwarancji = dateTimePickerDataZakonczeniaGwarancji.Value, 
                        Uwagi = textBoxUwagi.Text, 
                        SprzetId = SprzetId,
                        FirmaId = FirmaId
                    }; 
                    _unityOfWork.GwarancjeRepository.Create (gwarancja);
                    _unityOfWork.SaveChanges ();
                    MessageBox.Show ("Zapisane");


                    // Dodanie załączników 

                    foreach (var zalacznik in Zalaczniki)
                    {
                        GwarancjaZdjecie gwarancjaZdjecie = new GwarancjaZdjecie ()
                        {
                            GwarancjaZdjecieId = Guid.NewGuid ().ToString (),
                            Nazwa = zalacznik,
                            Data = GetBytes (zalacznik),
                            GwarancjaId = gwarancja.GwarancjaId
                        };
                        _unityOfWork.GwarancjeZdjeciaRepository.Create (gwarancjaZdjecie);
                        _unityOfWork.SaveChanges();
                    }
                }

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void GwarancjaCreate_Load (object sender, EventArgs e)
        {

        }

        private void comboBoxFirmy_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindFirma(comboBoxFirmy);
            comboBoxSprzet.DataSource = DisplayNazwySprzet();
        }

        private void comboBoxSprzet_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindSprzet(comboBoxSprzet);

            try
            {
                var model = Sprzet.Pola.FirstOrDefault (f=> f.Name == "Model");
                var numerSeryjny = Sprzet.Pola.FirstOrDefault (f=> f.Name == "Numer Seryjny" || f.Name == "Numer seryjny");
                var gdzieKupione = Sprzet.Pola.FirstOrDefault (f=> f.Name == "Miejsce Zakupu" || f.Name == "Miejsce zakupu");
                var zalaczniki = Sprzet.SprzetZdjecia.ToList ();

                if (model != null)
                    textBoxModel.Text = model.Wartosc;

                if (numerSeryjny != null)
                    textBoxNumerSeryjny.Text = numerSeryjny.Wartosc;

                listBoxZalacznikiSprzet.DataSource = zalaczniki;
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
             
        }
         

        private void textBoxCzasGwarancji_TextChanged (object sender, EventArgs e)
        {
            int iloscMiesiecy = int.Parse (textBoxCzasGwarancji.Text);
            dateTimePickerDataZakonczeniaGwarancji.Value = dateTimePickerDataRozpoczeciaGwarancji.Value.AddMonths (iloscMiesiecy);
        }

        private void buttonDodajGwarancja_Click (object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog open = new OpenFileDialog() { Multiselect = true })
                {
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        Zalaczniki.Clear();
                        Zalaczniki = open.FileNames.ToList();
                        DisplayItemsInListBox(open.FileNames.ToList().ToList(), listBoxZalacznikiGwarancja);
                    }
                }
            }
            catch { }
        }

        private void buttonUsunGwarancja_Click (object sender, EventArgs e)
        {
            listBoxZalacznikiGwarancja.Items.RemoveAt(listBoxZalacznikiGwarancja.SelectedIndex);
        }
    }
}
