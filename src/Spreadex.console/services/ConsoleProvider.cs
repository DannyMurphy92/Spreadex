using Spreadex.console.services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spreadex.console.services;
public class ConsoleProvider : IConsoleProvider
{
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }
}
