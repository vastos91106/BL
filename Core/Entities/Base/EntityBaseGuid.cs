using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Base
{
    public abstract  class EntityBaseGuid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  virtual Guid Id { get; set; }
    }
}
