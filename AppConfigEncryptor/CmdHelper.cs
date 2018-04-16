using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConfigEncryptor
{
    public static class CmdHelper
    {
        //Execute external program and get the result string
        public static string Shell(string exeFile, string argument)
        {
            Process pShell = new Process();
            pShell.StartInfo.FileName = exeFile;
            pShell.StartInfo.Arguments = argument;
            //Run as an administrator
            //pShell.StartInfo.Verb = "runas";

            //For output redirect
            pShell.StartInfo.UseShellExecute = false;
            pShell.StartInfo.RedirectStandardOutput = true;
            //No window
            pShell.StartInfo.CreateNoWindow = true;
            //Start
            pShell.Start();
            pShell.WaitForExit();
            //Convert StandardOutput to string
            return pShell.StandardOutput.ReadToEnd();
        }

        //Get the path of the latest aspnet_regiis.exe 
        public static string GetAspNetRegIisPath()
        {
            //Detect runtime version
            //REF http://west-wind.com/weblog/posts/1646.aspx
            RegistryKey reg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\ASP.NET");
            string[] versions = reg.GetSubKeyNames();
            string path = "";
            foreach (string ver in versions)
            {
                //Skip v1.1
                if (ver.StartsWith("1.1")) continue;
                path = Convert.ToString(reg.OpenSubKey(ver).GetValue("Path"));
                if (string.IsNullOrEmpty(path)) continue;
            }
            return Path.Combine(path, "aspnet_regiis.exe");
        }

        //Get a list of key containers on local machine
        public static List<string> GetKeyContainers()
        {
            var files = Directory.GetFiles(@"C:\ProgramData\Microsoft\Crypto\RSA\MachineKeys\");
            var keys = new List<string>();
            var errors = new List<string>();

            foreach (var file in files)
            {
                try
                {
                    var bytes = File.ReadAllBytes(file);
                    var containerName = Encoding.ASCII.GetString(bytes, 40, bytes[8] - 1);

                    if (!containerName.Contains("{") && !containerName.Contains("VS"))
                        keys.Add(containerName);

                    //if(containerName.Contains("myApp1SampleKeys"))
                    //    MessageBox.Show("myApp1SampleKeys" + file);
                }
                catch (UnauthorizedAccessException ex)
                {
                    errors.Add(ex.Message);
                }
            }

            //if (errors.Any())
            //{
            //    Console.WriteLine("\n\nErrors:");

            //    foreach (var e in errors)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}

            return keys;
        }
    }
}
