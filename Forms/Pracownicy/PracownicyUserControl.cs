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
    public partial class PracownicyUserControl : BaseUserControl
    {
        public PracownicyUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayPracownicy();
            SetDataGridViewStyles (dataGridViewPracownicy);
        }

        private void DisplayPracownicy ()
        {
            Index = 0;
            List <ApplicationUser> pracownicy = _unityOfWork.UsersRepository.GetAll ();

            //Odszukanie wszystkich użytkownikó przypisanych do danej roli
            if (toolStripComboBoxUprawnienia.SelectedItem != null)
            {
                if (toolStripComboBoxUprawnienia.SelectedItem.ToString() != "Wszystkie")
                {
                    string selectedRole = toolStripComboBoxUprawnienia.SelectedItem.ToString ();
                    ApplicationRole applicationRole = _unityOfWork.RolesRepository.GetAll ()
                                                        .FirstOrDefault (f=> f.Name == selectedRole);
                    if (applicationRole != null)
                    {
                        var roles = _unityOfWork.UsersRolesRepository.GetAll ()
                                        .Where (w=> w.RoleId == applicationRole.Id)
                                        .ToList ();
                        pracownicy.Clear();
                        foreach (var role in roles)
                        {
                            var user = _unityOfWork.UsersRepository.Get (role.UserId);
                            pracownicy.Add(user);
                        }
                    }
                }
            }

            dataGridViewPracownicy.DataSource = (from f in pracownicy
                                                 select new
                                                 {
                                                     Id = f.Id,
                                                     Lp = IndexCounter,
                                                     Imie = f.Imie,
                                                     Nazwisko = f.Nazwisko,
                                                     AdresEmailSluzbowy = f.AdresEmailSluzbowy,
                                                     NumerGG = f.NumerGG,
                                                     TelefonSluzbowy = f.TelefonSluzbowy,
                                                     PrywatnyTelefon = f.PrywatnyTelefon
                                                 }).ToList();


        }


        private void dataGridViewPracownicy_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    UserId = dataGridViewPracownicy.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewPracownicy_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPracownicy.SelectedRows.Count > 0)
                    UserId = dataGridViewPracownicy.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButtonDodajPracownika_Click (object sender, EventArgs e)
        {
            PracownikCreate pc = new PracownikCreate (_unityOfWork);
            pc.ShowDialog ();
        }

        private void toolStripButtonUsunPracownika_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikujPracownika_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UserId))
            {
                PracownikEdit pe = new PracownikEdit (UserId,_unityOfWork);
                pe.ShowDialog ();
            }
        }
    }
}
