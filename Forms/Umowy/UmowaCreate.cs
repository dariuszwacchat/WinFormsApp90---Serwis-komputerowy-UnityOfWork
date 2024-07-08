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

namespace WinFormsApp90.Forms.Umowy
{
    public partial class UmowaCreate : BaseForm
    {
        public UmowaCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent(); 
            Zalaczniki.Clear ();
            Firma = null; 
            comboBoxFirmy.DataSource = DisplayNazwyFirm();
        }


        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                Umowa umowa = new Umowa ()
                {
                    UmowaId = Guid.NewGuid ().ToString (),
                    DataRozpoczecia = dateTimePickerDataRozpoczecia.Value.ToString (),
                    CzasNieokreslony = checkBoxCzasNieokreslony.Checked,
                    KwotaMiesieczna = double.Parse (textBoxKwotaMiesiecznaNetto.Text),
                    NumerUmowy = textBoxNumerUmowy.Text,
                    OkresWypowiedzenia = int.Parse (textBoxOkresWypowiedzenia.Text),
                    Uwagi = textBoxUwagiUmowa.Text,
                    FirmaId = FirmaId                
                };

                if (!checkBoxCzasNieokreslony.Checked) 
                    umowa.DataZakonczenia = dateTimePickerDataZakonczenia.Value.ToString ();
                else
                    umowa.DataZakonczenia = "";

                _unityOfWork.UmowyRepository.Create (umowa);
                _unityOfWork.SaveChanges ();



                // Dodanie załączników 

                foreach (var zalacznik in Zalaczniki)
                {
                    SerwisZalacznik serwisZalacznik = new SerwisZalacznik ()
                    {
                        SerwisZalacznikId = Guid.NewGuid ().ToString (),
                        Nazwa = zalacznik,
                        Data = GetBytes (zalacznik),
                        SerwisId = SerwisId
                    };
                    _unityOfWork.SerwisyZalacznikiRepository.Create (serwisZalacznik);
                    _unityOfWork.SaveChanges();
                }


                Cursor = Cursors.Default;
                Close ();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
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

        private void comboBoxFirmy_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindFirma(comboBoxFirmy);
        }
         

        private void listBoxZalaczniki_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void label36_Click (object sender, EventArgs e)
        {

        }

        private void checkBoxCzasNieokreslony_CheckedChanged (object sender, EventArgs e)
        {
            if (checkBoxCzasNieokreslony.Checked)
                dateTimePickerDataZakonczenia.Enabled = false;
            else
                dateTimePickerDataZakonczenia.Enabled = true;
        }

    }
}
