FROM node:16-alpine@sha256:710a2c192ca426e03e4f3ec1869e5c29db855eb6969b74e6c50fd270ffccd3f1

COPY . .
RUN npm i

ENTRYPOINT ["node", "server.js"]
