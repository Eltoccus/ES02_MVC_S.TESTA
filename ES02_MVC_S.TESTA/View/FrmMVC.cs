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
using ES02_MVC_S.TESTA.Controller;
using ES02_MVC_S.TESTA.Model;


namespace ES02_MVC_S.TESTA.View
{
    public partial class FrmMVC : Form
    {
        public FrmMVC()
        {
            InitializeComponent();
        }

        private void FrmMVC_Load(object sender, EventArgs e)
        {
            /*
             * Gestire gli alunni di una scuola mediante MVC con visualizzazione di 
             * Master/Detail    dove l'inserimento e la modifica dei dati 
             * verrà gestita con tecnologia multiform e passaggio di parametri
             * tra form
            */

            clsAlunniController alunniController;
            clsAlunni alunni;
            string nomeFile = "alunni.txt";

        }
    }
}
