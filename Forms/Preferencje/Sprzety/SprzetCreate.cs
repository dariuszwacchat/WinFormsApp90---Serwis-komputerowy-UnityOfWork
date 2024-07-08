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
using WinFormsApp90.Models.Enums;
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms.Preferencje.Sprzety
{
    public partial class SprzetCreate : BaseForm
    {
        private ApplicationDbContext _context;
        public SprzetCreate ()
        { 
            InitializeComponent();
            _context = new ApplicationDbContext();
            Zalaczniki.Clear();
            S.SetDataGridViewStylesOrders (dataGridViewPola);
        }

        private void SprzetCreate_Load (object sender, EventArgs e)
        {
            try
            {
                dataGridViewPola.Rows.Add("1", "Data zakupu");
                dataGridViewPola.Rows.Add("2", "Miejsce zakupu");
                dataGridViewPola.Rows.Add("3", "Cena");
                dataGridViewPola.Rows.Add("4", "Model");
                dataGridViewPola.Rows.Add("5", "Numer seryjny");
                dataGridViewPola.Rows.Add("6", "Uwagi");
                dataGridViewPola.Rows.Add("7", "Gwarancja");
                dataGridViewPola.Rows.Add("8", "Nazwa");

                DataGridViewComboBoxColumn comboBox = dataGridViewPola.Columns [2] as DataGridViewComboBoxColumn;
                comboBox.DataSource = Enum.GetNames(typeof(RodzajPola));

            }
            catch { }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                // Sprawdza czy pole checkBox jest wybrane 
                SprzetItem sprzetItem = new SprzetItem ()
                {
                    SprzetItemId = Guid.NewGuid ().ToString (),
                    Nazwa = textBoxNazwa.Text
                };
                _context.SprzetItems.Add(sprzetItem);
                _context.SaveChanges();


                // Zczytanie nazw z kontrolki DataGridView z kolumny 1, która jest nazwą obiektu
                for (var i = 0; i < dataGridViewPola.Rows.Count - 1; i++)
                {
                    string nazwa = dataGridViewPola.Rows [i].Cells [1].Value.ToString ();
                    //string nazwaWyswietlana = dataGridViewPola.Rows [i].Cells [2].Value.ToString ();

                    string rodzajPola = "";
                    if (dataGridViewPola.Rows[i].Cells[2].Value != null)
                        rodzajPola = dataGridViewPola.Rows[i].Cells[2].Value.ToString();


                    // zapobiega przed dodawaniem takich samych pól
                    var czyIstniejePole = _context.PolaItems.FirstOrDefault (f=> f.Name == nazwa && f.SprzetItemId == sprzetItem.SprzetItemId);
                    if (czyIstniejePole == null)
                    {
                        PoleItem poleItem = new PoleItem ()
                        {
                            PoleItemId = Guid.NewGuid ().ToString (),
                            Name = nazwa,
                            SprzetItemId = sprzetItem.SprzetItemId
                        };

                        // jeżeli pole wyboru nie zostało wybrane wtedy automatycznie wybierana jest okreśłony rodzaj pola
                        if (string.IsNullOrEmpty(rodzajPola))
                            poleItem.RodzajPola = RodzajPola.MalePole;
                        else
                            poleItem.RodzajPola = (RodzajPola) Enum.Parse(typeof(RodzajPola), rodzajPola);


                        _context.PolaItems.Add(poleItem);
                        _context.SaveChanges();
                    }




                    // Dodanie załączników 

                    foreach (var zalacznik in Zalaczniki)
                    {
                        SprzetItemZalacznik sprzetItemZalacznik = new SprzetItemZalacznik ()
                        {
                            SprzetItemZalacznikId = Guid.NewGuid ().ToString (),
                            Data = GetBytes (zalacznik),
                            SprzetItemId = sprzetItem.SprzetItemId
                        };
                        _unityOfWork.SprzetItemsZalacznikiRepository.Create (sprzetItemZalacznik);
                        _unityOfWork.SaveChanges();
                    }


                }

                MessageBox.Show("Sprzęt zapisany poprawnie");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close();
            }
        }

        private void dataGridViewPola_UserAddedRow (object sender, DataGridViewRowEventArgs e)
        {
            int nextNumber = dataGridViewPola.Rows.Count-1;
            dataGridViewPola.Rows[dataGridViewPola.Rows.Count - 2].Cells[0].Value = nextNumber;
            //dataGridViewPola.Rows[dataGridViewPola.Rows.Count - 2].Cells[1].Value = nextNumber;
        }

        private void button2_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewPola_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    // button usuń
                    if (e.ColumnIndex == 4)
                    {
                        if (e.RowIndex == 0 ||
                            e.RowIndex == 1 ||
                            e.RowIndex == 2 ||
                            e.RowIndex == 3 ||
                            e.RowIndex == 4 ||
                            e.RowIndex == 5 ||
                            e.RowIndex == 6 ||
                            e.RowIndex == 7)
                        {
                            MessageBox.Show("Tego pola nie możesz usunąć, ponieważ zostały automatycznie dodane przez komputer, możesz usuwać jedynie pola, które sam dodałeś.");
                        }
                        else
                        {
                            dataGridViewPola.Rows.RemoveAt(e.RowIndex);
                        }
                        //Text = dataGridViewPola.Rows[0].Cells[2].Value.ToString();
                        //MessageBox.Show (dataGridViewPola.Rows[e.RowIndex].Cells[2].Value.ToString());
                    }
                }
            }
            catch { }
        }
         
    }
}
