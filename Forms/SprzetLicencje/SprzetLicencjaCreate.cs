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
    public partial class SprzetLicencjaCreate : BaseForm
    {
        public SprzetLicencjaCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            Zalaczniki.Clear ();
            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet();

        }

        private void SprzetLicencjaCreate_Load (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (Firma != null && Sprzet != null)
                {
                    SprzetLicencja sprzetLicencja = new SprzetLicencja ()
                    {
                        SprzetLicencjaId = Guid.NewGuid ().ToString (),
                        KluczLicencji = textBoxKlucz.Text,
                        NazwaProgramu = textBoxNazwaProgramu.Text,
                        DataZakonczenia = dateTimePickerDataZakonczenia.Value,
                        Uwagi = textBoxUwagi.Text, 
                        SprzetId = SprzetId,
                        FirmaId = FirmaId,
                    };
                    _unityOfWork.SprzetLicencjeRepository.Create (sprzetLicencja);
                    _unityOfWork.SaveChanges();



                    // Dodanie załączników  
                    foreach (var zalacznik in Zalaczniki)
                    {
                        SprzetLicencjaZalacznik sprzetLicencjaZalacznik = new SprzetLicencjaZalacznik ()
                        {
                            SprzetLicencjaZalacznikId = Guid.NewGuid ().ToString (),
                            Nazwa = zalacznik,
                            Data = GetBytes (zalacznik),
                            SprzetLicencjaId = sprzetLicencja.SprzetLicencjaId
                        };
                        _unityOfWork.SprzetLicencjeZalacznikiRepository.Create (sprzetLicencjaZalacznik);
                        _unityOfWork.SaveChanges();
                    }


                    MessageBox.Show("Dodane");  
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

        private void panel1_Paint (object sender, PaintEventArgs e)
        {

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
