﻿using SmartCart.Client.Enums;

namespace SmartCart.Client.Models
{
    public class ProductDto
    {
        public Guid ProductID { get; set; }
        public Guid CartID { get; set; }
        public string ProductName { get; set; }
        public Guid? BuyerID { get; set; }
        public int ProductQuantity { get; set; }
        public Quantity QuantityType { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsBought { get; set; }
    }
}
