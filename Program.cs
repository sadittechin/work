using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineApp
{
namespace CoffeeMachineApp
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                CoffeeMachine machine = new CoffeeMachine(5000, 500, 500, 500);

                while (true)
                {
                    Console.WriteLine("\n====== เครื่องชงกาแฟร้อนอัตโนมัติ ======");
                    Console.WriteLine("1. กาแฟดำ");
                    Console.WriteLine("2. มอคค่า");
                    Console.WriteLine("3. ลาเต้");
                    Console.WriteLine("4. ช็อคโกแลต");
                    Console.WriteLine("5. แสดงวัตถุดิบคงเหลือ");
                    Console.WriteLine("0. ออกจากโปรแกรม");
                    Console.Write("เลือกเมนู: ");

                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            machine.MakeBlackCoffee();
                            break;
                        case "2":
                            machine.MakeMocha();
                            break;
                        case "3":
                            machine.MakeLatte();
                            break;
                        case "4":
                            machine.MakeChocolate();
                            break;
                        case "5":
                            machine.ShowStock();
                            break;
                        case "0":
                            Console.WriteLine("ออกจากโปรแกรม...");
                            return;
                        default:
                            Console.WriteLine("กรุณาเลือกเมนูที่ถูกต้อง");
                            break;
                    }
                }
            }
        }

        public class CoffeeMachine
        {
            private int water;
            private int coffee;
            private int milk;
            private int chocolate;

            // Constructor
            public CoffeeMachine(int water, int coffee, int milk, int chocolate)
            {
                this.water = water;
                this.coffee = coffee;
                this.milk = milk;
                this.chocolate = chocolate;
            }

            public void MakeBlackCoffee()
            {
                if (CheckStock(300, 20, 0, 0))
                {
                    UseStock(300, 20, 0, 0);
                    Console.WriteLine(" ชงกาแฟดำเรียบร้อย");
                }
            }

            public void MakeMocha()
            {
                if (CheckStock(300, 20, 0, 10))
                {
                    UseStock(300, 20, 0, 10);
                    Console.WriteLine(" ชงมอคค่าเรียบร้อย");
                }
            }

            public void MakeLatte()
            {
                if (CheckStock(300, 20, 10, 0))
                {
                    UseStock(300, 20, 10, 0);
                    Console.WriteLine(" ชงลาเต้เรียบร้อย");
                }
            }

            public void MakeChocolate()
            {
                if (CheckStock(300, 0, 0, 20))
                {
                    UseStock(300, 0, 0, 20);
                    Console.WriteLine(" ชงช็อคโกแลตเรียบร้อย");
                }
            }

            private bool CheckStock(int w, int c, int m, int ch)
            {
                if (water < w || coffee < c || milk < m || chocolate < ch)
                {
                    Console.WriteLine(" วัตถุดิบไม่เพียงพอ");
                    return false;
                }
                return true;
            }

            private void UseStock(int w, int c, int m, int ch)
            {
                water -= w;
                coffee -= c;
                milk -= m;
                chocolate -= ch;
            }

            public void ShowStock()
            {
                Console.WriteLine("\n--- วัตถุดิบคงเหลือ ---");
                Console.WriteLine($"น้ำ: {water} g");
                Console.WriteLine($"กาแฟ: {coffee} g");
                Console.WriteLine($"นม: {milk} g");
                Console.WriteLine($"ช็อคโกแลต: {chocolate} g");
            }
        }
    }

        
        }
    

