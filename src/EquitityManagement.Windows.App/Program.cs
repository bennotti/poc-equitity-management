using EquitityManagement.Windows.App.Telas;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquitityManagement.Windows.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();

            ConfigureServices(services);
            services.AddScoped<FrmPrincipal>();
            services.AddScoped<FrmOrdens>();
            services.AddScoped<FrmAtivos>();
            services.AddScoped<FrmGruposAtivos>();
            services.AddScoped<FrmJurosDividendos>();
            services.AddScoped<FrmPainelPreco>();
            services.AddScoped<FrmExtrato>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var frmPrincipal = serviceProvider.GetRequiredService<FrmPrincipal>();
                System.Windows.Forms.Application.Run(frmPrincipal);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<Random>();
        }
    }
}
