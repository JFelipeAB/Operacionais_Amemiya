using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperacionaisTI
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu_Iniciar();
            Console.WriteLine("Encerrando");
            Console.ReadLine();
            
        }
        static void Menu_Iniciar()        
            {
            Console.WriteLine("Operacionais TI/n");
            Console.WriteLine("Selecione a operação desejava\n1 - Relatorio Controle de impressões\n2 - Em breve");
            int op = Convert.ToInt16(Console.ReadLine());

        }
    }
}
