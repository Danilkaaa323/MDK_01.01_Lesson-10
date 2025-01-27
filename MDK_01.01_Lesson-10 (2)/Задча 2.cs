using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK_01._01_Lesson_10__2_
{
    public abstract class Translator
    {
        public abstract string GetLanguage();
        public abstract void Translate(string text); 
    }
    public class EnglishTranslator : Translator
    {
        public override string GetLanguage()
        {
            return "английского";
        }
        public override void Translate(string text)
        {
            Console.WriteLine($"Перевод с английского: {text}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Translator englishTranslator = new EnglishTranslator();
            Console.WriteLine("Я переводчик с " + englishTranslator.GetLanguage());
        }
    }
}
