using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace os_vjezba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to File Editor x.1.0.\n");
            int input=10;

            while (input != 0)
            {
                Console.WriteLine("LISTING_________Input (1) to enter a folder path to list of files in folder\n");
                Console.WriteLine("PATH CREATION___Input (2) to enter a path to a folder you want to create\n");
                Console.WriteLine("FILE CREATION___Input (3) to enter a name of file you wish to create\n");
                Console.WriteLine("READ FILE_______Input (4) to read a file\n");
                Console.WriteLine("WRITE FILE______Input (5) to write in a text file\n");
                Console.WriteLine("SYSTEM INFO_____Input (6) to output system info");
                Console.WriteLine("CLS_____________Input (7) to clear screen");
                Console.WriteLine("QUIT            Input (0) to exit File Editor x.1.0.\n");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        SystemInfo();
                        break;
                    case 7:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Goodbye! :)");
                        break;
                }
            };

            //Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            //using (StreamReader sr = new StreamReader("TestFile.txt"))
            //{
            //    string line;
            //    // Read and display lines from the file until the end of 
            //    // the file is reached.
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //    sr.Close();
            //}

            //string path = @"C:\Users\Kukec\Documents\Škola\4 Semestar\OS\os vjezba 1\TestFile.txt";
            //try
            //{
            //    if (!File.Exists(path))
            //    {
            //        File.Create(path);
            //        TextWriter tw = new StreamWriter(path);
            //        tw.WriteLine("The very first line!");
            //        tw.Close();
            //    }
            //    else if (File.Exists(path))
            //    {
            //        TextWriter tw = new StreamWriter(path);
            //        tw.WriteLine("The next line!");
            //        tw.Close();
            //    }
            //}
            //catch (Exception e)
            //{
            //    // Let the user know what went wrong.
            //    Console.WriteLine("Wrong directory");
            //    Console.WriteLine(e.Message);

            //}



            //try
            //{
            //    // Create an instance of StreamReader to read from a file.
            //    // The using statement also closes the StreamReader.
            //    using (StreamReader sr = new StreamReader("TestFile.txt"))
            //    {
            //        string line;
            //        // Read and display lines from the file until the end of 
            //        // the file is reached.
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    // Let the user know what went wrong.
            //    Console.WriteLine("The file could not be read:");
            //    Console.WriteLine(e.Message);
            //}
            Console.ReadKey();
        }

        public static void SystemInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine(
                        "  Available space to current user:{0, 15} bytes",
                        d.AvailableFreeSpace);

                    Console.WriteLine(
                        "  Total available space:          {0, 15} bytes",
                        d.TotalFreeSpace);

                    Console.WriteLine(
                        "  Total size of drive:            {0, 15} bytes ",
                        d.TotalSize);
                    /* 
                    This code produces output similar to the following:

                    Drive A:\
                    Drive type: Removable
                    Drive C:\
                    Drive type: Fixed
                    Volume label: 
                    File system: FAT32
                    Available space to current user:     4770430976 bytes
                    Total available space:               4770430976 bytes
                    Total size of drive:                10731683840 bytes 
                    Drive D:\
                    Drive type: Fixed
                    Volume label: 
                    File system: NTFS
                    Available space to current user:    15114977280 bytes
                    Total available space:              15114977280 bytes
                    Total size of drive:                25958948864 bytes 
                    Drive E:\
                    Drive type: CDRom

                    The actual output of this code will vary based on machine and the permissions
                    granted to the user executing it.
                    */
                }
            }
        }
    }
    

}
