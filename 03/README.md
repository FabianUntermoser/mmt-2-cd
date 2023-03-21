# CD 03

Node Express Dockerfile

```sh
# build the image
docker build . -t express-test

# run the image
docker run --rm -it -p 8000:3000 express-test

# test the app
curl localhost:8000
```
