using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    public partial class Housingdocument
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string FileUrl { get; set; } = null!;
    }
}
