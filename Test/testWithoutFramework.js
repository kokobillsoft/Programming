const https = require('https');

https.get('https://whitebit.com/api/v1/public/ticker?market=BTC_UAH', (resp) => {
  let data = '';

  // A chunk of data has been received.
  resp.on('data', (chunk) => {
    data += chunk;
    console.log(data.result);
  });
  //console.log(data);
  // The whole response has been received. Print out the result.
 // resp.on('end', () => {
 //   console.log(JSON.parse(data).explanation);
 // });

}).on("error", (err) => {
  console.log("Error: " + err.message);
});