using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Transactions;
using System.Linq.Expressions;
using System;
using System.Windows;
using Microsoft.Win32;
using System.Reflection;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Security;
using System;
using System.Collections;
using System.Collections.Specialized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System;
using System.CodeDom.Compiler;
using System.IO;
using Microsoft.CSharp;
using System.Drawing;

public class Program
{

    static void Main(string[] args)
    {
        if (!File.Exists(@"C:\ProgramData\BSC-DOS\Logininfo.txt"))
        {
            Directory.CreateDirectory(@"C:\ProgramData\BSC-DOS");
            File.WriteAllText(@"C:\ProgramData\BSC-DOS\Logininfo.txt", "admin" + Environment.NewLine + "1234" + Environment.NewLine + "DarkCyan" + Environment.NewLine + "DarkCyan" + Environment.NewLine + "Black" + Environment.NewLine + 120 + Environment.NewLine + 30);
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("BSC-DOS has been set up! Please re-open the code to run BSC-DOS! Or endure this music.");
                Console.Beep(1000, 500);
                Console.Beep(900, 500);
                Console.Beep(1200, 500);
            }
        }
        string Username;
        string Password;
        string ColorSet;
        string HighlightcolorSet;
        if (File.Exists(@"C:\\ProgramData\\BSC-DOS\Logininfo.txt"))
        {
            try
            {
                Username = File.ReadLines(@"C:\\ProgramData\\BSC-DOS\Logininfo.txt").ElementAtOrDefault(0);
                Password = File.ReadLines(@"C:\\ProgramData\\BSC-DOS\Logininfo.txt").ElementAtOrDefault(1);
                ColorSet = File.ReadLines(@"C:\\ProgramData\\BSC-DOS\Logininfo.txt").ElementAtOrDefault(2);

                HighlightcolorSet = File.ReadLines(@"C:\\ProgramData\\BSC-DOS\Logininfo.txt").ElementAtOrDefault(3);
                string Height = File.ReadLines(@"C:\\ProgramData\\BSC-DOS\Logininfo.txt").ElementAtOrDefault(6);
                string Width = File.ReadLines(@"C:\\ProgramData\\BSC-DOS\Logininfo.txt").ElementAtOrDefault(5);
                int WIdth = int.Parse(Width);
                int HEight = int.Parse(Height);
                Console.SetWindowSize(WIdth, HEight);
            }
            catch (Exception e)
            {
                Console.Beep(1000, 1000);
                Username = "LOGIN ERR";
                Password = "LOGIN ERR";
                ColorSet = "DarkCyan";
                HighlightcolorSet = "Black";

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.SetWindowSize(90, 20);
                Console.WriteLine("The error {0} occured", e);
                Console.WriteLine("BSC-DOS will now attempt to find an error.");
                Thread.Sleep(1000);

                Console.Beep();
                if (File.Exists(@"C:\\ProgramData\\BSC-DOS\Logininfo.txt"))
                {
                    Console.Beep();
                    Console.WriteLine("BSC-DOS has found an issue with your coppy:");
                    Console.WriteLine("The config files for BSC-DOS are either out of date or corrupted");
                    Console.WriteLine("BSC-DOS will have to erase all of its memorised data, press E to proceed");
                    while (Console.ReadKey(true).Key != ConsoleKey.E)

                        Console.Beep();
                    {
                        Thread.Sleep(0);
                    }

                    Console.Beep();
                    Console.WriteLine("BSC-DOS will now erase its files. You will be prompted on boot to set up BSC-DOS");
                    File.Delete(@"C:\\ProgramData\\BSC-DOS\Logininfo.txt");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
                else
                {
                    if (System.Environment.OSVersion.Platform == PlatformID.Win32NT)
                    {

                        Console.Beep();
                        Console.WriteLine("BSC-DOS was designed to be run on Windows 7 (NT) and above.");
                        Console.WriteLine("Your machine does not meet this requirement.");
                        Console.WriteLine("Press any key to exit BSC-DOS");
                        Console.ReadKey(false);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("BSC-DOS has failed to detect an error on your machine, attempting to continue boot.");

                    }
                }
            }
        }
        else
        {
            Username = "NO_LOGIN";
            Password = "NO_LOGIN";
            ColorSet = "DarkCyan";
            HighlightcolorSet = "Black";
            Console.SetWindowSize(120, 30);
        }
        int AR = 3;
        int ARTEMP = 3;
        bool logincorr = false;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Beep();
        Console.Write("Welcome to");
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(" BSC");
        Console.ForegroundColor = ConsoleColor.Blue;
        DoStuff();
        Console.Write("-DOS");
        Console.Beep();
        Console.WriteLine();
        int mode = 0;
        int w = Console.WindowWidth;
        int h = Console.WindowHeight;
        if (!(Username.Equals("admin") & Password.Equals("1234")))


        {
            Console.WriteLine("Please type your username and password or type HELP to get a list of options");
            while (logincorr == false)
            {
                Console.Write("");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (mode == 0)
                {
                    Console.Write("");
                    Console.Write("Username:");
                }
                else
                {
                    Console.Write("");
                    Console.Write("Password:");
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                string UItemp = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (UItemp == Password || UItemp == Username)
                {

                    if (mode == 0)
                    {
                        Console.Beep();
                        Console.WriteLine("Welcome " + Username + " Now please enter your password.");

                        Console.Beep();
                        mode++;
                    }
                    else
                    {
                        if (UItemp == Password)
                        {

                            Console.Beep();
                            Console.WriteLine("Correct credentials, press any key to continue to BSC-DOS");

                            Console.Beep();
                            Console.ReadKey(false);
                            logincorr = true;
                            break;
                        }
                        else
                        {

                            Console.Beep();
                            Console.WriteLine("Invalid form, please enter the current requested information.");

                            Console.Beep();
                        }
                    }


                }
                else
                {
                    if (UItemp.ToUpper() == "SKIP")
                    {
                        Console.WriteLine("Skipping Login");
                    }
                    else
                    {
                        if (UItemp.ToUpper() == "NEWPW")
                        {
                            Console.WriteLine("Confirm Y/n");
                            string Ynlp = Console.ReadLine();
                            if (Ynlp.ToUpper() == "Y")
                            {
                                Console.WriteLine("Please enter your prevous password");
                                string OLDPW = Console.ReadLine();
                                if (OLDPW == Password)
                                {
                                    Console.WriteLine("Enter your new password");
                                    string NEWPW = Console.ReadLine();
                                    Console.WriteLine("Enter your new username");
                                    string NEWUN = Console.ReadLine();

                                    string filePath = @"C:\ProgramData\BSC-DOS\Logininfo.txt";

                                    var lines = File.ReadAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt"); // read all lines into an array
                                    lines[0] = lines[0].Replace(lines[0], NEWUN); // replace the first line with *
                                    lines[1] = lines[1].Replace(lines[1], NEWPW); // replace the second line with *
                                    File.WriteAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt", lines); // write all lines back to the file
                                    Username = NEWUN;
                                    Password = NEWPW;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid key");
                                    return;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Request canceled");
                                return;
                            }
                        }
                        else
                        {
                            if (UItemp.ToUpper() == "HELP")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("BSC-DOS Login help:");
                                DoStuff();
                                Console.WriteLine("Showing allowed command list:");
                                DoStuff();
                                Console.WriteLine();
                                Console.WriteLine("NEWPW - set a new password");
                                DoStuff();
                                Console.WriteLine("SKIP - skip the login process");
                                DoStuff();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                            }
                            else
                            {
                                ARTEMP = AR;
                                AR = ARTEMP - 1;
                                if (AR > 0)
                                {
                                    string MD = "";
                                    if (mode == 0)
                                    {
                                        MD = ("Username");
                                    }
                                    else
                                    {
                                        MD = ("Password");
                                    }
                                    if (AR > 1)
                                    {
                                        Console.WriteLine("Incorrect {0} " + AR + " attempts remaining", MD);
                                    }
                                    else
                                    {

                                        Console.WriteLine("Incorrect {0} " + AR + " attempt remaining", MD);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You have 0 attempts remaining press any key to exit");
                                    Console.ReadKey(false);
                                    Environment.Exit(0);
                                }
                            }
                        }
                    }
                }
            }
            if (true)
            {
                Username = "NO_LOGIN";
                Password = "NO_LOGIN";
            }
        }
        else
        {
            Console.WriteLine("Welcome new user! to BSC-DOS! Before you begin to enjoy this software we need some info.");
            Console.WriteLine("Press E to skip setup. You will be prompted next time. To continue dont press e press something else");
            char name = Console.ReadKey().KeyChar;
            if (name == 'E' || name == 'e')
            {
                Console.WriteLine("Continuing to BSC-DOS temporary settings have been chosen.");
            }
            else
            {
                Console.WriteLine("Enter your desired username:");
                string NEWUN = Console.ReadLine();
                Console.WriteLine("Enter your desired password:");
                string NEWPW = Console.ReadLine();

                string filePath = @"C:\ProgramData\BSC-DOS\Logininfo.txt";

                var lines = File.ReadAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt"); // read all lines into an array
                lines[0] = lines[0].Replace(lines[0], NEWUN); // replace the first line with *
                lines[1] = lines[1].Replace(lines[1], NEWPW); // replace the second line with *
                File.WriteAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt", lines); // write all lines back to the file
                Console.WriteLine("Excellent! Now please choose your desired text color. You can change this at any time.");
                Console.WriteLine("Your options are: ");
                Console.WriteLine("Yellow, DarkYellow, Red, DarkRed, Blue, DarkBlue, Cyan");
                Console.WriteLine("DarkCyan, Green, DarkGreen, Magenta, DarkMagenta, White, Black");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!INSERT EXACT TEXT INCLUDING CAPITALS!");
                NEWUN = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Now enter a desired background (black is reccomended) you can change this at any time also.");
                NEWPW = Console.ReadLine();

                lines = File.ReadAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt"); // read all lines into an array
                lines[2] = lines[2].Replace(lines[2], NEWUN); // replace the first line with *
                lines[3] = lines[3].Replace(lines[3], NEWPW); // replace the second line with *
                File.WriteAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt", lines); // write all lines back to the file
            }



        }



        ConsoleColor color = ConsoleColor.DarkCyan;
        color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), ColorSet);


        string Warnings = null;
        try
        {
            Console.SetWindowSize(w, h);
        }
        catch (Exception e)
        {
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), HighlightcolorSet);

        }
        int UNDAT = 0;
        int PWDAT = 0;
        int CSDAT = 0;
        int HLCDAT = 0;
        String uno = "Zero";
        String Highlightcolor = "Black";
        String COLORREAD = "Blue is cuel";

        String Command = "NA";

        Boolean Worked = false;

        //functions\\
        void Color()
        {
            DoStuff();
            if (COLORREAD == "Blue") // use a valid ConsoleColor value
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            else
            {
                try
                {
                    var lines = File.ReadAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt");
                    Console.ForegroundColor = color;
                    lines[3] = Highlightcolor;
                    lines[4] = Highlightcolor;
                    File.WriteAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt", lines);
                    Console.BackgroundColor = color;
                }
                catch (Exception e)
                {
                }
            }

            try
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), HighlightcolorSet);
            }
            catch (Exception e)
            {

            }
        }



        void fileoperation()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("FILE MODE ENTERED");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("type -filehelp for a list of file based commands");
            BeepNSleep();
            Console.WriteLine("type -close to exit file mode");
            BeepNSleep();
            Color();
            while (!(Command.ToUpper() == "CLOSE" || (Command.ToUpper() == "-CLOSE")))
            {

                Color();
                Console.Write("User: ");
                Console.ForegroundColor = ConsoleColor.Yellow;

                Command = Console.ReadLine();

                if (Command.ToUpper() == "FILEHELP" || Command.ToUpper() == "-FILEHELP")
                {
                    Worked = true;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("BSC-DOS Help:");
                    DoStuff();
                    Thread.Sleep(200);
                    Console.WriteLine("Showing Command list:");
                    DoStuff();
                    Thread.Sleep(200);
                    Console.WriteLine("-FileHelp - Command list");
                    BeepNSleep();
                    Console.WriteLine("-CopyFile - copy a file's contents to another UNSTABLE");
                    BeepNSleep();
                    Console.WriteLine("-Delete - delete a file and/or its contents. UNSTABLE");
                    BeepNSleep();
                    Console.WriteLine("-DiskSpace - display free space on disks");
                    BeepNSleep();
                    Console.WriteLine("-Write - write a file");
                    BeepNSleep();
                    Console.WriteLine("-Read - read a files contents");
                    BeepNSleep();
                    Console.WriteLine("-Dircont - read a directories contents");
                    continue;

                }



                if (Command.ToUpper() == "COPPYFILE" || Command.ToUpper() == "-COPPYFILE")
                {
                    try
                    {



                        Console.WriteLine("Enter first file name");
                        String NAME = Console.ReadLine();
                        Console.WriteLine(@"Enter drive path EX = C:\");
                        string DRIVE = Console.ReadLine();

                        Console.WriteLine("Enter folder (Type string of folders if needed)");
                        string Folder = Console.ReadLine();
                        Console.WriteLine("Enter File extension (dont add dot)");
                        string TYPE = Console.ReadLine();

                        string Path = DRIVE + @"\" + Folder + @"\" + NAME + "." + TYPE;

                        Console.WriteLine("Enter second file name");
                        String NAME2 = Console.ReadLine();
                        Console.WriteLine(@"Enter drive path EX = C:\");
                        string DRIVE2 = Console.ReadLine();

                        Console.WriteLine("Enter folder (Type string of folders if needed)");
                        string Folder2 = Console.ReadLine();
                        Console.WriteLine("Enter File extension (dont add dot)");
                        string TYPE2 = Console.ReadLine();
                        string Path2 = DRIVE2 + @"\" + Folder2 + @"\" + NAME2 + "." + TYPE2;
                        File.Copy(Path, Path2);
                        Worked = true;
                        continue;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error 004 File error couldnt process");
                        Console.WriteLine(e);
                    }
                }

                if (Command.ToUpper() == "DELETE" || Command.ToUpper() == "-DELETE")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter file name");
                    Color();
                    String NAME = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"Enter drive path EX = C:\");
                    Color();
                    string DRIVE = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter File extension (dont add dot)");
                    Color();
                    string TYPE = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter folder (Type string of folders if needed)");
                    Color();
                    string Folder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter file contents");
                    Color();
                    string Contents = Console.ReadLine();

                    string Path = DRIVE + @"\" + Folder + @"\" + NAME + "." + TYPE;
                    try
                    {
                        if (File.Exists(@Path))
                        {
                            File.Delete(@Path);
                        }
                        else
                        {
                            Console.WriteLine("Invalid path");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error 004 File error couldnt process");
                        Console.WriteLine(e);
                    }



                    Worked = true;
                    continue;
                }

                if (Command.ToUpper() == "DISKSPACE" || Command.ToUpper() == "-DISKSPACE")
                {
                    DriveInfo[] allDrives = DriveInfo.GetDrives();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    foreach (DriveInfo d in allDrives)
                    {
                        Console.WriteLine("Drive {0}", d.Name);
                        DoStuff();
                        Console.WriteLine("  File type: {0}", d.DriveType);
                        BeepNSleep();
                        if (d.IsReady == true)
                        {
                            Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                            DoStuff();
                            Console.WriteLine("  File system: {0}", d.DriveFormat);
                            DoStuff();
                            Console.WriteLine(
                                "  Available space to current user:{0, 15} bytes",
                                d.AvailableFreeSpace);
                            DoStuff();

                            Console.WriteLine(
                                "  Total available space:          {0, 15} bytes",
                                d.TotalFreeSpace);
                            DoStuff();

                            Console.WriteLine(
                                "  Total size of drive:            {0, 15} bytes ",
                                d.TotalSize);

                        }
                    }
                    Worked = true;
                    continue;
                }
                if (Command.ToUpper() == "DIRCONT" || Command.ToUpper() == "-DIRCONT")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter File Path");
                    Color();
                    String DIR = Console.ReadLine();
                    int READ = 0;
                    try
                    {
                        var searchTerm = "SEARCH_TERM";
                        var searchDirectory = new System.IO.DirectoryInfo(DIR);

                        var queryMatchingFiles =
                                from file in searchDirectory.GetFiles()
                                where file.Extension == ".txt"
                                let fileContent = System.IO.File.ReadAllText(file.FullName)
                                where fileContent.Contains(searchTerm)
                                select file.FullName;

                        foreach (string file in Directory.EnumerateFiles(DIR))
                        {
                            Console.WriteLine(file);
                            Console.Beep();
                        }
                    }
                    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Error " + e);
                    }
                    Worked = true;
                    continue;
                }
                if (Command.ToUpper() == "READ" || Command.ToUpper() == "-READ")
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Enter file name");
                        Color();
                        String NAME = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(@"Enter drive path EX = C:\");
                        Color();
                        string DRIVE = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Enter File extension (dont add dot)");
                        Color();
                        string TYPE = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Enter folder (Type string of folders if needed)");
                        Color();
                        string Folder = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Enter file contents");
                        Color();
                        string Contents = Console.ReadLine();

                        string Path = DRIVE + @"\" + Folder + @"\" + NAME + "." + TYPE;

                        string contents = File.ReadAllText(@Path);
                        Console.WriteLine(contents);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    Worked = true;
                    continue;
                }



                if (Command.ToUpper() == "WRITE" || Command.ToUpper() == "-WRITE")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter file name");
                    Color();
                    String NAME = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(@"Enter drive path EX = C:\");
                    Color();
                    string DRIVE = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter File extension (dont add dot)");
                    Color();
                    string TYPE = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter folder (Type string of folders if needed)");
                    Color();
                    string Folder = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Enter file contents");
                    Color();
                    string Contents = Console.ReadLine();

                    string Path = DRIVE + @"\" + Folder + @"\" + NAME + "." + TYPE;
                    try
                    {
                        File.WriteAllText(@Path, Contents);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error 004 File error couldnt process");
                        Console.WriteLine(e);
                    }
                    Worked = true;
                    continue;
                }

                if (Command.ToUpper() == "CLOSE" || Command.ToUpper() == "-CLOSE")
                {
                    Console.WriteLine("Returning to regular console");
                    Worked = true;
                    continue;
                }

                if (Command.ToUpper() == "FILE_MODE" || Command.ToUpper() == "-FILE_MODE")
                {
                    //invalid command
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error operating " + Command);
                    Console.WriteLine(" mode is already active ");
                    Console.WriteLine(" Error #005 improper usage");
                    Console.Beep(3000, 1000);
                    Color();

                    Worked = true;
                    continue;
                }



                //error detection
                if (Worked == false & !(Command == "" || Worked == false & Command == null))
                {

                    //invalid command
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error operating command" + Command);
                    Console.WriteLine(" is not recognised as a script or function.");
                    Console.WriteLine(" Error #001");
                    Console.Beep(3000, 1000);
                    Color();


                    Worked = false;
                    continue;
                }
                else
                {
                    if (Worked == false & Command == "" || Worked == false & Command == null)
                        Console.ForegroundColor = ConsoleColor.Red;
                    {
                        //no information
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error operating command " + Command);
                        Console.WriteLine(" No information detected inside.");
                        Console.WriteLine(" Error #002");
                        Console.Beep(3000, 1000);
                        Color();


                        continue;
                    }

                }







            }

        }
















        void BeepNSleep()
        {
            Console.Beep();
            Thread.Sleep(100);
        }



        try
        {
            Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), HighlightcolorSet);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        String dos = "Zero";
        Thread.Sleep(20);
        double repeat = w / 4.8;
        for (int i = 0; i < repeat; i++)
        {
            Thread.Sleep(20);
            Console.Write("--");

        }
        Thread.Sleep(100);
        DoStuff();
        Console.Write("Welcome to");
        Console.ForegroundColor = ConsoleColor.Blue;
        Thread.Sleep(50);
        Console.Write(" BSC");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Thread.Sleep(50);
        DoStuff();
        Console.Write("-DOS");
        Thread.Sleep(100);
        for (int i = 0; i < repeat; i++)
        {
            Thread.Sleep(20);
            Console.Write("--");
        }
        Thread.Sleep(20);
        BeepNSleep();
        Console.WriteLine(" ");
        BeepNSleep();
        repeat = 25;
        //start console
        for (int i = 0; i < repeat; i++)
        {
            Thread.Sleep(20);
            Console.Write("  ");
        }
        Thread.Sleep(20);
        BeepNSleep();
        Console.Write("Enter Command below");
        BeepNSleep();
        Thread.Sleep(20);
        for (int i = 0; i < repeat; i++)
        {
            Thread.Sleep(20);
            Console.Write("  ");
        }
        DoStuff();
        Thread.Sleep(200);
        Console.WriteLine("             Type -help for a list of commands");
        DoStuff();
        while (true)
        {
            Color();
            Console.Write("User: ");
            Color();
            Command = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.Yellow;
            if (Command.ToUpper() == "HELP" || Command.ToUpper() == "-HELP")
            {
                Worked = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("BSC-DOS Help:");
                DoStuff();
                Thread.Sleep(200);
                Console.WriteLine("Showing Command list:");
                DoStuff();
                Thread.Sleep(200);
                Console.WriteLine("-Add - Add a number");
                BeepNSleep();
                Console.WriteLine("-Subtract - Subtract a number");
                BeepNSleep();
                Console.WriteLine("-Multiply - Multiply a number");
                BeepNSleep();
                Console.WriteLine("-Divide - Divide a number");
                BeepNSleep();
                Console.WriteLine("-Squareroot - Get the square root of 2 numbers");
                BeepNSleep();
                Console.WriteLine("-HighlightColor  --> -Help (Built In) - Highlight color of text");
                BeepNSleep();
                Console.WriteLine("-TextColor  --> -Help (Built In) - Color of text");
                BeepNSleep();
                Console.WriteLine("-Help - Command list");
                BeepNSleep();
                Console.WriteLine("-Clear -  Clear the command pallette");
                BeepNSleep();
                Console.WriteLine("-Exit / Closeapp - Exit / close the app");
                BeepNSleep();
                Console.WriteLine("-Restart - Restarts the computer.");
                BeepNSleep();
                Console.WriteLine("-Run - Runs a program (Unstable)");
                BeepNSleep();
                Console.WriteLine("-CurrentTime - Disply system time and date");
                BeepNSleep();
                Console.WriteLine("-LockCurrentTime - Display system time forever (close program to reset)");
                BeepNSleep();
                BeepNSleep();
                Console.WriteLine("-Shutdown - shutdown PC");
                BeepNSleep();
                Console.WriteLine("-System_Status Display system status");
                BeepNSleep();
                Console.WriteLine("-Current_Version Display system update history");
                BeepNSleep();
                Console.WriteLine("-Message - send a message via email");
                BeepNSleep();
                Console.WriteLine("-ProcessList - get a list of all processed running on the PC");
                DoStuff();
                Console.WriteLine("-Userinfo - get info about current BSC-DOS account");
                DoStuff();
                Console.WriteLine("-File_Mode - enter file mode");
                DoStuff();
                Console.WriteLine("-Search - search up things");
                DoStuff();
                Console.WriteLine("||(File_Mode specific:)|| -FileHelp - Command list");
                BeepNSleep();
                Console.WriteLine("||(File_Mode specific:)|| -CopyFile - copy a file's contents to another UNSTABLE");
                BeepNSleep();
                Console.WriteLine("||(File_Mode specific:)|| -Delete - delete a file and/or its contents. UNSTABLE");
                BeepNSleep();
                Console.WriteLine("||(File_Mode specific:)|| -DiskSpace - display free space on disks");
                BeepNSleep();
                Console.WriteLine("||(File_Mode specific:)|| -Write - write a file");
                BeepNSleep();
                Console.WriteLine("||(File_Mode specific:)|| -Read - read a files contents");
                BeepNSleep();
                Console.WriteLine("||(File_Mode specific:)|| -Dircont - read a directories contents");
                Worked = true;
                continue;

            }
            if (Command.ToUpper() == "SUBTRACT" || Command.ToUpper() == "-SUBTRACT")
            {

                Worked = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insert First digit");
                DoStuff();
                Color();
                uno = Console.ReadLine();
                DoStuff();
                Int32.TryParse(uno, out int UNO);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insert Second digit");
                Color();
                dos = Console.ReadLine();
                DoStuff();
                Int32.TryParse(dos, out int DOS);
                int DELTAV = UNO - DOS;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(UNO + " - " + DOS + " = " + DELTAV);
                DoStuff();
                continue;
            }
            if (Command.ToUpper() == "ADD" || Command.ToUpper() == "-ADD")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insert First digit");
                DoStuff();
                Color();
                uno = Console.ReadLine();
                DoStuff();
                Int32.TryParse(uno, out int UNO);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insert Second digit");
                Color();
                dos = Console.ReadLine();
                DoStuff();
                Int32.TryParse(dos, out int DOS);
                int DELTAV = UNO + DOS;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(UNO + " + " + DOS + " = " + DELTAV);
                DoStuff();
                continue;

            }
            if (Command.ToUpper() == "MULTIPLY")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insert First digit");
                DoStuff();
                Color();
                uno = Console.ReadLine();
                DoStuff();
                Int32.TryParse(uno, out int UNO);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insert Second digit");
                Color();
                dos = Console.ReadLine();
                DoStuff();
                Int32.TryParse(dos, out int DOS);
                int DELTAV = UNO * DOS;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(UNO + " X " + DOS + " = " + DELTAV);
                DoStuff();
                continue;

            }
            if (Command.ToUpper() == "DIVIDE" || Command.ToUpper() == "-DIVIDE")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insert First digit");
                DoStuff();
                Color();
                uno = Console.ReadLine();
                DoStuff();
                Int32.TryParse(uno, out int UNO);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insert Second digit");
                Color();
                dos = Console.ReadLine();
                DoStuff();
                Int32.TryParse(dos, out int DOS);
                int DELTAV = UNO / DOS;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(UNO + " / " + DOS + " = " + DELTAV);
                DoStuff();
                continue;

            }
            if (Command.ToUpper() == "SQUAREROOT" || Command.ToUpper() == "-SQUAREROOT")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insert First digit");
                DoStuff();
                Color();
                uno = Console.ReadLine();
                DoStuff();
                Int32.TryParse(uno, out int UNO);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Insert Second digit");
                Color();
                dos = Console.ReadLine();
                DoStuff();
                Int32.TryParse(dos, out int DOS);
                int DELTAV = UNO * DOS;
                double SQRTV = Math.Sqrt(DELTAV);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(UNO + " √ " + DOS + " = " + SQRTV);
                DoStuff();
                continue;

            }
            if (Command.ToUpper() == "HIGHLIGHTCOLOR" || Command.ToUpper() == "-HIGHLIGHTCOLOR")
            {
                Worked = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("type a valid color or -help for a list of colors");
                COLORREAD = Console.ReadLine();
                if (COLORREAD.ToUpper() == "-HELP")
                {
                    Console.WriteLine("List of valid colors:");
                    Console.WriteLine("Yellow, DarkYellow, Red, DarkRed, Blue, DarkBlue, Cyan");
                    Console.WriteLine("DarkCyan, Green, DarkGreen, Magenta, DarkMagenta, White, Black");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!INSERT EXACT TEXT INCLUDING CAPITALS!");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                }
                if (COLORREAD == "Yellow" || COLORREAD == "Darkyellow" || COLORREAD == "Red" || COLORREAD == "DarkRed" || COLORREAD == "Blue" || COLORREAD == "DarkBlue" || COLORREAD == "Cyan" || COLORREAD == "DarkCyan" || COLORREAD == "Green" || COLORREAD == "DarkGreen" || COLORREAD == "Magenta" || COLORREAD == "DarkMagenta" || COLORREAD == "White" || COLORREAD == "Black")
                {
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), COLORREAD);
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), COLORREAD);
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), COLORREAD);
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), COLORREAD);
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), COLORREAD);

                    Console.BackgroundColor = color;
                    Console.BackgroundColor = color;
                    Console.BackgroundColor = color;
                    Console.BackgroundColor = color;
                    Console.BackgroundColor = color;
                    // Read all lines from the file into an array
                    string[] lines = System.IO.File.ReadAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt");

                    // Replace the element at index 2 (line 3) with the new value
                    lines[3] = Enum.GetName(typeof(ConsoleColor), color);

                    // Write the array back to the file
                    System.IO.File.WriteAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt", lines);
                }
                Console.WriteLine("Preview");
                Worked = true;

            }
            if (Command.ToUpper() == "TEXTCOLOR" || Command.ToUpper() == "-TEXTCOLOR")
            {
                Worked = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("type a valid color or -help for a list of colors");
                COLORREAD = Console.ReadLine();
                if (COLORREAD.ToUpper() == "-HELP")
                {
                    Console.WriteLine("List of valid colors:");
                    Console.WriteLine("Yellow, DarkYellow, Red, DarkRed, Blue, DarkBlue, Cyan");
                    Console.WriteLine("DarkCyan, Green, DarkGreen, Magenta, DarkMagenta, White, Black");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!INSERT EXACT TEXT INCLUDING CAPITALS!");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                }
                if (COLORREAD == "Yellow" || COLORREAD == "Darkyellow" || COLORREAD == "Red" || COLORREAD == "DarkRed" || COLORREAD == "Blue" || COLORREAD == "DarkBlue" || COLORREAD == "Cyan" || COLORREAD == "DarkCyan" || COLORREAD == "Green" || COLORREAD == "DarkGreen" || COLORREAD == "Magenta" || COLORREAD == "DarkMagenta" || COLORREAD == "White" || COLORREAD == "Black")
                {
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), COLORREAD);
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), COLORREAD);
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), COLORREAD);
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), COLORREAD);
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), COLORREAD);

                    Console.ForegroundColor = color;
                    Console.ForegroundColor = color;
                    Console.ForegroundColor = color;
                    Console.ForegroundColor = color;
                    Console.ForegroundColor = color;
                    // Read all lines from the file into an array
                    string[] lines = System.IO.File.ReadAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt");

                    // Replace the element at index 2 (line 3) with the new value
                    lines[2] = Enum.GetName(typeof(ConsoleColor), color);

                    // Write the array back to the file
                    System.IO.File.WriteAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt", lines);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error 008 invalid color");
                    Color();
                }
                Console.WriteLine("Preview");
                Worked = true;
                continue;

            }

            if (Command.ToUpper() == "CLEAR" || Command.ToUpper() == "-CLEAR")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                dos = "Zero";
                Thread.Sleep(20);
                repeat = w / 4.8;
                for (int i = 0; i < repeat; i++)
                {
                    Thread.Sleep(20);
                    Console.Write("--");

                }
                Thread.Sleep(100);
                DoStuff();
                Console.Write("Welcome to");
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(50);
                Console.Write(" BSC");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(50);
                DoStuff();
                Console.Write("-DOS");
                Thread.Sleep(100);
                for (int i = 0; i < repeat; i++)
                {
                    Thread.Sleep(20);
                    Console.Write("--");
                }
                Thread.Sleep(20);
                BeepNSleep();
                Console.WriteLine(" ");
                BeepNSleep();
                repeat = 25;
                //start console
                for (int i = 0; i < repeat; i++)
                {
                    Thread.Sleep(20);
                    Console.Write("  ");
                }
                Thread.Sleep(20);
                BeepNSleep();
                Console.Write("Enter Command below");
                BeepNSleep();
                Thread.Sleep(20);
                for (int i = 0; i < repeat; i++)
                {
                    Thread.Sleep(20);
                    Console.Write("  ");
                }
                DoStuff();
                Thread.Sleep(200);
                Console.WriteLine("             Type -help for a list of commands");
                DoStuff();
                continue;

            }

            if (Command.ToUpper() == "RESTART" || Command.ToUpper() == "-RESTART")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Are you are you want to instantly restart your device, any unsaved data will be lost. Y or N?");

                string? result = Console.ReadLine();
                result = result.ToUpper();
                if (result == "Y")
                {
                    RegisterApplicationRestart(Process.GetCurrentProcess().MainModule.FileName, 0);

                    IntPtr tokenHandle = IntPtr.Zero;

                    try
                    {
                        // get process token
                        if (!OpenProcessToken(Process.GetCurrentProcess().Handle,
                            TOKEN_QUERY | TOKEN_ADJUST_PRIVILEGES,
                            out tokenHandle))
                        {
                            throw new Win32Exception(Marshal.GetLastWin32Error(),
                                "Failed to open process token handle");
                        }

                        // lookup the shutdown privilege
                        TOKEN_PRIVILEGES tokenPrivs = new TOKEN_PRIVILEGES();
                        tokenPrivs.PrivilegeCount = 1;
                        tokenPrivs.Privileges = new LUID_AND_ATTRIBUTES[1];
                        tokenPrivs.Privileges[0].Attributes = SE_PRIVILEGE_ENABLED;

                        if (!LookupPrivilegeValue(null,
                            SE_SHUTDOWN_NAME,
                            out tokenPrivs.Privileges[0].Luid))
                        {
                            throw new Win32Exception(Marshal.GetLastWin32Error(),
                                "Failed to open lookup shutdown privilege");
                        }

                        // add the shutdown privilege to the process token
                        if (!AdjustTokenPrivileges(tokenHandle,
                            false,
                            ref tokenPrivs,
                            0,
                            IntPtr.Zero,
                            IntPtr.Zero))
                        {
                            throw new Win32Exception(Marshal.GetLastWin32Error(),
                                "Failed to adjust process token privileges");
                        }

                        // reboot
                        if (!ExitWindowsEx(ExitWindows.RestartApps | ExitWindows.Reboot, ShutdownReason.MajorOther | ShutdownReason.MinorOther | ShutdownReason.FlagPlanned))
                        {
                            throw new Win32Exception(Marshal.GetLastWin32Error(),
                                "Failed to reboot system");
                        }
                    }
                    catch (Exception ex)
                    {
                        // close the process token
                        if (tokenHandle != IntPtr.Zero)
                        {
                            CloseHandle(tokenHandle);
                        }
                        Console.WriteLine("Error 003 Restart error");
                        Console.WriteLine($"An error occurred: {ex.Message}");
                        Console.Beep(5000, 1000);
                    }
                }
                else if (result == "N")
                {
                    Console.WriteLine("Restart cancelled.");
                }
                else
                {
                    Console.WriteLine("Invalid command, aborting command.");
                    Console.Beep(3000, 1000);
                }
                continue;

            }

            if (Command.ToUpper() == "EXIT" || Command.ToUpper() == "-EXIT" || Command.ToUpper() == "CLOSEAPP" || Command.ToUpper() == "-CLOSEAPP")
            {
                Random rand = new();


                for (int o = 10; o < repeat; o++)
                {
                    for (int i = 1; i <= 10; i++)
                        Console.WriteLine("Closing Files " + "{0} -> {1}", i, rand.Next() + "//Program_Files//" + 1 + "//datafiles");
                    Thread.Sleep(50);
                    for (int i = 1; i <= 10; i++)
                        Console.WriteLine("Resetting data " + "{0} -> {1}", i, rand.Next() + "//users//" + 1 + "//datafiles");
                    Thread.Sleep(50);
                }
                Console.Clear();
                Environment.Exit(0);
                continue;

            }

            if (Command.ToUpper() == "RUN" || Command.ToUpper() == "-RUN")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter file name");
                Color();
                String NAME = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"Enter drive path EX = C:\");
                Color();
                string DRIVE = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter File extension (dont add dot)");
                Color();
                string TYPE = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Enter folder (Type string of folders if needed)");
                Color();
                string Folder = Console.ReadLine();

                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = Path.Combine(DRIVE, Folder, NAME + "." + TYPE);
                    psi.WorkingDirectory = Path.Combine(DRIVE, Folder);
                    Process.Start(psi);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                continue;






            }


            if (Command.ToUpper() == "CURRENTTIME" || Command.ToUpper() == "-CURRENTTIME")
            {


                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString("F"));


                Worked = true;
                continue;
            }



            if (Command.ToUpper() == "LOCKCURRENTTIME" || Command.ToUpper() == "-LOCKCURRENTTIME")
            {
                while (true)
                {

                    DateTime now = DateTime.Now;
                    Console.WriteLine(now.ToString("F"));
                    Thread.Sleep(1);
                    continue;
                }
            }


            if (Command.ToUpper() == "SEARCH" || Command.ToUpper() == "-SEARCH")
            {
                try
                {
                    Console.Write("Enter search: ");
                    string Query = Console.ReadLine();
                    string Url = "https://www.bing.com/search?q=" + WebUtility.UrlEncode(Query);
                    ProcessStartInfo info = new ProcessStartInfo(Url); // create a ProcessStartInfo object
                    info.UseShellExecute = true; // set the UseShellExecute property to true
                    Process.Start(info); // use Process.Start with the ProcessStartInfo object

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                Worked = true;
                continue;
            }
            if (Command.ToUpper() == "SIZE" || Command.ToUpper() == "-SIZE")
            {
                Console.WriteLine("Enter new console width");

                string[] lines = System.IO.File.ReadAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt");
                try
                {
                    string width = Console.ReadLine();
                    Console.WriteLine("Enter new console height");
                    string height = Console.ReadLine();
                    int WIDTH = int.Parse(width);
                    int HEIGHT = int.Parse(height);
                    Console.SetWindowSize(WIDTH, HEIGHT);
                    w = Console.WindowWidth;
                    h = Console.WindowHeight;


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                lines[5] = w.ToString();


                System.IO.File.WriteAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt", lines);
                lines[6] = h.ToString();

                // Write the array back to the file
                System.IO.File.WriteAllLines(@"C:\ProgramData\BSC-DOS\Logininfo.txt", lines);
                Worked = true;
                continue;
            }







            if (Command.ToUpper() == "SHUTDOWN" || Command.ToUpper() == "-SHUTDOWN")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Are you are you want to instantly shutdown your device, any unsaved data will be lost. Y or N?");

                string? result = Console.ReadLine();
                result = result.ToUpper();
                if (result == "Y")
                {
                    RegisterApplicationRestart(Process.GetCurrentProcess().MainModule.FileName, 0);

                    IntPtr tokenHandle = IntPtr.Zero;

                    try
                    {
                        // get process token
                        if (!OpenProcessToken(Process.GetCurrentProcess().Handle,
                            TOKEN_QUERY | TOKEN_ADJUST_PRIVILEGES,
                            out tokenHandle))
                        {
                            throw new Win32Exception(Marshal.GetLastWin32Error(),
                                "Failed to open process token handle");
                        }

                        // lookup the shutdown privilege
                        TOKEN_PRIVILEGES tokenPrivs = new TOKEN_PRIVILEGES();
                        tokenPrivs.PrivilegeCount = 1;
                        tokenPrivs.Privileges = new LUID_AND_ATTRIBUTES[1];
                        tokenPrivs.Privileges[0].Attributes = SE_PRIVILEGE_ENABLED;

                        if (!LookupPrivilegeValue(null,
                            SE_SHUTDOWN_NAME,
                            out tokenPrivs.Privileges[0].Luid))
                        {
                            throw new Win32Exception(Marshal.GetLastWin32Error(),
                                "Failed to open lookup shutdown privilege");
                        }

                        // add the shutdown privilege to the process token
                        if (!AdjustTokenPrivileges(tokenHandle,
                            false,
                            ref tokenPrivs,
                            0,
                            IntPtr.Zero,
                            IntPtr.Zero))
                        {
                            throw new Win32Exception(Marshal.GetLastWin32Error(),
                                "Failed to adjust process token privileges");
                        }

                        // shutdown
                        if (!ExitWindowsEx(ExitWindows.RestartApps | ExitWindows.ShutDown, ShutdownReason.MajorOther | ShutdownReason.MinorOther | ShutdownReason.FlagPlanned))
                        {
                            throw new Win32Exception(Marshal.GetLastWin32Error(),
                                "Failed to shutdown system");
                        }
                    }
                    catch (Exception ex)
                    {
                        // close the process token
                        if (tokenHandle != IntPtr.Zero)
                        {
                            CloseHandle(tokenHandle);
                        }
                        Console.WriteLine("Error 003 Shutdown error");
                        Console.WriteLine($"An error occurred: {ex.Message}");
                        Console.Beep(5000, 1000);
                    }
                }
                else if (result == "N")
                {
                    Console.WriteLine("Shutdown cancelled.");
                }
                else
                {
                    Console.WriteLine("Invalid command, aborting command.");
                    Console.Beep(3000, 1000);
                }
                Worked = true;
                continue;
            }





            if (Command.ToUpper() == "CURRENT_VERSION" || Command.ToUpper() == "-CURRENT_VERSION")
            {
                Console.WriteLine("BSC-DOS Major Update History:");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.0.0.1 - Added subtraction and addition functions");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.0.0.5 - Added multiplication and division, title");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.0.1.0 - Animated title writing, screen size, textcolor/ highlightcolor");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.0.1.5 - Added -help list, bugfixes ");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.0.5.5 - Added Time/Date ");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.0.7.0 - Added Basic file reading/writing");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.0.7.1 - Removed file reading/writing due to errors");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.0.7.2 - Re-Added Basic file reading/writing");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.0.8.0 - DiskSpace Reading");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.0.9.2 - Added Restart, Shutdown");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.0.9.6 - Added CoppyFiles");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.0.0 - Added More file functions");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.0.5 - Added System_Status command");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.0.7 - Added Proper os being used sensor");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.1.0 - Several bugfixes, recoloring, and more redundancy for errors in system");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.1.3 - Resized window for efficency, view file_mode commands in reguilar -help menu");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.1.7 - Added sqare root math, bugfixes, fixed run command");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.1.9 - Bugfixes, repairs, antilag");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.2.2 - Added Bootconfig file");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.3.0 - Added new side application: BSC-DOS Login");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.3.5 - Added User Settings storage (color highlightcolor password) added set username, and improved login UI.");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.3.7 - Added 2 shortcuts: Boot and quickboot. Boot leading to user login and quickboot leading to instant BSC-DOS entry");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.4.0 - Removed old login, 1 part code now");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.4.3 - Dotnet native added, runs without .net framework!");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.4.7 - fixed error detection syste,");
                Thread.Sleep(200);
                DoStuff();
                Console.WriteLine("V 0.1.0.5 Bugfixes (obvously)");



                Worked = true;
                continue;
            }


            if (Command.ToUpper() == "SYSTEM_STATUS" || Command.ToUpper() == "-SYSTEM_STATUS")
            {

                Assembly assem = Assembly.GetEntryAssembly();
                AssemblyName assemName = assem.GetName();
                Version ver = assemName.Version;
                bool isWindows = System.Runtime.InteropServices.RuntimeInformation
                                   .IsOSPlatform(OSPlatform.Windows);
                Console.WriteLine("Proper OS in use: " + isWindows);
                string osNameAndVersion = RuntimeInformation.OSDescription;
                Console.WriteLine("User operating system: " + osNameAndVersion);
                String warnings = Warnings;
                if (Warnings != null)
                {
                    warnings = "Warnings detected " + Warnings;
                }
                else
                {
                    warnings = "no warnings.";
                }
                Console.WriteLine("BSC-DOS Warnings: " + warnings);
                Worked = true;
                continue;
            }






            if (Command.ToUpper() == "SYSTEMINFO" || Command.ToUpper() == "-SYSTEMINFO")
            {
                string osNameAndVersion = RuntimeInformation.OSDescription;
                Console.WriteLine("User operating system: " + osNameAndVersion);
                Worked = true;
                continue;
            }

            if (Command.ToUpper() == "MESSAGE" || Command.ToUpper() == "-MESSAGE")
            {


                string sendMail = "";
                try
                {
                    Console.WriteLine("Enter your email name");
                    Console.Beep();
                    string fromEmail1 = Console.ReadLine();
                    Console.WriteLine("Enter email your platform i.e outlook, gmail");
                    Console.Beep();
                    String TARGETPLATFORM1 = Console.ReadLine();
                    Console.Beep();
                    string fromEmail = fromEmail1 + "@" + TARGETPLATFORM1 + ".com";
                    Console.WriteLine("Enter target email name");
                    Console.Beep();
                    string fromEmail2 = Console.ReadLine();
                    Console.WriteLine("Enter target email i.e outlook, gmail");
                    Console.Beep();
                    String TARGETPLATFORM = Console.ReadLine();
                    string Target = fromEmail2 + "@" + TARGETPLATFORM + ".com";

                    string body = Console.ReadLine();
                    MailMessage mailMessage = new MailMessage(fromEmail, "to" + Target + "@gmail.com", "Subject", body);
                    mailMessage.IsBodyHtml = true;
                    SmtpClient smtpClient = new SmtpClient("smtp." + TARGETPLATFORM1 + ".com", 587);
                    SmtpClient smtpClient1 = new SmtpClient("smtp." + TARGETPLATFORM + ".com", 587);
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromEmail, frompassword);
                    smtpClient.Send(mailMessage);
                }
                catch (Exception ex)
                {
                    sendMail = ex.Message.ToString();
                    Console.WriteLine(ex.ToString());
                }
                Console.WriteLine(sendMail);

                Worked = true;
                continue;
            }
            if (Command.ToUpper() == "PROCESSLIST" || Command.ToUpper() == "-PROCESSLIST")
            {
                Process[] processlist = Process.GetProcesses();

                foreach (Process theprocess in processlist)
                {
                    Console.WriteLine($"{theprocess.ProcessName}" + "  Process ID " + $"{theprocess.Id}" + " Process Threads " + $"{theprocess.Threads}");
                    Thread.Sleep(10);
                }
                Worked = true;
                continue;
            }



            if (Command.ToUpper() == "FILE_MODE" || Command.ToUpper() == "-FILE_MODE")
            {
                fileoperation();
                Worked = true;
                continue;
            }
            if (Command.ToUpper() == "USERINFO" || Command.ToUpper() == "-USERINFO")
            {
                Console.WriteLine("Username:" + Username);
                Console.Write("Password:");
                foreach (char c in Password)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

                Worked = true;
                continue;
            }
            if (Command.ToUpper() == "CMD" || Command.ToUpper() == "-CMD")
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.RedirectStandardError = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();
                string input;
                cmd.BeginOutputReadLine();
                cmd.BeginErrorReadLine();
                cmd.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>

                {
                    Console.WriteLine(e.Data);
                });
                cmd.ErrorDataReceived += new DataReceivedEventHandler((sender, e) =>
                {
                    Console.WriteLine(e.Data);
                });
                while (true)
                {
                    cmd.StandardInput.WriteLine("");
                    Console.Write("C:\\>");
                    input = Console.ReadLine();
                    if (input == "exit")
                    {
                        break;
                    }
                    cmd.StandardInput.WriteLine(input);
                    cmd.StandardInput.Flush();
                }
                cmd.CancelOutputRead();
                cmd.CancelErrorRead();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                Worked = true;
                continue;
            }





            //FALSECOMMANDS

            if (Command.ToUpper() == "FILEHELP" || Command.ToUpper() == "-FILEHELP")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error operating " + Command);
                Console.WriteLine("command is not accessable ");
                Console.WriteLine(" Error #005 improper usage");
                Console.Beep(3000, 1000);
                Color();

                Worked = true;
                continue;

            }



            if (Command.ToUpper() == "COPPYFILE" || Command.ToUpper() == "-COPPYFILE")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error operating " + Command);
                Console.WriteLine("command is not accessable ");
                Console.WriteLine(" Error #005 improper usage");
                Console.Beep(3000, 1000);
                Color();

                Worked = true;
                continue;
            }

            if (Command.ToUpper() == "DELETE" || Command.ToUpper() == "-DELETE")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error operating " + Command);
                Console.WriteLine("command is not accessable ");
                Console.WriteLine(" Error #005 improper usage");
                Console.Beep(3000, 1000);
                Color();

                Worked = true;
                continue;
            }

            if (Command.ToUpper() == "DISKSPACE" || Command.ToUpper() == "-DISKSPACE")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error operating " + Command);
                Console.WriteLine("command is not accessable ");
                Console.WriteLine(" Error #005 improper usage");
                Console.Beep(3000, 1000);
                Color();

                Worked = true;
                continue;
            }
            if (Command.ToUpper() == "DIRCONT" || Command.ToUpper() == "-DIRCONT")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error operating " + Command);
                Console.WriteLine("command is not accessable ");
                Console.WriteLine(" Error #005 improper usage");
                Console.Beep(3000, 1000);
                Color();

                Worked = true;
                continue;
            }
            if (Command.ToUpper() == "READ" || Command.ToUpper() == "-READ")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error operating " + Command);
                Console.WriteLine("command is not accessable ");
                Console.WriteLine(" Error #005 improper usage");
                Console.Beep(3000, 1000);
                Color();

                Worked = true;
                continue;
            }



            if (Command.ToUpper() == "WRITE" || Command.ToUpper() == "-WRITE")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error operating " + Command);
                Console.WriteLine("command is not accessable ");
                Console.WriteLine(" Error #005 improper usage");
                Console.Beep(3000, 1000);
                Color();

                Worked = true;
                continue;
            }

            if (Command.ToUpper() == "CLOSE" || Command.ToUpper() == "-CLOSE")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error operating " + Command);
                Console.WriteLine("command is not accessable ");
                Console.WriteLine(" Error #005 improper usage");
                Console.Beep(3000, 1000);
                Color();

                Worked = true;
                continue;
            }



















            //error detection
            if (Worked == false & !(Command == "" || Worked == false & Command == null))
            {

                //invalid command
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error operating command" + Command);
                Console.WriteLine(" is not recognised as a script or function.");
                Console.WriteLine(" Error #001");
                Console.Beep(3000, 1000);
                Color();


                Worked = false;
                continue;
            }
            else
            {
                if (Worked == false & Command == "" || Worked == false & Command == null)
                    Console.ForegroundColor = ConsoleColor.Red;
                {
                    //no information
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error operating command " + Command);
                    Console.WriteLine(" No information detected inside.");
                    Console.WriteLine(" Error #002");
                    Console.Beep(3000, 1000);
                    Color();


                    continue;
                }

            }
        }









        void DoStuff()
        {
            Console.Beep();
        }
    }



    static void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
    {
        Console.WriteLine(outLine.Data);
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern int RegisterApplicationRestart([MarshalAs(UnmanagedType.LPWStr)] string commandLineArgs, int Flags);

    [Flags]
    enum ExitWindows : uint
    {
        //1 of
        LogOff = 0x00,
        ShutDown = 0x01,
        Reboot = 0x02,
        PowerOff = 0x08,
        RestartApps = 0x40,
        //1 of
        Force = 0x04,
        ForceIfHung = 0x10,
    }

    [Flags]
    enum ShutdownReason : uint
    {
        MajorApplication = 0x00040000,
        MajorHardware = 0x00010000,
        MajorLegacyApi = 0x00070000,
        MajorOperatingSystem = 0x00020000,
        MajorOther = 0x00000000,
        MajorPower = 0x00060000,
        MajorSoftware = 0x00030000,
        MajorSystem = 0x00050000,

        MinorBlueScreen = 0x0000000F,
        MinorCordUnplugged = 0x0000000b,
        MinorDisk = 0x00000007,
        MinorEnvironment = 0x0000000c,
        MinorHardwareDriver = 0x0000000d,
        MinorHotfix = 0x00000011,
        MinorHung = 0x00000005,
        MinorInstallation = 0x00000002,
        MinorMaintenance = 0x00000001,
        MinorMMC = 0x00000019,
        MinorNetworkConnectivity = 0x00000014,
        MinorNetworkCard = 0x00000009,
        MinorOther = 0x00000000,
        MinorOtherDriver = 0x0000000e,
        MinorPowerSupply = 0x0000000a,
        MinorProcessor = 0x00000008,
        MinorReconfig = 0x00000004,
        MinorSecurity = 0x00000013,
        MinorSecurityFix = 0x00000012,
        MinorSecurityFixUninstall = 0x00000018,
        MinorServicePack = 0x00000010,
        MinorServicePackUninstall = 0x00000016,
        MinorTermSrv = 0x00000020,
        MinorUnstable = 0x00000006,
        MinorUpgrade = 0x00000003,
        MinorWMI = 0x00000015,

        FlagUserDefined = 0x40000000,
        FlagPlanned = 0x80000000
    }

    [StructLayout(LayoutKind.Sequential)]
    struct LUID
    {
        public uint LowPart;
        public int HighPart;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct LUID_AND_ATTRIBUTES
    {
        public LUID Luid;
        public UInt32 Attributes;
    }

    struct TOKEN_PRIVILEGES
    {
        public UInt32 PrivilegeCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public LUID_AND_ATTRIBUTES[] Privileges;
    }

    const UInt32 TOKEN_QUERY = 0x0008;
    const UInt32 TOKEN_ADJUST_PRIVILEGES = 0x0020;
    const UInt32 SE_PRIVILEGE_ENABLED = 0x00000002;
    const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
    private static SecureString? frompassword;

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool ExitWindowsEx(ExitWindows uFlags,
        ShutdownReason dwReason);

    [DllImport("advapi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool OpenProcessToken(IntPtr ProcessHandle,
        UInt32 DesiredAccess,
        out IntPtr TokenHandle);

    [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool LookupPrivilegeValue(string lpSystemName,
        string lpName,
        out LUID lpLuid);

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool CloseHandle(IntPtr hObject);

    [DllImport("advapi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool AdjustTokenPrivileges(IntPtr TokenHandle,
        [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges,
        ref TOKEN_PRIVILEGES NewState,
        UInt32 Zero,
        IntPtr Null1,
        IntPtr Null2);
}








//command frame



/*
if (Command.ToUpper() == "" || Command.ToUpper() == "-")
{

Worked = true;
continue;
}
*/












