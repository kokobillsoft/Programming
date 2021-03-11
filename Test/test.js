const request = require('request');

request('https://whitebit.com/api/v1/public/ticker?market=BTC_UAH', { json: true }, (err, res, body) => {
  if (err) { return console.log(err); }
  console.log(body.result.bid);
});