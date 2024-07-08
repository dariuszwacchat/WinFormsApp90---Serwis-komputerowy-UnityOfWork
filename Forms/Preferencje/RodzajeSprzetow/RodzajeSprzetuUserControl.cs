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

namespace WinFormsApp90.Forms.Preferencje.RodzajeSprzetow
{
    public partial class RodzajeSprzetuUserControl : BaseUserControl
    {
        private ApplicationDbContext _context;


        public RodzajeSprzetuUserControl ()
        {
            InitializeComponent();
            _context = new ApplicationDbContext ();
            DisplayRodzajeUrzadzen ();

            SetDataGridViewStyles (dataGridViewRodzajeUrzadzen);
        }

        private void DisplayRodzajeUrzadzen ()
        {
            var rodzajeUrzadzen = _context.RodzajeSprzetow.ToList ();
            dataGridViewRodzajeUrzadzen.DataSource = rodzajeUrzadzen;
        }


    }
}
