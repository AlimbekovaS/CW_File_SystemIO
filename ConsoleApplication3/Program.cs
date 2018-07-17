using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream(@"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\Alimbekova.txt", FileMode.Create);


            
          //  Random rnd = new Random();


            string filePath = @"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\Saltanat.txt";
            Console.WriteLine(filePath);

            filePath= @"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\Konstantin\Konstantin_0.txt";
            Console.WriteLine("----------------");
            int i = 0;
            using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
               
            {
                //char[] array = new char[4];
                //sr.Read(array, 0, 4);

                //foreach (var item in array)
                //{
                //    Console.WriteLine(item);
                //}

                //string line;
                //while ((line=sr.ReadLine())!=null)
                //{
                //    Console.WriteLine("{0}-{1}", i++, line);
                //}
            }
            filePath = @"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\Konstantin\Konstantin_" + DateTime.Now.Millisecond+".txt";

            var f = File.Create(filePath);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                for (int h = 0; h < DateTime.Now.Hour; h++)
                {
                    sw.WriteLine();
                }
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                DirectoryInfo dir = new DirectoryInfo(@"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11");
                DirectoryInfo[] dirSw = dir.GetDirectories();
                foreach (FileInfo fileFolder in dirSw)
                {
                    
                    string user
                }
            }


            //DirectoryInfo dir = new DirectoryInfo(".");
            //dir.CreateSubdirectory("test");

            //dir = new DirectoryInfo(filePath + @"NEW_FOLDER_2+ZUK");
            //dir.Create();

            //DirectoryInfo dir = new DirectoryInfo(filePath);
            //DirectoryInfo[] dirs = dir.GetDirectories();
            //foreach (DirectoryInfo folder in dirs)
            //{
            //    Console.WriteLine(folder.Name);
            //    Console.WriteLine(folder.FullName);
            //    foreach (FileInfo fileFolder in folder.GetFiles())
            //    {
            //        Console.WriteLine("-->"+fileFolder.Name);
            //    }
            //}

            //_
            //FileInfo file = new FileInfo(filePath);
            //if(!file.Exists)
            //{

            //    Console.WriteLine("-");
            //    Console.WriteLine(file.Name);
            //    Console.WriteLine(file.Length);
            //    Console.WriteLine(file.Extension);

            //    //filePath= @"\\dc\Студенты\ПКО\SMB-172.1\C#\Модуль 11\zuk Move\Saltanat" , FileMode.Create);
            //    ////zuk Move
            //    //file.MoveTo()
            //}
            //else
            //{
            //    var data = file.Open(FileMode.OpenOrCreate);
            //    Console.WriteLine("Work");
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("File create!");




            //    fs.Close();
            //}

            //    using (FileStream fs = new FileStream(filePath, FileMode.Create))
            //{

            //}

            // FileStream fs2 = new FileStream(fileRath, FileMode.Create, FileAccess.Write);

            //using (FileStream fs3 = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Read))
            //{
            //    Console.WriteLine(filePath);
            //    Thread.Sleep(5000000);
            //    var test = 555;
            //}

        }
    }
}
