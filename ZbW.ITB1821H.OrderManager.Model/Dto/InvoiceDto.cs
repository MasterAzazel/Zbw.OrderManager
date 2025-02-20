﻿using System;
using System.ComponentModel;

namespace ZbW.ITB1821H.OrderManager.Model.Dto
{
    public class InvoiceDto : IValidate
    {
        [ReadOnly(true)]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public DateTime DateOfPurchase { get; set; }
        [ReadOnly(true)]
        public int OrderId { get; set; }
        public double Amount { get; set; }

        // nothing to validate (yet)
        [Browsable(false)]
        public bool IsValid => true;
    }
}
