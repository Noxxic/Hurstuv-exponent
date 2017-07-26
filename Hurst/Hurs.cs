using CommonLib.Numerical;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hurst_exp
{
    public class Hurst_Result
    {
        public List<double> X;
        public List<double> Y;
        public double hurst;
        public double YIntercept;
        public double rovnicePrimky(double x) => (hurst * x + YIntercept);
    }
   public class Hurst
    {
        public Hurst_Result Spocti_Hurstuv_Koeficient(List<double> vstupni_data)
        {
            Dictionary<char, List<double>> body = new Dictionary<char, List<double>>(); //slovník bodů
            body.Add('X', new List<double>()); //Xové souřadnice
            body.Add('Y', new List<double>()); //Yové souřadnice
            int max = 8; //Velikost počáteční množiny bodů
            while (true)
            {
                var tmp_data = new List<double>(); //Ořezaná množina vstupních dat
                for (int i = 0; i < max; i++)
                    tmp_data.Add(vstupni_data[i]); //Naplnění Ořezané množiny vstupních dat
                var res = Hurstuv_Koeficient(tmp_data); //Vypočet bodu, který je výsledkem R/S analýzy pro ořezanou množinu
                body['X'].Add(res.Item1); //Přidání souřadnic bodu do slovníku bodů
                body['Y'].Add(res.Item2); //Přidání souřadnic bodu do slovníku bodů
                if (max >= vstupni_data.Count) //Pokud je velikost množiny větší než velikost vstupních dat, tak konec
                    break;
                max = max+8 >= vstupni_data.Count ? vstupni_data.Count : max + 8; //Zvětšení velikosti ořezané mbnožiny
            }
            var ds = new XYDataSet(body['X'], body['Y']);

            return new Hurst_Result
            {
                X = body['X'],
                Y = body['Y'],
                hurst = Math.Round(ds.Slope, 4),
               YIntercept = Math.Round(ds.YIntercept, 4)
            };
       
        }

        public Tuple<double,double> Hurstuv_Koeficient(List<double> vstupni_data)
        {
            double prumer = Spocti_Prumery(vstupni_data); //spočítání průměru
            List<double> odchylky = Spocti_Odchylky(vstupni_data, prumer); //spočítání odchylek
            List<double> kumulovane_odchylky = Spocti_Kumulovane_Odchylky(odchylky); //spočítání Kumulovaných odchylek

            double r = kumulovane_odchylky.Max() - kumulovane_odchylky.Min(); // rozpetí kumulovaných odchylek

            double s = Spocti_Smerodatnou_Odchylku(vstupni_data, prumer); //  směrodatná odchylka

            double x = Math.Log10(vstupni_data.Count); //Spočítání Xové souřadnice bodu
            double y = Math.Log10(r / s); //Spočítání Yové souřadnice bodu
           
         
            
            return new Tuple<double, double>(x,y);
        }
        private double Spocti_Smerodatnou_Odchylku(List<double> data, double prumer) => Math.Sqrt((from x in data select (x - prumer) * (x - prumer)).Sum() / data.Count());

        //Spočítání kumulovaných odchylek :  Y(1) = x(1), Y(2) = x(1)+x(2), ... Y(n) = x(1)+x(2)+...x(n). 
        // x = odchylka
        private List<double> Spocti_Kumulovane_Odchylky(List<double> odchylky)
        {
            //hacmac
            var kumulovane_odchylky = new List<double>();
            for (int i = 0; i < odchylky.Count; i++)
                if (i != 0)
                    kumulovane_odchylky.Add(kumulovane_odchylky[i - 1] + odchylky[i]);
                else
                    kumulovane_odchylky.Add(odchylky[i]);
            return kumulovane_odchylky;
        }

        //x(1) = h(1) - M, x(2) = h(2) - M, ... x(n) = h(n) - M. 
        // h = vstupní hodnota; M = průměr
        private List<double> Spocti_Odchylky(List<double> data, double prumer) => (from h in data select h - prumer).ToList();

        private double Spocti_Prumery(List<double> rozdelena_data) => rozdelena_data.Sum() / rozdelena_data.Count;
 

        //Již nepoužíváme - zatím možná
        private Dictionary<int, List<double>> Rozdel_data(double[] data,int pocet_intervalu)
        {
            var data_rozdelena_do_intervalu = new Dictionary<int,List<double>>();
            int velikost_intervalu = data.Length / pocet_intervalu;
            var tmp_list = new List<double>();
            for(int i = 0; i <= pocet_intervalu;i++)
            {
                tmp_list = new List<double>();
                for (int j = i*velikost_intervalu; j < (i*velikost_intervalu + velikost_intervalu);j++)
                {
                    if (j >= data.Length)
                        break;
                    tmp_list.Add(data[j]);
                }
                data_rozdelena_do_intervalu.Add(i, tmp_list);
            }
            return data_rozdelena_do_intervalu;
        }
    }
}
