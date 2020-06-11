using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//using Abstraction.Interface jika menggunakan interface   
using Abstraction.AbstractClass; 


namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {

            Gitar gitar;                     //menggunakan abstact classs
	    gitar = new Akustik(); 
            gitar.Jenis();

            Console.WriteLine();
            gitar = new Elektrik();
            gitar.Jenis();           

            Console.WriteLine();
            gitar = new Ukulele();
            gitar.Jenis();



	    /* IGitar gitar;                     //menggunakan interface
	    gitar = new Akustik(); 
            gitar.Jenis();

            Console.WriteLine();
            gitar = new Elektrik();
            gitar.Jenis();           

            Console.WriteLine();
            gitar = new Ukulele();
            gitar.Jenis(); */


            Console.ReadKey();
        }
    }
}
