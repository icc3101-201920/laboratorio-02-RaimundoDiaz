using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class SpecialCard : Card
    {
        //Atributos
        private string buffType;
        private string effect;

        //Constructor
        public SpecialCard(string name, string type, string effect) : base (name, type)
        {
            Name = name;
            Type = type;
            Effect = effect;
            BuffType = null;
        }

        //Propiedades
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        //Propiedades
        public string BuffType
        {
            get
            {
                return this.buffType;
            }
            set
            {
                this.buffType = value;
            }
        }
        public string Effect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
        }

        internal void Add(SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }

        public static implicit operator SpecialCard(SpecialCard v)
        {
            throw new NotImplementedException();
        }
    }
}
