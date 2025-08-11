using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Models;
using Services;
using Database;

namespace WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<ContactDbContext>(options =>
                    options.UseSqlServer("Server=FISH\\MSSQLSERVER02;Database=contactdb;Trusted_Connection=True;TrustServerCertificate=True;"))
                .AddScoped<IContactService, ContactService>()
                .AddScoped<MainForm>()
                .BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = serviceProvider.GetService<MainForm>();

            if (mainForm != null)
            {
                Application.Run(mainForm);
            }
            else
            {
                MessageBox.Show("Failed to create MainForm.");
            }
        }
    }
}