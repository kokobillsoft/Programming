const TelegramBot = require ('node-telegram-bot-api');
const fs = require('fs');
const http = require('http');
const https = require('https');
const TOKEN = fs.readFileSync("token.txt", "utf8");
const bot = new TelegramBot(TOKEN, {polling: true});
const MoneyMarket = "BTC_UAH";
let actualPrice = "1";
let previousPrice = "1";
let lowestPrice = 10000000000;
let higestPrice =0;
let CHAT_ID


bot.on("message", (msg)=>{

    console.log("Bot Starting");
    CHAT_ID = msg.chat.id;

    if (msg.text == "Ноль")
    {
        higestPrice = actualPrice;
        lowestPrice = actualPrice;
        bot.sendMessage (CHAT_ID, "Ноль котировки = " + actualPrice);
    }

    if (msg.text == "Установить ноль");
    {

    }

    if (msg.text == "Мин")
    {
        bot.sendMessage (CHAT_ID, "Минимум за сегодня = " + lowestPrice);
    }

    if (msg.text == "Макс")
    {
        bot.sendMessage (CHAT_ID, "Максимум за сегодня = " + higestPrice);
    }
    
    if ((msg.text == "Курс") || (msg.text == "курс")){
        bot.sendMessage (CHAT_ID, "Текущий курс = " + actualPrice);
    }
    console.log(msg);
    if (msg.text == "Hi"){
        bot.sendMessage (CHAT_ID, msg.chat.first_name + " Hi");
    }
    else if (msg.text == "Piska"){
        bot.sendMessage (CHAT_ID, msg.chat.first_name + " Слыш, ты че, берега попутал?");
    } 
    
});


const request = require('request');

let xSecond = 10000;// 5 second
setInterval(function(){
    request('https://whitebit.com/api/v1/public/ticker?market='+ MoneyMarket, { json: true }, (err, res, body) => {
    if (err) { return console.log(err); }
       previousPrice = actualPrice; 
       actualPrice = body.result.bid;
       
       let changeCourse = actualPrice/previousPrice;
       console.log (changeCourse);
       if (actualPrice>higestPrice)
       {
           higestPrice = actualPrice;
           bot.sendMessage (CHAT_ID, "Максимум за сегодня = " + higestPrice);
       }
       if (actualPrice<lowestPrice)
       {
           lowestPrice = actualPrice;
           bot.sendMessage (CHAT_ID, "Минимум за сегодня = " + lowestPrice);
       }
      // console.log (changeCourse);
       if (changeCourse>=1.01)
       {
            bot.sendMessage (CHAT_ID, "Курс падает = " + actualPrice);
            console.log ("Upper");
       } else if (changeCourse<=0.99)
       {
            bot.sendMessage (CHAT_ID, "Курс растет = " + actualPrice);
            console.log ("Lowwer");
       }

        
});
},xSecond);