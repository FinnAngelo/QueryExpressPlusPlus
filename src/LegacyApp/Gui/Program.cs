using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Fluxor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QueryExPlusPlus.WinformsMdiApp.Features.About.Pages;
using QueryExPlusPlus.WinformsMdiApp.Features.About.Store;

namespace QueryExPlusPlus.LegacyApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (DisplayHelpIfNeeded(args))
                    return;
            }
            if (QueryExPlusPlus.LegacyApp.Properties.Settings.Default.IsFirstRun)
            {
                QueryExPlusPlus.LegacyApp.Properties.Settings.Default.Upgrade();
                QueryExPlusPlus.LegacyApp.Properties.Settings.Default.IsFirstRun = false;
                QueryExPlusPlus.LegacyApp.Properties.Settings.Default.Save();
                System.Windows.Forms.MessageBox.Show("Settings Upgraded");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += (object sender, ThreadExceptionEventArgs e) => MessageBox.Show(e.Exception.Message);
            AppDomain.CurrentDomain.UnhandledException += (object sender, UnhandledExceptionEventArgs e) => MessageBox.Show(e.ExceptionObject.ToString());

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var store = ServiceProvider.GetRequiredService<IStore>();
            //await store.InitializeAsync();
            store.InitializeAsync().Wait();// WTF?

            //var app = ServiceProvider.GetRequiredService<MainForm>();

            Application.Run(new MainForm(args));
        }

        static void Default_SettingsSaving(object sender, System.ComponentModel.CancelEventArgs e)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private static bool DisplayHelpIfNeeded(string[] args)
        {
            CommandLineParams cmdLine = new CommandLineParams(args);
            if (cmdLine["?"] != null ||cmdLine["help"] != null)
            {
                //System.Console.WriteLine(string.Format("{0} - {1}", 
                //                             AboutForm.AssemblyTitle, 
                //                             AboutForm.AssemblyVersion));
                System.Console.WriteLine("-------------------------------------------------------------");
                System.Console.WriteLine("Command Line Arguments");
                System.Console.WriteLine("   -?, -help : Help");
                System.Console.WriteLine("   -cn [connection_name] : Load connection by name");
                System.Console.WriteLine("   -s [SQL_Server_Name] : Connect to SQL Server by Name");
                System.Console.WriteLine("   -os [Oracle_Data_Source] : Connect to Oracle by Data Source Name");
                System.Console.WriteLine("   -e : Use Trusted Connection");
                System.Console.WriteLine("   -u [User_Name] : User Name");
                System.Console.WriteLine("   -p [Password] : Password");
                System.Console.WriteLine("   -i [FileName] : Open SQL File");
                return true;
            }
            return false;
        }



        // hmm... is Service locator anti-pattern needed for winforms?
        public static IServiceProvider ServiceProvider { get; private set; } = null!;

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    //services.AddScoped<MainForm>();
                    services.AddSingleton<MainForm>();
                    services.AddSingleton<Assembly>(typeof(Program).Assembly);
                    services.AddTransient<AboutForm>();
                    services.AddFluxor(o => o.ScanAssemblies(
                        typeof(Program).Assembly,
                        typeof(AboutForm).Assembly
                        ));

                    services.AddAutoMapper(typeof(AboutState).Assembly);
                    services.AddAutoMapper(typeof(Program).Assembly);
                });
        }
    }
}