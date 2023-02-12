using System;
using System.IO;

namespace BitFlipper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the source file path: ");
            string sourceFilePath = Console.ReadLine();
            Console.WriteLine("Enter the destination file path: ");
            string destinationFilePath = Console.ReadLine();

            try
            {
                byte[] bytes = File.ReadAllBytes(sourceFilePath);
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)~bytes[i];
                }
                File.WriteAllBytes(destinationFilePath, bytes);
                Console.WriteLine("File flip complete. Check destination path for the flipped file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}