using System;
using System.Collections.Generic;
using System.Text;

namespace EquitityManagement.Core.Dto.Order
{
    public class OrderFileDocumentDto
    {
        public string Identificador { get; set; } = Guid.NewGuid().ToString();
        public decimal Price { get; set; } = decimal.Zero;
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal Amount { get; set; } = decimal.Zero;
        public decimal Cost { get; set; } = decimal.Zero;
        public decimal Payment { get; set; } = decimal.Zero;
        public DateTime AvailableDate { get; set; } = DateTime.Now;
    }
}
