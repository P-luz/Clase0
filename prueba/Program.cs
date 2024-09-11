  
using System.Text;
Console.WriteLine ("**************DESAFIO******************");
string firstName3;
firstName3 = "Bob";
//Console.WriteLine (firstName);
int num=3;
//Console.WriteLine (num);
//float tem = 34.4f;
//Console.WriteLine (tem);
var tem2 = 34.4;
//Console.WriteLine (tem2);
Console.WriteLine ("Hello,"+ firstName3 + ",! You have"+ num + "messages in your inbox. The temperature is"+tem2+ "celsius.");

Console.WriteLine ("***********Ejemplo UTF**************");
Console.OutputEncoding=Encoding.UTF8;
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
//Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
//Console.WriteLine(@"c:\invoices\app.exe -j");

Console.Clear();
Console.WriteLine ("***********Ejemplo 1**************");
int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText} {version.ToString()}!";
Console.WriteLine(message);

Console.Clear();
Console.WriteLine ("***********Ejemplo UTF**************"); 
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

Console.Clear();
Console.WriteLine ("***********desafío**************"); 
Console.OutputEncoding=Encoding.UTF8;
projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine (russianMessage);
