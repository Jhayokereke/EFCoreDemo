using EFCoreDemo.UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace EFCoreDemo.UI.Entities
{
    public partial class DotnetFellow
    {
        public DotnetFellow()
        {
            var id = Guid.NewGuid().ToString().Replace("-", "")[..8];
            Id = id[0..4] + "-" + id[4..8];
        }
        
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        [Range(1, 3, ErrorMessage ="Not a valid gender")]
        public int GenderId { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}
