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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Forms : Form
    {
        #region test
        //procesory
        public Processor inteli7_9700 = new Processor("Intel Core i7-9700", 1545, 8, 3, Enum.GetName(typeof(socket), socket.LGA1151));
        public Processor inteli7_8700 = new Processor("Intel Core i7-8700K", 1772, 6, 3.7, Enum.GetName(typeof(socket), socket.LGA1151));
        public Processor inteli7_3770 = new Processor("Intel Core i7-3770", 1418, 4, 3.4, Enum.GetName(typeof(socket), socket.LGA1155));

        //Karty Graficzne
        public GraphicCard gtx1050TI = new GraphicCard("ASUS CERBERUS GeForce GTX 1050TI O4G", 998, 4, 1480, true);
        public GraphicCard rtx2080TI = new GraphicCard("GeForce RTX 2080 Ti Dual 11GB GDDR6", 4528, 11, 1350, true);
        public GraphicCard gtx1650 = new GraphicCard("GeForce GTX 1660 SUPER OC 6GB GDDR6", 1219, 6, 1530, true);

        //dysk

        public Disk wdred = new Disk("WD Red", 399, 2000, Enum.GetName(typeof(diskType), diskType.HDD));
        public Disk seagateFireCuda = new Disk("Seagate FireCuda", 489, 2000, Enum.GetName(typeof(diskType), diskType.HDD));
        public Disk seagateIronWolf = new Disk("Seagate IronWolf", 522, 4000, Enum.GetName(typeof(diskType), diskType.HDD));

        //płyta główna

        public Motherboard gigabyteB360M = new Motherboard("Gigabyte B360M Aorus Gaming 3", 439, true, 4, Enum.GetName(typeof(size), size.MicroATX));
        public Motherboard msiH310m = new Motherboard("MSI H310M PRO-M2", 309, true, 2, Enum.GetName(typeof(size), size.MicroATX));
        public Motherboard msiMPG = new Motherboard("MSI MPG Z390I Gaming Edge AC", 699, true, 2, Enum.GetName(typeof(size), size.MiniITX));

        //RAM

        public Ram aegis = new Ram("G.Skill Aegis", 305, 16, 3000, Enum.GetName(typeof(memoryType), memoryType.DDR4));
        public Ram patriotViper = new Ram("Patriot Viper 4", 154, 8, 3000, Enum.GetName(typeof(memoryType), memoryType.DDR4));
        public Ram hyperxPredator = new Ram("HyperX Predator", 376, 16, 3200, Enum.GetName(typeof(memoryType), memoryType.DDR4));

        //Zasilacz

        PowerSupply silentiumVeroM2 = new PowerSupply("SilentiumPC Vero M2 Bronze", 213, 600, Enum.GetName(typeof(standardOfPowerSupply), standardOfPowerSupply.ATX), 120);
        PowerSupply silentiumVeroL2 = new PowerSupply("SilentiumPC Vero L2", 199, 600, Enum.GetName(typeof(standardOfPowerSupply), standardOfPowerSupply.ATX), 160);
        PowerSupply ThermaltakeSmart = new PowerSupply("Thermaltake Smart SE2", 186, 500, Enum.GetName(typeof(standardOfPowerSupply), standardOfPowerSupply.ATX), 150);

        public List<Processor> processors = new List<Processor>();
        public List<GraphicCard> graphicCards = new List<GraphicCard>();
        public List<Disk> disks = new List<Disk>();
        public List<Motherboard> motherboards = new List<Motherboard>();
        public List<Ram> rams = new List<Ram>();
        public List<PowerSupply> powerSupplies = new List<PowerSupply>();

        public Forms()
        {
            processors.Add(inteli7_9700);
            processors.Add(inteli7_8700);
            processors.Add(inteli7_3770);

            graphicCards.Add(gtx1050TI);
            graphicCards.Add(gtx1650);
            graphicCards.Add(rtx2080TI);

            disks.Add(wdred);
            disks.Add(seagateFireCuda);
            disks.Add(seagateIronWolf);

            motherboards.Add(gigabyteB360M);
            motherboards.Add(msiH310m);
            motherboards.Add(msiMPG);

            rams.Add(aegis);
            rams.Add(patriotViper);
            rams.Add(hyperxPredator);

            powerSupplies.Add(silentiumVeroM2);
            powerSupplies.Add(silentiumVeroL2);
            powerSupplies.Add(ThermaltakeSmart);
        }
        #endregion
    }
}
    