using APSDevApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APSDevApp.ViewModels
{
    public class ChangeTraineeAssign
    {
        public IEnumerable<Course> Courses { get; set; }
        public Trainee Trainee { get; set; }
    }
}