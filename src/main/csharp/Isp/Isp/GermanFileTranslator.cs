using System;
using System.Collections.Generic;
using System.IO;

namespace Isp
{
    public class GermanFileTranslator : ITranslator, IFileLoader
    {
        private readonly Dictionary<string, string> dict = new Dictionary<string, string>();

        public GermanFileTranslator()
        {
            dict.Add("cat", "Katze");
            dict.Add("dog", "Hund");
            dict.Add("house", "Haus");
            dict.Add("duck", "Ente");
        }

        public string Translate(string text)
        {
            return dict.ContainsKey(text) ? dict[text] : text;
        }

        public string LoadFile(string filename)
        {
            return File.ReadAllText(filename);
        }

        public bool FileExists(string filename)
        {
            return File.Exists(filename);
        }
    }
}