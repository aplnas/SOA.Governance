using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Contracts
{
     public interface ITranscriptClient
     {
          TranscriptItem FindByUserAndTraining(int userId, int trainingId);

          TranscriptItem Find(int transcriptId);

          TranscriptItem Complete(int transcriptItemId, int actorId);

          TranscriptItem Request(int transcriptItemId, int actorId);

          TranscriptItem Register(int transcriptItemId, int actorId);

          TranscriptItem Approve(int transcriptItemId, int actorId);


     }
}
