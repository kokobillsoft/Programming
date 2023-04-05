const http = require('http');

const PORT = 3000;

const server = http.createServer((req, res) => {
    console.log('server request');
    console.log(req.url, req.method);

    res.setHeader ('Content-Type', 'application/json' );
    const dataResponce = JSON.stringify([
        {name: 'Alex', age: 32},
        {name: 'Igor', age: 44},
    ]);
    
    res.end(dataResponce);
});

server.listen(PORT, 'localhost', (error) => {
    error ? console.log(error) : console.log(`listening port ${PORT}`);
});



