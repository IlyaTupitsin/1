internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            StreamReader fin = new StreamReader("C:\\Users\\Пользователь\\Desktop\\urok.xml");
            int c;
            while ((c = fin.Read()) != -1)
            {
                Console.Write((char)c);
            }
            fin.Close();
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}