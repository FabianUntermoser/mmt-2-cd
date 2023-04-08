FROM node:18-alpine

LABEL author="Fabian Untermoser"

WORKDIR /app

COPY --chown=node:node . .

# install packages
RUN npm install

VOLUME [ "/tmp" ]
USER node

# application port
ENV PORT 3000
EXPOSE $PORT

# run node application
CMD [ "npm", "start" ]
