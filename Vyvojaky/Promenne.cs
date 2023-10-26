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

        private Dictionary<string, Int16> Int16V = new Dictionary<string, Int16>();
        private Dictionary<string, Int32> Int32V = new Dictionary<string, Int32>();
        private Dictionary<string, Int64> Int64V = new Dictionary<string, Int64>();
        private Dictionary<string, float> FloatV = new Dictionary<string, float>();
        private Dictionary<string, double> DoubleV = new Dictionary<string, double>();
        private Dictionary<string, bool> BoolV = new Dictionary<string, bool>();
        private Dictionary<string, string> StringV = new Dictionary<string, string>();
        private Dictionary<string, char> CharV = new Dictionary<string, char>();

        //private List<Int16> Int16L = new List<Int16>();
        //private List<Int32> Int32L = new List<Int32>();
        //private List<Int64> Int64L = new List<Int64>();
        //private List<float> FloatL = new List<float>();
        //private List<double> DoubleL = new List<double>();
        //private List<bool> BoolL = new List<bool>();
        //private List<string> StringL = new List<string>();
        //private List<char> Charl = new List<char>();

        Promenne()
        {
            
        }

        public void VytvoritPromennou(string nazev, Enum hodnota)
        {

        }
    }
}
