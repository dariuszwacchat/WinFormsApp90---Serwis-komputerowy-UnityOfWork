using Microsoft.AspNetCore.Identity;
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

namespace WinFormsApp90.Forms.Pracownicy
{
    public partial class PracownikEdit : BaseForm
    {
        public PracownikEdit (string userId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            Zalaczniki.Clear(); 
            UserId = userId;
            User = _unityOfWork.UsersRepository.Get (UserId);
        }
        private void PracownikEdit_Load (object sender, EventArgs e)
        { 
            if (User != null)
            {
                textBoxImie.Text = User.Imie;
                textBoxNazwisko.Text = User.Nazwisko;
                dateTimePickerDataUrodzenia.Value = User.DataUrodzenia;
                textBoxAdresZamieszkania.Text = User.AdresZamieszkania;
                textBoxPrywatnyTelefon.Text = User.PrywatnyTelefon;
                textBoxTelefonSluzbowy.Text = User.TelefonSluzbowy;
                textBoxAdresEmailSluzbowy.Text = User.AdresEmailSluzbowy;
                textBoxNumerGG.Text = User.NumerGG;
                textBoxUwagi.Text = User.Uwagi;
            }

            // Wyświetlenie wszystkich ról wraz z tymi do których należy
            DisplayAllRolesISprawdzCzyDoNiejNalezy(panelUprawnienia, User);


            // Dodanie załączników 

            if (User.ApplicationUserZalaczniki != null)
                DisplayItemsInListBox(User.ApplicationUserZalaczniki.Select(s => s.Nazwa).ToList(), listBoxZalaczniki);
             
        }

        private void button3_Click (object sender, EventArgs e)
        {
            try
            {
                if (User != null)
                {
                    User.Imie = textBoxImie.Text;
                    User.Nazwisko = textBoxNazwisko.Text;
                    User.DataUrodzenia = dateTimePickerDataUrodzenia.Value;
                    User.PrywatnyTelefon = textBoxPrywatnyTelefon.Text;
                    User.TelefonSluzbowy = textBoxTelefonSluzbowy.Text;
                    User.AdresEmailSluzbowy = textBoxAdresEmailSluzbowy.Text;
                    User.NumerGG = textBoxNumerGG.Text;
                    User.Uwagi = textBoxUwagi.Text;


                    _unityOfWork.UsersRepository.Update (User);
                    _unityOfWork.SaveChanges ();
                }
                // Zczytanie uprawnień 


                // Dodanie załączników  
                foreach (var zalacznik in Zalaczniki)
                {
                    ApplicationUserZalacznik applicationUserZalacznik = new ApplicationUserZalacznik ()
                    {
                        ApplicationUserZalacznikId = Guid.NewGuid ().ToString (),
                        Nazwa = zalacznik,
                        Zalacznik = GetBytes (zalacznik),
                        UserId = User.Id
                    };
                    _unityOfWork.UsersZalacznikiRepository.Create (applicationUserZalacznik);
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

        private void listBoxZalaczniki_DoubleClick (object sender, EventArgs e)
        {
            var zalacznik = _unityOfWork.UsersZalacznikiRepository.GetAll ()
                                .FirstOrDefault (f=> f.Nazwa == listBoxZalaczniki.SelectedItem.ToString () && f.UserId == User.Id);
            if (zalacznik != null)
                DisplayFile(zalacznik.Zalacznik, listBoxZalaczniki.SelectedItem.ToString());
        }
    }
}
