﻿using System.Collections.Generic;
using System.Linq;
using ZbW.ITB1821H.OrderManager.Model.Context;
using ZbW.ITB1821H.OrderManager.Model.Entities;
using ZbW.ITB1821H.OrderManager.Model.Repository.Interfaces;

namespace ZbW.ITB1821H.OrderManager.Model.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public new List<Invoice> Get()
        {
            using (var context = new DatabaseContext())
            {
                return context.GetInvoices().ToList();
            }
        }
    }
}
