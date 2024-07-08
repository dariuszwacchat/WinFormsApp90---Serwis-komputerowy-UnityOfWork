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

namespace WinFormsApp90.Forms.Gwarancje
{
    public partial class GwarancjaEdit : BaseForm
    {
        public GwarancjaEdit (string gwarancjaId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            Zalaczniki.Clear ();
            GwarancjaId = gwarancjaId;
            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet();

            Gwarancja = _unityOfWork.GwarancjeRepository.Get (GwarancjaId);
        }

        private void GwarancjaEdit_Load (object sender, EventArgs e)
        {
            if (Gwarancja != null)
            {
                textBoxCzasGwarancji.Text = Gwarancja.CzasGwarancji.ToString ();
                dateTimePickerDataRozpoczeciaGwarancji.Value = Gwarancja.DataRozpoczeciaGwarancji;
                dateTimePickerDataZakonczeniaGwarancji.Value = Gwarancja.DataZakonczeniaGwarancji;
                textBoxUwagi.Text = Gwarancja.Uwagi;


                if (Gwarancja.GwarancjaZdjecia != null)
                    listBoxZalacznikiGwarancja.DataSource = Gwarancja.GwarancjaZdjecia.ToList();
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                if (Gwarancja != null)
                {
                    Gwarancja.CzasGwarancji = int.Parse (textBoxCzasGwarancji.Text);
                    Gwarancja.DataRozpoczeciaGwarancji = dateTimePickerDataRozpoczeciaGwarancji.Value;
                    Gwarancja.DataZakonczeniaGwarancji = dateTimePickerDataZakonczeniaGwarancji.Value;
                    Gwarancja.Uwagi = textBoxUwagi.Text;

                    _unityOfWork.GwarancjeRepository.Update (Gwarancja);
                    _unityOfWork.SaveChanges ();



                    // Dodanie załączników 

                    foreach (var zalacznik in Zalaczniki)
                    {
                        GwarancjaZdjecie gwarancjaZdjecie = new GwarancjaZdjecie ()
                        {
                            GwarancjaZdjecieId = Guid.NewGuid ().ToString (),
                            Nazwa = zalacznik,
                            Data = GetBytes (zalacznik),
                            GwarancjaId = GwarancjaId
                        };
                        _unityOfWork.GwarancjeZdjeciaRepository.Create (gwarancjaZdjecie);
                        _unityOfWork.SaveChanges();
                    }
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
                        DisplayItemsInListBox(open.FileNames.ToList(), listBoxZalacznikiGwarancja);
                    }
                }
            }
            catch { }
        }

        private void buttonUsunGwarancja_Click (object sender, EventArgs e)
        {
            listBoxZalacznikiGwarancja.Items.RemoveAt(listBoxZalacznikiGwarancja.SelectedIndex);
        }

        private void comboBoxFirmy_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindFirma(comboBoxFirmy);
            comboBoxSprzet.DataSource = DisplayNazwySprzet();
        }

        private void comboBoxSprzet_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindSprzet(comboBoxSprzet);

            var model = Sprzet.Pola.FirstOrDefault (f=> f.Name == "Model");
            var numerSeryjny = Sprzet.Pola.FirstOrDefault (f=> f.Name == "Numer Seryjny" || f.Name == "Numer seryjny");
            var gdzieKupione = Sprzet.Pola.FirstOrDefault (f=> f.Name == "Miejsce Zakupu" || f.Name == "Miejsce zakupu");

            var zalaczniki = Sprzet.SprzetZdjecia.ToList ();

            if (model != null)
                textBoxModel.Text = model.Wartosc;

            if (numerSeryjny != null)
                textBoxNumerSeryjny.Text = numerSeryjny.Wartosc;

            if (gdzieKupione != null)
                textBoxGdzieKupione.Text = gdzieKupione.Wartosc;
        }

        private void textBoxCzasGwarancji_TextChanged (object sender, EventArgs e)
        {
            int iloscMiesiecy = int.Parse (textBoxCzasGwarancji.Text);
            dateTimePickerDataZakonczeniaGwarancji.Value = dateTimePickerDataRozpoczeciaGwarancji.Value.AddMonths(iloscMiesiecy);
        }

    }
}
