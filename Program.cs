using DesafioPOO.Models;

Nokia nokia = new Nokia("4444","Nokia","11234679",58);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhastApp");

Console.WriteLine("==================================================");

Iphone iphone = new Iphone("55555","Iphone 11","12345678",103);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
