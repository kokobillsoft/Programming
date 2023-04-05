const config = require("../config");

let isDone = false;

module.exports = function (bot, chatId) {
    if ( !isDone ) {
        isDone = true;

        setInterval(function() {
            bot.sendMessage (chatId, "Я жив))");
        }, config.keepAliveTimerMs);

        setInterval(function()
        {
            if (config.startBot == 1)
            {
                request('https://whitebit.com/api/v1/public/ticker?market='+ MoneyMarket, { json: true }, (err, res, body) => {
                if (err) { return console.log(err); }
                previousPrice = actualPrice; 
                actualPrice = body.result.bid;
                
                let changeCourse = actualPrice/previousPrice;
                console.log(changeCourse);
                if ((upLimit == 0) && (downLimit == 0))
                {
                    
                    if (actualPrice>higestPrice)
                    {
                        higestPrice = actualPrice;
                        bot.sendMessage (CHAT_ID, "Максимум за сегодня = " + higestPrice);
                    };

                    if (actualPrice<lowestPrice)
                    {
                        lowestPrice = actualPrice;
                        bot.sendMessage (CHAT_ID, "Минимум за сегодня = " + lowestPrice);
                    };

                    if (changeCourse>=1.001)
                    {
                        bot.sendMessage (CHAT_ID, "Курс падает c = " + previousPrice + " до = " + actualPrice);
                        console.log ("Upper");
                    };

                    if (changeCourse<=0.999)
                    {
                        bot.sendMessage (CHAT_ID, "Курс растет c = " + previousPrice + " до = " + actualPrice);
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
    }
}