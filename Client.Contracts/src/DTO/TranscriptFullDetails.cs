using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Contracts
{
     public class TranscriptFullDetails
     {
          public List<TranscriptItem> items { get; set; }

          public decimal CompletedHours { get; set; }
     }
}
