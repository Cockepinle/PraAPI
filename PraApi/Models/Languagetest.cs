using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    public partial class Languagetest
    {
        public Languagetest()
        {
            Testimages = new HashSet<Testimage>();
            Usertestresults = new HashSet<Usertestresult>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Testimage> Testimages { get; set; }
        public virtual ICollection<Usertestresult> Usertestresults { get; set; }
    }
}
