﻿using System;
using System.Collections.Generic;

namespace buckstore.products.service.application.IntegrationEvents
{
    public class ProductCreatedIntegrationEvent : IntegrationEvent
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<string> ImagesId { get; set; }

        public ProductCreatedIntegrationEvent() : base(DateTime.Now)
        {

        }
    }
}
