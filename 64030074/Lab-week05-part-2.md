# การทดลองสัปดาห์ที่ 5.2 #
## แสดงรายละเอียดของ predefined type ในภาษา C#  ##


### Learning Outcome ###
1. นักศึกษารู้จัก predefined type และบอกได้ว่ามีอะไรบ้าง
2. นักศึกษาสามารถเขียนโปรแกรมเพื่อรายงานค่าเฉพาะตัวของ predefined type ได้

## แบบฝึกหัด ##

แก้ไขโค้ดตัวอย่าง ให้รายงานรายละเอียดของ predefine type ได้ครบถ้วน

Type ใดที่ไม่มี properties ที่กำหนดให้แสดงก็ให้เว้นไว้ หรือใช้การขีด (`-`)
```cs
sbyte sb = new sbyte();  // create new object
byte bt = new byte();
short sh;                 
ushort ush;
int ii = new int();
uint ui;
long lo;
ulong ul;
float fl;
double db;
bool bl;
char ch;
decimal de;

object ob = new object();
string st = new string("");
dynamic dy;


Console.WriteLine($"Declaration\tType name\tType code\tMaximum Value\tMinimum Value");
Console.WriteLine($"----------------------------------------------------------------------------");
Console.WriteLine($"sbyte sb\t{sb.GetType()}\t{sb.GetTypeCode()}\t\t{sbyte.MaxValue}\t\t{sbyte.MinValue}");
Console.WriteLine($"byte bt\t\t{sb.GetType()}\t{bt.GetTypeCode()}\t\t{byte.MaxValue}\t\t{byte.MinValue}");
Console.WriteLine($"short sh");
Console.WriteLine($"ushort ush");
Console.WriteLine($"int ii\t\t{ii.GetType()}\t{ii.GetTypeCode()}\t\t{int.MaxValue}\t{int.MinValue} ");

Console.WriteLine($"object ob\t{ob.GetType()}");
Console.WriteLine($"string st\t{st.GetType()}\t{st.GetTypeCode()} ");

Console.WriteLine("============================================================================");

```
![image](https://user-images.githubusercontent.com/115066414/235320562-cfd9c6bf-ca3c-450b-9a7e-ce0aa8128799.png)
```
sbyte เป็นประเภทจำนวนเต็ม 8 บิตแบบลงตัวและช่วงของมันคือจาก -128 ถึง 127
byte: เป็นประเภทจำนวนเต็ม 8 บิตแบบไม่ลงตัวและช่วงของมันคือจาก 0 ถึง 255
short: เป็นประเภทจำนวนเต็ม 16 บิตแบบลงตัวและช่วงของมันคือจาก -32768 ถึง 32767
ushort: เป็นประเภทจำนวนเต็ม 16 บิตแบบไม่ลงตัวและช่วงของมันคือ
int: เป็นชนิดจำนวนเต็มที่เป็นลบ 32-bit และมีช่วงของค่าจาก -2147483648 ถึง 2147483647
uint: เป็นชนิดจำนวนเต็มที่ไม่เป็นลบ 32-bit และมีช่วงของค่าจาก 0 ถึง 4294967295
long: เป็นชนิดจำนวนเต็มที่เป็นลบ 64-bit และมีช่วงของค่าจาก -9223372036854775808 ถึง 9223372036854775807
ulong: เป็นชนิดจำนวนเต็มที่ไม่เป็นลบ 64-bit และมีช่วงของค่าจาก 0 ถึง 18446744073709551615
float: เป็นชนิดเลขทศนิยม 32-bit สำหรับการเก็บค่าสำหรับหน่วยความสามารถขนาดเล็ก
double: มันเป็นประเภทจำนวนจริง 64-บิตที่มีค่าความแม่นยำ double-precision
bool: เป็นประเภท Boolean ซึ่งสามารถเป็น true หรือ false
char: เป็นประเภทตัวอักษร 16-บิต Unicode
decimal: เป็นประเภทจำนวนที่ถูกต้อง 128-บิต
object: เป็นคลาสพื้นฐานสำหรับทุกประเภทใน C# และแทนตัวอ็อบเจกต์ที่อยู่ในหน่วยความจำ
string: เป็นประเภท string ซึ่งแทนซับซ้อนของตัวอักษร Unicode
dynamic: เป็นประเภทที่เปิดใช้การเรียกเมธอดแบบ dynamic dispatch ซึ่งช่วยให้คุณสามารถเรียกเมธอดและเข้าถึงคุณสมบัติแบบดัชนีด้วยตนเองในเวลารัน
```

![](./Pictures/Lab5_2_Pic1.png)
