const fs = require('fs');
//Create directories and copy file from another file
fs.readFile('./modules.js', (error, data) => {
    console.log(data.toString());
    fs.mkdir('./fs', () => {
        fs.writeFile('./fs/copyFile.txt', data, (error) => {
            error ? console.log(error) : null;
        });
    });

setTimeout(()=> {
    if (fs.existsSync('./fs/copyFile.txt')) {
        fs.unlink ('./fs/copyFile.txt', () => {});
    };
}, 4000);

setTimeout(()=>{
    if (fs.existsSync('./fs/')) {
        fs.rmdir('./fs', ()=>{});
    };
}, 8000);

});

