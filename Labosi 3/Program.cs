using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labosi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadatak1
            //DataSet dataset = new DataSet();
            //var newdataset = dataset.Clone();
            //dataset.LoadDataFromCSV(@"C:\Users\Mario Matić\source\repos\Labosi 3\Labosi 3\bin\Debug\cvs");
            //Console.WriteLine(dataset.PrintList());



            //Zadatak2
            //double[][] matrix = Matrix.GetInstance().GenerateMatrix(5, 5);
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matrix[i][j].ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}



            //Zadatak3
            //Logger.GetInstance().LogToFile("\nMario Matić, sensas team");



            //Zadatak4
            ConsoleNotification notification = new ConsoleNotification("Mario", "Sensas", "Uklija se najbolje lovi razmućenom hranom", DateTime.Now, Category.ALERT, ConsoleColor.DarkYellow);
            NotificationManager manager = new NotificationManager();
            manager.Display(notification);//
        }
    }
}


