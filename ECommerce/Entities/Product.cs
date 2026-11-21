namespace ECommerce.Entities
{
    public class Product
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
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
