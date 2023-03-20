# การทดลองสัปดาห์ที่ 5.1 #
## ศึกษา data structure  และ methods ของ predefined type ในภาษา C#  ##


### Learning Outcome ###
1. นักศึกษารู้จัก predefined type และบอกได้ว่ามีอะไรบ้าง
2. นักศึกษารู้จักองค์ประกอบของ predefined type แต่ละชนิดและสามารถสร้างแผนภาพอธิบาย type เหล่านั้นได้

### ความรู้เบื้องต้น ###
#### 1.  Predefined type ในภาษา C# ####

Predefined type ในภาษา C# มีอยู่ด้วยกัน 16 ชนิด (สำหรับคนที่ update เป็น C# version 9 แล้ว จะมี 18 ชนิด) ดังรูปที่ 1


![](./Pictures/PredefinedType.png)


<p align = "center"> <b>รูปที่ 1</b>  predefined type ในภาษา C# </p>

#### 2. การเข้าถึง predefined type โดยใช้ Visual Studio IDE ####
เราสามารถอาศัยเครื่องมือใน text editor ของ Visual Studio เข้าถึงนิยามของ predefined type ได้โดยการกดปุ่ม F12 หรือ กดปุ่ม Ctrl บนคีย์บอร์ดแล้วใช้เมาส์คลิกที่ขื่อของ Type นั้นๆ

##### ลำดับขั้นการทดลอง #####

1. สร้าง console project ใน Visual studio สมมติว่าตั้งชื่อ project เป็น `Week05_Lab1`



2. แก้ไขไฟล์ `program.cs` มีเนื้อหาดังต่อไปนี้


```cs
class Program
{
    sbyte sb;
    byte bt;
    short sh;
    ushort ush;
    int ii;
    uint ui;
    long lo;
    ulong ul;
    float fl;
    double db;
    bool bl;
    char ch;
    decimal de;

    object ob;
    string st;
    dynamic dy;

    static void Main(string[] args)
    {

    }
}
```

<p align = "center"> <b>รูปที่ 2 </b> Source code  ของ program.cs</p>


3. กดปุ่ม Ctrl แล้วใช้เมาส์คลิกที่ `sbyte` โปรแกรม Visual Studio จะเปิดไฟล์ใหม่ขึ้นมา ซื่งมือเนื้อหาของ `System.Sbyte`

![รูปที่ 2](./Pictures/Lab5_1_Pic2.png)


จะสังเกตได้ว่าในบรรทัดที่ 12 มีการสร้าง type ของข้อมูลเป็น `struct` ซึ่งมีการ สืบทอดมาจาก `Interface` หลายชนิด (จะได้เรียนเรื่อง `interface` ในภายหลัง)

ในบรรทัดที่ 18 และ 22 มีตัวแปรแบบ `public const SByte` จำนวนสองตัว ซึ่งทำหน้าที่บอกค่าสูงสุด (`MaxValue`) และค่าต่ำสุด  (`MinValue`) ที่สามารถเก็บในตัวแปรชนิดนี้ 

จากค่า `MaxValue`  และ   `MinValue` ทำให้เรารู้ได้ว่าตัวแปรที่สร้างจาก type นี้มีขนาด 8 บิตแบบคิดเครื่องหมาย นั่นคือต้องใช้บิดซ้ายสุดจำนวน 1 บิตเป็นตัวเก็บเครื่องหมาย (ถ้าบิตนี้มีค่า 0 คือจำนวนเต็มบวก ถ้าเป็น 1 จะเป็นจำนวนเต็มลบ) ดังนั้นจึงสามารถมีข้อมูลได้ 7 บิต (แทนค่าเป็นเลขฐานสิบได้ 0-127)

`1 0000000` ถึง `1 1111111` เป็นค่าลบ

`0 0000000` ถึง `0 1111111` เป็นค่าบวก


บรรทัดที่ 27 ถึง 338 จะเป็น methods ของชนิดข้อมูลนี้ ทำให้เรารู้ว่าสามารถทำอะไรกับชนิดข้อมูลนี้ได้บ้าง  

ถ้าลองคลิ่ folding โดยการคลิกที่เครื่องหมาย [+] เราจะเห็นข้อความอธิบายอยู่ใน comment ดังรูปที่ 3

![รูปที่ 3](./Pictures/Lab5_1_Pic3.png)

<p align = "center"> <b>รูปที่ 3</b> คำอธิบาย method ของ SByte </p>

4. วาดไดอะแกรมของ type นี้ด้วย plantuml

``` puml
@startuml
class SByte
{
  + Maxvalue : SByte
  + Minvalue : SByte

  + Parse(...) : SByte 
  + TryParse(...) : SByte
  + CompareTo(...) : SByte
  + Equals(...) : bool
  + GatHashCode() : int
  + GetTypeCode() : TypeCode
  + ToString(...) : string
}
@enduml
```

