const TelegramBot = require ('node-telegram-bot-api');
const fs = require('fs');
const http = require('http');
const https = require('https');
const TOKEN = fs.readFileSync("token.txt", "utf8");
const bot = new TelegramBot(TOKEN, {polling: true});
const MoneyMarket = "BTC_UAH";
let actualPrice = "1";
let previousPrice = "1";

const request = require('request');

let xSecond = 10000;// 5 second
setInterval(function(){
    request('https://whitebit.com/api/v1/public/ticker?market='+ MoneyMarket, { json: true }, (err, res, body) => {
    if (err) { return console.log(err); }
       previousPrice = actualPrice; 
       actualPrice = body.result.bid;
       let changeCourse = actualPrice/previousPrice;
       console.log (changeCourse);
       if (changeCourse>1.001)
       {
            console.log ("Upper");
       } else if (changeCourse<0.998)
       {
            console.log ("Lowwer");
       }

        
});
},xSecond);

bot.on('message', (msg)=>{

    console.log("Bot Starting");

    if ((msg.text == "Курс") || (msg.text == "курс")){
        bot.sendMessage (msg.chat.id, actualPrice);
    }
    console.log(msg);
    if (msg.text == "Hi"){
        bot.sendMessage (msg.chat.id, msg.chat.first_name + " Hi");
    }
    else if (msg.text == "Piska"){
        bot.sendMessage (msg.chat.id, msg.chat.first_name + " Слыш, ты че, берега попутал?");
    } 
    
})
