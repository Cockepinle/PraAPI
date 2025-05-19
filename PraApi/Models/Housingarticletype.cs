using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    public partial class Housingarticletype
    {
        public Housingarticletype()
        {
            Housingarticles = new HashSet<Housingarticle>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Housingarticle> Housingarticles { get; set; }
    }
}
