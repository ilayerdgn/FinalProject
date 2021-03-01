﻿using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer:IEntity //sen veri tabanı nesnesisin
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
    }
}
