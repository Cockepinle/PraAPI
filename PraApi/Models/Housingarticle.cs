﻿using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    public partial class Housingarticle
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int? TypeId { get; set; }

        public virtual Housingarticletype? Type { get; set; }
    }
}
