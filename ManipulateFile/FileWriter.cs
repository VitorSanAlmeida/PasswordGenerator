using Portfólio.Passwords;

namespace Portfólio.ManipulateFile
{
    public class FileWriter
    {
        public static void ToSave(string password)
        {
            StreamWriter streamWriter = new StreamWriter("C:\\PasswordGenerator\\Passwords.txt", true);
            streamWriter.WriteLine($"Senha gerada em: {DateTime.Now}");
            streamWriter.WriteLine("Senha: ");
            streamWriter.WriteLine(password);
            streamWriter.WriteLine("====================================================================");
            streamWriter.Close();
        }
    }
}
