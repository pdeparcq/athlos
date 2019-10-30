using System;
using System.Collections.Generic;

namespace Athlos.Api.ViewModels
{
    public class TrainingPlan
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int Weeks { get; set; }
        public List<Training> Trainings { get; set; }
    }
}
