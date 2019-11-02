using System;

namespace Athlos.Api.Models
{
    public class RuleListModel
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
    }
}
