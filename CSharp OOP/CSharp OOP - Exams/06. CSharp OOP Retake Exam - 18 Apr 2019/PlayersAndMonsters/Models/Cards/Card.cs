﻿namespace PlayersAndMonsters.Models.Cards
{
    using System;

    using PlayersAndMonsters.Utilities.Messages;
    using PlayersAndMonsters.Models.Cards.Contracts;
    
    public abstract class Card : ICard
    {
        private string name;
        private int damagePoints;
        private int healthPoints;

        protected Card(string name, int damagePoints, int healthPoints)
        {
            this.Name = name;
            this.DamagePoints = damagePoints;
            this.HealthPoints = healthPoints;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NullCardName);
                }

                this.name = value;
            }
        }

        public int DamagePoints
        {
            get => this.damagePoints;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.NegativeCardDamagePoints);
                }

                this.damagePoints = value;
            }
        }

        public int HealthPoints
        {
            get => this.healthPoints;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.NegativeCardHealthPoints);
                }

                this.healthPoints = value;
            }
        }
    }
}
