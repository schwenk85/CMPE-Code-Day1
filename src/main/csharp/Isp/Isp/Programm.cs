using System;

namespace Isp
{
    public class Programm
    {
        public static void Main2(string[] args)
        {
            var deTranslator = TranslatorFactory.CreateTranslator(Language.De);

            Console.WriteLine("Translating english to german.");
            Console.WriteLine("Supported words so far: \n" +
                              "dog, cat, house, duck.");
            Console.WriteLine("Please enter text to translate - line by line:");

            while (true)
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;
                Console.WriteLine("Translation: \n" + deTranslator.Translate(line));
            }
        }

        public static void Main(string[] args)
        {
            var fileTranslator = new GermanFileTranslator();

            Console.WriteLine("Type file name:");
            var filename = Console.ReadLine();

            if (fileTranslator.FileExists(filename))
            {
                var filetext = fileTranslator.LoadFile(filename);

                Console.WriteLine("\r\nFile content:");
                Console.WriteLine(filetext);

                Console.WriteLine("\r\nTranslations:");
                foreach (string word in filetext.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None))
                {
                    Console.WriteLine(fileTranslator.Translate(word));
                }
            }
            Console.ReadLine();
        }
    }
}