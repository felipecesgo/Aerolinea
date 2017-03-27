using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERCEWeb.Data.Person
{
    public interface IPerson
    {
        public string IDClient { get; set; }
        public string Name { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
        public DateTime Birthdate { get; set; }

    }
}
