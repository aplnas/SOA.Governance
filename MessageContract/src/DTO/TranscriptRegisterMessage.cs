using MessageContract.Contracts;

namespace MessageContract
{
     public class TranscriptRegisterMessage : ITranscriptMessage
     {
          public int TrainingId{ get; set; }
     }
}
