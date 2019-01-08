using ExamManager.closure;
using ExamManager.esempio;
using System;

namespace ExamManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dbSource = new DBDataSource();
            //var proc = new DataProcessor(dbSource);

            Person p = new Superman();
            p.Run();
            Superhero sh = new Superman();
            sh.Run();
            Superman sp = new Superman();
            sp.Run();



            //var path = @"C:\data\Studenti.csv";
            ////var UI = new UserInterface(proc);
            ////var  UI = new UserInterface(new DataProcessor(new FileDataSource(path)));
            //var UI = new UserInterface(new DataProcessor(new DBDataSource()));
            //UI.MainMenu();


        }
    }
}
