byte b = 10;
short s = 200;
int i = 1000;
long l = 50000L;
float f = 12.5F;
double d = 45.678;
decimal dec = 123.456M;
char c = 'A';
bool isTrue = true;


string strNumber = 42.ToString();
double convertedDouble = Convert.ToDouble("3.14");


Console.WriteLine($"byte: {b}");
Console.WriteLine($"short: {s}");
Console.WriteLine($"int: {i}");
Console.WriteLine($"long: {l}");
Console.WriteLine($"float: {f}");
Console.WriteLine($"double: {d}");
Console.WriteLine($"decimal: {dec}");
Console.WriteLine($"char: {c}");
Console.WriteLine($"bool: {isTrue}");
Console.WriteLine($"Converted int (42) to string: {strNumber}");
Console.WriteLine($"Converted string (\"3.14\") to double: {convertedDouble}");