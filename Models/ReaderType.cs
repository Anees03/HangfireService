using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class ReaderType
    {
        public ReaderType()
        {
            Readers = new HashSet<Reader>();
        }

        public byte PreaderTypeId { get; set; }
        public string ReaderTypeName { get; set; } = null!;
        public string? ReaderType1 { get; set; }

        public virtual ICollection<Reader> Readers { get; set; }
    }
}
