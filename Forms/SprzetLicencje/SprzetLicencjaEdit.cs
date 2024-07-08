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

namespace WinFormsApp90.Forms.SprzetLicencje
{
    public partial class SprzetLicencjaEdit : BaseForm
    {
        public SprzetLicencjaEdit (string sprzetLicencjaId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            SprzetLicencjaId = sprzetLicencjaId;
            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet();

            SprzetLicencja = _unityOfWork.SprzetLicencjeRepository.Get (SprzetLicencjaId);
        }
         

        private void SprzetLicencjaEdit_Load (object sender, EventArgs e)
        {
            if (SprzetLicencja != null)
            {
                if (SprzetLicencja.Firma != null)
                    comboBoxFirmy.SelectedItem = SprzetLicencja.Firma.SkroconaNazwa;

                if (SprzetLicencja.Sprzet != null)
                    comboBoxSprzet.SelectedItem = SprzetLicencja.Sprzet.Nazwa;

                 

                textBoxNazwaProgramu.Text = SprzetLicencja.NazwaProgramu;
                textBoxKlucz.Text = SprzetLicencja.KluczLicencji;
                dateTimePickerDataZakonczenia.Value = SprzetLicencja.DataZakonczenia;
                textBoxUwagi.Text = SprzetLicencja.Uwagi; 

            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                if (SprzetLicencja != null)
                { 
                    Cursor = Cursors.WaitCursor;


                    SprzetLicencja.NazwaProgramu = textBoxNazwaProgramu.Text;
                    SprzetLicencja.KluczLicencji = textBoxKlucz.Text;
                    SprzetLicencja.DataZakonczenia = dateTimePickerDataZakonczenia.Value;
                    SprzetLicencja.Uwagi = textBoxUwagi.Text;

                    _unityOfWork.SprzetLicencjeRepository.Update (SprzetLicencja);
                    _unityOfWork.SaveChanges ();


                    // Dodanie załączników  
                    foreach (var zalacznik in Zalaczniki)
                    {
                        SprzetLicencjaZalacznik sprzetLicencjaZalacznik = new SprzetLicencjaZalacznik ()
                        {
                            SprzetLicencjaZalacznikId = Guid.NewGuid ().ToString (),
                            Nazwa = zalacznik,
                            Data = GetBytes (zalacznik),
                            SprzetLicencjaId = SprzetLicencja.SprzetLicencjaId
                        };
                        _unityOfWork.SprzetLicencjeZalacznikiRepository.Create (sprzetLicencjaZalacznik);
                        _unityOfWork.SaveChanges();
                    }
                     
                    Cursor = Cursors.Default;
                    Close();
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

        private void comboBoxFirmy_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindFirma(comboBoxFirmy);
            comboBoxSprzet.DataSource = DisplayNazwySprzet();
        }

        private void comboBoxSprzet_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindSprzet(comboBoxSprzet);
        }

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
                        DisplayItemsInListBox(open.FileNames.ToList(), listBoxZalaczniki);
                    }
                }
            }
            catch { }
        }

        private void buttonUsun_Click (object sender, EventArgs e)
        {
            listBoxZalaczniki.Items.RemoveAt(listBoxZalaczniki.SelectedIndex);
        }
    }
}
