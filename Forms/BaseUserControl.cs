using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp90.Data;
using WinFormsApp90.Models;

namespace WinFormsApp90.Forms
{
    public class BaseUserControl : UserControl
    {
        public IUnityOfWork _unityOfWork;
        public BaseUserControl () { }

        public BaseUserControl (IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public string UserId { get; set; }
        public string FirmaId { get; set; }
        public string SprzetId { get; set; }
        public string SprzetLicencjaId { get; set; }
        public string SprzetItemId { get; set; }
        public string ArchiwizacjaId { get; set; }
        public string GwarancjaId { get; set; }
        public string HasloInfoId { get; set; }
        public string HostingId { get; set; }
        public string InformacjeSprzedazoweId { get; set; }
        public string KontaktId { get; set; }
        public string LicencjaId { get; set; }
        public string NaprawaId { get; set; }
        public string RodzajSprzetuId { get; set; }
        public string SerwisId { get; set; }
        public string UmowaId { get; set; }
        public string WiedzaId { get; set; }
        public string WolnaLicencjaId { get; set; }


        public ApplicationUser User { get; set; }
        public Firma Firma { get; set; }
        public Sprzet Sprzet { get; set; }
        public SprzetLicencja SprzetLicencja { get; set; }
        public SprzetItem SprzetItem { get; set; }
        public Archiwizacja Archiwizacja { get; set; }
        public Gwarancja Gwarancja { get; set; }
        public HasloInfo HasloInfo { get; set; }
        public Hosting Hosting { get; set; } 
        public Kontakt Kontakt { get; set; }
        public WolnaLicencja Licencja { get; set; }
        public Naprawa Naprawa { get; set; }
        public RodzajSprzetu RodzajSprzetu { get; set; }
        public Serwis Serwis { get; set; }
        public Umowa Umowa { get; set; }
        public Wiedza Wiedza { get; set; }
        public WolnaLicencja WolnaLicencja { get; set; }

        public Pole Pole { get; set; }
        public string PoleId { get; set; }
        public bool NowePolaDodane = false;

        public int Index = 1;
        public int IndexCounter
            => Index++;


        /// <summary>
        /// Wyświetla skrócone nazwy wszystkich istniejących w systemie firm
        /// </summary>
        public List<string> DisplayNazwyFirm ()
        {
            return _unityOfWork.FirmyRepository.GetAll ()
                    .Select (s=> s.SkroconaNazwa)
                    .ToList ();
        }


        /// <summary>
        /// Wyświetla sprzęt należący do danej firmy
        /// </summary>
        public List<string> DisplayNazwySprzet ()
        {
            return _unityOfWork.SprzetyRepository.GetAll ()
                    .Where(w => w.Firma.SkroconaNazwa == Firma.SkroconaNazwa)
                    .OrderBy(o => o.Nazwa)
                    .Select(s => s.Nazwa)
                    .ToList();
        }

        public void DisplayNazwyFirm (ToolStripComboBox toolStripComboBoxFirmy)
        {
            foreach (var firma in _unityOfWork.FirmyRepository.GetAll ())
                toolStripComboBoxFirmy.Items.Add(firma.SkroconaNazwa);
            if (toolStripComboBoxFirmy.Items.Count > 0)
                toolStripComboBoxFirmy.SelectedIndex = 0;
        }


        /// <summary>
        /// Wyszukuje wybraną w ComboBox'ie firmę i przypisuje ją do zmiennej Firma
        /// </summary>
        public void FindFirma (ComboBox comboBoxFirmy)
        {
            try
            {
                Firma = _unityOfWork.FirmyRepository.GetAll () 
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
        public void FindSprzet (ComboBox comboBoxSprzet)
        {
            try
            {
                Sprzet = _unityOfWork.SprzetyRepository.GetAll ()
                    .FirstOrDefault(f => f.Nazwa == comboBoxSprzet.SelectedItem.ToString());
                SprzetId = Sprzet.SprzetId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public void DisplayAllRoles (Panel panelUprawnienia)
        {
            try
            {
                Index = 0;
                foreach (var role in _unityOfWork.RolesRepository.GetAll ().Select(s => s.Name).ToList())
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
        public void DisplayAllRolesISprawdzCzyDoNiejNalezy (Panel panelUprawnienia, ApplicationUser user)
        {
            try
            {
                Index = 0;
                foreach (var role in _unityOfWork.RolesRepository.GetAll ())
                {
                    CheckBox checkBox = new CheckBox ()
                    {
                        Text = role.Name,
                        Location = new Point (5, Index * 40),
                        Size = new Size (300, 40)
                    };

                    // Sprawdzenie czy rola jest przypisana do użytkownika
                    IdentityUserRole <string> userRole = new IdentityUserRole<string> ();
                    userRole = _unityOfWork.UsersRolesRepository.GetAll ()
                                    .FirstOrDefault(f => f.RoleId == role.Id && f.UserId == user.Id);
                    if (userRole != null)
                        checkBox.Checked = true;
                    else
                        checkBox.Checked = false;


                    checkBox.CheckedChanged += (s, e) =>
                    {
                        //_context = new ApplicationDbContext();
                        userRole = _unityOfWork.UsersRolesRepository.GetAll ().FirstOrDefault(f => f.RoleId == role.Id && f.UserId == user.Id);

                        CheckBox ch = (CheckBox) s;
                        if (ch.Checked)
                        {
                            // dodanie usera do roli 
                            IdentityUserRole <string> ur = new IdentityUserRole<string> () { RoleId = role.Id, UserId = user.Id };
                            _unityOfWork.UsersRolesRepository.Create (ur);
                            _unityOfWork.SaveChanges();
                        }
                        else
                        {
                            // usunięcie roli  
                            if (userRole != null)
                            {
                                _unityOfWork.UsersRolesRepository.Delete (userRole.UserId, userRole.RoleId);
                                _unityOfWork.SaveChanges();
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
        public List<string> GetUserRoles (ApplicationUser user)
        {
            Index = 0;
            List <string> userRoles = new List<string> ();
            foreach (var role in _unityOfWork.RolesRepository.GetAll())
            {
                // Sprawdzenie czy rola jest przypisana do użytkownika
                IdentityUserRole <string> userRole = _unityOfWork.UsersRolesRepository.GetAll ().FirstOrDefault (f=> f.RoleId == role.Id && f.UserId == user.Id);
                if (userRole != null)
                    userRole.Equals(role.Name);
                Index++;
            }
            return userRoles;
        }

        /// <summary>
        /// Pobiera wszystkie role użytkownika w formie stringa
        /// </summary>
        public string GetUserRolesString (ApplicationUser user)
        {
            Index = 0;
            List <string> userRoles = new List<string> ();
            foreach (var role in _unityOfWork.RolesRepository.GetAll ())
            {
                // Sprawdzenie czy rola jest przypisana do użytkownika
                IdentityUserRole <string> userRole = _unityOfWork.UsersRolesRepository.GetAll ().FirstOrDefault (f=> f.RoleId == role.Id && f.UserId == user.Id);
                if (userRole != null)
                    userRole.Equals(role.Name);
                Index++;
            }
            return string.Concat(userRoles);
        }


        /// <summary>
        /// Przypisuje użytkownika do istniejącej roli
        /// </summary>
        public void PrzypiszUzytkownikaDoRoli (string rolaName, ApplicationUser user)
        {
            ApplicationRole role = _unityOfWork.RolesRepository.GetAll ().FirstOrDefault (f=> f.Name == rolaName);
            if (role != null)
            {
                IdentityUserRole <string> userRole = new IdentityUserRole<string>()
                {
                    UserId = user.Id,
                    RoleId = role.Id
                };
                _unityOfWork.UsersRolesRepository.Create (userRole);
                _unityOfWork.SaveChanges();
            }
        }


        public List<AppUser> PokazWszystkichUzytkownikowZrola (string roleName)
        {
            Index = 0;
            List <AppUser> appUsers = new List<AppUser> ();
            ApplicationRole role = _unityOfWork.RolesRepository.GetAll ().FirstOrDefault (f=> f.Name == roleName);
            if (role != null)
            {
                var userRoles = _unityOfWork.UsersRolesRepository.GetAll ()
                                    .Where (w=> w.RoleId == role.Id).ToList ();
                foreach (var userRole in userRoles)
                {
                    var user = _unityOfWork.UsersRepository.GetAll ().FirstOrDefault (f=> f.Id == userRole.UserId);
                    if (user != null)
                    {
                        AppUser appUser = new AppUser ()
                        {
                            Imie = user.Imie,
                            Nazwisko = user.Nazwisko
                        };
                        appUsers.Add(appUser);
                    }
                }
            }
            return appUsers;
        }




        public List <string> Zalaczniki = new List<string> ();
        public List <string> ListaRol = new List<string> ();

        public bool IsValid (List<TextBox> lista)
        {
            bool result = false;
            foreach (TextBox textBox in lista)
            {
                if (!string.IsNullOrEmpty(textBox.Text))
                    result = true;
                else
                    result = false;
            }
            return result;
        }

        public Image GetImage (string sciezka)
        {
            Image image;

            WebRequest webreq = WebRequest.Create(sciezka);
            WebResponse webres = webreq.GetResponse();
            Stream stream = webres.GetResponseStream();
            image = Image.FromStream(stream);
            stream.Close();

            return image;
        }

        public byte[] GetBytes (string filePath)
        {
            byte [] bytes = new byte [0];
            using (Stream stream = File.OpenRead(filePath))
            {
                bytes = new byte[stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                string extension = new FileInfo (filePath).Extension;
                return bytes;
            }
        }

        public Image GetImageFromBytes (byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image image = Image.FromStream (ms);
                return image;
            }
        }

        public string GetStringFromBytes (byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                using (StreamReader sr = new StreamReader(ms))
                {
                    return sr.ReadToEnd();
                }
            }
        }


        public void DisplayItemsInListBox (List<string> items, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var item in items)
            {
                listBox.Items.Add(item);
            }
        }


        public void DisplayItemsInListBoxConvertFromBytes (List<byte[]> items, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var bytes in items)
            {
                string path = GetStringFromBytes (bytes);
                listBox.Items.Add(path);
            }
        }





        public static bool UmowaKonczySieDzisiaj (DateTime zakonczenie)
        {
            var dni = (zakonczenie - DateTime.Now).Days;
            if (dni == 0 && zakonczenie.Day == DateTime.Now.Day)
                return true;
            else
                return false;
        }

        public static bool UmowaKonczySieWtymTygodniu (DateTime zakonczenie)
        {
            var dni = (zakonczenie - DateTime.Now).Days;
            if (dni >= 0 && dni <= 7)
                return true;
            else
                return false;
        }

        public bool UmowaKonczySieWtymMiesiacu (DateTime zakonczenie)
        {
            var dni = (zakonczenie - DateTime.Now).Days;
            if (dni >= 0 && dni <= 30)
                return true;
            else
                return false;
        }

        public bool TerminZakonczeniaUmowyUplynal (DateTime zakonczenie)
        {
            var dni = (zakonczenie - DateTime.Now).Days;
            if (dni <= -1)
                return true;
            else
                return false;
        }



        public void DisplayFile (byte[] data, string filePath)
        {
            if (data.Length > 0 && !string.IsNullOrEmpty(filePath))
            {
                string extension = new FileInfo (filePath).Extension;
                switch (extension)
                {
                    case ".txt":
                        /*MemoryStream ms = new MemoryStream (data);
                        string streamReader = new StreamReader (ms).ReadToEnd ();
                        MessageBox.Show (streamReader);*/

                        //File.WriteAllBytes(@"F:\data2.txt", data); 
                        Process.Start(@"F:\data1.txt");
                        //MessageBox.Show (Convert.ToBase64String (data));
                        break;

                    case ".jpg":
                        DisplayPhoto dpJpg = new DisplayPhoto (data);
                        dpJpg.ShowDialog();
                        break;

                    case ".png":
                        DisplayPhoto dpPng = new DisplayPhoto (data);
                        dpPng.ShowDialog();
                        break;

                    case ".pdf":

                        break;

                    case ".docx":
                        MemoryStream msWord = new MemoryStream (data);
                        /*string streamReaderWord = new StreamReader (msWord).ReadToEnd ();
                        var create = new FileStream (@"F:\file.docx", FileMode.Create);
                        var open = new FileStream ("", FileMode.Open);
                        var sr = new StreamWriter (msWord);*/

                        File.WriteAllBytes(@"F:\data1.txt", data);

                        //MessageBox.Show(streamReaderWord);
                        break;

                }
            }
        }



        public static void SetDataGridViewStyles (DataGridView dataGridView)
        {
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ReadOnly = false;
            dataGridView.MultiSelect = false;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.BackgroundColor = Color.White;

            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 245, 245);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

            dataGridView.DefaultCellStyle.SelectionBackColor = Color.CadetBlue;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

        }




    }
}