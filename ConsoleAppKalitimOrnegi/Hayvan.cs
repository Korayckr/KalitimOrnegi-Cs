using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKalitimOrnegi
{

    // Hayvan ismi verilen sınıfta daha öncekilerde oldupu gibi methodlar ve değişkenler tanımlandı.
    // Farklı olarak yaş nesnesinin erişim belirleyicisi private olarak tanımlandı.
    public class Hayvan
    {
        public string hayvanName;
        public string hayvanGender;
        private int hayvanYas;

        public void hayvanInfo()
        {
            string hayvan = "Hayvanın İsmi: " + hayvanName + "Hayvanın Cinsiyeti: " + hayvanGender;
                

            Console.WriteLine(hayvan);


        }

    }
}


