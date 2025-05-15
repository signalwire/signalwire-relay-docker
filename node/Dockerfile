FROM node:20-slim 

WORKDIR /app

# Install app dependencies
COPY package*.json ./
RUN npm install

# Bundle app source
COPY consumer.js .

CMD [ "npm", "start" ]
