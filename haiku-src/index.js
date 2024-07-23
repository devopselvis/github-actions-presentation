let express = require('express');
let app = express();
let ejs = require('ejs');
/* *
const haikus = require('./haikus.json');
const port = process.env.PORT || 3000;

app.use(express.static('public'))
app.set('view engine', 'ejs');

app.get('/', (req, res) => {
  res.render('index', {haikus: haikus});
});

app.listen(port);
*/
const haikus = require('./haikus.json');
//const express = require('express');
//const app = express();

app.use(express.static('public'))
app.set('view engine', 'ejs');

app.get('/', (req, res) => {
  res.render('index', {haikus: haikus});
});

app.get('/haikus', (req, res) => {
  res.setHeader('Content-Type', 'application/json');
  res.send({haikus: haikus});
});

module.exports = app;



