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

namespace WinFormsApp90.Forms.Firmy
{
    public partial class FirmyUserControl : BaseUserControl
    {
        public FirmyUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();

            DisplayFirmy ();
            SetDataGridViewStyles (dataGridViewFirmy);
        }


        private void DisplayFirmy ()
        {
            Index = 0;
            var firmy = _unityOfWork.FirmyRepository.GetAll ();
            dataGridViewFirmy.DataSource = (from f in firmy
                                            select new
                                            {
                                                FirmaId = f.FirmaId,
                                                Lp = IndexCounter,
                                                PelnaNazwa = f.PelnaNazwa,
                                                SkroconaNazwa = f.SkroconaNazwa,
                                                Adres = f.Adres,
                                                Nip = f.Nip,
                                            }).ToList();
        }



        private void dataGridViewFirmy_CellMouseClick (object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    FirmaId = dataGridViewFirmy.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(FirmaId))
                    {
                        Firma = _unityOfWork.FirmyRepository.Get (FirmaId); 
                    }
                }
            }
            catch { }
        }

        private void dataGridViewFirmy_SelectionChanged (object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewFirmy.SelectedRows.Count > 0)
                {
                    FirmaId = dataGridViewFirmy.Rows[0].Cells[0].Value.ToString();
                    if (!string.IsNullOrEmpty(FirmaId))
                        Firma = _unityOfWork.FirmyRepository.Get (FirmaId);
                }
            }
            catch { }
        }

        private void toolStripButtonDodajFirma_Click (object sender, EventArgs e)
        {
            FirmaCreate fc = new FirmaCreate (_unityOfWork);
            fc.ShowDialog ();
        }

        private void toolStripButtonUsunFirma_Click (object sender, EventArgs e)
        {

        }

        private void toolStripButtonModyfikujFirma_Click (object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (FirmaId))
            {
                FirmaEdit fe = new FirmaEdit (FirmaId,_unityOfWork);
                fe.ShowDialog ();
            }
        }
    }
}
