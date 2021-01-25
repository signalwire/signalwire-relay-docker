# SignalWire Python Example Relay Consumer

## Running the consumer


`docker build . -t relay-python`
`docker run -e SIGNALWIRE_PROJECT_KEY=<YOUR PROJECT> -e SIGNALWIRE_TOKEN=<YOUR TOKEN> -e LOG_LEVEL=DEBUG relay-python`