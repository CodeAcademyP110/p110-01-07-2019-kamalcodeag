namespace P110_CoreStart
{
    public class ProductsController
    {
        public int Index()
        {
            return 5;
        }

        public string[] GetAll()
        {
            return new string[] { "Samir", "Zakir", "Qasim" };
        }

        public object Details()
        {
            return new
            {
                id = 1,
                name = "Deodorant",
                price = 10
            };
        }
    }
}
