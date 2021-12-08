using Schedule.Interfaces;
using System.Reflection;

namespace Schedule
{
    class Program
    {
        private static string Namespace;
        static void Main(string[] args)
        {
            try
            {

                if (args.Length <= 0)
                {
                    Error();

                    return;
                }

                Namespace = Assembly.GetExecutingAssembly().GetName().Name;

                string taskName = args[0];

                string providerName = $"{Namespace}." + "Providers." + taskName;

                Type providerType = Type.GetType(providerName);

                if (providerType == null)
                {
                    Error();

                    return;
                }

                IProvider provider = Activator.CreateInstance(providerType) as IProvider;

                if (provider == null)
                {
                    Error();

                    return;
                }

                provider.Run();
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }

        private static void Error(string ex = "")
        {
            if (!string.IsNullOrEmpty(ex))
                Console.WriteLine(ex);

            Console.WriteLine("Çalıştırılabilecek bir parametre bulunamadı");

            Console.ReadKey();
        }
    }
}