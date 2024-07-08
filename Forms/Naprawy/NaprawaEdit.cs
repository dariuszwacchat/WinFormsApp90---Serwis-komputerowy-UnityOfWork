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
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms.Naprawy
{
    public partial class NaprawaEdit : BaseForm
    {
        public NaprawaEdit (string naprawaId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            NaprawaId = naprawaId;
            Naprawa = _unityOfWork.NaprawyRepository.Get (NaprawaId);

            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet();
        }

        private void NaprawaEdit_Load (object sender, EventArgs e)
        {
            try
            {
                if (Naprawa != null)
                {
                    if (Naprawa.Firma != null)
                        comboBoxFirmy.SelectedItem = Naprawa.Firma.SkroconaNazwa;

                    if (Naprawa.Sprzet != null)
                    {
                        comboBoxSprzet.SelectedItem = Sprzet.Nazwa;
                        if (Sprzet.Pola != null)
                        {
                            var numerSeryjny = Naprawa.Sprzet.Pola.FirstOrDefault (f=> f.Name == "Numer Seryjny" || f.Name == "Numer seryjny");
                            if (numerSeryjny != null)
                                textBoxNumerSeryjny.Text = numerSeryjny.Wartosc;
                        }
                    }


                    dateTimePickerDataDokonaniaNaprawy.Value = Naprawa.DataNaprawy;
                    dateTimePickerDataWygasnieciaGwarancji.Value = Naprawa.DataZakonczeniaGwarancji;
                    textBoxCzasUdzielonejGwarancji.Text = Naprawa.CzasUdzielonejGwarancji.ToString ();
                    textBoxUwagi.Text = Naprawa.Uwagi;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                if (Naprawa != null)
                {

                    Naprawa.DataNaprawy = dateTimePickerDataDokonaniaNaprawy.Value;
                    Naprawa.CzasUdzielonejGwarancji = int.Parse (textBoxCzasUdzielonejGwarancji.Text);
                    Naprawa.DataZakonczeniaGwarancji = dateTimePickerDataWygasnieciaGwarancji.Value;
                    Naprawa.Uwagi = textBoxUwagi.Text;

                    _unityOfWork.NaprawyRepository.Update (Naprawa);
                    _unityOfWork.SaveChanges ();
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

        private void textBoxCzasUdzielonejGwarancji_TextChanged (object sender, EventArgs e)
        { 
            int iloscMiesiecy = int.Parse (textBoxCzasUdzielonejGwarancji.Text);
            dateTimePickerDataWygasnieciaGwarancji.Value = dateTimePickerDataDokonaniaNaprawy.Value.AddMonths(iloscMiesiecy);
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
