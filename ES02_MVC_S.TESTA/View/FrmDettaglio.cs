using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using ES02_MVC_S.TESTA.Model;


namespace ES02_MVC_S.TESTA.View
{
    public partial class FrmDettaglio : Form
    {
        public FrmDettaglio()
        {
            InitializeComponent();
        }

        public FrmDettaglio(clsAlunni _alunno)
        {
            InitializeComponent();
        }

        private void FrmDettaglio_Load(object sender, EventArgs e)
        {

        }
    }
}
