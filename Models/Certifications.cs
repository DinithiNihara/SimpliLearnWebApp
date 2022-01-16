using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpliLearnWebApp.Models
{
    public class Certifications
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YoCompletion { get; set; }

        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }
        public virtual Trainer Trainer { get; set; }



        public Certifications(int id, string name, int yoCompletion, int trainerId, Trainer trainer)
        {
            Id = id;
            Name = name;
            YoCompletion = yoCompletion;
            TrainerId = trainerId;
            Trainer = trainer;
        }

        public Certifications()
        {
        }

        public Certifications(int id)
        {
            Id = id;
        }
    }
}
