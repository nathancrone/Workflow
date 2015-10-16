using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Workflow.Contracts.Models;

namespace Workflow.Repositories.DataRepository.Models
{
    public class Process : IProcess
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ProcessId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
