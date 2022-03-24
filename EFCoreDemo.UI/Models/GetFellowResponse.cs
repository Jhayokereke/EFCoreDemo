using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.UI.Models
{
    public class GetFellowResponse
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string StateName { get; set; }
        public string Gender { get; set; }
    }

    public class RegisterFellowRequest
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public int StateId { get; set; }
        public int GenderId { get; set; }
    }

    public class UpdateFellowRequest
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public int StateId { get; set; }
        public int GenderId { get; set; }
    }
}
