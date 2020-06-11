using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class Ukulele : Gitar
    {
        public override void Jenis()
        {
            Console.WriteLine("Adalah salah satu jenis gitar");
            Console.WriteLine("dengan ciri ciri body yg lebih kecil dan hanya mempunyai 4 senar");
        }
    }
}
