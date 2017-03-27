using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERCEWeb.Data.Account
{
    public interface IUser
    {
        public int IDLogin { get; set; }
        public string IDClient { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
