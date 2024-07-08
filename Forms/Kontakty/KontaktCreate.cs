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

namespace WinFormsApp90.Forms.Kontakty
{
    public partial class KontaktCreate : BaseForm
    {
        public KontaktCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent(); 
            Firma = null; 
            comboBoxNazwaFirmy.DataSource = DisplayNazwyFirm(); 
        }

        private void KontaktCreate_Load (object sender, EventArgs e)
        {
            comboBoxNazwaFirmy.DataSource = _unityOfWork.FirmyRepository.GetAll ().Select (s=> s.SkroconaNazwa).ToList ();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                if (IsValid (new List<TextBox> () { textBoxAdres, textBoxAdresEmail, textBoxNumerTelefonu,textBoxOsobaKontaktowa }))
                {
                    Firma = _unityOfWork.FirmyRepository.GetAll ().FirstOrDefault(f => f.SkroconaNazwa == comboBoxNazwaFirmy.SelectedItem.ToString());
                    if (Firma != null)
                    {
                        Kontakt kontakt = new Kontakt ()
                        {
                            KontaktId = Guid.NewGuid ().ToString (),
                            Adres = textBoxAdres.Text,
                            AdresEmail = textBoxAdresEmail.Text,
                            NumerTelefonu = textBoxNumerTelefonu.Text,
                            OsobaKontaktowa = textBoxOsobaKontaktowa.Text,
                            FirmaId = Firma.FirmaId
                        };
                        _unityOfWork.KontaktyRepository.Create (kontakt);
                        _unityOfWork.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Pola nie mogą być puste");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally
            {
                Close ();
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            Close ();
        }

        private void comboBoxNazwaFirmy_SelectedIndexChanged (object sender, EventArgs e)
        { 
            FindFirma(comboBoxNazwaFirmy); 
        }
    }
}
