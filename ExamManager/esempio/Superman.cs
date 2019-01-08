using System;
using System.Collections.Generic;
using System.Text;

namespace ExamManager.esempio
{
    class Superman : Person, Superhero
    {
        void Person.Run()
        {
            Console.WriteLine("chiano chiano...");
        }

        public void Run()
        {
            Console.WriteLine("piu veloce della luce");
        }
    }
}
