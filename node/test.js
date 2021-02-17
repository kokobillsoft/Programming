const http = require('http');
const fs = require('fs');

//http.createServer().listen(3000);
http.createServer(function (request,response){
	//console.log(request.url);
	//console.log(request.headers['user-agent']);
	
	response.setHeader("Content-Type", "text/html; charset=utf-8;")
	if (request.url =='/'){
		response.end('Main <h2>Hiiiiii</h2>');
	}
	else if (request.url =='/cat'){
		response.end('Category <h2>Hiiiiii</h2>');
	}
	else if (request.url == '/dat')
	{
		let myFile = fs.readFileSync('1.dat');
		response.end(myFile);
	}
	response.end('123');
}).listen(3000);