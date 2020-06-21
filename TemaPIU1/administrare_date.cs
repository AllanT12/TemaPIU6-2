//Tanasa Alin Petru 3121A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace TemaPIU1
{
    public class AdministrareStudenti_FisierText : IStocareData
    {
        private const int PAS_ALOCARE = 10;
        string NumeFisier { get; set; }
        string numefisier { get; set; }
        public AdministrareStudenti_FisierText(string numeFisier ,string Fisier)
        {
            this.NumeFisier = numeFisier;
            this.numefisier = Fisier;
            Stream sFisierText = File.Open("user.txt", FileMode.OpenOrCreate);
            Stream FisierText = File.Open("sejur.txt", FileMode.OpenOrCreate);
            sFisierText.Close();
            FisierText.Close();
        }
        public void AddUtilizator(Utilizator u,Sejur s)
        {
                using (StreamWriter swFisierText = new StreamWriter("user.txt", true))
                {
                    swFisierText.WriteLine(u.ConversieLaSir_PentruFisier());
                }
            using (StreamWriter swFisierText = new StreamWriter("sejur.txt", true))
            {
                swFisierText.WriteLine(s.ConversieLaSir_PentruFisier());
            }

        }
        public void UpdateUtilizator(Utilizator[] u,int nr,Sejur S)
        {
            var encoding = Encoding.UTF8;
            using (var stream = new FileStream(NumeFisier, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {

                stream.Position =0;
                using (var writer = new StreamWriter(stream, encoding))
                {
                    for(int z=0;z<=nr;z++)
                    writer.Write(u[z].ConversieLaSir_PentruFisierU(S));
                }
                    
            }
        }

        public void updateUtilizator(Utilizator u,int id,Sejur s)
        {
            int nr = 0;
            List<Utilizator> utilizatori = GetUtilizators();
            using (StreamWriter swFisierText = new StreamWriter("user.txt", false))
            {
                foreach (Utilizator stud in utilizatori)
                {
                    //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                    if (nr != id)
                    {
                        swFisierText.WriteLine(stud.ConversieLaSir_PentruFisier());
                    }
                    else
                    {
                        swFisierText.WriteLine(u.ConversieLaSir_PentruFisier());
                    }
                    nr++;
                }
            }
        }
        public Utilizator[] GetUtilizator(out int nrUtilizator)
        {
            Utilizator[] utilizator = new Utilizator[PAS_ALOCARE];

           
           
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    nrUtilizator = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                    string[] cuv = line.Split(' ');
                        utilizator[nrUtilizator++] = new Utilizator(Convert.ToString(cuv[0]), Convert.ToString(cuv[1]), Convert.ToInt32(cuv[2]));
                        if (nrUtilizator == PAS_ALOCARE)
                        {
                            Array.Resize(ref utilizator, nrUtilizator + PAS_ALOCARE);
                        }
                    }
                }
            

            return utilizator;
        }
        public Utilizator getUtilizator(int nrUtilizator)
        {
            Utilizator[] utilizator = new Utilizator[PAS_ALOCARE];

            int NrUtilizator=0;

            using (StreamReader sr = new StreamReader("user.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null && NrUtilizator<nrUtilizator+1)
                {
                    string[] cuv = line.Split(';');
                    utilizator[NrUtilizator] = new Utilizator(Convert.ToString(cuv[0]), Convert.ToString(cuv[1]), Convert.ToInt32(cuv[2]));
                    utilizator[NrUtilizator].Preferinta = (Preferinte)Enum.Parse(typeof(Preferinte),(cuv[3]));
                    List<string> Discipline = new List<string>();
                    Discipline.AddRange(cuv[4].Split(','));
                    utilizator[NrUtilizator].Optiune = Discipline;
                    utilizator[NrUtilizator].Tara_Pref = Convert.ToString(cuv[5]);
                    utilizator[NrUtilizator].dataRezervarii = DateTime.Parse(cuv[6]);
                    if (nrUtilizator == PAS_ALOCARE)
                    {
                        Array.Resize(ref utilizator, nrUtilizator + PAS_ALOCARE);
                    }
                    NrUtilizator++;
                }
            }


            return utilizator[nrUtilizator];
        }
        public List<Utilizator> GetUtilizators()
        {
            List<Utilizator> studenti = new List<Utilizator>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader("user.txt"))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Utilizator s = new Utilizator(line);
                        studenti.Add(s);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return studenti;
        }

        public List<Sejur> GetSejururi()
        {
            List<Sejur> studenti = new List<Sejur>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(numefisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Sejur s = new Sejur(line);
                        studenti.Add(s);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            
            return studenti;
        }

        public List<Utilizator> GetUtilizatorsbogati()
        {
            List<Utilizator> utilizators = GetUtilizators();
            List<Utilizator> bogati =new List<Utilizator>() ;
            foreach (Utilizator s in utilizators)
            {
                if (s.Buget >= 500)
                    bogati.Add(s);
            }
            return bogati;

        }
        public int GetUtilizatorssaraci()
        {
            int sum = 0;
            List<Utilizator> utilizators = GetUtilizators();
            
            foreach (Utilizator s in utilizators)
            {
                sum += s.Buget;
            }
            return sum;
        }
        public List<Utilizator> Data(DateTime date)
        {
            List<Utilizator> utilizators = GetUtilizators();
            List<Utilizator> bogati = new List<Utilizator>();
            foreach (Utilizator s in utilizators)
            {
                if (s.dataRezervarii.Date == date.Date)
                    bogati.Add(s);
            }
            return bogati;
        }
        public ArrayList GetUtilizatori()
        {
            ArrayList utilizatori = new ArrayList();
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader("user.txt"))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Utilizator u = new Utilizator(line);
                        utilizatori.Add(u);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return utilizatori;
        }
       
    }
}
