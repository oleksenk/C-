using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._2
{

    
    class Knop: Disktel
    {
        public string Number { get; set; }
        public string Symbols = "1234567890#*";
        public virtual void getCallBogdan()
        {
            Console.WriteLine("Вам звонит номер:+380980196843");
        }
}
}
