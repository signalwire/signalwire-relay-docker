# SignalWire PHP Example Relay Consumer

## Running the consumer


`docker build . -t relay-php`
`docker run -e SIGNALWIRE_PROJECT_KEY=<YOUR PROJECT> -e SIGNALWIRE_TOKEN=<YOUR TOKEN> -e DEBUG=1 relay-php`