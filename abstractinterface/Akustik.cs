using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.Interface
{
    public class Akustik : IGitar
    {
        public void Jenis()
        {
            Console.WriteLine("Akustik adalah salah satu jenis gitar");
            Console.WriteLine("dengan ciri ciri dibuat dari ada lubang ditengah gitar");
        }
    }
}
