# Coffee Machine Console Application
# ข้อมูลนักศึกษา
- ชื่อ: นายศดิศเตชินท์ รัตนพงค์
- รหัสนักศึกษา: 683450194-7

## คำอธิบายโปรแกรม
โปรแกรมเครื่องชงกาแฟร้อนอัตโนมัติแบบ Console  
ผู้ใช้สามารถเลือกเครื่องดื่ม ระบบจะตรวจสอบวัตถุดิบก่อนทำการชง  
หากวัตถุดิบไม่เพียงพอ ระบบจะแจ้งเตือน

## เมนูเครื่องดื่ม
- กาแฟดำ
- มอคค่า
- ลาเต้
- ช็อคโกแลต

## Class Diagram

```mermaid
classDiagram
    class CoffeeMachine {
        -int water
        -int coffee
        -int milk
        -int chocolate
        +CoffeeMachine()
        +MakeBlackCoffee()
        +MakeMocha()
        +MakeLatte()
        +MakeChocolate()
        +ShowStock()
        -CheckStock()
        -UseStock()
    }

    class Program {
        +Main()
    }

    Program --> CoffeeMachine
