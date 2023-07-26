using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }

        private Permission Permission; 

        public string Permission   
        {
            get { return Role == Role.Judge ? Permission.Admin ? Permission.Other ; }  
            set { Permission = value; }  
        }
    }
}
