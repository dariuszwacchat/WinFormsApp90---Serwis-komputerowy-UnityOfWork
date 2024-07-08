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

namespace WinFormsApp90.Forms.BazaWiedzy
{
    public partial class WiedzaEdit : BaseForm
    {
        public WiedzaEdit (string wiedzaId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            WiedzaId = wiedzaId;
            Wiedza = _unityOfWork.WiedzaRepository.Get (WiedzaId);
        }

        private void WiedzaEdit_Load (object sender, EventArgs e)
        {
            if (Wiedza != null)
            {
                textBoxTemat.Text = Wiedza.Temat;
                textBoxOpis.Text = Wiedza.Rozwiazanie;


                // Wyświetlenie zdjęć

                if (Wiedza.WiedzaZdjecia != null)
                {
                    listBoxZalaczniki.DataSource = Wiedza.WiedzaZdjecia.ToList ();
                }
            }
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                Wiedza.Temat = textBoxTemat.Text;
                Wiedza.Rozwiazanie = textBoxOpis.Text;

                _unityOfWork.WiedzaRepository.Update (Wiedza);
                _unityOfWork.SaveChanges ();



                // Dodanie załączników  
                foreach (var zalacznik in Zalaczniki)
                {
                    WiedzaZdjecie wiedzaZdjecie = new WiedzaZdjecie ()
                    {
                        WiedzaZdjecieId = Guid.NewGuid ().ToString (),
                        Nazwa = zalacznik,
                        Data = GetBytes (zalacznik),
                        WiedzaId = WiedzaId
                    };
                    _unityOfWork.WiedzaZdjeciaRepository.Create (wiedzaZdjecie);
                    _unityOfWork.SaveChanges();
                }

                Cursor = Cursors.Default;
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
                        Zalaczniki = open.FileNames.ToList();
                        DisplayItemsInListBox(open.FileNames.ToList (), listBoxZalaczniki);
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
