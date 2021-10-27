using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Manuel = new Person("Manuel", 15);
            Person Juan = new Person("Juan", 12);
            Person Facundo = new Person("Facundo", 20);
            Person Agustin = new Person("Agustin", 20);
            Person Gonza = new Person("Gonzalo", 50);
            Person Luis= new Person("Luis", 21);
            Person Ana = new Person("Ana", 48);
            Person Lara = new Person("Lara", 20);
            Person Amy = new Person("Amy", 10);            

            Node n1 = new Node(Manuel);
            Node n2 = new Node(Juan);
            Node n3 = new Node(Facundo);
            Node n4 = new Node(Agustin);
            Node n5 = new Node(Gonza);
            Node n6 = new Node(Ana);
            Node n7 = new Node(Lara);
            Node n8 = new Node(Amy);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            
            // visitar el árbol aquí
        }
    }
}
