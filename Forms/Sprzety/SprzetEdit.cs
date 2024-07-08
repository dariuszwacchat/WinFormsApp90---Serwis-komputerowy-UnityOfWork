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

namespace WinFormsApp90.Forms.Sprzety
{
    public partial class SprzetEdit : BaseForm
    {  
        public SprzetEdit (string sprzetId, IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent(); 
            Zalaczniki.Clear(); 
            SprzetId = sprzetId;

            if (!string.IsNullOrEmpty (SprzetId))
                Sprzet = _unityOfWork.SprzetyRepository.Get(SprzetId);
        }


        private void SprzetEdit_Load (object sender, EventArgs e)
        { 
            Index = 0;  
            if (Sprzet != null)
            {  
                checkBoxUrzadzenieSieciowe.Checked = Sprzet.UrzadzenieSieciowe;


                if (Sprzet.Pola != null)
                {
                    dataGridView1.DataSource = Sprzet.Pola.ToList();
                }
            }
        }
         
        private void button1_Click (object sender, EventArgs e)
        {

            if (checkBoxUrzadzenieSieciowe.Checked)
                Sprzet.UrzadzenieSieciowe = true;
            else
                Sprzet.UrzadzenieSieciowe = false;



            _unityOfWork.SprzetyRepository.Update (Sprzet);
            _unityOfWork.SaveChanges ();


            // Dodanie załączników 

            foreach (var zalacznik in Zalaczniki)
            {
                SprzetZdjecie sprzetZdjecie = new SprzetZdjecie ()
                {
                    SprzetZdjecieId = Guid.NewGuid ().ToString (),
                    Nazwa = zalacznik,
                    Data = GetBytes (zalacznik),
                    SprzetId = Sprzet.SprzetId
                };
                _unityOfWork.SprzetZdjeciaRepository.Create(sprzetZdjecie);
                _unityOfWork.SaveChanges();
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
