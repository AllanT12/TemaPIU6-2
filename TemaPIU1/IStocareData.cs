//Tanasa Alin Petru 3121A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace TemaPIU1
{
   public interface IStocareData
    {
        void AddUtilizator(Utilizator u,Sejur s);
        Utilizator[] GetUtilizator(out int nrUtilizatori);
        Utilizator getUtilizator(int nrUtilizator);
        List<Utilizator> GetUtilizators();
        List<Sejur> GetSejururi();
        ArrayList GetUtilizatori();
        void UpdateUtilizator(Utilizator[] u,int nr,Sejur s);
        void updateUtilizator(Utilizator u,int id, Sejur s);
        List<Utilizator> GetUtilizatorsbogati();
        int GetUtilizatorssaraci();
        List<Utilizator> Data(DateTime dat);
    }
}
