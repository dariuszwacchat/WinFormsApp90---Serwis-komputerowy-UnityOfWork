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
using WinFormsApp90.Services;

namespace WinFormsApp90.Forms.BazaWiedzy
{
    public partial class BazaWiedzyUserControl : BaseUserControl
    {
        public BazaWiedzyUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayBazaWiedzy ();
            SetDataGridViewStyles (dataGridViewBazaWiedzy);
        }


        private void DisplayBazaWiedzy ()
        {
            Index = 0;
            var wiedza = _unityOfWork.WiedzaRepository.GetAll ();

            dataGridViewBazaWiedzy.DataSource = (from f in wiedza
                                                 select new
                                                 {
                                                     WiedzaId = f.WiedzaId,
                                                     Lp = IndexCounter,
                                                     Temat = f.Temat,
                                                     Rozwiazanie = f.Rozwiazanie,
                                                     WiedzaZdjecia = f.WiedzaZdjecia.Count,
                                                 }).ToList();
        }
        private void dataGridViewBazaWiedzy_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    WiedzaId = dataGridViewBazaWiedzy.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(WiedzaId))
                    {
                        Wiedza = _unityOfWork.WiedzaRepository.Get (WiedzaId);
                        if (Wiedza != null)
                        {
                            textBoxTematBazaWiedzy.Text = Wiedza.Temat;
                            textBoxRozwiazanieBazaWiedzy.Text = Wiedza.Rozwiazanie;


                            if (Wiedza.WiedzaZdjecia != null)
                                DisplayItemsInListBox (Wiedza.WiedzaZdjecia.Select(s=> s.Nazwa).ToList(), listBoxZalacznikiBazaWiedzy);
                        }
                    }
                }
            }
            catch { }
        }

        private void dataGridViewBazaWiedzy_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBazaWiedzy.SelectedRows.Count > 0)
                {
                    WiedzaId = dataGridViewBazaWiedzy.Rows[0].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(WiedzaId))
                        Wiedza = _unityOfWork.WiedzaRepository.Get (WiedzaId);
                }
            }
            catch { }
        }

        private void toolStripButtonDodajBazaWiedzy_Click (object sender, EventArgs e)
        {
            WiedzaCreate wiedzaCreate = new WiedzaCreate (_unityOfWork);
            wiedzaCreate.ShowDialog();
        }

        private void toolStripButtonUsunBazaWiedzy_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikujBazaWiedzy_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(WiedzaId))
            { 
                WiedzaEdit wiedzaEdit = new WiedzaEdit (WiedzaId,_unityOfWork);
                wiedzaEdit.ShowDialog ();
            }
        }

        private void listBoxZalacznikiBazaWiedzy_DoubleClick (object sender, EventArgs e)
        {
            var zdjecie = _unityOfWork.WiedzaZdjeciaRepository.GetAll ()
                            .FirstOrDefault (f=> f.Nazwa == listBoxZalacznikiBazaWiedzy.SelectedItem.ToString () && f.WiedzaId == WiedzaId);
            if (zdjecie != null)
                DisplayFile (zdjecie.Data, zdjecie.Nazwa);
        }
    }
}
