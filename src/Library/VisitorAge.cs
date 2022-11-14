using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class VisitorAge:Visitor
    {
        public int TotalAge{get;set;}  
        public VisitorAge()
        {
            this.TotalAge= 80;
        }
        public override string Content()
        {
          return TotalAge.ToString();
        }
    
        public override void Visit(Person person)
        {
            TotalAge+=person.Age;
        }
        public override void VisitNode(Node node)
        {
            foreach (Node Child in node.Children)
            {
                Child.Accept(this);
                this.Visit(Child.Person);
            }
        }
    }
}