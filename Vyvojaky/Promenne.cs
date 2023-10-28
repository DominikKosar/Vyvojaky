using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyvojaky
{
    internal class Promenne
    {
        //int16, int32, int64, float, double, bool, string, char

        public Dictionary<string, Int16> Int16V = new Dictionary<string, Int16>();
        public Dictionary<string, Int32> Int32V = new Dictionary<string, Int32>();
        public Dictionary<string, Int64> Int64V = new Dictionary<string, Int64>();
        public Dictionary<string, float> FloatV = new Dictionary<string, float>();
        public Dictionary<string, double> DoubleV = new Dictionary<string, double>();
        public Dictionary<string, bool> BoolV = new Dictionary<string, bool>();
        public Dictionary<string, string> StringV = new Dictionary<string, string>();
        public Dictionary<string, char> CharV = new Dictionary<string, char>();

        public List<string> pouziteNazvy = new List<string>();



        public Promenne()
        {
            
        }

        public void VytvoritPromennou(string typ, string nazev, string hodnota)
        {
            switch (typ)
            {
                case "Int16":
                    Int16V.Add(nazev, Convert.ToInt16(hodnota));
                    break;
                case "Int32":
                    break;
                case "Int64":
                    break;
                case "Float":
                    break;
                case "Double":
                    break;
                case "Bool":
                    break;
                case "String":
                    break;
                default:
                    break;
            }
        }
    }
}
