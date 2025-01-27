using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK_01._01_Lesson_10
{
    public interface ISelectable
    {
        void OnSelect();
    }
    public interface IUpdatable
    {
        void Refresh();
    }
    public class Screen : ISelectable, IUpdatable
    {
        public void OnSelect()
        {
            Console.WriteLine("Экран выбран.");
        }
        public void Refresh()
        {
            Console.WriteLine("Экран обновлен.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
