using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace state_machine_api.Models
{
    public class State
    {
        public string Id { get; set; } = string.Empty;
        public bool IsInitial { get; set; }
        public bool IsFinal { get; set; }
        public bool Enabled { get; set; } = true;
    }
}