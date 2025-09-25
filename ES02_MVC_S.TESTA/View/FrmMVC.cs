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
            string nomeFile = "alunni.txt";
            alunniController = new clsAlunniController(nomeFile);
            dgv.DataSource = alunniController.LeggiAlunni();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                FrmDettaglio f = new FrmDettaglio();
                //  MessageBox.Show("Prima");
                f.ShowDialog();                 //In modalità modale, blocca la form e l'azione dopo di quelli vengono eseguiti solo dopo che la form viene chiusa
                //f.Show();                     //In modalità non modale, non blocca la form e l'azione dopo di quelli vengono eseguiti subito
                //   MessageBox.Show("Dopo");
            }
        }
    }
}
