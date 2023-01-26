using Portfólio.ModifiedScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfólio
{
    public class MainMenu
    {
        public void PasswordType()
        {
            DrawnScreen.Drawn();
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Escolha o tipo da senha: ");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("1 - Padrão alfanumérico.");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("2 - Senha com caracteres especiais (Recomendado).");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("3 - Senha numérica.");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("0 - Sair");
        }
    }
}
