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

namespace WinFormsApp90.Forms.Archiwizacje
{
    public partial class ArchiwizacjaEdit : BaseForm
    {
        public ArchiwizacjaEdit (string archiwizacjaId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            ArchiwizacjaId = archiwizacjaId; 
            Archiwizacja = _unityOfWork.ArchiwizacjeRepository.Get (ArchiwizacjaId); 


            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet();
        }

        private void ArchiwizacjaEdit_Load (object sender, EventArgs e)
        {
            try
            {
                if (Archiwizacja != null)
                { 
                    Cursor = Cursors.WaitCursor;

                    comboBoxFirmy.SelectedItem = Archiwizacja.Firma.SkroconaNazwa;
                    comboBoxSprzet.SelectedItem = Archiwizacja.Sprzet.Nazwa;

                    textBoxDaneDoArchiwizacji.Text = Archiwizacja.DaneDoArchiwizacji;
                    textBoxCzestotliwoscArchiwizacji.Text = Archiwizacja.CzestotliwoscArchiwizacji.ToString ();
                    dateTimePickerDataArchiwizacji.Value = Archiwizacja.DataArchiwizacji;
                    textBoxNosnikArchiwizacji.Text = Archiwizacja.NosnikArchiwizacji;
                    textBoxKopiaPrzekazana.Text = Archiwizacja.KopiaPrzekazana;
                    textBoxUwagi.Text = Archiwizacja.Uwagi;

                    Cursor = Cursors.Default;
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
                if (Archiwizacja != null)
                {
                    Archiwizacja.DaneDoArchiwizacji = textBoxDaneDoArchiwizacji.Text;
                    Archiwizacja.CzestotliwoscArchiwizacji = int.Parse (textBoxCzestotliwoscArchiwizacji.Text);
                    Archiwizacja.DataArchiwizacji = dateTimePickerDataArchiwizacji.Value;
                    Archiwizacja.NosnikArchiwizacji = textBoxNosnikArchiwizacji.Text;
                    Archiwizacja.KopiaPrzekazana = textBoxKopiaPrzekazana.Text;
                    Archiwizacja.Uwagi = textBoxUwagi.Text;
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
    }
}
