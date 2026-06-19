namespace ProductService.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public string ImageURL { get; set; } = string.Empty;

        public int Stock { get; set; }

        public decimal Price { get; set; }  

        public bool Featured { get; set; }

        public int Rating { get; set; }

    }
}
