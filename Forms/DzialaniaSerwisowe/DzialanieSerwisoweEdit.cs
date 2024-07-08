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

namespace WinFormsApp90.Forms.DzialaniaSerwisowe
{
    public partial class DzialanieSerwisoweEdit : BaseForm
    {
        public DzialanieSerwisoweEdit (string serwisId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            SerwisId = serwisId;
            Zalaczniki.Clear ();
            S.SetDataGridViewStyles(dataGridViewWykonawcy);
            comboBoxFirmy.DataSource = DisplayNazwyFirm();
            comboBoxSprzet.DataSource = DisplayNazwySprzet();

            Serwis = _unityOfWork.SerwisyRepository.Get (SerwisId);
            
        }


        private int godzinaRozpoczecia = 0;
        private int godzinaZakonczenia = 0;
        private int czasTrwania = 0;
        private void DzialanieSerwisoweEdit_Load (object sender, EventArgs e)
        {
            godzinaRozpoczecia = Serwis.GodzinaRozpoczecia;
            godzinaZakonczenia = Serwis.GodzinaZakonczenia; 
            if (godzinaZakonczenia >= godzinaRozpoczecia)
                czasTrwania = godzinaZakonczenia - godzinaRozpoczecia;

            if (Serwis != null)
            {

                comboBoxFirmy.SelectedItem = Serwis.Firma.SkroconaNazwa;
                comboBoxSprzet.SelectedItem = Serwis.Sprzet.Nazwa;

                dateTimePickerData.Value = Serwis.Data;
                textBoxGodzinaRozpoczecia.Text = godzinaRozpoczecia.ToString ();
                textBoxGodzinaZakonczenia.Text = godzinaZakonczenia.ToString ();
                textBoxCzasTrwaniaSerwisu.Text = czasTrwania.ToString ();
                textBoxSzczegolowyOpis.Text = Serwis.SzczegółowyOpis;
                checkBoxCzySprawaZakonczona.Checked = Serwis.SprawaZakonczona;


                // Wyświetlenie serwisantów

                if (Serwis.ApplicationUserSerwisy != null) 
                    dataGridViewWykonawcy.DataSource = (from f in Serwis.ApplicationUserSerwisy.ToList()
                                                        select new
                                                        {
                                                            Imie = f.User.Imie,
                                                            Nazwisko = f.User.Nazwisko
                                                        }).ToList (); 


                // Wyświetlenie załączników
                if (Serwis.SerwisZalaczniki != null) 
                    listBoxZalaczniki.DataSource = Serwis.SerwisZalaczniki.Select (s=> s.Nazwa).ToList ();

                this.Text = Serwis.SerwisZalaczniki.Count.ToString ();
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                godzinaRozpoczecia = Serwis.GodzinaRozpoczecia;
                godzinaZakonczenia = Serwis.GodzinaZakonczenia;
                if (godzinaZakonczenia >= godzinaRozpoczecia)
                    czasTrwania = godzinaZakonczenia - godzinaRozpoczecia;


                Serwis.CzasTrwaniaSerwisu = int.Parse (textBoxCzasTrwaniaSerwisu.Text);
                Serwis.Data = dateTimePickerData.Value;
                Serwis.GodzinaRozpoczecia = int.Parse (textBoxGodzinaRozpoczecia.Text);
                Serwis.GodzinaZakonczenia = int.Parse (textBoxGodzinaZakonczenia.Text);
                Serwis.SprawaZakonczona = checkBoxCzySprawaZakonczona.Checked;
                Serwis.SzczegółowyOpis = textBoxSzczegolowyOpis.Text;

                _unityOfWork.SerwisyRepository.Update (Serwis);
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

        private void buttonBazaWiedzy_Click (object sender, EventArgs e)
        {
            try
            {
                Wiedza wiedza = new Wiedza ()
                {
                    WiedzaId = Guid.NewGuid ().ToString (),
                    Rozwiazanie = textBoxSzczegolowyOpis.Text,
                    DataDodania = DateTime.Now
                };
                if (Serwis.SzczegółowyOpis.Length > 10)
                    wiedza.Temat = Serwis.SzczegółowyOpis.Substring(0, 10);

                _unityOfWork.WiedzaRepository.Create (wiedza);
                _unityOfWork.SaveChanges();
                MessageBox.Show ("Informacja została dodana do bazy wiedzy");
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
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

        private void panel1_Paint (object sender, PaintEventArgs e)
        {

        }

        private void listBoxZalaczniki_DoubleClick (object sender, EventArgs e)
        {

        }
    }
}
