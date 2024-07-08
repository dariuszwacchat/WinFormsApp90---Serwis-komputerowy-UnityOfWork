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
    public partial class DzialanieSerwisoweCreate : BaseForm
    {
        private List <AppUser> appUsers = new List<AppUser> ();


        public DzialanieSerwisoweCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            Zalaczniki.Clear ();
            S.SetDataGridViewStyles (dataGridViewWykonawcy);
            comboBox2.DataSource = DisplayNazwyFirm ();
            comboBox1.DataSource = DisplayNazwySprzet ();
        }

        private void DzialanieSerwisoweCreate_Load (object sender, EventArgs e)
        { 
            // Wyświetlenie serwisantów
            DisplayUsers ();
        }

        private void DisplayUsers ()
        {
            Index = 0;
            var users = PokazWszystkichUzytkownikowZrola ("Personel");   
            dataGridViewWykonawcy.DataSource = users.ToList ();
        }


        private int godzinaRozpoczecia = 0;
        private int godzinaZakonczenia = 0;
        private int czasTrwania = 0;
        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                godzinaRozpoczecia = int.Parse(textBoxGodzinaRozpoczecia.Text);
                godzinaZakonczenia = int.Parse(textBoxGodzinaZakonczenia.Text); 

                if (godzinaZakonczenia >= godzinaRozpoczecia)
                {
                    Cursor = Cursors.WaitCursor;

                    czasTrwania = godzinaZakonczenia - godzinaRozpoczecia;

                    if (Firma != null && Sprzet != null)
                    { 
                        Serwis serwis = new Serwis ()
                        {
                            SerwisId = Guid.NewGuid ().ToString (),
                            Data = dateTimePickerData.Value,
                            GodzinaRozpoczecia = godzinaRozpoczecia,
                            GodzinaZakonczenia = godzinaZakonczenia,
                            CzasTrwaniaSerwisu = czasTrwania,
                            SprawaZakonczona = checkBoxCzySprawaZakonczona.Checked,
                            SzczegółowyOpis = textBoxSzczegolowyOpis.Text,
                            SprzetId = SprzetId,
                            FirmaId = FirmaId
                        };


                        _unityOfWork.SerwisyRepository.Create (serwis);
                        _unityOfWork.SaveChanges();
                        MessageBox.Show("Dodane");


                        // Dodanie serwisantów tylko tych, którzy są zaznaczeni

                        Index = 0;
                        foreach (DataGridViewRow row in dataGridViewWykonawcy.Rows)
                        {
                            if (dataGridViewWykonawcy.Rows[Index].Cells[0].Value != null)
                            {
                                // sprawdzenie czy obiekt w pierwszej kolumnie jest zaznaczony
                                bool isChecked = (bool) dataGridViewWykonawcy.Rows[Index].Cells[0].Value;
                                if (isChecked)
                                {
                                    string imie = dataGridViewWykonawcy.Rows[Index].Cells[1].Value.ToString ();
                                    string nazwisko = dataGridViewWykonawcy.Rows[Index].Cells[2].Value.ToString ();

                                    // znalezienie użytkownika
                                    ApplicationUser user = _unityOfWork.UsersRepository.GetAll ()
                                                            .FirstOrDefault (f=> f.Imie == imie && f.Nazwisko == nazwisko);
                                    if (user != null)
                                    {
                                        ApplicationUserServis applicationUserServis = new ApplicationUserServis ()
                                        {
                                            SerwisId = serwis.SerwisId,
                                            UserId = user.Id
                                        };
                                        _unityOfWork.ApplicationUserServisy.Create (applicationUserServis);
                                        _unityOfWork.SaveChanges();
                                    }
                                }
                            }
                            Index++;
                        }

                         

                        // Dodanie załączników  
                        foreach (var zalacznik in Zalaczniki)
                        {
                            SerwisZalacznik serwisZalacznik = new SerwisZalacznik ()
                            {
                                SerwisZalacznikId = Guid.NewGuid ().ToString (),
                                Nazwa = zalacznik,
                                Data = GetBytes (zalacznik),
                                SerwisId = serwis.SerwisId
                            };
                            _unityOfWork.SerwisyZalacznikiRepository.Create (serwisZalacznik);
                            _unityOfWork.SaveChanges();
                        }
                    }

                    Cursor = Cursors.Default;
                    Close ();
                }
                else
                {
                    MessageBox.Show("Godzina zakończenia musi być większa od godziny rozpoczęcia");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void button2_Click (object sender, EventArgs e)
        {
            if (dataGridViewWykonawcy.Rows[0].Cells[0].Value != null)
            {
                bool isChecked = (bool) dataGridViewWykonawcy.Rows[0].Cells[0].Value;
                this.Text = isChecked.ToString ();
            }


            //Close();
        }

        private void comboBox2_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindFirma(comboBox2);
            comboBox1.DataSource = DisplayNazwySprzet();
        }

        private void comboBox1_SelectedIndexChanged (object sender, EventArgs e)
        {
            FindSprzet (comboBox1);
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
