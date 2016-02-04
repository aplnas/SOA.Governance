using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Contracts;
namespace Client
{
    public class TranscriptClient : ITranscriptClient
    {
          private IServiceLocator _locator;
          private IServiceTransport _transport;
          private IServiceEnvironment _config;
          public TranscriptClient(IServiceLocator locator, IServiceTransport transport, IServiceEnvironment config)
          {
               this._locator = locator;
               this._transport = transport;
               this._config = config;
          }

          public TranscriptItem FindByUserAndTraining(int userId, int trainingId)
          {
               throw new NotImplementedException();
          }

          public TranscriptItem Find(int transcriptId)
          {
               throw new NotImplementedException();
          }

          public TranscriptItem Complete(int transcriptItemId, int actorId)
          {
               throw new NotImplementedException();
          }

          public TranscriptItem Request(int transcriptItemId, int actorId)
          {
               throw new NotImplementedException();
          }

          public TranscriptItem Register(int transcriptItemId, int actorId)
          {
               throw new NotImplementedException();
          }

          public TranscriptItem Approve(int transcriptItemId, int actorId)
          {
               throw new NotImplementedException();
          }
     }
}
