using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace Herencias
{

    class program
    {


        static void Main(string[] args)
        {

            Clasehija1 Herencia = new Clasehija1();
            Herencia.Saludar();
            Herencia.Nombre();
            Herencia.Edad();
          
            Herencia.Despedirse();

           
             
            Console.ReadKey();
        }
    }
}
