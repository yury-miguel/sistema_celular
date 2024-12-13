using DesafioPOO.Models;

Nokia nokia = new ("123456789", "Nokia Antigo", "0000", 48);
Iphone iphone = new ("987654321", "Iphone 13", "1111", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");