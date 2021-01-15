const { RelayConsumer } = require('@signalwire/node')

const consumer = new RelayConsumer({
  project: process.env.SIGNALWIRE_PROJECT,
  token: process.env.SIGNALWIRE_TOKEN,
  contexts: ['office'],

  ready: async ({ client }) => {
    // Consumer is successfully connected with Relay.
    // You can make calls or send messages here..
    if (process.env.ENABLE_DEBUG) { 
      client.__logger.setLevel(client.__logger.levels.DEBUG)
    }
  },

  onIncomingCall: async (call) => {
    await call.answer()
    await call.playTTS({ text: 'Welcome to SignalWire!' });
    await call.hangup();
  }
})

consumer.run()