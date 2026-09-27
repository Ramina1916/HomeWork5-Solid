namespace hw05
{
    // Define a service that uses the product repository
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void DisplayProducts()
        {
            Console.WriteLine(_repository.GetProducts());
        }
    }
}
