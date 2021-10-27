using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {

        private Person Persona;

        private List<Node> children = new List<Node>();


        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person persona)
        {
            this.Persona = persona;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
    }
}
