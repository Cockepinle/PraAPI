using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    public partial class Legalarticle
    {
        public int Id { get; set; }
        public string Category { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
