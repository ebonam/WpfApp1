using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace code.bdd.cmdVlep
{
    class VlepCmd
    {

        //Gâteaux pépites de chocolat Pépito Pépito 317241 24378 3048282900646  1.0 le paquet de 5 - 150 g 1,01€ 1,01€ 
        public static List<string> Test(string sdsf)
        {
            //List<ProductVlep> d = new List<string>();
            var  d = new List<string>();
            var liness = Regex.Matches(sdsf, "\\n");
            foreach (Match l in liness)
            {/*

                ([0-9]{13}) gencode
\[0-9]+,[0-9]+€ \ prix
[0-9]+\.[0-9] quantité


                */
                //l.
           //     d.Add(l.Value.Replace("^FS", "").Replace("^FD", ""));
            }
                return d;
        }
    }
}
