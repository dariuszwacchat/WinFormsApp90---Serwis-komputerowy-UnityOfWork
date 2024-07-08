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

namespace WinFormsApp90.Forms.Preferencje.LicencjaWolna
{
    public partial class LicencjaEdit : BaseForm
    {
        public LicencjaEdit (string wolnaLicencjaId)
        {
            InitializeComponent();
            WolnaLicencjaId = wolnaLicencjaId;
            WolnaLicencja = _unityOfWork.WolneLicencjeRepository.Get (WolnaLicencjaId);
        }

        private void LicencjaEdit_Load (object sender, EventArgs e)
        {
            if (WolnaLicencja != null)
            {
                textBoxKluczLicencji.Text = WolnaLicencja.KluczLicencji;
                textBoxIloscLicencji.Text = WolnaLicencja.IloscLicencji.ToString ();
                dateTimePickerDataZakupu.Value = WolnaLicencja.DataZakupu;
                dateTimePickerDataWaznosci.Value = WolnaLicencja.DataWaznosci;
                textBoxGdzieKupiona.Text = WolnaLicencja.MiejsceZakupu;
                textBoxUwagi.Text = WolnaLicencja.Uwagi;



                if (WolnaLicencja.WolnaLicencjaZalaczniki != null)
                    DisplayItemsInListBoxConvertFromBytes (WolnaLicencja.WolnaLicencjaZalaczniki.Select (s=>s.Data).ToList (), listBoxZalaczniki);
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                if (WolnaLicencja != null)
                { 
                    Cursor = Cursors.WaitCursor;
                    WolnaLicencja.KluczLicencji = textBoxKluczLicencji.Text;
                    WolnaLicencja.IloscLicencji = int.Parse (textBoxIloscLicencji.Text);
                    WolnaLicencja.DataZakupu = dateTimePickerDataZakupu.Value;
                    WolnaLicencja.DataWaznosci = dateTimePickerDataWaznosci.Value;
                    WolnaLicencja.MiejsceZakupu = textBoxGdzieKupiona.Text;
                    WolnaLicencja.Uwagi = textBoxUwagi.Text;
                     
                    _unityOfWork.WolneLicencjeRepository.Update (WolnaLicencja);
                    _unityOfWork.SaveChanges ();



                    // Dodanie załączników 
                    foreach (var zalacznik in Zalaczniki)
                    {
                        WolnaLicencjaZalacznik licencjaZalacznik = new WolnaLicencjaZalacznik ()
                        {
                            WolnaLicencjaZalacznikId = Guid.NewGuid ().ToString (),
                            Nazwa = zalacznik,
                            Data = GetBytes (zalacznik),
                            WolnaLicencjaId = WolnaLicencja.WolnaLicencjaId
                        };
                        _unityOfWork.WolneLicencjeZalacznikiRepository.Create (licencjaZalacznik);
                        _unityOfWork.SaveChanges();
                    }


                    Cursor = Cursors.Default;
                    Close();

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
