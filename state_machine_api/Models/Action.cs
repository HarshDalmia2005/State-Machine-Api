using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace state_machine_api.Models
{
    public class Action
    {
        public string Id { get; set; } = string.Empty;
        public bool Enabled { get; set; } = true;
        public List<string> FromStates { get; set; } = new();
        public string ToState { get; set; } = string.Empty;
    }
}