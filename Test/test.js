const { timeStamp } = require('console');
const fs = require('fs');
const http = require('http');
const https = require('https');
const { mainModule } = require('process');
const MoneyMarket = "BTC_UAH";
const request = require('request');
let maxDayLimit;
let minDayLimit;
let curentChangePercent;


request('https://whitebit.com/api/v1/public/ticker?market='+ MoneyMarket, { json: true }, (err, res, body) => {
        if (err) { return console.log(err); }
        maxDayLimit = body.result.high; 
        minDayLimit = body.result.low;
        curentChangePercent = body.result.change;


        minDayLimit
        maxDayLimit
        curentChangePercent 
});

