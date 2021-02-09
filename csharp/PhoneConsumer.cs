using System;

using SignalWire.Relay;
using SignalWire.Relay.Calling;

namespace ConsumerExample
{
    [Serializable]
    internal class PhoneConsumer : Consumer
    {        
        protected override void Setup()
        {

        }

        protected override void OnIncomingCall(Call call)
        {
            AnswerResult resultAnswer = call.Answer();
            if (!resultAnswer.Successful)
            {
            }
            else
            {
                // incoming call failed
            }

            call.PlayTTS("The quick brown fox jumps over the lazy dog.");
            TerminateCall(call);
        }

        public void TerminateCall(Call call)
        {
            call.Hangup();
        }
    }
}
