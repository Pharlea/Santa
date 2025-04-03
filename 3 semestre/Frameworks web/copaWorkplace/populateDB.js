#! /usr/bin/env node

console.log('Teste gravacao de dados no banco remoto');

// Get arguments passed on command line
var userArgs = process.argv.slice(2);

var async = require('async')
var Copa = require('./models/copa')

var mongoose = require('mongoose');
var mongoDB = userArgs[0];

mongoose.connect(mongoDB, {useNewUrlParser: true, useUnifiedTopology: true});
mongoose.Promise = global.Promise;
var db = mongoose.connection;
db.on('error', console.error.bind(console, 'MongoDB connection error:'));

async function gravaRegistros() {
  await (new Copa({time1: "Prets", pontosTime1: "2", time2: "Só no Looping", pontosTime2: "0",})).save();
  await (new Copa({time1: "Professores Galáticos", pontosTime1: "2", time2: "Inimigos da Bola", pontosTime2: "1"})).save();
  await (new Copa({time1: "Desfibrilador", pontosTime1: "0", time2: "Só-K Nelas", pontosTime2: "1"})).save();
  await (new Copa({time1: "Coxinhas", pontosTime1: "1", time2: "Pindorama", pontosTime2: "0"})).save();
  await (new Copa({time1: "Prets", pontosTime1: "W", time2: "Desfibrilador", pontosTime2: "O"})).save();
  await (new Copa({time1: "Professores Galáticos", pontosTime1: "0", time2: "Coxinhas", pontosTime2: "1"})).save();
  await (new Copa({time1: "Só no Looping", pontosTime1: "0", time2: "Só-K Nelas", pontosTime2: "11"})).save();
  await (new Copa({time1: "Inimigos da Bola", pontosTime1: "1", time2: "Pindorama", pontosTime2: "4"})).save();
  await (new Copa({time1: "Prets", pontosTime1: "0", time2: "Só-K Nelas", pontosTime2: "0"})).save();
  await (new Copa({time1: "Professores Galáticos", pontosTime1: "0", time2: "Pindorama", pontosTime2: "3"})).save();
  await (new Copa({time1: "Só no Looping", pontosTime1: "O", time2: "Desfibrilador", pontosTime2: "W"})).save();
  await (new Copa({time1: "Inimigos da bola", pontosTime1: "0", time2: "Coxinha", pontosTime2: "0"})).save();
  await (new Copa({time1: "Só-K Nelas", pontosTime1: "0", time2: "Pindorama", pontosTime2: "2"})).save();
  await (new Copa({time1: "Coxinha", pontosTime1: "2", time2: "Prets", pontosTime2: "0"})).save();
  await (new Copa({time1: "Pindorama", pontosTime1: "2", time2: "Coxinhas", pontosTime2: "0"})).save();
  await mongoose.connection.close();
}

gravaRegistros()

