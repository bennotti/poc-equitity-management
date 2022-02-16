using System;
using System.Collections.Generic;
using System.Text;

namespace EquitityManagement.Core.Dto.Entries
{
    public class EntrieFileDocumentDto
    {
        public string Identificador { get; set; } = Guid.NewGuid().ToString();
    }
}
