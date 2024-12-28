using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGitExample
{
    internal class Program
    {
        //константы ходов
        const string ROCK = "Камень";
        const string PAPER = "Бумага";
        const string SCISSORS = "Ножницы";

        static void Main(string[] args)
        {
            Console.Write("Ваш ход: ");
            string userStep = Console.ReadLine();
            string pcStep = GetRandomStep();
            Console.WriteLine($"Ваш ход - {userStep}\nХод компьютера - {pcStep}");
            Console.WriteLine($"Итог игры - {GetTheWinner(userStep, pcStep)}");



        }


        //ф-я рандомно возвращает один из ходов: камень, ножницы или бумагу
        static string GetRandomStep()
        {
            string[] steps = new string[3] { ROCK, PAPER, SCISSORS };
            int index = new Random().Next(0, 3);
            return steps[index];
        }

        //ф-я определяет, кто выиграл
        static string GetTheWinner(string userStep, string pcStep)
        {
            //константы результатов игры
            const string DRAW = "Ничья";
            const string USERWIN = "Вы выиграли";
            const string PCWIN = "Выиграл компьютер";


            if(userStep == pcStep)
            {
                return DRAW;
            }

            if (userStep == ROCK)
            {
                if(pcStep == PAPER)
                {
                    return PCWIN;
                }
                else
                {
                    return USERWIN;
                }
            }
            else if(userStep == PAPER)
            {
                if(pcStep == SCISSORS)
                {
                    return PCWIN;
                }
                else
                {
                    return USERWIN;
                }
            }
            else
            {
                if(pcStep == ROCK)
                {
                    return PCWIN;
                }
                else
                {
                    return USERWIN;
                }
            }
        }
    }
}
