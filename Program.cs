namespace Assignment2._3._1
{
    using System.IO;

    internal class Program
    {
        static void Main(string[] args)
        {
            string lineJustRead;
            try
            {
                var writer = new StreamWriter("C:\\MSSA-CCAD14\\Write Example.txt");
                writer.WriteLine("Name: Ted Collins");
                writer.WriteLine("Age: 46");
                writer.WriteLine("Address: 1600 Pennsylvania Ave NW, Washington, DC 20500");
                writer.Close();

                var reader = new StreamReader("C:\\MSSA-CCAD14\\Write Example.txt");
                do
                {
                    lineJustRead = reader.ReadLine();
                    Console.WriteLine(lineJustRead);
                } while (lineJustRead != null);
                reader.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
