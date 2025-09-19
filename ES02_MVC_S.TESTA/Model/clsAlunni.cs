using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES02_MVC_S.TESTA.Model
{
    internal class clsAlunni
    {
        private int idAlunno;
        private string cognome;
        private string nome;
        private DateTime dataNascita;
        private bool icdl;

        public int IdAlunno
        {
            get
            {
                return idAlunno; 
            }
            set
            {
                idAlunno = value;
            }
        }

        public string Cognome
        {
            get
            {
                return cognome;
            }
            set
            {
                cognome = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public DateTime DataNascita
        {
            get
            {
                return dataNascita;
            }
            set
            {
                dataNascita = value;
            }
        }

        public bool Icdl
        {
            get
            {
                return icdl;
            }
            set
            {
                icdl = value;
            }
        }
    }
}
