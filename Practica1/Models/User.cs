using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}