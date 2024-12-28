using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGitExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш ход: ");
            
        }


        //ф-я рандомно возвращает один из ходов: камень, ножницы или бумагу
        static string GetRandomStep()
        {
            string[] steps = new string[3] { "Камень", "Бумага", "Ножницы" };
            int index = new Random().Next(0, 3);
            return steps[index];
        }
    }
}
