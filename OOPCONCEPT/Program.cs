
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCONCEPT
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice\n1.SingleInheritance\n2.Multileve\n3.Hirarchical\n4.CompileTimePoly\n5.RuntimePoly\n6.Abstraction\n7.Interface\n8.Encapsulation");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //Single Inheritance
                    Dog dog = new Dog();
                    dog.Name = " Juli";
                    dog.display();
                    dog.getName();
                    Console.ReadLine();
                    break;
                case 2:
                    //multilevel inheritance
                    child child = new child();
                    child.Name = " GANDPAPA";
                    child.printName();
                    child.Name2 = " PAPA";
                    child.setName();
                    child.Name3 = " VARSHA";
                    child.getName();
                    Console.ReadLine();
                    break;
                case 3:
                    //hierarchical inheritance
                    Principal g = new Principal();
                    g.Monitor();
                    Teacher d = new Teacher();
                    d.Monitor();
                    d.Teach();
                    Student s = new Student();
                    s.Monitor();
                    s.Learn();
                    Console.ReadLine();
                    break;
                case 4:
                    //compileTimePolymorphism
                    CompileTime compile = new CompileTime();
                    compile.show(5);
                    compile.show(2.5);
                    compile.show("vasu");
                    Console.ReadLine();
                    break;
                case 5:
                    //RuntimePolymorphism
                    Animal1 a = new Animal1();
                    a.eat();
                    Dog1 d1 = new Dog1();
                    d1.eat();
                    Console.ReadLine();
                    break;
                case 6:
                    //Abstraction
                    Shape s1;
                    s1 = new Rectangle();
                    s1.draw();
                    s1 = new Circle();
                    s1.draw();
                    Console.ReadLine();
                    break;
                case 7:
                    //Interface
                    Drawable dra;
                    dra = new Rectangle1();
                    dra.draw();
                    dra = new Circle1();
                    dra.draw();
                    break;
                case 8:
                    //Encapsulation
                    DemoEncap obj = new DemoEncap();
                    obj.Name = "varsha";
                    obj.Age = 21;
                    Console.WriteLine("Name: " + obj.Name);
                    Console.WriteLine("Age: " + obj.Age);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("not avaliable");
                    break;
            }

        }
    }
}

       
    



