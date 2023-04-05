const http = require('http'); // lib with server

const PORT = 3000;

const server = http.createServer((req, res) => {
    console.log('Server request');
    console.log(req.url, req.method); // send console url and method

    res.setHeader ('Content-Type', 'text/plain'); // send info for browser about sendings data (if change 'text/plain' to text/html. Browser was created DOM)
    res.write('hello'); // send data to browser
    res.end(); // check all data return to browser
});

server.listen(PORT, 'localhost', (error) => {
    error ? console.log(error) : console.log(`listening port ${3000}`); // check error from server start and listen 
});