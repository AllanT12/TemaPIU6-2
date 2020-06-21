//Tanasa Alin Petru 3121A
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIU1
{
    [Flags]
    public enum Dotari
    {
        nimic=0,
        WIFI=1,
        Parcare=2,
        Restaurant=4
    }
    public enum Climat
    {
        Mediteranian = 1,
        Ecuatoriala = 2,
        Subtropical = 3,
        Subpolar = 4,
        Polar = 5
    };
    public enum Distanta
    {
        Mare=1,
        Medie=2,
        Mica=3
    };
    public enum CampuriUtilizatori
    {
        Nume=0,
        Prenume=1,
        Buget=2,
        Preferinte=3,
        Optiuni=4,
        TaraPref=5,
        Data=6
    }
    public enum Preferinte
    {
        nimic=0,
        ieftin=1,
        scump=2
    }
}
