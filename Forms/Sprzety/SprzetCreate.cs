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
using WinFormsApp90.Models.Enums;
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms.Sprzety
{
    public partial class SprzetCreate : BaseForm
    {  

        public SprzetCreate ()
        {
            InitializeComponent(); 
            Zalaczniki.Clear();

            comboBoxFirmy.DataSource = _unityOfWork.FirmyRepository.GetAll ()
                                           .Select(s => s.SkroconaNazwa).ToList();
            comboBoxSprzetItems.DataSource = _unityOfWork.SprzetItemsRepository.GetAll ()
                                                .Select(s => s.Nazwa).ToList();
        }

        private void SprzetCreate_Load (object sender, EventArgs e)
        {

        }

        private void comboBoxSprzetItems_SelectedIndexChanged (object sender, EventArgs e)
        {
            string nazwaSprzetu = comboBoxSprzetItems.SelectedItem.ToString ();
            SprzetItem = _unityOfWork.SprzetItemsRepository.GetAll ()
                            .FirstOrDefault(f => f.Nazwa == nazwaSprzetu);
            DisplayFields();
        }


        private void DisplayFields ()
        {
            Index = 0;
            dataGridView1.Rows.Clear();
            if (SprzetItem != null)
            {
                if (SprzetItem.PolaItems != null)
                {
                    // Wyświetlenie pozycji w komórkach
                    foreach (var poleItem in SprzetItem.PolaItems)
                    {
                        dataGridView1.Rows.Add(poleItem.Name);
                        dataGridView1.Rows[Index].Cells[1].Value = "";

                        Index++;
                    }
                }
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                var firma = _unityOfWork.FirmyRepository.GetAll ()
                                .FirstOrDefault (f=> f.SkroconaNazwa == comboBoxFirmy.SelectedItem.ToString ());
                var rodzajSprzetu = _unityOfWork.RodzajeSprzetowRepository.GetAll ()
                                        .FirstOrDefault (f=> f.Nazwa == comboBoxSprzetItems.SelectedItem.ToString ());

                if (firma != null && rodzajSprzetu != null)
                {

                    Sprzet sprzet = new Sprzet ()
                    {
                        SprzetId = Guid.NewGuid ().ToString (),
                        RodzajSprzetuId = rodzajSprzetu.RodzajSprzetuId,
                        FirmaId = firma.FirmaId
                    };


                    if (checkBoxUrzadzenieSieciowe.Checked)
                        sprzet.UrzadzenieSieciowe = true;
                    else
                        sprzet.UrzadzenieSieciowe = false;


                    // Zczytanie Nazwy sprzętu z danego wiersza z kontrolki i przypisanie go do nazwy sprzętu
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string nazwa = row.Cells [0].Value.ToString ();
                        string wartosc = row.Cells [1].Value.ToString ();
                        if (nazwa == "Nazwa") 
                            sprzet.Nazwa = wartosc; 
                    }

                    _unityOfWork.SprzetyRepository.Create(sprzet);
                    _unityOfWork.SaveChanges();



                    // Zczytanie wszystkichc danych z wszystkich pól kontrolki i utworzenie z nich klasy z odpowiednimi danymi
                    Index = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        Pole pole = new Pole ()
                        {
                            PoleId = Guid.NewGuid ().ToString (),
                            Name = row.Cells [0].Value.ToString (),
                            Wartosc = row.Cells [1].Value.ToString (),
                            SprzetId = sprzet.SprzetId
                        };
                        _unityOfWork.PolaRepository.Create(pole);
                        _unityOfWork.SaveChanges();
                        Index++;
                    }



                    // Dodanie załączników 

                    foreach (var zalacznik in Zalaczniki)
                    {
                        SprzetZdjecie sprzetZdjecie = new SprzetZdjecie ()
                        {
                            SprzetZdjecieId = Guid.NewGuid ().ToString (),
                            Nazwa = zalacznik,
                            Data = GetBytes (zalacznik),
                            SprzetId = sprzet.SprzetId
                        };
                        _unityOfWork.SprzetZdjeciaRepository.Create (sprzetZdjecie);
                        _unityOfWork.SaveChanges();
                    }

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
