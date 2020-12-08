using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._2
{
    class Disktel
    {
        public string Number { get; set; }
        public string Symbols = "1234567890";

        public virtual void call()
        {
            Console.WriteLine("я звоню");
        }
        public virtual void getCall()
        {
            Console.WriteLine("Я принимаю звонок");
        }
    }
}
