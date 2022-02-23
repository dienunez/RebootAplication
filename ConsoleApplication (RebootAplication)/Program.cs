using System;
using System.Diagnostics;

class Demo
{
    public static void Main()
    {
        Launch();
        Launch2();
        Console.ReadLine();
    }

    private static void Launch()
    {
        ProcessStartInfo psi = new ProcessStartInfo();
        psi.FileName = "iexplore.exe";

        Process p = new Process();
        p.StartInfo = psi;
        p.EnableRaisingEvents = true;
        p.Exited += LaunchAgain; //C# 2.0 syntax - alternative: p.Exited += new EventHandler(LaunchAgain);

        p.Start();
    }

    private static void Launch2()
    {
        ProcessStartInfo psi2 = new ProcessStartInfo();
        psi2.FileName = "C:\\ProgramData\\Banco Galicia\\SysInfo\\sysinfo.exe";

        Process p2 = new Process();
        p2.StartInfo = psi2;
        p2.EnableRaisingEvents = true;
        p2.Exited += LaunchAgain2; //C# 2.0 syntax - alternative: p.Exited += new EventHandler(LaunchAgain);

        p2.Start();
    }



    private static void LaunchAgain(object o, EventArgs e)
    {
        Console.WriteLine("El proceso IEXPLORE fue cerrado por el usuario, iniciando nuevamente...");
        Launch();
    }

    private static void LaunchAgain2(object o, EventArgs e)
    {
        Console.WriteLine("El proceso GALSYSINFO fue cerrado por el usuario, iniciando nuevamente...");
        Launch2();
    }
}