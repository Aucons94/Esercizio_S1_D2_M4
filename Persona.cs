using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_S1_D2_M_4
{
    internal class Persona
    {
        private String _nome, _cognome;
        private int _eta;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }
        public int Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                _eta = value;
            }
        }
        public void GetNome()
        {
            Console.WriteLine("Inserire il nome della persona: ");
            _nome = Console.ReadLine();
        }
        public void GetCognome()
        {
            Console.WriteLine("Inserire il cognome della persona: ");
            _cognome = Console.ReadLine();
        }
        public void GetEta()
        {
            Console.WriteLine("Inserire l'età della persona: ");
            _eta = int.Parse(Console.ReadLine());
        }
        public void GetDettagli()
        {
            Console.WriteLine($"La persona è: \n - Nome: {Nome} \n - Cognome: {Cognome} \n - Età: {Eta} \n");
        }
    }
}
