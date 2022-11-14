using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {         
            Node n1 = new Node(1,80,"Jesabel");
            Node n2 = new Node(2,50,"Juan");
            Node n3 = new Node(3,47,"Diego");
            Node n4 = new Node(4,55,"Jose");
            Node n5 = new Node(5,19,"Francisco");
            Node n6 = new Node(6,15,"Guillermo");
            Node n7 = new Node(7,24,"Paula");
            Node n8 = new Node(8,29,"Valentina");
            Node n9 = new Node(9,1,"Dante");
            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);

            n2.AddChildren(n5);
            n2.AddChildren(n6);

            n4.AddChildren(n7);
            n4.AddChildren(n8);

            n3.AddChildren(n9);

            VisitorAge TotalAge1 = new VisitorAge();
            TotalAge1.VisitNode(n1);
            Console.WriteLine($"la suma de las edades de todos los integrantes de la familia es: {TotalAge1.Content()}");
            VisitorName LargestName1 = new VisitorName();
            LargestName1.VisitNode(n1);
            Console.WriteLine(LargestName1.Content());
            VisitorSon Son1 = new VisitorSon();
            Son1.VisitNode(n1);
            Console.WriteLine(Son1.Content());
        }
    }
}
