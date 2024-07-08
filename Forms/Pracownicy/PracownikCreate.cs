using Microsoft.AspNetCore.Identity;
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
    public partial class PracownikCreate : BaseForm
    { 
        public PracownikCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            Zalaczniki.Clear (); 
            ListaRol.Count ();
        }
        private void PracownikCreate_Load (object sender, EventArgs e)
        {
            // Wyświetlenie wszystkich ról
            DisplayAllRoles (panelUprawnienia);
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                PasswordHasher <ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser> ();
                ApplicationUser user = new ApplicationUser ()
                {
                    Id = Guid.NewGuid ().ToString (),
                    Imie = textBoxImie.Text,
                    Nazwisko = textBoxNazwisko.Text,
                    DataUrodzenia = dateTimePickerDataUrodzenia.Value,
                    AdresZamieszkania = textBoxAdresZamieszkania.Text,
                    PrywatnyTelefon = textBoxPrywatnyTelefon.Text,
                    TelefonSluzbowy = textBoxTelefonSluzbowy.Text,
                    AdresEmailSluzbowy = textBoxAdresEmailSluzbowy.Text,
                    NumerGG = textBoxNumerGG.Text,
                    Uwagi = textBoxUwagi.Text
                };
                user.PasswordHash = passwordHasher.HashPassword(user, "SDG%$@5423sdgagSDert");
                _unityOfWork.UsersRepository.Create (user);
                _unityOfWork.SaveChanges();


                // Dodanie użytkownika do roli 

                foreach (var rola in ListaRol)
                {
                    /*ApplicationRole role = _unityOfWork.Roles.FirstOrDefault (f=> f.Name == rola);
                    if (role != null)
                    {
                        IdentityUserRole <string> userRole = new IdentityUserRole<string>()
                        {
                            UserId = user.Id,
                            RoleId = role.Id
                        };
                        _unityOfWork.UserRoles.Add(userRole);
                        _unityOfWork.SaveChanges();
                    }*/
                    PrzypiszUzytkownikaDoRoli (rola, user);
                }


                // Dodanie załączników  
                foreach (var zalacznik in Zalaczniki)
                {
                    ApplicationUserZalacznik applicationUserZalacznik = new ApplicationUserZalacznik ()
                    {
                        ApplicationUserZalacznikId = Guid.NewGuid ().ToString (),
                        Nazwa = zalacznik,
                        Zalacznik = GetBytes (zalacznik),
                        UserId = user.Id
                    };
                    _unityOfWork.UsersZalacznikiRepository.Create(applicationUserZalacznik);
                    _unityOfWork.SaveChanges();
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

         



    }
}
