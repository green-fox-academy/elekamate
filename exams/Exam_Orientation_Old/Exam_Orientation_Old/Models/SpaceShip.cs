using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam_Orientation_Old.Models
{
    public partial class SpaceShip
    {
        public int Id { get; set; }
        public int Population { get; set; }
        [ForeignKey("Planet")]
        public Planet OnPlanet { get; set; }
    }
}
