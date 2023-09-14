using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Announcement:EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
