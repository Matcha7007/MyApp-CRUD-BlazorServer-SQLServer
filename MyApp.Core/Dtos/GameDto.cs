using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Dtos
{
    public class GameDto
    {
        public string Name { get; set; } = string.Empty;
        public string Developer { get; set; } = string.Empty;
        public DateTime? Released { get; set; }
    }
}
