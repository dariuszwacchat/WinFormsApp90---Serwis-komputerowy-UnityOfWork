using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Models;
using WinFormsApp90.Services;

namespace WinFormsApp90.Data
{
    public static class D
    {
        //public static ApplicationDbContext _context = new ApplicationDbContext (); 

        /*public static string UserId { get; set; }
        public static string FirmaId { get; set; }
        public static string SprzetId { get; set; }
        public static string SprzetLicencjaId { get; set; }
        public static string SprzetItemId { get; set; }
        public static string ArchiwizacjaId { get; set; }
        public static string GwarancjaId { get; set; }
        public static string HasloInfoId { get; set; }
        public static string HostingId { get; set; }
        public static string InformacjeSprzedazoweId { get; set; }
        public static string KontaktId { get; set; }
        public static string LicencjaId { get; set; }
        public static string NaprawaId { get; set; }
        public static string RodzajSprzetuId { get; set; }
        public static string SerwisId { get; set; }
        public static string UmowaId { get; set; }
        public static string WiedzaId { get; set; }
        public static string WolnaLicencjaId { get; set; }


        public static ApplicationUser User { get; set; }
        public static Firma Firma { get; set; }
        public static Sprzet Sprzet { get; set; }
        public static SprzetLicencja SprzetLicencja { get; set; }
        public static SprzetItem SprzetItem { get; set; }
        public static Archiwizacja Archiwizacja { get; set; }
        public static Gwarancja Gwarancja { get; set; }
        public static HasloInfo HasloInfo { get; set; }
        public static Hosting Hosting { get; set; }
        public static InformacjeSprzedazowe InformacjeSprzedazowe { get; set; }
        public static Kontakt Kontakt { get; set; }
        public static WolnaLicencja Licencja { get; set; }
        public static Naprawa Naprawa { get; set; }
        public static RodzajSprzetu RodzajSprzetu { get; set; }
        public static Serwis Serwis { get; set; }
        public static Umowa Umowa { get; set; }
        public static Wiedza Wiedza { get; set; }
        public static WolnaLicencja WolnaLicencja { get; set; }



        /// <summary>
        /// Wyświetla skrócone nazwy wszystkich istniejących w systemie firm
        /// </summary>
        public static List<string> DisplayNazwyFirm ()
        {
            return _context.Firmy
                .OrderBy(o => o.SkroconaNazwa)
                .Select(s => SkroconaNazwa)
                .ToList();
        }


        /// <summary>
        /// Wyświetla sprzęt należący do danej firmy
        /// </summary>
        public static List<string> DisplayNazwySprzet ()
        {
            return _context.Sprzet
                .Where(w => w.Firma.SkroconaNazwa == Firma.SkroconaNazwa)
                .OrderBy(o => o.Nazwa)
                .Select(s => Nazwa)
                .ToList();
        }

        public static void DisplayNazwyFirm (ToolStripComboBox toolStripComboBoxFirmy)
        {
            foreach (var firma in _context.Firmy.ToList())
                toolStripComboBoxFirmy.Items.Add(firma.SkroconaNazwa);
            if (toolStripComboBoxFirmy.Items.Count > 0)
                toolStripComboBoxFirmy.SelectedIndex = 0;
        }


        /// <summary>
        /// Wyszukuje wybraną w ComboBox'ie firmę i przypisuje ją do zmiennej Firma
        /// </summary>
        public static void FindFirma (ComboBox comboBoxFirmy)
        {
            try
            {
                Firma = _context.Firmy
                     .Include(i => i.Sprzet)
                        .ThenInclude (t=> t.Pola)
                     .FirstOrDefault(f => f.SkroconaNazwa == comboBoxFirmy.SelectedItem.ToString());
                FirmaId = Firma.FirmaId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Wyszukuje wybrany w ComboBox'ie sprzęt i przypisuje ją do zmiennej Sprzet
        /// </summary>
        public static void FindSprzet (ComboBox comboBoxSprzet)
        {
            try
            {
                Sprzet = _context.Sprzet
                    .Include(i => i.Pola)
                    .Include(i => i.SprzetLicencje)
                    .Include(i => i.SprzetZdjecia)
                    .FirstOrDefault(f => f.Nazwa == comboBoxSprzet.SelectedItem.ToString());
                SprzetId = Sprzet.SprzetId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public static void DisplayAllRoles (Panel panelUprawnienia)
        {
            try
            {
                Index = 0;
                foreach (var role in _unityOfWork.Roles.Select(s => Name).ToList())
                {
                    CheckBox checkBox = new CheckBox ()
                    {
                        Text = role,
                        Location = new Point (5, Index * 40),
                        Size = new Size (150, 40)
                    };
                    checkBox.CheckedChanged += (s, e) =>
                    {
                        CheckBox ch = (CheckBox) s;
                        if (ch.Checked)
                            ListaRol.Add(ch.Text);
                        else
                            ListaRol.Remove(ch.Text);
                    };
                    panelUprawnienia.Controls.Add(checkBox);

                    Index++;
                }
            }
            catch { }
        }



        /// <summary>
        /// Sprawdza do jakich róln należy dany użytkownik.
        /// Wykorzystywane w sekcjach edycyjnych
        /// </summary>
        public static void DisplayAllRolesISprawdzCzyDoNiejNalezy (Panel panelUprawnienia, ApplicationUser user)
        {
            try
            {
                Index = 0; 
                foreach (var role in _unityOfWork.Roles.ToList())
                {
                    CheckBox checkBox = new CheckBox ()
                    {
                        Text = role.Name,
                        Location = new Point (5, Index * 40),
                        Size = new Size (300, 40)
                    };

                    // Sprawdzenie czy rola jest przypisana do użytkownika
                    IdentityUserRole <string> userRole = new IdentityUserRole<string> ();
                    userRole = _context.UserRoles.FirstOrDefault (f=> f.RoleId == role.Id && f.UserId == user.Id);
                    if (userRole != null)
                        checkBox.Checked = true;
                    else
                        checkBox.Checked = false;


                    checkBox.CheckedChanged += (s, e) =>
                    {
                        _context = new ApplicationDbContext(); 
                        userRole = _context.UserRoles.FirstOrDefault (f=> f.RoleId == role.Id && f.UserId == user.Id);

                        CheckBox ch = (CheckBox) s;
                        if (ch.Checked)
                        {
                            // dodanie usera do roli 
                            IdentityUserRole <string> ur = new IdentityUserRole<string> () { RoleId = role.Id, UserId = user.Id };
                            _context.UserRoles.Add(ur);
                            _context.SaveChanges(); 
                        }
                        else
                        {
                            // usunięcie roli  
                            if (userRole != null)
                            {
                                _context.UserRoles.Remove(userRole);
                                _context.SaveChanges();
                            }
                        }
                    };
                    panelUprawnienia.Controls.Add(checkBox);

                    Index++;
                } 
            }
            catch { }
        }


        /// <summary>
        /// Pobiera wszystkie role użytkownika
        /// </summary>
        public static List<string> GetUserRoles (ApplicationUser user)
        {
            Index = 0;
            List <string> userRoles = new List<string> ();
            foreach (var role in _context.Roles.ToList())
            {
                // Sprawdzenie czy rola jest przypisana do użytkownika
                IdentityUserRole <string> userRole = _context.UserRoles.FirstOrDefault (f=> f.RoleId == role.Id && f.UserId == user.Id);
                if (userRole != null)
                    userRole.Equals (role.Name);
                Index++;
            }
            return userRoles;
        }

        /// <summary>
        /// Pobiera wszystkie role użytkownika w formie stringa
        /// </summary>
        public static string GetUserRolesString (ApplicationUser user)
        {
            Index = 0;
            List <string> userRoles = new List<string> ();
            foreach (var role in _context.Roles.ToList())
            {
                // Sprawdzenie czy rola jest przypisana do użytkownika
                IdentityUserRole <string> userRole = _context.UserRoles.FirstOrDefault (f=> f.RoleId == role.Id && f.UserId == user.Id);
                if (userRole != null)
                    userRole.Equals(role.Name);
                Index++;
            }
            return string.Concat (userRoles);
        }


        /// <summary>
        /// Przypisuje użytkownika do istniejącej roli
        /// </summary>
        public static void PrzypiszUzytkownikaDoRoli (string rolaName, ApplicationUser user)
        {
            ApplicationRole role = _context.Roles.FirstOrDefault (f=> f.Name == rolaName);
            if (role != null)
            {
                IdentityUserRole <string> userRole = new IdentityUserRole<string>()
                {
                    UserId = user.Id,
                    RoleId = role.Id
                };
                _context.UserRoles.Add(userRole);
                _context.SaveChanges();
            }
        }


        public static List <AppUser> PokazWszystkichUzytkownikowZrola (string roleName)
        {
            Index = 0; 
            List <AppUser> appUsers = new List<AppUser> ();
            ApplicationRole role = _context.Roles.FirstOrDefault (f=> f.Name == roleName);
            if (role != null)
            {
                var userRoles = _context.UserRoles.Where (w=> w.RoleId == role.Id).ToList ();
                foreach (var userRole in userRoles)
                {
                    var user = _context.Users.FirstOrDefault (f=> f.Id == userRole.UserId);
                    if (user != null)
                    {
                        AppUser appUser = new AppUser ()
                        {
                            Imie = user.Imie,
                            Nazwisko = user.Nazwisko
                        };
                        appUsers.Add (appUser);
                    }
                }
            }
            return appUsers;
        }*/


    }
}
