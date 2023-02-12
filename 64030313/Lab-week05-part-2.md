# การทดลองสัปดาห์ที่ 5.2 #
## แสดงรายละเอียดของ predefined type ในภาษา C#  ##


### Learning Outcome ###
1. นักศึกษารู้จัก predefined type และบอกได้ว่ามีอะไรบ้าง
2. นักศึกษาสามารถเขียนโปรแกรมเพื่อรายงานค่าเฉพาะตัวของ predefined type ได้

## แบบฝึกหัด ##

แก้ไขโค้ดตัวอย่าง ให้รายงานรายละเอียดของ predefine type ได้ครบถ้วน

Type ใดที่ไม่มี properties ที่กำหนดให้แสดงก็ให้เว้นไว้ หรือใช้การขีด (`-`)
```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sb = new sbyte();  // create new object
            byte bt = new byte();
            short sh = new short();
            ushort ush = new ushort();
            int ii = new int();
            uint ui = new uint();
            long lo = new long();
            ulong ul = new ulong();
            float fl = new float();
            double db = new double();
            bool bl = new bool();
            char ch = new char();
            decimal de = new decimal();

            object ob = new object();
            string st = new string(new char[] { });
            //dynamic dy = new { };
            dynamic dy = new System.Dynamic.ExpandoObject();

            Console.WriteLine($"Declaration\tType name\tType code\tMaximum Value\tMinimum Value");
            Console.WriteLine($"----------------------------------------------------------------------------");
            Console.WriteLine($"sbyte sb\t{sb.GetType()}\t{sb.GetTypeCode()}\t\t{sbyte.MaxValue}\t\t{sbyte.MinValue}");
            Console.WriteLine($"byte bt\t\t{bt.GetType()}\t{bt.GetTypeCode()}\t\t{byte.MaxValue}\t\t{byte.MinValue}");
            Console.WriteLine($"short sh\t{sh.GetType()}\t{sh.GetTypeCode()}\t\t{short.MaxValue}\t\t{short.MinValue}");
            Console.WriteLine($"ushort ush\t{ush.GetType()}\t{ush.GetTypeCode()}\t\t{ushort.MaxValue}\t\t{ushort.MinValue}");
            Console.WriteLine($"int ii\t\t{ii.GetType()}\t{ii.GetTypeCode()}\t\t{int.MaxValue}\t{int.MinValue} ");
            Console.WriteLine($"uint ui\t\t{ui.GetType()}\t{ui.GetTypeCode()}\t\t{uint.MaxValue}\t{uint.MinValue} ");
            Console.WriteLine($"long lo\t\t{lo.GetType()}\t{lo.GetTypeCode()}\t\t{long.MaxValue}\t{long.MinValue} ");
            Console.WriteLine($"ulong ul\t{ul.GetType()}\t{ul.GetTypeCode()}\t\t{ulong.MaxValue}\t{ulong.MinValue} ");
            Console.WriteLine($"float fl\t{fl.GetType()}\t{fl.GetTypeCode()}\t\t{float.MaxValue}\t{float.MinValue} ");
            Console.WriteLine($"double db\t{db.GetType()}\t{db.GetTypeCode()}\t\t{double.MaxValue}\t{double.MinValue} ");
            Console.WriteLine($"bool bl\t\t{bl.GetType()}\t{bl.GetTypeCode()}\t\t{bool.TrueString}\t{bool.FalseString} ");
            Console.WriteLine($"char ch\t\t{ch.GetType()}\t{ch.GetTypeCode()}\t\t{char.MaxValue}\t{char.MinValue} ");
            Console.WriteLine($"decimal de\t{de.GetType()}\t{de.GetTypeCode()}\t\t{decimal.MaxValue}\t{decimal.MinValue} ");
            Console.WriteLine($"object ob\t{ob.GetType()}\t{"---"}\t\t{decimal.MaxValue}\t{decimal.MinValue} ");
            Console.WriteLine($"string st\t{st.GetType()}\t{st.GetTypeCode()}\t\t{"---"}\t{"---"} ");
            Console.WriteLine($"dynamic dy\t{dy.GetType()}\t{"---"}\t{"---"}\t{"---"} ");


            Console.WriteLine("============================================================================");
            Console.ReadKey();
        }
    }
}
```

![329329481_562760435792382_5552503357897288267_n](https://user-images.githubusercontent.com/115037574/218332735-62c8c1a8-dcd5-4052-9920-d8e589caab51.png)

`sbyte มันเป็นประเภทจำนวนเต็ม 8 บิตแบบลงตัวและช่วงของมันคือจาก -128 ถึง 127`<br>
`byte: มันเป็นประเภทจำนวนเต็ม 8 บิตแบบไม่ลงตัวและช่วงของมันคือจาก 0 ถึง 255`<br>
`short: มันเป็นประเภทจำนวนเต็ม 16 บิตแบบลงตัวและช่วงของมันคือจาก -32768 ถึง 32767`<br>
`ushort: มันเป็นประเภทจำนวนเต็ม 16 บิตแบบไม่ลงตัวและช่วงของมันคือ`<br>
`int: เป็นชนิดจำนวนเต็มที่เป็นลบ 32-bit และมีช่วงของค่าจาก -2147483648 ถึง 2147483647`<br>
`uint: เป็นชนิดจำนวนเต็มที่ไม่เป็นลบ 32-bit และมีช่วงของค่าจาก 0 ถึง 4294967295`<br>
`long: เป็นชนิดจำนวนเต็มที่เป็นลบ 64-bit และมีช่วงของค่าจาก -9223372036854775808 ถึง 9223372036854775807`<br>
`ulong: เป็นชนิดจำนวนเต็มที่ไม่เป็นลบ 64-bit และมีช่วงของค่าจาก 0 ถึง 18446744073709551615`<br>
`float: เป็นชนิดเลขทศนิยม 32-bit สำหรับการเก็บค่าสำหรับหน่วยความสามารถขนาดเล็ก`<br>
`double: มันเป็นประเภทจำนวนจริง 64-บิตที่มีค่าความแม่นยำ double-precision`<br>
`bool: มันเป็นประเภท Boolean ซึ่งสามารถเป็น true หรือ false`<br>
`char: มันเป็นประเภทตัวอักษร 16-บิต Unicode`<br>
`decimal: มันเป็นประเภทจำนวนที่ถูกต้อง 128-บิต`<br>
`object: มันเป็นคลาสพื้นฐานสำหรับทุกประเภทใน C# และแทนตัวอ็อบเจกต์ที่อยู่ในหน่วยความจำ`<br>
`string: มันเป็นประเภท string ซึ่งแทนซับซ้อนของตัวอักษร Unicode`<br>
`dynamic: มันเป็นประเภทที่เปิดใช้การเรียกเมธอดแบบ dynamic dispatch ซึ่งช่วยให้คุณสามารถเรียกเมธอดและเข้าถึงคุณสมบัติแบบดัชนีด้วยตนเองในเวลารัน`