เมื่อ render ด้วยโปรแกรม plantuml แล้วจะได้คลาสไดอะแกรมดังนี้

![รูปที่ 3](./Pictures/SByte_uml.png)

<p align = "center"> <b>รูปที่ 4</b> diagram สำหรับ SByte </p>


----------
__หมายเหตุ__ 

รูปแบบของการเขียนรายละเอียดของตัวแปรและ function ใน class diagram คือ
```
< +|-|# > name [ : < return-type > ]
```
เมื่อ
```
+ คือการเข้าถึงแบบ public
- คือการเข้าถึงแบบ private
# คือการเข้าถึงแบบ protected

< > หมายถึงเป็นส่วนที่ต้องมี (required)
[ ] หมายถึงเป็นส่วนที่ไม่ต้องก็ได้ (optional)

เช่น 
 + Maxvalue : SByte     //  ในกรณีที่ต้องการระบุให้ชัดเจนเนื่องจากรู้ชนิดล่วงหน้าแล้ว
 หรือ 
 + Maxvalue             // ในกรณีที่ยังไม่รู้ชนิดล่วงหน้า 

```
ในกรณีที่ชื่อฟังก์ชันเหมือนกันแต่มี parameter ต่างกันให้เขียน parameter  เป็น (...) แล้วใช้ฟังก์ชันเดียวเท่านั้น

----------

## แบบฝึกหัด ##

เขียนโค้ด plantuml สำหรับ type ชนิดอื่นๆ โดยใช้วิธีเดียวกันกับขั้นตอนที่ 3  เพื่อสร้าง diagram สำหรับ predefined type ทุกชนิด<br>
1.Byte<br>
![image](https://user-images.githubusercontent.com/115066298/226383173-fbcf6987-0a99-40d2-8230-89fcdc05c7ea.png)

2.short(Int16)<br>
![image](https://user-images.githubusercontent.com/115066298/226384862-c9647a49-df60-4889-8c1e-76b1231698e2.png)

3.short(Uint16)<br>
![image](https://user-images.githubusercontent.com/115066298/226385073-46a1e906-d539-499c-8b7d-2ea0c3b7108d.png)

4.int(Int32)<br>
![image](https://user-images.githubusercontent.com/115066298/226385187-c13669e4-815f-4eae-8ace-c5ac5fde7c8d.png)

5.uint(Uint32)<br>
![image](https://user-images.githubusercontent.com/115066298/226385305-28b8bbae-686a-4c81-a04b-cce6f3ec91d4.png)

6.long(Int64)<br>
![image](https://user-images.githubusercontent.com/115066298/226385398-04a239ad-1677-464b-b9c4-d6aa4197db15.png)

7.ulong(Uint64)<br>
![image](https://user-images.githubusercontent.com/115066298/226385510-c82e4e65-df1a-44c7-94f5-83922706a735.png)

8.float(Single)<br>
![image](https://user-images.githubusercontent.com/115066298/226385646-073ce491-6285-45cf-908a-4c0d48ec40bc.png)

9.double<br>
![image](https://user-images.githubusercontent.com/115066298/226385798-10f3135a-44ec-43b9-b56a-52d892a41388.png)

10.bool<br>
![image](https://user-images.githubusercontent.com/115066298/226385899-49c9ea89-dcd3-43ac-afa4-0d7a0839f00f.png)

11.char<br>
![image](https://user-images.githubusercontent.com/115066298/226386000-712a1c5c-2af6-40e6-b0bf-9a21fc03d071.png)

12.decimal<br>
![image](https://user-images.githubusercontent.com/115066298/226386106-953c913e-c482-4b1b-9d89-53ef4fef4c2d.png)
![image](https://user-images.githubusercontent.com/115066298/226386178-c738d673-7f35-4db5-a1fa-06545b2d9619.png)
![image](https://user-images.githubusercontent.com/115066298/226386235-2a69d66d-d629-4e3a-a185-027ff9e23932.png)

13.Object<br>
![image](https://user-images.githubusercontent.com/115066298/226386365-11f4ab97-236d-4e40-acda-64491267a0ae.png)

14.string<br>
![image](https://user-images.githubusercontent.com/115066298/226386449-4caa11fa-add7-4b0b-af0c-2c19e32c7379.png)
![image](https://user-images.githubusercontent.com/115066298/226386489-28d36837-ecf1-4c14-8073-7a6f9d717b5d.png)
![image](https://user-images.githubusercontent.com/115066298/226386569-b13a2bb5-a82b-47bf-bd9f-34fe41942d84.png)
![image](https://user-images.githubusercontent.com/115066298/226386669-e55479d2-4d00-45f6-8cb0-c4cddba29b85.png)
