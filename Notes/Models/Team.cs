using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models
{
    public class Team
    {
        public string Name { get; set; }
        public int Games { get; set; }
        public int Win { get; set; }
        public int Loss { get; set; }
        public int Points { get; set; }
        public string Image { get; set; }
    }
}
