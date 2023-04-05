const http = require("http");

const host = 'localhost';
const port = 8000;

const requestListener = function (req, res) {};

const server = http.createServer(requestListener);
server.listen(port, host, () =>{
    console.log(`Serer is runing on http://=${host}:${port}`);
});