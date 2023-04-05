const TelegramBot = require ('node-telegram-bot-api');
const handleMessage = require('./handle-message');

module.exports = function main() {
    const TOKEN = fs.readFileSync("../token.txt", "utf8");
    const bot = new TelegramBot(TOKEN, {polling: true});
    
    bot.on("message", (msg)=> handleMessage(bot, msg));
}

