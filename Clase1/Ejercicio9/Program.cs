using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que imprima por pantalla una pirámide como
            //la siguiente:
            //*
            //***
            //*****
            //*******
            //*********

            string character = "*";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(character);
                character += "**";
            }
            Console.ReadKey();
        }
    }
}
