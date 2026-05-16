using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  FixUp.Repository.Models
{
    public class Client:User
    {
        // רשימת המשימות שהלקוח פתח
        public List<Request> MyRequests { get; set; } = new List<Request>();

    }
}
