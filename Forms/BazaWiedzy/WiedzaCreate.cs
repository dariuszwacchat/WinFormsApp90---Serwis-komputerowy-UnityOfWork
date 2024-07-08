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
    public partial class WiedzaCreate : BaseForm
    {
        public WiedzaCreate (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
            Zalaczniki.Clear ();
        }

        private void WiedzaCreate_Load (object sender, EventArgs e)
        {
        }

        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                Wiedza wiedza = new Wiedza ()
                {
                    WiedzaId = Guid.NewGuid ().ToString (),
                    Temat = textBoxTemat.Text,
                    Rozwiazanie = textBoxOpis.Text,
                    DataDodania = DateTime.Now
                };

                _unityOfWork.WiedzaRepository.Create (wiedza);
                _unityOfWork.SaveChanges();


                // Dodanie załączników 

                foreach (var zalacznik in Zalaczniki)
                {
                    WiedzaZdjecie wiedzaZdjecie = new WiedzaZdjecie ()
                    {
                        WiedzaZdjecieId = Guid.NewGuid ().ToString (),
                        Nazwa = zalacznik,
                        Data = GetBytes (zalacznik),
                        WiedzaId = wiedza.WiedzaId
                    };
                    _unityOfWork.WiedzaZdjeciaRepository.Create (wiedzaZdjecie);
                    _unityOfWork.SaveChanges();
                }



                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            Close();
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
