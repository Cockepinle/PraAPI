using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    public partial class Aboutprojectsection
    {
        public int Id { get; set; }
        public string Section { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
