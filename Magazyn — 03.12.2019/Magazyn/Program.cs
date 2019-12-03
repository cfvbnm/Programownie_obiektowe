using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //procesory
            Processor inteli7_9700 = new Processor("Intel Core i7-9700", 1545, 8, 3, Enum.GetName(typeof((socket.LGA1151));
            Processor inteli7_8700 = new Processor("Intel Core i7-8700K", 1772, 6, 3.7, socket.LGA1151);
            Processor inteli7_3770 = new Processor("Intel Core i7-3770", 1418, 4, 3.4, socket.LGA1155);

            //Karty Graficzne Deptiego
            GraphicCard gtx150TI = new GraphicCard("ASUS CERBERUS GeForce GTX 1050TI O4G", 998, 4, 1480, true);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }
    }
}
    