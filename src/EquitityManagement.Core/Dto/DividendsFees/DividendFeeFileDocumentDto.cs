using System;
using System.Collections.Generic;
using System.Text;

namespace EquitityManagement.Core.Dto.DividendsFees
{
    public class DividendFeeFileDocumentDto
    {
        public string Identificador { get; set; } = Guid.NewGuid().ToString();
    }
}
