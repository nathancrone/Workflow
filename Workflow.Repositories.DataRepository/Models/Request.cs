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
    public class Request : IRequest
    {
        public int? RequestId { get; set; }
        public DateTime DateRequested { get; set; }
        public string Title { get; set; }
    }
}
