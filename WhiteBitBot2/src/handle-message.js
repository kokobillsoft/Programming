const setupIntervals = require('./setup-intervals');
const state = require('./state');

module.exports = (bot, msg)=>{

    console.log("Bot Starting");
    const CHAT_ID = msg.chat.id;
    setupIntervals(bot, CHAT_ID);

    console.log(startBot);
    let curentMessage = msg.text;
    console.log(curentMessage);

    if (curentMessage.toLowerCase() == "ноль")
    {
        higestPrice = actualPrice;
        lowestPrice = actualPrice;
        bot.sendMessage (CHAT_ID, "Ноль котировки = " + actualPrice);
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
        bot.sendMessage (CHAT_ID, "Минимум за сегодня = " + lowestPrice);
    }

    if (curentMessage == "Макс")
    {
        bot.sendMessage (CHAT_ID, "Максимум за сегодня = " + higestPrice);
    }
    
    if (curentMessage == "Курс"){
        bot.sendMessage (CHAT_ID, "Текущий курс = " + actualPrice);
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
    
}