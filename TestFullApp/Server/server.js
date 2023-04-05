const request = require('request');
const url = 'http://admin:admin@192.168.1.109/dev/sps/io/Button1/On'; // http://www.mysite.ru/index.php
var answer = '';

request({
   method: 'GET',
   url: url,
  }, function (error, response, body) {
  if (!error && response.statusCode == 200) {
    // console.log(body);
    // валидация и 
    // обработка полученного ответа, заголовков
    answer = body;
  }
})