using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n1);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            Person person1 = new Person("Mateo",21);
            Person person2 = new Person("Bruno",23);
            Person person3 = new Person("Sebastian",24);
            Person person4 = new Person("Rodrigo",25);
            Person person5 = new Person("Corina",26);
            Person person6 = new Person("Maria",27);
            Person person7 = new Person("Milagros",28);
            Person person8 = new Person("Pilar",22);

            
            // visitar el árbol aquí


        }
    }
}
