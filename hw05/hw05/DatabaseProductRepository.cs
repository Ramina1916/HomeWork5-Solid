namespace hw05
{
    // Implementations of IProductRepositories from different sources
    public class DatabaseProductRepository : IProductRepository
    {
        public string GetProducts() => "Products from Database";
    }
}
