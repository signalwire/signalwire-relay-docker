from signalwire.relay.consumer import Consumer
import os

class CustomConsumer(Consumer):
  def setup(self):
    self.project = os.environ['SIGNALWIRE_PROJECT_KEY']
    self.token = os.environ['SIGNALWIRE_TOKEN']
    self.contexts = ['office']

  async def on_incoming_call(self, call):
    result = await call.answer()
    if result.successful:
      await call.play_tts(text='Welcome to SignalWire!')
      await call.hangup()

# Run your consumer..
consumer = CustomConsumer()
consumer.run()