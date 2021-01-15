# SignalWire NodeJS Example Relay Consumer

## Running the consumer


`docker build . -t relay-node`
`docker run -e SIGNALWIRE_PROJECT_KEY=<YOUR PROJECT> -e SIGNALWIRE_TOKEN=<YOUR TOKEN> -e ENABLE_DEBUG=true relay-node`