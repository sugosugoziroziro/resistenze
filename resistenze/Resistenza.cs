using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resistenze
{
    internal class Resistenza
    {
        public double Valore { get; set; }
        public List<Colore> Colori { get; set; }
        Resistenza(double v) 
        {
            Valore = v;
        }
        public static Resistenza operator & (Resistenza r1, Resistenza r2)
        {
            return new Resistenza(r1.Valore + r2.Valore);
        }
        public static Resistenza operator|(Resistenza r1, Resistenza r2)
        {
            return new Resistenza(1/(1/r1.Valore + 1/r2.Valore));
        }
        public static bool operator <(Resistenza r1, Resistenza r2)
        {
            return (r1.Valore<r2.Valore);
        }
        public static bool operator >(Resistenza r1, Resistenza r2)
        {
            return (r1.Valore > r2.Valore);
        }
        public static bool operator ==(Resistenza r1, Resistenza r2)
        {
            if (Object.ReferenceEquals(r1, null))
            {
                if (Object.ReferenceEquals(r2, null))
                {
                    return true;
                }
                return false;
            }
            else if (Object.ReferenceEquals(r2, null))
            {
                return false;// r1 esiste
            }
            else
                return (r1.Valore ==r2.Valore);

        }
        public static bool operator !=(Resistenza r1, Resistenza r2)
        {
            if (r1 == r2)
            {
                return false;
            }
            else
                return true;
        }
        public Resistenza ParseColore(string s)
        {
            if (s == "blu")
            {
                return new Resistenza(10E+6);
            }
            else if (s == "red")
            {
                return new Resistenza(10E+2);
            }
            else
                return new Resistenza(10E+4);
        }
        public Resistenza ParseValore(string s)
        {
            return new Resistenza(double.Parse(s));
        }

    }
}
