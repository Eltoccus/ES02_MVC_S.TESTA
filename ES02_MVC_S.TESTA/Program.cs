using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//
//using ES02_MVC_S.TESTA.View;          O fare come a riga Application.Run(new *nome namespace*.*nome form*());

namespace ES02_MVC_S.TESTA
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ES02_MVC_S.TESTA.View.FrmMVC());
        }
    }
}
