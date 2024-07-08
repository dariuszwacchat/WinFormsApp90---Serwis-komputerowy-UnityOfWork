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

namespace WinFormsApp90.Forms.Kontakty
{
    public partial class KontaktEdit : BaseForm
    {
        public KontaktEdit (string kontaktId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            KontaktId = kontaktId;
        }

        private void KontaktEdit_Load (object sender, EventArgs e)
        {
            Kontakt = _unityOfWork.KontaktyRepository.Get (KontaktId);
            if (Kontakt != null)
            {
                textBoxAdres.Text = Kontakt.Adres;
                textBoxOsobaKontaktowa.Text = Kontakt.OsobaKontaktowa;
                textBoxNumerTelefonu.Text = Kontakt.NumerTelefonu;
                textBoxAdresEmail.Text = Kontakt.AdresEmail;
            }
        }

        private void buttonZapisz_Click (object sender, EventArgs e)
        {
            try
            {
                if (IsValid(new List<TextBox>() { textBoxAdres, textBoxAdresEmail, textBoxNumerTelefonu, textBoxOsobaKontaktowa }))
                {
                    if (Kontakt != null)
                    {
                        Kontakt.Adres = textBoxAdres.Text;
                        Kontakt.AdresEmail = textBoxAdresEmail.Text;
                        Kontakt.NumerTelefonu = textBoxNumerTelefonu.Text;
                        Kontakt.OsobaKontaktowa = textBoxOsobaKontaktowa.Text;

                        _unityOfWork.KontaktyRepository.Update (Kontakt);
                        _unityOfWork.SaveChanges ();
                    }
                }
                else
                {
                    MessageBox.Show ("Pola nie mogą być puste");
                }
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

        private void buttonZamknij_Click (object sender, EventArgs e)
        {
            Close ();
        }

    }
}
