const TelegramBot = require ('node-telegram-bot-api');
const fs = require('fs');
const http = require('http');
const https = require('https');
const TOKEN = fs.readFileSync("token.txt", "utf8");
const bot = new TelegramBot(TOKEN, {polling: true});
const MoneyMarket = "BTC_UAH";
const actualPrice = 0;

const request = require('request');

let xSecond = 5000;// 5 second
setInterval(function(){
    askCurentPrice();
},xSecond)

function askCurentPrice (){
    request('https://whitebit.com/api/v1/public/ticker?market='+ MoneyMarket, { json: true }, (err, res, body) => {
        if (err) { return console.log(err); }
        console.log(body.result.bid);
});
};

//console.log(ask.x)
bot.on('message', (msg)=>{

    console.log("1");

    if (msg.text == "Курс"){
        bot.sendMessage (msg.chat.id, body.result.bid);
    }
    console.log(msg);
    if (msg.text == "Hi"){
        bot.sendMessage (msg.chat.id, msg.chat.first_name + " Hi");
    }
    else if (msg.text == "Piska"){
        bot.sendMessage (msg.chat.id, msg.chat.first_name + " Слыш, ты че, берега попутал?");
    } 
    
})
