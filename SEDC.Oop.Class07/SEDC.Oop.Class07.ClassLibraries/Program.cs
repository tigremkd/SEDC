using SEDC.Oop.Class07.Services;
using SEDC.Oop.Class07.Models;
using System;


namespace SEDC.Oop.Class07.ClassLibraries
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpoyeeService employeeService = new EmpoyeeService();
            employeeService.CreateObjectAndWriteInConsole();
        }
    }
}
