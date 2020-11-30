using System;

namespace Penguin.Database.Models
{
    public class PostTransaction
    {
        public int Id { get; set; }
        public string accountNumber { get; set; }
        public DateTime dateTime { get; set; }
        public int centsAmount { get; set; }
        public string currencyCode { get; set; }
        public string type { get; set; }
        public string reference { get; set; }
        public string cardId { get; set; }
        public string merchantName { get; set; }
        public string merchantCity { get; set; }
        public string categoryCode { get; set; }
        public string categoryKey { get; set; }
        public string categoryName { get; set; }
        public string countryCode { get; set; }
        public string countryAlpha3 { get; set; }
        public string countryName { get; set; }
    }
}