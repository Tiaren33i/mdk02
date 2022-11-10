//import img from './img/file.jpg';
require('./magazine.js');

var normalizedPath = require("./").join(__dirname, "img");



require("./").readdirSync(normalizedPath).forEach(function(file) {

require("./img/" + file);

});

//https://tproger.ru/translations/webpack-from-zero-to-hero/
//https://habr.com/ru/post/447560/
//https://lavalite.org/blog/require-all-files-in-the-folder-in-nodejs
//https://habr.com/ru/post/350886/