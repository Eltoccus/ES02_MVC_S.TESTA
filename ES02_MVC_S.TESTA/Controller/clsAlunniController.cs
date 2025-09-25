using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using ES02_MVC_S.TESTA.Model;       //Per accedere al namespace, da tutte le parti del progetto, devo fare il "using *nome namespace*"
using System.IO;
using System.Windows.Forms;

namespace ES02_MVC_S.TESTA.Controller
{
    internal class clsAlunniController
    {
        private string nomeFile;


        public string Nomefile
        {
            get
            {
                return nomeFile;
            }
            set
            {
                nomeFile = value;
            }
        }

        //costruttore 
        public clsAlunniController(string _nomeFile)
        {
            Nomefile = _nomeFile;
        }

        //metodi
        public List<clsAlunni> LeggiAlunni()
        {
            List<clsAlunni> listaAlunni = new List<clsAlunni>();
            if (File.Exists(nomeFile))
            {
                StreamReader sr = new StreamReader(nomeFile);
                string[] vet;
                sr.ReadLine(); //leggo la prima riga (intestazione) e la scarto STAI GASANDO            

                while (!sr.EndOfStream)
                {
                    vet = sr.ReadLine().Split(';');
                    clsAlunni alunno = new clsAlunni();
                    alunno.IdAlunno = Convert.ToInt32(vet[0]);
                    alunno.Cognome = vet[1];
                    alunno.Nome = vet[2];
                    alunno.DataNascita = Convert.ToDateTime(vet[3]);
                    alunno.Icdl = Convert.ToBoolean(vet[4]);
                    listaAlunni.Add(alunno);
                }
                sr.Close();
            }

            return listaAlunni;
        }

        public void scriviAlunni(List<clsAlunni> _listaAlunni)
        {
            StreamWriter sw = new StreamWriter(nomeFile, false);
            sw.WriteLine("IdAlunno;Cognome;Nome;DataNascita;Icdl"); //intestazione
            sw.Close();

            foreach (clsAlunni alunno in _listaAlunni)
            {
                scriviAlunno(alunno);
                //alunni = alunno.IdAlunno.ToString() + ";";
                //alunni += alunno.Cognome + ";";
                //alunni += alunno.Nome + ";";
                //alunni += alunno.DataNascita + ";";
                //alunni += alunno.Icdl.ToString();

                //sw.WriteLine(alunni);
            }

        }

        public void scriviAlunno(clsAlunni _alunno)
        {
            StreamWriter sw = new StreamWriter(nomeFile, true);
            string testo;

            testo = _alunno.IdAlunno.ToString() + ";";
            testo += _alunno.Cognome + ";";
            testo += _alunno.Nome + ";";
            testo += _alunno.DataNascita + ";";
            testo += _alunno.Icdl.ToString();

            sw.WriteLine(testo);

            sw.Close();
        }
    }
}
