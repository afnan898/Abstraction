using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class Elektrik : Gitar
    {
        public override void Jenis()
        {
            Console.WriteLine("Elektrik adalah salah satu jenis gitar");
            Console.WriteLine("dengan ciri ciri menggunakan kayu solid dan memerlukan listrik dan speaker agar suaranya terdengar");
        }
    }
}
