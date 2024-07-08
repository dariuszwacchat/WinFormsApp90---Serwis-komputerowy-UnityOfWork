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

namespace WinFormsApp90.Forms.InformacjeSprzedazowe
{
    public partial class InformacjeSprzedazoweUserControl : BaseUserControl
    {
        public InformacjeSprzedazoweUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayInformacjeSprzedazowe ();
            DisplayNazwyFirm(toolStripComboBoxFirmyInformacjeSprzedazowe);
            SetDataGridViewStyles (dataGridViewInformacjeSprzedazowe);
        }


        private void DisplayInformacjeSprzedazowe ()
        {
            Index = 0;
            var informacjeSprzedazowe = _unityOfWork.InformacjeSprzedazoweRepository.GetAll ();

            // Filtrowanie

            if (toolStripComboBoxRodzajInformacjeSprzedazowe.SelectedItem != null &&
                toolStripComboBoxFirmyInformacjeSprzedazowe.SelectedItem != null)
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmyInformacjeSprzedazowe.SelectedItem.ToString ();
                informacjeSprzedazowe = informacjeSprzedazowe.Where(w => w.Firma != null && w.Firma.SkroconaNazwa == wybranaNazwaFirmy).ToList();

                dataGridViewInformacjeSprzedazowe.DataSource = (from f in informacjeSprzedazowe
                                                                select new
                                                                {
                                                                    InformacjeSprzedazoweId = f.InformacjeSprzedazoweId,
                                                                    Lp = IndexCounter,
                                                                    Cena = f.Cena,
                                                                    NazwaProduktu = f.NazwaProduktu,
                                                                    //Firma = f.Firma.SkroconaNazwa,
                                                                    Uwagi = f.Uwagi
                                                                }).ToList();
            }


            Index = 0;
            if (toolStripComboBoxRodzajInformacjeSprzedazowe.SelectedItem != null &&
                toolStripComboBoxRodzajInformacjeSprzedazowe.SelectedItem.ToString() == "Nieprzypisane")
            {
                string wybranaNazwaFirmy = toolStripComboBoxFirmyInformacjeSprzedazowe.SelectedItem.ToString ();
                informacjeSprzedazowe = _unityOfWork.InformacjeSprzedazoweRepository.GetAll ()
                                            .Where(w => w.Firma == null)
                                            .ToList();

                dataGridViewInformacjeSprzedazowe.DataSource = (from f in informacjeSprzedazowe
                                                                select new
                                                                {
                                                                    InformacjeSprzedazoweId = f.InformacjeSprzedazoweId,
                                                                    Lp = IndexCounter,
                                                                    Cena = f.Cena,
                                                                    NazwaProduktu = f.NazwaProduktu,
                                                                    //Firma = f.Firma.SkroconaNazwa,
                                                                    Uwagi = f.Uwagi
                                                                }).ToList();
            }

        }

        private void dataGridViewInformacjeSprzedazowe_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    InformacjeSprzedazoweId = dataGridViewInformacjeSprzedazowe.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void dataGridViewInformacjeSprzedazowe_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewInformacjeSprzedazowe.SelectedRows.Count > 0)
                    InformacjeSprzedazoweId = dataGridViewInformacjeSprzedazowe.Rows[0].Cells[0].Value.ToString();
            }
            catch { }
        }

        private void toolStripButtonDodajInformacjeSprzedazowe_Click (object sender, EventArgs e)
        {
            InformacjaSprzedazowaCreate isc = new InformacjaSprzedazowaCreate (_unityOfWork);
            isc.ShowDialog ();
        }

        private void toolStripButtonUsunInformacjeSprzedazowe_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikujInformacjeSprzedazowe_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InformacjeSprzedazoweId))
            {
                InformacjaSprzedazowaCreate isc = new InformacjaSprzedazowaCreate (_unityOfWork);
                isc.ShowDialog ();
            }
        }

        private void toolStripComboBoxFirmyInformacjeSprzedazowe_SelectedIndexChanged (object sender, EventArgs e)
        {
            DisplayInformacjeSprzedazowe ();
        }
    }
}
