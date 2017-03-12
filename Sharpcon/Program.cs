using System;
using System.Reflection;
using System.Windows.Forms;

namespace Sharpcon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Application.Run(new Form1());
        }

        /// <summary>
        /// Gets called when the program can't find the assembly it needs in the current directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            var assembly = $"{Assembly.GetExecutingAssembly().GetName().Name}.Dependencies.{new AssemblyName(args.Name).Name}.dll";

            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(assembly))
            {
                var buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                return Assembly.Load(buffer);
            }
        }
    }
}
