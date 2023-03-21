using System;

namespace Lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EriksNotebook eriksNotebook = new EriksNotebook();
            INotebook IeriksNoteBook = new EriksNotebook();
            eriksNotebook.Brand = "";
            eriksNotebook.FirstAcceleration();
            IeriksNoteBook.SecondAcceleration(20);
        }
    }
}
