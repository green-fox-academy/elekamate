using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam_Orientation_Macrotis.Models
{
    public class AttractionsJson
    {
        public string Result { get; set; }
        public int Count { get; set; }
        public List<Attraction> Attractions { get; set; }
    }
}
