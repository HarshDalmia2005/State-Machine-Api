using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace state_machine_api.Models
{
    public class WorkflowDefinition
    {
        public string Id { get; set; } = string.Empty;
        public List<State> States { get; set; } = new();
        public List<Action> Actions { get; set; } = new();
    }
}