using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OPC_WebAPI.Models
{
    public class OPCBindingModel
    {
        [Required]
        public int OPCID { get; set; }
        [Required]
        public int CC { get; set; }
        [Required]
        public string Cat { get; set; }
        [Required]
        public int Secs { get; set; }
    }
}