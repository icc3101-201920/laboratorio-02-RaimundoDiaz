using System;
namespace Laboratorio_1_OOP_201902.Card
{
    public class Card
    {
        protected string name;
        protected string type;

        public Card(string name, string type)
        {
            this.name = name;
            this.type = type;
        }

        public string GetName()
        {
            return name;
        }

        public string GetType()
        {
            return type;
        }
    }
}
