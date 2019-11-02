using System;
using System.Collections.Generic;

namespace Athlos.Api.ViewModels
{
    public class TrainingPlanModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int Weeks { get; set; }
        public List<RuleListModel> Rules { get; set; }
        public DateTime GenerationDate { get; set; }
        public List<TrainingListModel> Trainings { get; set; }
        public int Score { get; set; }
    }
}
