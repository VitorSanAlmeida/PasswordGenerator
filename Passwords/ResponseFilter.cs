namespace Portfólio.Passwords
{
    public class ResponseFilter
    {
        MainMenu password = new MainMenu();
        GeneratePassword generate = new GeneratePassword();
        public int answer { get; private set; }
        public void SaveAnswer()
        {
            password.PasswordType();
            try
            {
                Console.SetCursorPosition(3, 7);
                answer = int.Parse(Console.ReadLine());
            }

            catch (FormatException)
            {
                Console.WriteLine("Por favor, digite uma opção válida");
                Thread.Sleep(1000);
                Console.Clear();
                SaveAnswer();
            }
            catch (Exception)
            {

                Console.WriteLine("Opção inválida");
                Thread.Sleep(1000);
                Console.Clear();
                SaveAnswer();
            }
            PasswordDelivery();
        }
        public void PasswordDelivery()
        {
            switch (answer)
            {
                case 1: generate.AlphaNumericPassword(); break;
                case 2: generate.SpecialCharacteres(); break;
                case 3: generate.NumericPassword(); break;
                case 0: Environment.Exit(1); break;
                default:
                    Console.WriteLine("Por favor, escolha uma opção válida!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    SaveAnswer();
                    break;
            }
        }
    }
}
