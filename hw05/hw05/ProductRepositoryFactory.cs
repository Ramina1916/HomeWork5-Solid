namespace hw05
{
    // Define a ProductRepositoryFactory to create instances of IProductRepository
    public static class ProductRepositoryFactory
    {
        public static IProductRepository CreateRepository(int choice)
        {
            return choice switch
            {
                1 => new DatabaseProductRepository(),
                2 => new ApiProductRepository(),
                3 => new FileProductRepository(),
                _ => throw new ArgumentException("Invalid source type"),
            };
        }
    }
}
