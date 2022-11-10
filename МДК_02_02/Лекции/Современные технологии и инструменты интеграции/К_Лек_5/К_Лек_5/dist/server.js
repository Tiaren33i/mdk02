const express = require("express");
var bodyParser = require("body-parser");
var fs = require("fs");


const app = express();
var jsonParser = bodyParser.json();
 
app.use(express.static(__dirname));

app.get("/", function(request, response){
    var content = fs.readFileSync("dist/data.json", "utf8");
    var all = JSON.parse(content);

    response.send(all);
});
app.get("/users", function(request, response){
    var content = fs.readFileSync("dist/data.json", "utf8");
    var all = JSON.parse(content);

    response.send(all.users); 
 //   response.send("<h1>О сайте</h1>");
});
app.get("/contacts", function(request, response){
    var content = fs.readFileSync("dist/data.json", "utf8");
    var all = JSON.parse(content);
    response.send(all.contacts); 
 //   response.send("<h1>Контакты</h1>");
});
app.listen(3000);