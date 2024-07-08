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

namespace WinFormsApp90.Forms.Raporty
{
    public partial class RaportyUserControl : BaseUserControl
    {
        public RaportyUserControl (IUnityOfWork unityOfWork) : base(unityOfWork)
        {
            InitializeComponent();
        }
    }
}
