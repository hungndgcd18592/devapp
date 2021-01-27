using APSDevApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APSDevApp.ViewModels
{
    public class ChangeTrainerAssign
    {
        public IEnumerable<Course> Courses { get; set; }
        public Trainer Trainer { get; set; }
    }
}