using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication0010.Models
{
    public class Context01 : DbContext
    {
        public Context01() : base("DefaultConnection")
        {

        }
    }
}