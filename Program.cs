using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new("74999887766", "13 PRO", "125154125415404", 264);

iphone.InstalarAplicativo("Vero");
iphone.Ligar();
iphone.ReceberLigacao();

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new("74999887766", "BRICK 10", "516154185411492", 64);

nokia.InstalarAplicativo("Vero");
nokia.Ligar();
nokia.ReceberLigacao();