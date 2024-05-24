using Coursework.Forms;
using Coursework.Models;

namespace Coursework
{
    internal static class Program
    {

        //Шеф - кухар.База рецептур страв: розкладка, рецепт приготування.
        //База продуктів на складі: найменування, ціна, кількість, термін
        //придатності. Формування меню на день (на задане число персон). Пропозиція
        //страви дня з урахуванням запасів продуктів.Перевірка достатності запасів; 
        //формування видаткової накладної на склад, коригування запасів.

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}