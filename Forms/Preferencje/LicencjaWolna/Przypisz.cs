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

namespace WinFormsApp90.Forms.Preferencje.LicencjaWolna
{
    public partial class Przypisz : BaseForm
    {
        public Przypisz ()
        {
            InitializeComponent(); 
            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet();

            WolnaLicencja = _unityOfWork.WolneLicencjeRepository.Get (WolnaLicencjaId);
         }

        private void Przypisz_Load (object sender, EventArgs e)
        {
            try
            {
                if (WolnaLicencja != null)
                {
                    textBoxKlucz.Text = WolnaLicencja.KluczLicencji;
                    dateTimePickerDataZakonczenia.Value = WolnaLicencja.DataWaznosci;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (Firma != null && Sprzet != null && WolnaLicencja != null)
                {
                    string uwagi = WolnaLicencja.Uwagi;
                    SprzetLicencja sprzetLicencja = new SprzetLicencja ()
                    {
                        SprzetLicencjaId = Guid.NewGuid ().ToString (),
                        KluczLicencji = WolnaLicencja.KluczLicencji,
                        NazwaProgramu = textBoxNazwaProgramu.Text,
                        DataZakonczenia = WolnaLicencja.DataWaznosci,
                        Uwagi = uwagi + Environment.NewLine + Environment.NewLine + textBoxUwagi.Text,
                        SprzetId = SprzetId,
                        FirmaId = FirmaId,
                    };
                    _unityOfWork.SprzetLicencjeRepository.Create (sprzetLicencja);
                    _unityOfWork.SaveChanges();


                    // Dodanie załączników do licencji, skopiowanie z poprzedniej wolnej licencji

                    if (WolnaLicencja.WolnaLicencjaZalaczniki != null)
                    {
                        foreach (WolnaLicencjaZalacznik wolnaLicencjaZalacznik in WolnaLicencja.WolnaLicencjaZalaczniki.ToList())
                        {
                            SprzetLicencjaZalacznik sprzetLicencjaZalacznik = new SprzetLicencjaZalacznik ()
                            {
                                SprzetLicencjaZalacznikId = Guid.NewGuid ().ToString (),
                                Data = wolnaLicencjaZalacznik.Data,
                                Nazwa = wolnaLicencjaZalacznik.Nazwa,
                                SprzetLicencjaId = sprzetLicencja.SprzetLicencjaId
                            };
                            _unityOfWork.SprzetLicencjeZalacznikiRepository.Create (sprzetLicencjaZalacznik);
                            _unityOfWork.SaveChanges ();
                        } 
                    }



                    WolnaLicencja.IloscLicencji = WolnaLicencja.IloscLicencji - 1;
                    _unityOfWork.WolneLicencjeRepository.Update (WolnaLicencja);
                    _unityOfWork.SaveChanges ();


                    MessageBox.Show("Licencja przypisana");
                }

                Cursor = Cursors.Default;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
