﻿
using System;



namespace events_filewatcher

{

    class Program

    {

        static void Main(string[] args)

        {

            System.IO.FileSystemWatcher w =

                new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");

            w.EnableRaisingEvents = true;

            //w.Changed += W_Changed;

            w.Created += (s, e) => { Console.WriteLine(e.ChangeType + " " + e.FullPath); };

            w.Renamed += (s, e) => { Console.WriteLine(e.ChangeType + " " + e.FullPath + " old name " +e.OldName); };

            w.Deleted += (o, e) => { Console.WriteLine(e.ChangeType + " " + e.FullPath); };

            do { } while (true);

        }

        //private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)

        //{

        //    Console.WriteLine(e.Name);

        //}

    }

}