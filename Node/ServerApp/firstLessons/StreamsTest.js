const fs = require('fs'); // work with file
const zlib = require('zlib'); //work with compressing data

const readStream = fs.createReadStream('./textForStreame.txt');
const writeStream = fs.createWriteStream('./textForStreameWrite.txt');
const writeCompressingStream = fs.createWriteStream('./textForStreameWriteWithCompressing.txt');
const compressStream = zlib.createGzip();
const deCompressingStream = zlib.createGunzip();

//first example - use read chunk from file an write this chunk to another file
/*
readStream.on('data', (pipka) => {
    
    writeStream.write('111111111111111111111111111111111111');
    writeStream.write(pipka);
    writeStream.write('111111111111111111111111111111111111');
})
*/
//second example - use special method pipe ()

const handleErrorReadAndWrite = () =>{
    console.log('Error');
    readStream.destroy();
    writeStream.end('Finished with error...');
}

readStream
    .on('error', handleErrorReadAndWrite)
    .pipe(compressStream)
    //.pipe(writeCompressingStream)
    //.pipe(deCompressingStream)
    .pipe(writeStream)
    .on('error', handleErrorReadAndWrite);