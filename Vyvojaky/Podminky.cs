using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CSharp;


namespace Vyvojaky
{
    public class Podminky
    {
        
        Podminky(int prom1, int prom2, string operatory) 
        {
            porovnani(prom1, prom2, operatory);
            
        }

        public void hledaniPromennych(string promena1) 
        {
            short promena2 = 1;
            if (Int16V.TryGetValue(promena1, out promena2))
            {
                Debug.Write(promena2);
            }
            else
            {
                Debug.Write("Chyba");
            }
            
        }
        
        public void porovnani(int prom1, int prom2, string operatory) 
        {
            
            switch (operatory)
            {
                case ">":
                    if (prom1 > prom2)
                    {

                    }
                    break;
                case "<":
                    if (prom1 < prom2)
                    {

                    }
                    break;
                case ">=":
                    if (prom1 >= prom2)
                    {

                    }
                    break;
                case "<=":
                    if (prom1 <= prom2)
                    {

                    }
                    break;
                case "==":
                    if (prom1 == prom2)
                    {

                    }
                    break;
                case "!=":
                    if (prom1 != prom2)
                    {
                        
                    }
                    break;
                default:
                    break;

            }
        }


        public Podminky() 
        { 
            
        }
    }
}
