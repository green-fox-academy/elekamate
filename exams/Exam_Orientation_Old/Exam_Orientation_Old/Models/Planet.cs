using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam_Orientation_Old.Models
{
    public partial class Planet
    {
        [ForeignKey("SpaceShip")]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }

        public virtual SpaceShip SpaceshipId { get; set; }
    }
}
