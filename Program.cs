using System;
using ZbieraniaDanychOSzkoleniachZdalnych.Controller;

namespace ZbieraniaDanychOSzkoleniachZdalnych
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller.Controller controller = new Controller.Controller();
            controller.Uruchom();
        }
    }
}
