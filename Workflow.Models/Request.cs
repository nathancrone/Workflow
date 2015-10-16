using System;
using Workflow.Contracts.Models;

namespace Workflow.Models
{
    public class Request : IRequest
    {
        public int? RequestId { get; set; }
       
        public string Title { get; set; }

        public DateTime DateRequested { get; set; }
    }
}
