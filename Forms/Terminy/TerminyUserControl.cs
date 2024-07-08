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

namespace WinFormsApp90.Forms.Terminy
{
    public partial class TerminyUserControl : BaseUserControl
    {
        public TerminyUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            if (toolStripComboBoxGwarancje.Items.Count > 0)
                toolStripComboBoxGwarancje.SelectedIndex = 0;

            if (toolStripComboBoxLicencje.Items.Count > 0)
                toolStripComboBoxLicencje.SelectedIndex = 0;

            if (toolStripComboBoxNaprawy.Items.Count > 0)
                toolStripComboBoxNaprawy.SelectedIndex = 0;

            if (toolStripComboBoxUmowy.Items.Count > 0)
                toolStripComboBoxUmowy.SelectedIndex = 0;



            DisplayGwarancje();
            DisplayLicencje();
            DisplayNaprawy();
            DisplayUmowy();

            SetDataGridViewStyles(dataGridViewGwarancje);
            SetDataGridViewStyles(dataGridViewLicencje);
            SetDataGridViewStyles(dataGridViewNaprawy);
            SetDataGridViewStyles(dataGridViewUmowy);
        }

        private void DisplayGwarancje ()
        {
            try
            {
                List <Gwarancja> gwarancje = new List<Gwarancja> ();
                gwarancje.Clear();

                // Miesiac 
                foreach (Gwarancja gwarancja in _unityOfWork.GwarancjeRepository.GetAll ())
                {
                    if (UmowaKonczySieWtymMiesiacu(gwarancja.DataZakonczeniaGwarancji))
                        gwarancje.Add(gwarancja);
                }
                dataGridViewGwarancje.DataSource = (from f in gwarancje
                                                    select new
                                                    {
                                                        GwarancjaId = f.GwarancjaId,
                                                        Lp = IndexCounter,
                                                        DataRozpoczeciaGwarancji = f.DataRozpoczeciaGwarancji,
                                                        DataZakonczeniaGwarancji = f.DataZakonczeniaGwarancji,
                                                        CzasGwarancji = f.CzasGwarancji,
                                                        Sprzet = f.Sprzet.Nazwa,
                                                        Uwagi = f.Uwagi
                                                    }).ToList();
            }
            catch { }
        }

        private void DisplayLicencje ()
        {
            try
            {
                List <SprzetLicencja> sprzetLicencje = new List<SprzetLicencja> ();
                sprzetLicencje.Clear();

                // Miesiac 
                foreach (SprzetLicencja sprzetLicencja in _unityOfWork.SprzetLicencjeRepository.GetAll ())
                {
                    if (UmowaKonczySieWtymMiesiacu(sprzetLicencja.DataZakonczenia))
                        sprzetLicencje.Add(sprzetLicencja);
                }

                dataGridViewLicencje.DataSource = (from f in sprzetLicencje
                                                   select new
                                                   {
                                                       SprzetLicencjaId = f.SprzetLicencjaId,
                                                       Lp = IndexCounter,
                                                       DataWaznosci = f.DataZakonczenia,
                                                       KluczLicencji = f.Uwagi,
                                                       Sprzet = f.Sprzet.Nazwa,
                                                       Firma = f.Firma.SkroconaNazwa,
                                                       Uwagi = f.Uwagi
                                                   }).ToList();
            }
            catch { }
        }

        private void DisplayNaprawy ()
        {
            try
            {
                List <Naprawa> naprawy = new List<Naprawa> ();
                naprawy.Clear();

                // Miesiac 
                foreach (Naprawa naprawa in _unityOfWork.NaprawyRepository.GetAll())
                {
                    if (UmowaKonczySieWtymMiesiacu(naprawa.DataZakonczeniaGwarancji))
                        naprawy.Add(naprawa);
                }

                dataGridViewNaprawy.DataSource = (from f in naprawy
                                                  select new
                                                  {
                                                      NaprawaId = f.NaprawaId,
                                                      Lp = IndexCounter,
                                                      DataNaprawy = f.DataNaprawy,
                                                      CzasUdzielonejGwarancji = f.CzasUdzielonejGwarancji,
                                                      DataZakonczeniaGwarancji = f.DataZakonczeniaGwarancji,
                                                      Sprzet = f.Sprzet.Nazwa,
                                                      Uwagi = f.Uwagi
                                                  }).ToList();
            }
            catch { }
        }

        private void DisplayUmowy ()
        {
            try
            {
                List <Umowa> umowy = new List<Umowa> ();
                umowy.Clear();

                // Miesiac 
                foreach (Umowa umowa in _unityOfWork.UmowyRepository.GetAll())
                {
                    if (!string.IsNullOrEmpty (umowa.DataZakonczenia))
                    {
                        DateTime dataZakonczenia = DateTime.Parse (umowa.DataZakonczenia);
                        if (UmowaKonczySieWtymMiesiacu(dataZakonczenia))
                            umowy.Add(umowa);
                    }
                }

                dataGridViewUmowy.DataSource = (from f in umowy
                                                select new
                                                {
                                                    UmowaId = f.UmowaId,
                                                    Lp = IndexCounter,
                                                    NumerUmowy = f.NumerUmowy,
                                                    DataRozpoczecia = f.DataRozpoczecia,
                                                    DataZakonczenia = f.DataZakonczenia,
                                                    CzasNieokreslony = f.CzasNieokreslony,
                                                    OkresWypowiedzenia = f.OkresWypowiedzenia,
                                                    Uwagi = f.Uwagi
                                                }).ToList();
            }
            catch { }
        }


    }
}
