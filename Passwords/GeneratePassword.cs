using Portfólio.ManipulateFile;
using System.Text;

namespace Portfólio.Passwords
{
    public class GeneratePassword
    {
        public string password { get; private set; }
        public void AlphaNumericPassword()
        {
            password = Guid.NewGuid().ToString().Replace("-", "").Remove(16);
            Console.WriteLine("Sua senha gerada foi: ");
            Console.WriteLine(password);
            Console.WriteLine(" ");
            Console.WriteLine("Lembre-se " +
                "suas senhas são salvas no arquivo Passwords.txt");
            FileWriter.ToSave(password);
        }
        public void SpecialCharacteres()
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string spChars = "@!#$";
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 1; x++)
                {
                    int index = random.Next(chars.Length);
                    sb.Append(chars[index]);
                }
                for (int x = 0; x < 1; x++)
                {
                    int index = random.Next(chars.Length);
                    sb.Append(chars[index]);
                }
                for (int x = 0; x < 1; x++)
                {
                    int index = random.Next(spChars.Length);
                    sb.Append(spChars[index]);
                }

            }
            password = sb.ToString();
            Console.WriteLine(password);
        }
        public void NumericPassword()
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            const string numbers = "0123456789";
            for (int i = 0; i < 8; i++)
            {
                for (int x = 0; x < 1; x++)
                {
                    int index = random.Next(numbers.Length);
                    sb.Append(numbers[index]);
                }
            }
            password = sb.ToString();
            Console.WriteLine(password);
        }
    }
}
