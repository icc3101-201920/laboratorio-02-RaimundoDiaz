using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Board : Game
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;

        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;

        private SpecialCard[] captainCards;
        private List<SpecialCard> weatherCards;

        //Propiedades
        public List<CombatCard>[] MeleeCards
        {
            get
            {
                return this.meleeCards;
            }
        }
        public List<CombatCard>[] RangeCards
        {
            get
            {
                return this.rangeCards;
            }
        }
        public List<CombatCard>[] LongRangeCards
        {
            get
            {
                return this.longRangeCards;
            }
        }
        public SpecialCard[] SpecialMeleeCards
        {
            get
            {
                return this.specialMeleeCards;
            }
            set
            {
                this.specialMeleeCards = value;
            }
        }
        public SpecialCard[] SpecialRangeCards
        {
            get
            {
                return this.specialRangeCards;
            }
            set
            {
                this.specialRangeCards = value;
            }
        }
        public SpecialCard[] SpecialLongRangeCards
        {
            get
            {
                return this.specialLongRangeCards;
            }
            set
            {
                this.specialLongRangeCards = value;
            }
        }
        public SpecialCard[] CaptainCards
        {
            get
            {
                return this.captainCards;
            }
        }
        public List<SpecialCard> WeatherCards
        {
            get
            {
                return this.weatherCards;
            }
        }


        //Constructor
        public Board()
        {
            this.meleeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard>();
            this.captainCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
        }

        

        //Metodos
        public void AddCombatCard(int PlayerId , CombatCard combatCard)
        {
            switch (combatCard.Type)
            {
                case "melee":
                    AddMeleeCard(PlayerId, combatCard);
                    break;
                case "range":
                    AddRangeCard(PlayerId, combatCard);
                    break;
                case "longRange":
                    AddLongRangeCard(PlayerId, combatCard);
                    break;
                default:
                    Console.WriteLine(" Invalid Combat Card Type, must be 'melee', 'range' or 'longRange' ");
                    break;
            }

        }
        public void AddMeleeCard(int playerId, CombatCard combatCard)
        {
            MeleeCards[playerId - 1].Add(combatCard);
        }
        public void AddRangeCard(int playerId, CombatCard combatCard)
        {
            RangeCards[playerId - 1].Add(combatCard);
        }
        public void AddLongRangeCard(int playerId, CombatCard combatCard)
        {
            LongRangeCards[playerId - 1].Add(combatCard);
        }
        public void AddSpecialCard(SpecialCard specialCard, int playerId, string buffType)
        {
            switch (specialCard.Type)
            {
                case "captainCard":
                    if (
                        SpecialMeleeCards[playerId - 1] == null &&   // COMO SOLO PUEDE HABER UNA SPECIALCARD HAGO EL &&
                        SpecialRangeCards[playerId - 1] == null &&
                        SpecialLongRangeCards[playerId - 1] == null &&
                        CaptainCards[playerId - 1] == null
                        )
                    {
                        SpecialMeleeCards[playerId - 1].Add(specialCard);
                    }

                    else
                    {
                        Console.WriteLine("There is a SpecialCard already on the board");
                    }

                    break;

                case "specialMelee":
                    if (
                        SpecialMeleeCards[playerId - 1] == null &&   // COMO SOLO PUEDE HABER UNA SPECIALCARD HAGO EL &&
                        SpecialRangeCards[playerId - 1] == null &&
                        SpecialLongRangeCards[playerId - 1] == null &&
                        CaptainCards[playerId - 1] == null
                        )
                    {
                        SpecialMeleeCards[playerId - 1].Add(specialCard);
                    }

                    else
                    {
                        Console.WriteLine("There is a SpecialCard already on the board");
                    }

                    break;

                case "specialRange":
                    if (
                        SpecialMeleeCards[playerId - 1] == null &&   // COMO SOLO PUEDE HABER UNA SPECIALCARD HAGO EL &&
                        SpecialRangeCards[playerId - 1] == null &&
                        SpecialLongRangeCards[playerId - 1] == null &&
                        CaptainCards[playerId - 1] == null
                        )
                    {
                        SpecialRangeCards[playerId - 1].Add(specialCard);
                    }

                    else
                    {
                        Console.WriteLine("There is a SpecialCard already on the board");
                    }

                    break;
                case "specialLongRange":
                    if (
                        SpecialMeleeCards[playerId - 1] == null &&   // COMO SOLO PUEDE HABER UNA SPECIALCARD HAGO EL &&
                        SpecialRangeCards[playerId - 1] == null &&
                        SpecialLongRangeCards[playerId - 1] == null &&
                        CaptainCards[playerId - 1] == null
                        )
                    {
                        SpecialLongRangeCards[playerId - 1].Add(specialCard);
                    }

                    else
                    {
                        Console.WriteLine("There is a SpecialCard already on the board");
                    }

                    break;

                default:
                    Console.WriteLine(" Invalid Special Card Type, must be 'specialMelee', 'specialRange', 'specialLongRange' or 'captainCard' ");
                    break;
            }
        }
        public void AddCaptainCard(int playerId, SpecialCard specialCard)
        {
            CaptainCards[playerId - 1].Add(specialCard);
        }
        public void AddWeatherCard(int playerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void DestroyCombatCard(int playerId)
        {
            DestroyMeleeCard(playerId);
            DestroyMeleeCard(playerId);
            DestroyLongRangeCard(playerId);
        }
        public void DestroyMeleeCard(int playerId)
        {
            MeleeCards[playerId - 1].Clear();
        }
        public void DestroyRangeCard(int playerId)
        {
            RangeCards[playerId - 1].Clear();
        }
        public void DestroyLongRangeCard(int playerId)
        {
            LongRangeCards[playerId - 1].Clear();
        }
        public void DestroySpecialCards()
        {
            //SpecialMeleeCards[0].Clear();
            //SpecialRangeCards[0].Clear();
            //SpecialLongRangeCards[0].Clear();
        }
        public void DestroySpecialMeleeCard(int playerId)
        {
            //SpecialMeleeCards[playerId - 1].Clear; no entiendo porque tira error, la SpecialMeleeCards no es una lista del mismo tipo que MeleeCards?
        }
        public void DestroySpecialRangeCard(int playerId)
        {
            //SpecialRangeCards[playerId - 1].Clear();
        }
        public void DestroySpecialLongRangeCard(int playerId)
        {
            //SpecialLongRangeCards[playerId - 1].Clear();
        }
        public void DestroyWeatherCard(int playerId)
        {
            throw new NotImplementedException();
        }
        //public int[,] GetMeleeAttackPoints()
        //{
            //int[,] AP = new { Players[1].AttackPoints, Players[0].AttackPoints };
            //return AP;

        //}
        public int[] GetRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
        public int[] GetLongRangeAttackPoints()
        {
            throw new NotImplementedException();
        }
    }
}
