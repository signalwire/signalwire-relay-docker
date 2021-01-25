<?php

require dirname(__FILE__) . '/vendor/autoload.php';

use Generator as Coroutine;
use SignalWire\Relay\Consumer;

class CustomConsumer extends Consumer {
  public $contexts = ['office'];

  public function setup() {
    $this->project = isset($_ENV['SIGNALWIRE_PROJECT_KEY']) ? $_ENV['SIGNALWIRE_PROJECT_KEY'] : '';
    $this->token = isset($_ENV['SIGNALWIRE_TOKEN']) ? $_ENV['SIGNALWIRE_TOKEN'] : '';
  }

  public function ready(): Coroutine {
    yield;
    // Consumer is successfully connected with Relay.
    // You can make calls or send messages here..
  }

  public function onIncomingCall($call): Coroutine {
    $result = yield $call->answer();
    if ($result->isSuccessful()) {
      yield $call->playTTS(['text' => 'Welcome to SignalWire!']);
    }
    yield $call->hangup();
  }
}

$consumer = new CustomConsumer();
$consumer->run();