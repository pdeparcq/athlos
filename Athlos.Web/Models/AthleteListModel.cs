using System;

namespace Athlos.Api.Models
{
    public class AthleteListModel
    {
        public Guid Id { get; set; }
        public string StravaId { get; set; }
        public string FullName { get; set; }
    }
}
