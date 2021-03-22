# SignalWire NodeJS Example Relay Consumer

This image provides a quick way to get started with [Relay](https://docs.signalwire.com/topics/relay/), SignalWire's Websocket-based call control protocol.

A Relay Consumer is the building block for the rest of the Relay features, and we provide a simple example that will pick up a call and say "Welcome!" to your callers.

## Preparing to run the example

You will need a project key and a token from your dashboard.

![Where to find API credentials on SignalWire](https://s3-us-east-2.amazonaws.com/signalwire-corpweb/images/resource-docs/api_credentials.png)

You will also need to set up a phone number to handle a call with Relay. Purchase a DID from the SignalWire dashboard, select "Relay" as the handler, and input `office` as the context.

## Running the consumer

If you are simply wanting to try the example consumer, run: 

`docker run -e SIGNALWIRE_PROJECT_KEY=<YOUR PROJECT> -e SIGNALWIRE_TOKEN=<YOUR TOKEN> -e ENABLE_DEBUG=true signalwire/relay-example-node`

Place a call to the DID you set up above, and you will hear the greeting!

Take a look at the logs in your console to find out what Relay JSON looks like.

## Creating your own consumer

If you would like to modify the consumer to explore the different Relay features, you don't need rebuild the image. You can simply run the container while mounting the consumer file to `/app/consumer.js`.

`docker run -e SIGNALWIRE_PROJECT_KEY=<YOUR PROJECT> -e SIGNALWIRE_TOKEN=<YOUR TOKEN> -e ENABLE_DEBUG=true  -v "/path/to/your/consumer.js:/app/consumer.js" signalwire/relay-example-node`

## Building your own image

You can also clone this repository, move into the `ruby` folder, then build your own version.

`docker build . -t relay-example-node`
`docker run -e SIGNALWIRE_PROJECT_KEY=<YOUR PROJECT> -e SIGNALWIRE_TOKEN=<YOUR TOKEN> -e ENABLE_DEBUG=true relay-example-node`


## More information

[Relay 101 Workshop Slides](https://docs.google.com/presentation/d/e/2PACX-1vSDTQl7HJPHZdiORUa1zXderYXXa8I9Pp2Gyra8g4Xk2lEpxNyTyOVOKVcyOk43ropKE8BNBBkloEi8/pub?start=false&loop=false&delayms=3000)
