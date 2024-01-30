using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_S1_D2_M_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.GetNome();
            persona.GetCognome();
            persona.GetEta();
            persona.GetDettagli();
            Console.ReadLine();
        }
     }
}
