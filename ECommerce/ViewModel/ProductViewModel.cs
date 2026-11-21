namespace ECommerce.ViewModel
{
    public class ProductViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public string? Badge { get; set; }          // e.g. "Bestseller", "Only 2 left"
        public bool BadgeIsUrgent { get; set; }      // low-stock styling
        public string IconPath { get; set; } = string.Empty; // inline SVG path data (see markup)
        public string AccentColor { get; set; } = "#B08D57";
    }
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public decimal? OfferPrice { get; set; }      // offer/sale price if applicable
        public string Size { get; set; } = "";         // available sizes as CSV, e.g. "35,36,37,38"
        public string Color { get; set; } = "";        // available colours as CSV, e.g. "Black,Beige,Tan"
        public string Brand { get; set; } = "";
        public string Category { get; set; } = "";     // product category, e.g. "Flat Sandals", "Winter Collection"
        public int? StyleId { get; set; }
        public int StockQuantity { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsSpecialOffer { get; set; }
        public bool IsSoldOut { get; set; }
        public string ImagePath { get; set; } = "";    // "/uploads/xxxx.jpg"
        public string Extension { get; set; } = "";    // "/uploads/xxxx.jpg"
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<ProductImages> ProductImages { get; set; } = new ();
    }
    public class ProductImages
    {
        public int Id { get; set; }
        public string ImagePath { get; set; } = "";
        public string Extension { get; set; } = "";
        public string? Color { get; set; }
    }
}
