using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojlLV3
{
    class Program
    {
        static void Main(string[] args)
        {   //prvi zadatak
            Dataset dataset = new Dataset();
            Dataset clone = new Dataset();
            dataset.LoadDataFromCSV("csvfile.txt");
            clone = (Dataset)dataset.Clone();
            Console.WriteLine(clone.PrintList());
            Console.WriteLine(dataset.PrintList());


            //drugi zadatak
            double[][] matrix = MatrixGenerator.GetInstance().GenerateMatrix(5, 5);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i][j].ToString()+" ");
                }
                Console.WriteLine();
            }

            //treci
            Logger.GetInstance().LogToFile("\nDobar dan!");

            //cetvrti
            ConsoleNotification notification = new ConsoleNotification("leon", "mvp", "nani", DateTime.Now, Category.INFO, ConsoleColor.White);
            NotificationManager manager = new NotificationManager();
            manager.Display(notification);
        }
    }
}
