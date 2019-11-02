using System;
using Kledex.Domain;

namespace Athlos.Command
{
    public class RegisterAthlete : DomainCommand
    {
        public string StravaId { get; set; }
        public string FullName { get; set; }
    }
}
