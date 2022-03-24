using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDemo.UI.Entities
{
    public partial class State
    {
        public State()
        {
            DotnetFellows = new HashSet<DotnetFellow>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string Region { get; set; }

        public virtual ICollection<DotnetFellow> DotnetFellows { get; set; }
    }
}
