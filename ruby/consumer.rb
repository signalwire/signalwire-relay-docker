require "signalwire"

Signalwire::Logger.logger.level = ::Logger::DEBUG if ENV['ENABLE_DEBUG']

class ::Consumer < Signalwire::Relay::Consumer
  contexts ['office']

  def on_incoming_call(call)
    call.answer
    call.play_tts text: 'Welcome to SignalWire'

    call.hangup
  end
end

::Consumer.new.run