sbyte sb = new sbyte();  // create new object
byte bt = new byte();
short sh = 0;
ushort ush = 0;
int ii = new int();
uint ui = 0;
long lo = 0;
ulong ul = 0;
float fl = 0.0f;
double db = 0.0;
bool bl = false;
char ch = '\0';
decimal de = 0.0m;

object ob = new object();
string st = new string("");
dynamic dy;


Console.WriteLine($"Declaration\tType name\tType code\tMaximum Value\tMinimum Value");
Console.WriteLine($"----------------------------------------------------------------------------");
Console.WriteLine($"sbyte sb\t{sb.GetType()}\t{sb.GetTypeCode()}\t\t{sbyte.MaxValue}\t\t{sbyte.MinValue}");
Console.WriteLine($"byte bt\t\t{sb.GetType()}\t{bt.GetTypeCode()}\t\t{byte.MaxValue}\t\t{byte.MinValue}");
Console.WriteLine($"short sh\t{sh.GetType()}\t{sh.GetTypeCode()}\t\t{short.MaxValue}\t\t{short.MinValue}");
Console.WriteLine($"ushort ush\t{ush.GetType()}\t{ush.GetTypeCode()}\t\t{ushort.MaxValue}\t\t{ushort.MinValue}");
Console.WriteLine($"int ii\t\t{ii.GetType()}\t{ii.GetTypeCode()}\t\t{int.MaxValue}\t{int.MinValue} ");
Console.WriteLine($"uint ui\t\t{ui.GetType()}\t{ui.GetTypeCode()}\t\t{uint.MaxValue}\t\t{uint.MinValue}");
Console.WriteLine($"long lo\t\t{lo.GetType()}\t{lo.GetTypeCode()}\t\t{long.MaxValue}\t{long.MinValue}");
Console.WriteLine($"ulong ul\t\t{ul.GetType()}\t{ul.GetTypeCode()}\t\t{ulong.MaxValue}\t\t{ulong.MinValue}");
Console.WriteLine($"float fl\t\t{fl.GetType()}\t{fl.GetTypeCode()}\t\t{float.MaxValue}\t\t{float.MinValue} ");
Console.WriteLine($"double db\t\t{db.GetType()}\t{db.GetTypeCode()}\t\t{double.MaxValue}\t\t{double.MinValue}");
Console.WriteLine($"bool bl\t\t{bl.GetType()}\t{bl.GetTypeCode()} ");
Console.WriteLine($"char ch\t\t{ch.GetType()}\t{ch.GetTypeCode()} ");
Console.WriteLine($"decimal de\t{de.GetType()}\t{de.GetTypeCode()}\t\t{decimal.MaxValue}\t{decimal.MinValue} ");

Console.WriteLine("============================================================================");
