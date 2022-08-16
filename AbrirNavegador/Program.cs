// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;


namespace AbrirNavegador
{

    class Program
    {

        static void Main(string[] args)
        {
            BrowserDriver browser = new BrowserDriver();
            //ChromeOptions opt = new ChromeOptions();
            browser.TarefaNavegador();

        }
    }
}