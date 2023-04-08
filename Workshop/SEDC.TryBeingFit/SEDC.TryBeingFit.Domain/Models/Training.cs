using SEDC.TryBeingFit.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.TryBeingFit.Domain.Models
{
    public abstract class Training : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Duration { get; set; }
        public TrainingLevel Level { get; set; }
        public Trainer Trainer { get; set; }
    }
}
