using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._2
{
    class Mobch: Knop
    {
        
        public string symbol { get; set; }
        public string Symbols = "1234567890#*ЙЦУКЕНГШЩЗХЇФІВАПРОЛДЖЄЯЧСМИТЬБЮ";
        public string rozdilzdatnistekrany { get; set; }
        public string color { get; set; }
        public int rozmirekrany { get; set; }

        public virtual void sendsms()
        {
            Console.WriteLine("отправка смс");
        }
        public virtual void getsms()
        {
            Console.WriteLine("принимаю смс");
        }

    }
}
