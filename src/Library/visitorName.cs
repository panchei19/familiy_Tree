using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class VisitorName:Visitor
    {
    
    public string LarggestName{get;set;}
    public VisitorName()
    {
        this.LarggestName="";
    }
    public override string Content()
    {
        return LarggestName.ToString();
    }
    
    public override void Visit(Person person)
    {
        if (person.Name.Length>LarggestName.Length)
        {
            LarggestName= person.Name;
        }
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