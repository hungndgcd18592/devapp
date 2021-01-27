using System;
using APSDevApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APSDevApp.ViewModels
{
    public class ListTrainerTraineeInCourse
    {
        public Course Course { get; set; }
        public IEnumerable<Trainer> Trainers { get; set; }
        public IEnumerable<Trainee> Trainees { get; set; }
    }
}