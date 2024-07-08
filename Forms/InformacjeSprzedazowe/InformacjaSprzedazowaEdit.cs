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

namespace WinFormsApp90.Forms.InformacjeSprzedazowe
{
    public partial class InformacjaSprzedazowaEdit : BaseForm
    {
        public InformacjaSprzedazowaEdit (string informacjeSprzedazoweId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            Zalaczniki.Clear ();
            InformacjeSprzedazoweId = informacjeSprzedazoweId;
            InformacjeSprzedazowe = _unityOfWork.InformacjeSprzedazoweRepository.Get (InformacjeSprzedazoweId);
             
            //comboBoxSprzetItems.DataSource = _unityOfWork.SprzetItems.Select(s=> Nazwa).ToList ();
            comboBoxSprzetItems.DataSource = _unityOfWork.RodzajeSprzetowRepository.GetAll ()
                                                .Select (s=> s.Nazwa).ToList ();

            comboBoxFirmy.Enabled = false;
            comboBoxFirmy.Text = "";
        }

        private void InformacjaSprzedazowaEdit_Load (object sender, EventArgs e)
        {
            try
            {
                if (InformacjeSprzedazowe != null)
                {
                    if (InformacjeSprzedazowe.Firma != null)
                        comboBoxFirmy.Text = InformacjeSprzedazowe.Firma.SkroconaNazwa;

                    if (InformacjeSprzedazowe.RodzajSprzetu != null)
                        comboBoxSprzetItems.SelectedItem = InformacjeSprzedazowe.RodzajSprzetu.Nazwa;

                    textBoxNazwaProduktu.Text = InformacjeSprzedazowe.NazwaProduktu;
                    textBoxCena.Text = InformacjeSprzedazowe.Cena.ToString ();
                    textBoxUwagi.Text = InformacjeSprzedazowe.Uwagi;


                    // Wyświetlenie załączników
                    if (InformacjeSprzedazowe.InformacjaSprzedazowaZalaczniki != null)
                        listBoxZalaczniki.DataSource = InformacjeSprzedazowe.InformacjaSprzedazowaZalaczniki.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                if (InformacjeSprzedazowe != null)
                {
                    InformacjeSprzedazowe.NazwaProduktu = textBoxNazwaProduktu.Text;
                    InformacjeSprzedazowe.Cena = double.Parse (textBoxCena.Text);
                    InformacjeSprzedazowe.Uwagi = textBoxUwagi.Text;

                    _unityOfWork.InformacjeSprzedazoweRepository.Update (InformacjeSprzedazowe);
                    _unityOfWork.SaveChanges ();

                     

                    // Dodanie załączników  
                    foreach (var zalacznik in Zalaczniki)
                    {
                        InformacjaSprzedazowaZalacznik informacjaSprzedazowaZalacznik = new InformacjaSprzedazowaZalacznik ()
                        {
                            InformacjaSprzedazowaZalacznikId = Guid.NewGuid ().ToString (),
                            Nazwa = zalacznik,
                            Data = GetBytes (zalacznik),
                            InformacjeSprzedazoweId = InformacjeSprzedazowe.InformacjeSprzedazoweId
                        };
                        _unityOfWork.InformacjeSprzedazoweZalacznikiRepository.Create(informacjaSprzedazowaZalacznik);
                        _unityOfWork.SaveChanges();
                    }



                    // Dodanie sprzętu do sprzętów i przypisanie go do jakiejś firmy 
                    if (checkBoxPrzypiszDoFirmy.Checked)
                    {
                        Sprzet sprzet = new Sprzet ()
                        {
                            SprzetId = Guid.NewGuid ().ToString (), 
                            RodzajSprzetuId = InformacjeSprzedazowe.RodzajSprzetuId,
                            FirmaId = Firma.FirmaId
                        };
                        _unityOfWork.SprzetyRepository.Create (sprzet);
                        _unityOfWork.SaveChanges();


                        // Pobranie pól danego z sprzętu
                        var sprzetItem = _unityOfWork.SprzetItemsRepository.GetAll ()
                            .FirstOrDefault (f=> f.Nazwa == comboBoxSprzetItems.SelectedItem.ToString ());
                        if (sprzetItem != null && sprzetItem.PolaItems != null)
                        {
                            foreach (PoleItem poleItem in sprzetItem.PolaItems.ToList())
                            {
                                Pole pole = new Pole ()
                                {
                                    PoleId = Guid.NewGuid ().ToString (),
                                    Name = poleItem.Name,
                                    Wartosc = "",
                                    SprzetId = sprzet.SprzetId
                                };
                                _unityOfWork.PolaRepository.Create (pole);
                                _unityOfWork.SaveChanges();
                            }
                        }



                        InformacjeSprzedazowe.FirmaId = Firma.FirmaId;
                        _unityOfWork.InformacjeSprzedazoweRepository.Update (InformacjeSprzedazowe);
                        _unityOfWork.SaveChanges ();
                    }


                    MessageBox.Show ("Dane zostały zapisane");
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
         

        private void comboBoxFirmy_SelectedIndexChanged (object sender, EventArgs e)
        { 
            FindFirma(comboBoxFirmy);
        }

        private void checkBoxPrzypiszDoFirmy_CheckedChanged (object sender, EventArgs e)
        { 
            if (checkBoxPrzypiszDoFirmy.Checked)
            {
                comboBoxFirmy.Enabled = true;
                comboBoxFirmy.DataSource = DisplayNazwyFirm ();
                FindFirma (comboBoxFirmy);
            }
            else
            {
                comboBoxFirmy.Enabled = false;
                comboBoxFirmy.Text = "";
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

        private void listBoxZalaczniki_SelectedIndexChanged (object sender, EventArgs e)
        {

        }

        private void comboBoxSprzetItems_SelectedIndexChanged (object sender, EventArgs e)
        {

        }
    }
}
