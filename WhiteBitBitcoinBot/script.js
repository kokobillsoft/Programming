const TelegramBot = require ('node-telegram-bot-api');
const fs = require('fs');
const http = require('http');
const https = require('https');
const TOKEN = fs.readFileSync("token.txt", "utf8");
const bot = new TelegramBot(TOKEN, {polling: true});
let MoneyMarket = "BTC_UAH";
let actualPrice = "1";
let previousPrice = "1";
let lowestPrice = 10000000000;
let higestPrice =0;
let CHAT_ID
let startBot = 0;
const request = require('request');
let upLimit = 0;
let downLimit = 0;

bot.on("message", (msg)=>{

    console.log("Bot Starting");
    CHAT_ID = msg.chat.id;
    console.log(startBot);
    let curentMessage = msg.text;
    console.log(curentMessage);

    if (curentMessage == "Ноль")
    {
        higestPrice = actualPrice;
        lowestPrice = actualPrice;
        bot.sendMessage (CHAT_ID, "Ноль котировки = " + actualPrice);
    }
    
    if (curentMessage == "ETC")
    {
        MoneyMarket = "ETC_UAH"
    }

    if (curentMessage == "BTC")
    {
        MoneyMarket = "BTC_UAH"
    }

    if (curentMessage== "Стоп")
    {
        startBot = 0;
    }

    if (curentMessage == "Старт")
    {
        startBot = 1;
    }

    if (curentMessage == "Мин")
    {
        bot.sendMessage (CHAT_ID, "Минимум за сегодня " + MoneyMarket + " = " + lowestPrice);
    }

    if (curentMessage == "Макс")
    {
        bot.sendMessage (CHAT_ID, "Максимум за сегодня " + MoneyMarket + " = "  + higestPrice);
    }
    
    if (curentMessage == "Курс"){
        bot.sendMessage (CHAT_ID, "Текущий курс " + MoneyMarket + " = "  + actualPrice);
    }
    console.log(msg);

    if (curentMessage.lastIndexOf("Верхний лимит")!= -1)
    {
        upLimit = Number(curentMessage.substr(curentMessage.lastIndexOf("=")+2));
        downLimit = 0;
        bot.sendMessage (CHAT_ID, "Верхний лимит = " + upLimit + ("\nНижний лимит сброшен в 0"));
    }

    if (curentMessage.lastIndexOf("Нижний лимит")!= -1)
    {
        downLimit = Number(curentMessage.substr(curentMessage.lastIndexOf("=")+2));
        upLimit = 0;
        bot.sendMessage (CHAT_ID, "Нижний лимит = " + downLimit + ("\nВерхний лимит сброшен в 0"));
    }
    
    if (curentMessage == "Help")
    {
        bot.sendMessage (CHAT_ID, "Старт - Запуск оповещения\nСтоп - Остановка оповещения\nНоль - Установка нуля\nКурс - Текущий курс");
    }
    
});

let ySecond = 600000;// 10 minutes
setInterval(function() {
    bot.sendMessage (CHAT_ID, "Я жив))");
},ySecond);


console.log(startBot);


let xSecond = 10000;// 5 second
setInterval(function()
{
    if (startBot == 1)
    {
        request('https://whitebit.com/api/v1/public/ticker?market='+ MoneyMarket, { json: true }, (err, res, body) => {
        if (err) { return console.log(err); }
        previousPrice = actualPrice; 
        actualPrice = body.result.bid;
        
        let changeCourse = actualPrice/previousPrice;
        console.log (changeCourse);
        if ((upLimit == 0) && (downLimit == 0))
        {
            
            if (actualPrice>higestPrice)
            {
                higestPrice = actualPrice;
                bot.sendMessage (CHAT_ID, "Максимум за сегодня " + MoneyMarket + " = "  + higestPrice);
            };

            if (actualPrice<lowestPrice)
            {
                lowestPrice = actualPrice;
                bot.sendMessage (CHAT_ID, "Минимум за сегодня " + MoneyMarket + " = "  + lowestPrice);
            };

            if (changeCourse>=1.001)
            {
                bot.sendMessage (CHAT_ID, "Курс растет c = " + previousPrice + " до = " + actualPrice);
                console.log ("Upper");
            };

            if (changeCourse<=0.999)
            {
                bot.sendMessage (CHAT_ID, "Курс падает c = " + previousPrice + " до = " + actualPrice);
                console.log ("Lowwer");
            };  
            
        } else if (upLimit != 0)
            {
                if (actualPrice>upLimit)
                {
                    bot.sendMessage (CHAT_ID, "Значение выше верхнего лимита = " + actualPrice);
                };
            } else 
                {
                    if (actualPrice<downLimit)
                {
                    bot.sendMessage (CHAT_ID, "Значение ниже нижнего лимита = " + actualPrice);
                };
                }

        });
    };
},xSecond);
