using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FFHelper.Models
{
    public class Roster
    {
        [Key]
        public int Id { get; set; }
        public string full_name { get; set; }
        public string ApiPlayerId { get; set; }
    }
}