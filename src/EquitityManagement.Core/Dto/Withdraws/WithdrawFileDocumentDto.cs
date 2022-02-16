using System;
using System.Collections.Generic;
using System.Text;

namespace EquitityManagement.Core.Dto.Withdraws
{
    public class WithdrawFileDocumentDto
    {
        public string Identificador { get; set; } = Guid.NewGuid().ToString();
    }
}
