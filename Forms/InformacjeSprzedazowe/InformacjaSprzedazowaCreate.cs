﻿using System;
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

namespace WinFormsApp90.Forms.InformacjeSprzedazowe
{
    public partial class InformacjaSprzedazowaCreate : BaseForm
    {
        public InformacjaSprzedazowaCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            Zalaczniki.Clear();
            comboBoxSprzetItems.DataSource = _unityOfWork.RodzajeSprzetowRepository.GetAll ()
                                                .Select(s => s.Nazwa).ToList();
        }

        private void InformacjaSprzedazowaCreate_Load (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;


                var rodzajSprzetu = _unityOfWork.RodzajeSprzetowRepository.GetAll ()
                                        .FirstOrDefault (f=> f.Nazwa == comboBoxSprzetItems.SelectedItem.ToString ());
                Models.InformacjeSprzedazowe informacjaSprzedazowa = new Models.InformacjeSprzedazowe ()
                {
                    InformacjeSprzedazoweId = Guid.NewGuid ().ToString (),
                    Cena = double.Parse (textBoxCena.Text),
                    NazwaProduktu = textBoxNazwaProduktu.Text,
                    Uwagi = textBoxUwagi.Text
                };

                if (rodzajSprzetu != null)
                    informacjaSprzedazowa.RodzajSprzetuId = rodzajSprzetu.RodzajSprzetuId;


                _unityOfWork.InformacjeSprzedazoweRepository.Create (informacjaSprzedazowa);
                _unityOfWork.SaveChanges();



                // Dodanie załączników  
                foreach (var zalacznik in Zalaczniki)
                {
                    InformacjaSprzedazowaZalacznik informacjaSprzedazowaZalacznik = new InformacjaSprzedazowaZalacznik ()
                    {
                        InformacjaSprzedazowaZalacznikId = Guid.NewGuid ().ToString (),
                        Nazwa = zalacznik,
                        Data = GetBytes (zalacznik),
                        InformacjeSprzedazoweId = informacjaSprzedazowa.InformacjeSprzedazoweId
                    };
                    _unityOfWork.InformacjeSprzedazoweZalacznikiRepository.Create (informacjaSprzedazowaZalacznik);
                    _unityOfWork.SaveChanges();
                }


                MessageBox.Show("Zapisano");


                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            Close();
        }



        private void comboBoxSprzet_SelectedIndexChanged (object sender, EventArgs e)
        {

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
