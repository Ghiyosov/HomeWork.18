



using Task1;
//Task1
var account1 = new Account(18564,"Ismoil", 100m);
account1.GetInfo();
System.Console.WriteLine("------------------");
account1.AddBalance(20m);
account1.GetInfo();
System.Console.WriteLine("------------------");
account1.TakenBalance(80m);
account1.GetInfo();
//Task2
var hekins = new Account(12345, "Heikki's", 1000);
var personal = new Account(12358, "Personal", 0);
hekins.GetInfo();
personal.GetInfo();
System.Console.WriteLine("----------------");
hekins.Transfer(personal,100m);
hekins.GetInfo();
personal.GetInfo();