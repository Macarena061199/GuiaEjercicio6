using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

ConsoleKeyInfo key;
Console.TreatControlCAsInput = true;
Console.WriteLine("Por favor presione cualquier tecla. ");
Console.WriteLine("Si desea salir presione Shift+Ctrl+F.");

do
{
    key = Console.ReadKey();
    Console.WriteLine();

    if ((key.Key == ConsoleKey.F) &&
        ((key.Modifiers & ConsoleModifiers.Control) != 0) && ((key.Modifiers & ConsoleModifiers.Shift) != 0))
    {
        break;
    }

} while (true);
