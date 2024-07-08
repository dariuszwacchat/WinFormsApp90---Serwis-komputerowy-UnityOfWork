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

namespace WinFormsApp90.Forms.Archiwizacje
{
    public partial class ArchiwizacjaCreate : BaseForm
    {
        public ArchiwizacjaCreate (IUnityOfWork unityOfWork) : base (unityOfWork)
        {
            InitializeComponent();
            Firma = null; 
        }

        private void ArchiwizacjaCreate_Load (object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet ();
            Cursor = Cursors.Default;
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (Firma != null && Sprzet != null)
                {
                    Archiwizacja archiwizacja = new Archiwizacja ()
                    {
                        ArchiwizacjaId = Guid.NewGuid ().ToString (),
                        CzestotliwoscArchiwizacji = int.Parse (textBoxCzestotliwoscArchiwizacji.Text),
                        DaneDoArchiwizacji = textBoxDaneDoArchiwizacji.Text,
                        DataArchiwizacji = dateTimePickerDataArchiwizacji.Value,
                        KopiaPrzekazana = textBoxKopiaPrzekazana.Text,
                        NosnikArchiwizacji = textBoxNosnikArchiwizacji.Text,
                        Uwagi = textBoxUwagi.Text,
                        FirmaId = FirmaId,
                        SprzetId = SprzetId
                    };
                    _unityOfWork.ArchiwizacjeRepository.Create (archiwizacja);
                    _unityOfWork.SaveChanges ();
                }
                Cursor = Cursors.Default;
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

        private void comboBoxFirmy_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindFirma (comboBoxFirmy);
            comboBoxSprzet.DataSource = DisplayNazwySprzet();
        }

        private void comboBoxSprzet_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindSprzet(comboBoxSprzet);
        }

    }
}
