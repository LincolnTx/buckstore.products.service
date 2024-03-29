﻿using System;

namespace buckstore.products.service.application.IntegrationEvents
{
    public class ProductUpdatedIntegrationEvent : IntegrationEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        
        public ProductUpdatedIntegrationEvent() : base(DateTime.Now)
        {
        }
    }
}