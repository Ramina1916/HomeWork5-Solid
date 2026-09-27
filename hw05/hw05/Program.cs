using Microsoft.Extensions.DependencyInjection;

namespace hw05
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            implemented with factory pattern and dependency injection, but commented out for now.
            Console.WriteLine("Hello, Daneshkar!");

            // Ask the user to choose a source type
            Console.WriteLine("1. Database\n2. API\n3. File");
            int choice = int.Parse(Console.ReadLine());

            // Create the appropriate repository based on user choice
            IProductRepository repository = ProductRepositoryFactory.CreateRepository(choice);
            // Create the ProductService with the selected repository
            var productService = new ProductService(repository);

            productService.DisplayProducts();
            */

            // IoC container setup, don't need to use factory pattern anymore, just register the dependencies in the container and let the container resolve them for us.
            Console.WriteLine("1. Database");
            Console.WriteLine("2. API");
            Console.WriteLine("3. File");

            int choice = int.Parse(Console.ReadLine());

            var services = new ServiceCollection();

            switch (choice)
            {
                case 1:
                    services.AddScoped<IProductRepository,DatabaseProductRepository>();
                    break;

                case 2:
                    services.AddScoped<IProductRepository,ApiProductRepository>();
                    break;

                case 3:
                    services.AddTransient<IProductRepository,FileProductRepository>();
                    break;
            }

            services.AddTransient<ProductService>();

            var provider = services.BuildServiceProvider();
            // Resolve the ProductService from the service provider
            var service = provider.GetRequiredService<ProductService>();

            service.DisplayProducts();

        }
    }
}
