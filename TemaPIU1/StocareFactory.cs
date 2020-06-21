//Tanasa Alin Petru 3121A
using System;
using System.Configuration;

namespace TemaPIU1
{ 
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        private const string NUME_FISIE = "numefisier";
        public static IStocareData GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            var numefisier= ConfigurationManager.AppSettings[NUME_FISIE];
            return new AdministrareStudenti_FisierText(numeFisier + "." + formatSalvare,numefisier + "." + formatSalvare);
        }
    }
}
