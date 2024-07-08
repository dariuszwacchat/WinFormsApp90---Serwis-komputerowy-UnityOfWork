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

namespace WinFormsApp90.Forms.Naprawy
{
    public partial class NaprawaCreate : BaseForm
    {
        public NaprawaCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent(); 
            Firma = null;
            Sprzet = null;
            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet();  
        }


        private void NaprawaCreate_Load (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (Firma != null && Sprzet != null)
                {
                    Naprawa naprawa = new Naprawa ()
                    {
                        NaprawaId = Guid.NewGuid ().ToString (),
                        CzasUdzielonejGwarancji = int.Parse (textBoxCzasUdzielonejGwarancji.Text),
                        DataNaprawy = dateTimePickerDataDokonaniaNaprawy.Value,
                        DataZakonczeniaGwarancji = dateTimePickerDataWygasnieciaGwarancji.Value,
                        Uwagi = textBoxUwagi.Text,
                        SprzetId = SprzetId,
                        FirmaId = FirmaId
                    };

                    _unityOfWork.NaprawyRepository.Create (naprawa);
                    _unityOfWork.SaveChanges ();
                    MessageBox.Show ("Dodane");
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

        private void comboBoxFirmy_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindFirma(comboBoxFirmy);
            comboBoxSprzet.DataSource = DisplayNazwySprzet();
        }

        private void comboBoxSprzet_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindSprzet(comboBoxSprzet);

            var numerSeryjny = Sprzet.Pola.FirstOrDefault (f=> f.Name == "Numer Seryjny" || f.Name == "Numer seryjny");
            if (numerSeryjny != null)
                textBoxNumerSeryjny.Text = numerSeryjny.Wartosc;
        }

        private void textBoxCzasUdzielonejGwarancji_TextChanged (object sender, EventArgs e)
        {
            int iloscMiesiecy = int.Parse (textBoxCzasUdzielonejGwarancji.Text);
            dateTimePickerDataWygasnieciaGwarancji.Value = dateTimePickerDataDokonaniaNaprawy.Value.AddMonths (iloscMiesiecy);
        }
    }
}
