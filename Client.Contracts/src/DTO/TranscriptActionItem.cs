using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Contracts
{
     public class TranscriptActionItem
     {
          DateTime ActionDate { get; set; }
          DateTime Created { get; set; }
          public int UserId { get; set; }
          public int TrainingId { get; set; }
          public int ActionId { get; set; }

     }
}
