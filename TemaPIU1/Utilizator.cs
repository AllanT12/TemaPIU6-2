//Tanasa Alin Petru 3121A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIU1
{
    public class Utilizator
    {
        public Distanta Distanta
        {
            get;
            set;
        }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Buget { get; set; }
        public static int IdUltimUtilizator { get; set; } = 0;
        public string NumeComplet { get { return Nume + " " + Prenume; } }
        public Preferinte Preferinta { get; set; }
        public string Tara_Pref { get; set; }
        public DateTime dataActualizare { get; set; }
        public DateTime dataRezervarii { get; set; }
        public List<string> Optiune { get; set; }
        public string OptiuniAsString
        {
            get
            {
                string sDiscipline = string.Empty;

                foreach (string disciplina in Optiune)
                {
                    if (sDiscipline != string.Empty)
                    {
                        sDiscipline += ',';
                    }
                    sDiscipline += disciplina;
                }

                return sDiscipline;
            }
        }
        public Utilizator(string _Nume,string _Prenume,int _Buget)
        {
            Nume = _Nume;
            Prenume = _Prenume;
            Buget = _Buget;
        }
        //ex1 lab 4
        public string ConversieLaSir()
        {

            string s=string.Format("Utilizatorul {0} {1} are bugetul {2} Euro",Nume,Prenume,Buget);
            return s;
        }
        //ex2 lab 4
        public string compara(Utilizator utilizator)
        {
            if (Buget < utilizator.Buget)
                return"utilizatorul "+utilizator.Nume+" are mai multi bani";
            else if (Buget == utilizator.Buget)
                return"utilizatorii au acelasi buget";
            else
                return"utilizatorul "+Nume+ " are mai multi bani";
        }
        //Lab 5
        public string ConversieLaSir_PentruFisier()
        {
            string s = string.Format("{0};{1};{2};{3};{4};{5};{6}",Nume,Prenume,Buget,Preferinta,OptiuniAsString,Tara_Pref,dataRezervarii);

            return s;
        }
        public string ConversieLaSir_PentruFisierU(Sejur S)
        {
            string s = string.Format("{0};{1};{2};{3};{4};{5};{6};", Nume, Prenume, Buget, Preferinta, OptiuniAsString, Tara_Pref, dataRezervarii);

            return s;
        }
        public void SetBuget(int _buget)
        {
            Buget = _buget;
        }
        public Utilizator(string linieFisier)
        {
            var dateFisier = linieFisier.Split(';');
            Nume = dateFisier[(int)CampuriUtilizatori.Nume];
            Prenume = dateFisier[(int)CampuriUtilizatori.Prenume];
            Buget = Convert.ToInt32(dateFisier[(int)CampuriUtilizatori.Buget]);
            Preferinta = (Preferinte)Enum.Parse(typeof(Preferinte), dateFisier[(int)CampuriUtilizatori.Preferinte]);
            Optiune = new List<string>();
            Optiune.AddRange(dateFisier[(int)CampuriUtilizatori.Optiuni].Split(' '));
            Tara_Pref = dateFisier[(int)CampuriUtilizatori.TaraPref];
            dataRezervarii = DateTime.Parse(dateFisier[(int)CampuriUtilizatori.Data]);
        }
    }
}
