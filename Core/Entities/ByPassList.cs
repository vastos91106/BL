using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Entities.Base;

namespace Core.Entities
{
    public class ByPassList : ByPassBase
    {
        [Required]
        public string Name { get; set; }

        public Guid WorkerId { get; set; }

        public virtual User Worker { get; set; }

        public virtual IEnumerable<ByPassState> BypassStates { get; set; }
    }
}
