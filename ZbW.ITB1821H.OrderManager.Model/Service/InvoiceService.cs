﻿using ZbW.ITB1821H.OrderManager.Model.Dto;
using ZbW.ITB1821H.OrderManager.Model.Entities;
using ZbW.ITB1821H.OrderManager.Model.Repository.Interfaces;
using ZbW.ITB1821H.OrderManager.Model.Service.Interfaces;

namespace ZbW.ITB1821H.OrderManager.Model.Service
{
    public class InvoiceService : ReportingServiceBase<Invoice, InvoiceDto>, IInvoiceService
    {
        public InvoiceService(IInvoiceRepository repo) : base(repo) { }
    }
}
