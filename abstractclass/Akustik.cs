using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class Akustik : Gitar
    {
        public override void Jenis()
        {
            Console.WriteLine("Akustik adalah salah satu jenis gitar");
            Console.WriteLine("dengan ciri ciri dibuat dari ada lubang ditengah gitar");
        }
    }
}
