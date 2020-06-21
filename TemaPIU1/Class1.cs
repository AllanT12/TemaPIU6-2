//Tanasa Alin Petru 3121A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIU1
{
    public class Sejur
    {
       
        public string Tara
        {
            set;
            get;
        }
        public string Oras
        {
            set;
            get;
        }

        public int pret
        {
            set;
            get;
        }

        public Climat Climat
        {
            set;
            get;
        }
        public Dotari Dotari
        {
            get;
            set;
        }
      
        public Sejur(string _Tara, string _Oras, string _pret)
        {
            Tara = _Tara;
            Oras = _Oras;
            pret = Convert.ToInt32(_pret);
        }

        public Sejur(string _Tara,string _Oras,int _pret)
        {
            Tara = _Tara;
            Oras = _Oras;
            pret = _pret;
        }

        public Sejur(string rand)
        {
            string[] cuvinte = rand.Split(';');
            Tara=cuvinte[0];
            Oras = cuvinte[1];
            pret =Convert.ToInt32(cuvinte[2]);
        }

        public string Afisare()
        {
            return string.Format("Ati castigat {0} {1} la pretul de {2} euro",Tara,Oras,pret);
        }
        public string ConversieLaSir_PentruFisier()
        {
            string s = string.Format("{0};{1};{2}",Tara,Oras,pret);

            return s;
        }

    }
}