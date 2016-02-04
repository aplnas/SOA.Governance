using MessageContract.Contracts;

namespace MessageContract
{
     public class TranscriptFindMessage : ITranscriptMessage
     {
          public int TrainingId{ get; set; }
     }
}
