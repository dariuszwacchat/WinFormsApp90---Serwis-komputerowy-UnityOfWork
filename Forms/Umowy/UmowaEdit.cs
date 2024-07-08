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

namespace WinFormsApp90.Forms.Umowy
{
    public partial class UmowaEdit : BaseForm
    {
        public UmowaEdit (string umowaId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            UmowaId = umowaId;
            Umowa = _unityOfWork.UmowyRepository.Get (UmowaId);
        }

        private void UmowaEdit_Load (object sender, EventArgs e)
        {
            if (Umowa != null)
            {
                if (Umowa.Firma != null)
                    comboBoxFirmy.SelectedItem = Umowa.Firma.SkroconaNazwa;


                textBoxNumerUmowy.Text = Umowa.NumerUmowy;
                dateTimePickerDataRozpoczecia.Value = DateTime.Parse (Umowa.DataRozpoczecia);

                if (!string.IsNullOrEmpty (Umowa.DataZakonczenia))
                    dateTimePickerDataZakonczenia.Value = DateTime.Parse (Umowa.DataZakonczenia);

                checkBoxCzasNieokreslony.Checked = Umowa.CzasNieokreslony;
                textBoxOkresWypowiedzenia.Text = Umowa.OkresWypowiedzenia.ToString ();
                textBoxKwotaMiesiecznaNetto.Text = Umowa.KwotaMiesieczna.ToString ();
                textBoxUwagiUmowa.Text = Umowa.Uwagi;


                if (Umowa.UmowaZalaczniki != null)
                    listBoxZalaczniki.DataSource = Umowa.UmowaZalaczniki.ToList ();
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            { 
                Cursor = Cursors.WaitCursor;

                // Dodanie załączników 

                if (Umowa != null)
                {
                    Umowa.NumerUmowy = textBoxNumerUmowy.Text;
                    Umowa.DataRozpoczecia = dateTimePickerDataRozpoczecia.Value.ToString ();

                    if (checkBoxCzasNieokreslony.Checked)
                        Umowa.DataZakonczenia = dateTimePickerDataZakonczenia.Value.ToString ();
                    else
                        Umowa.DataZakonczenia = "";

                    Umowa.OkresWypowiedzenia = int.Parse (textBoxOkresWypowiedzenia.Text);
                    Umowa.KwotaMiesieczna = double.Parse (textBoxKwotaMiesiecznaNetto.Text);
                    Umowa.Uwagi = textBoxUwagiUmowa.Text;


                    _unityOfWork.UmowyRepository.Update (Umowa);
                    _unityOfWork.SaveChanges ();
                }

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
                Close();
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

        private void checkBoxCzasNieokreslony_CheckedChanged (object sender, EventArgs e)
        { 
            if (checkBoxCzasNieokreslony.Checked)
                dateTimePickerDataZakonczenia.Enabled = false;
            else
                dateTimePickerDataZakonczenia.Enabled = true;
        }
    }
}
