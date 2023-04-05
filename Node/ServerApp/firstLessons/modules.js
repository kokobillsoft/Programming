const { userName: user, seyHi} = require('./test');
const os = require('os');

const name = 'pipka';
console.log(seyHi(name));

console.log(os.platform(), os.release());