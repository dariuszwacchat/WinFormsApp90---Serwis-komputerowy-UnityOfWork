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
    public partial class LicencjaCreate : BaseForm
    {
        public LicencjaCreate ()
        {
            InitializeComponent(); 
            Zalaczniki.Clear ();
        }


        private void LicencjaCreate_Load (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                WolnaLicencja wolnaLicencja = new WolnaLicencja ()
                {
                    WolnaLicencjaId = Guid.NewGuid ().ToString (),
                    DataWaznosci = dateTimePickerDataWaznosci.Value,
                    DataZakupu = dateTimePickerDataZakupu.Value,
                    IloscLicencji = int.Parse (textBoxIloscLicencji.Text),
                    KluczLicencji = textBoxKluczLicencji.Text,
                    MiejsceZakupu = textBoxGdzieKupiona.Text,
                    Uwagi = textBoxUwagi.Text
                };
                _unityOfWork.WolneLicencjeRepository.Create (wolnaLicencja);
                _unityOfWork.SaveChanges();



                // Dodanie załączników  
                foreach (var zalacznik in Zalaczniki)
                {
                    WolnaLicencjaZalacznik licencjaZalacznik = new WolnaLicencjaZalacznik ()
                    {
                        WolnaLicencjaZalacznikId = Guid.NewGuid ().ToString (),
                        Nazwa = zalacznik,
                        Data = GetBytes (zalacznik),
                        WolnaLicencjaId = wolnaLicencja.WolnaLicencjaId
                    };
                    _unityOfWork.WolneLicencjeZalacznikiRepository.Create(licencjaZalacznik);
                    _unityOfWork.SaveChanges();
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
            Close();
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
