using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System;
using CommonLib.Numerical;
using System.IO;

namespace Hurst_exp
{
    class Program
    {

        static void Main(string[] args)
        {
            var h = new Hurst();
            var neco = h.Spocti_Hurstuv_Koeficient(NactiData(@"C:\Users\Katlin\Desktop\neco.txt")); //Získáme body získané pomocí R/S metody
            //var ds = new XYDataSet(neco['X'], neco['Y']); //Provede lineární regresy nad získanými body

            //Console.WriteLine(Math.Round(ds.Slope, 4)); //Vypíšeme vypočítaný odhad Hurstova exponentu
            //Console.WriteLine(Math.Round(ds.YIntercept, 4)); 
            //Console.ReadKey();
        }
        public static List<double> NactiData(string path) => (from radek in File.ReadAllLines(path) select Convert.ToDouble(radek)).ToList(); //Načítá data ze souboru
    }
}
