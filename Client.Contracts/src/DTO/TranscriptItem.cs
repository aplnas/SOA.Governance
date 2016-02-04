using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Contracts
{
     public class TranscriptItem
     {
          public int Id { get; set; }
          public int TrainingId { get; set; }
          public int UserId { get; set; }
          public string TrainingTitle { get; set; }
          public string UserName { get; set; }
          public int Status { get; set; }
          public DateTime Created { get; set; }
          public DateTime Completed { get; set; }
          public decimal Score { get; set; }
          public IEnumerable<TranscriptActionItem> Actions{ get; set; }
     }
}
