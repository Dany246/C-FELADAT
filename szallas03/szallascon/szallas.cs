using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace szallascon
{
    public class Szallas
    {
        public string Nev { get; private set; }
        public string Cim { get; private set; }
        public int Szobaszam { get; private set; } 
        public int AgySzam { get; private set; } 
        public string UzNeve { get; private set; } 
        public string UzCime { get; private set; } 
        public string UzTelefon { get; private set; } 
        public bool Statusz { get; private set; } 
        public string TevTipus { get; private set; }

        public Szallas(string sor) 
        {
            string[] darabol = sor.Split(';');

            Nev = darabol[0];
            Cim = darabol[1];
            Szobaszam = int.Parse(darabol[2]);
            AgySzam = int.Parse(darabol[3]);
            UzNeve = darabol[4];
            UzCime = darabol[5];
            UzTelefon = darabol[6];
            Statusz = (darabol[7] == "Aktív");
            TevTipus = darabol[8];  

        }
        public static List<Szallas> Beolvas(string file) 
        {
            List<Szallas> list = new List<Szallas>();

            StreamReader sr = new StreamReader(file, Encoding.UTF8);

            sr.ReadLine();
            while (!sr.EndOfStream) 
            {
                string line = sr.ReadLine();
                Szallas szallas = new Szallas(line);
                list.Add(szallas);
            }

            
            

            sr.Close();

            return list;
        }

        public string Telepules
        {
            get
            {
                return Cim.Split(' ')[1];
            }
        }
    }
}

