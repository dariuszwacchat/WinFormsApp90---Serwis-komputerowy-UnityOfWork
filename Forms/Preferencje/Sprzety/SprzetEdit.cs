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

namespace WinFormsApp90.Forms.Preferencje.Sprzety
{
    public partial class SprzetEdit : BaseForm
    { 
        public SprzetEdit (string sprzetItemId)
        {
            InitializeComponent();
            Zalaczniki.Clear();
            SprzetItemId = sprzetItemId;
            SprzetItem = _unityOfWork.SprzetItemsRepository.Get (SprzetItemId);


            S.SetDataGridViewStylesOrders(dataGridViewPola);
        }

        private void SprzetEdit_Load (object sender, EventArgs e)
        {
            DisplayPola();
        }

        private void DisplayPola ()
        {
            if (SprzetItem != null)
            {
                textBoxNazwa.Text = SprzetItem.Nazwa;
                if (SprzetItem.PolaItems != null)
                {
                    Index = 0;
                    var pola = SprzetItem.PolaItems.ToList ();
                    dataGridViewPola.DataSource = (from f in pola
                                                   select new
                                                   {
                                                       PoleItemId = f.PoleItemId,
                                                       Lp = IndexCounter,
                                                       Name = f.Name,
                                                       Delete = "x"
                                                   }).ToList();
                }
            }

        }


        private void button3_Click (object sender, EventArgs e)
        { 
            NowePolaDodane = true;

            // Dodanie standardowych kolumn do tabeli

            dataGridViewPola.DataSource = null;

            DataGridViewTextBoxColumn lp = new DataGridViewTextBoxColumn ()
            {
                HeaderText = "Lp",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
                ReadOnly = true
            };
            dataGridViewPola.Columns.Add(lp);

            DataGridViewTextBoxColumn nazwa = new DataGridViewTextBoxColumn ()
            {
                HeaderText = "Nazwa"
            };
            dataGridViewPola.Columns.Add(nazwa); 


            dataGridViewPola.Rows.Add("1");
            dataGridViewPola.Rows[0].Cells [1].Selected = true;
            button3.Enabled = false;
        }


        private void button1_Click (object sender, EventArgs e)
        {
            try
            {


                if (SprzetItem != null)
                {
                    SprzetItem.Nazwa = textBoxNazwa.Text;

                    _unityOfWork.SprzetItemsRepository.Update (SprzetItem);
                    _unityOfWork.SaveChanges();
                }




                if (NowePolaDodane)
                {
                    for (var i = 0; i < dataGridViewPola.Rows.Count - 1; i++)
                    {
                        // Odczytanie nazwy z określonej komórki
                        string name = dataGridViewPola.Rows[i].Cells[1].Value.ToString ();

                        // sprawdzenie czy pozycja istnieje w bazie
                        var findPoleItem = _unityOfWork.PolaItemsRepository.GetAll ()
                                                .FirstOrDefault (f=> f.Name == name && f.SprzetItemId == SprzetItemId);
                        if (findPoleItem == null)
                        {
                            PoleItem poleItem = new PoleItem ()
                            {
                                PoleItemId = Guid.NewGuid ().ToString (),
                                Name = name,
                                SprzetItemId = SprzetItemId
                            };
                            _unityOfWork.PolaItemsRepository.Create(poleItem);
                            _unityOfWork.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Pole o podanej nazwie już istnieje");
                            Close();
                        }
                    }
                    MessageBox.Show("Dane zostały zapisane poprawnie");
                }

                button1.Enabled = false;

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


        private void dataGridViewPola_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        { 
            try
            {
                if (e.RowIndex >= 0)
                {
                    PoleItemId = dataGridViewPola.Rows[e.RowIndex].Cells[0].Value.ToString();

                    // Odnalezienie rekordu w bazie na podstawie Id pobranego z odpowiedniej komórki
                    PoleItem = _unityOfWork.PolaItemsRepository.Get (PoleItemId);

                    // Jeżeli zostanie wciśnięty przycisk delete na DataGridView
                    if (PoleItem != null && e.ColumnIndex == 3)
                    {
                        // Pól standardowych nie można usunąć
                        if (PoleItem.Name == "Data zakupu" ||
                            PoleItem.Name == "Miejsce zakupu" ||
                            PoleItem.Name == "Cena" ||
                            PoleItem.Name == "Model" ||
                            PoleItem.Name == "Numer seryjny" ||
                            PoleItem.Name == "Uwagi" ||
                            PoleItem.Name == "Gwarancja" ||
                            PoleItem.Name == "Nazwa")
                        {
                            MessageBox.Show ("Tego pola nie możesz usunąć, ponieważ zostały automatycznie dodane przez komputer, możesz usuwać jedynie pola, które sam dodałeś.");
                        }
                        else
                        {
                            var message = MessageBox.Show ("Czy na pewno chcesz usunąć wybrane pole?", "Usuwanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (message == DialogResult.Yes)
                            {
                                _unityOfWork.PolaItemsRepository.Delete(PoleItem.PoleItemId);
                                _unityOfWork.SaveChanges();
                                DisplayPola();
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void dataGridViewPola_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPola.SelectedRows.Count > 0)
                {
                    PoleItemId = dataGridViewPola.Rows[0].Cells[0].Value.ToString();
                    PoleItem = _unityOfWork.PolaItemsRepository.Get (PoleItemId);
                }
            }
            catch { }
        }

        private void dataGridViewPola_UserAddedRow (object sender, DataGridViewRowEventArgs e)
        {
            int nextNumber = dataGridViewPola.Rows.Count-1;
            dataGridViewPola.Rows[dataGridViewPola.Rows.Count - 2].Cells[0].Value = nextNumber;
        }


    }
}
