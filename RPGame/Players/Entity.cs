using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame.Players

{
    public enum EntityGender { Male, Female, Other}
    public enum playerLevel { Amateur, Beginner, Pro, Expert, Legend }
    public abstract class Entity
    {
        #region Fields

        protected string name;

        protected EntityGender gender;

        protected int health;
        protected int strength;
        protected int accuracy;
        protected int intoxication;

        protected int healthModifier;
        protected int strengthModifier;
        protected int accuracyModifier;
        protected int intoxicationModifier;

        #endregion

        #region Properties

        public string Name
        {
            get { return this.name; }

            protected set { this.name = value; }
        }

        public EntityGender Gender
        {
            get { return this.gender; }

            protected set { this.gender = value; }
        }

        public int Strength
        {
            get { return this.strength+ strengthModifier; }    
            protected set { this.strength = value; }
        }

        public int Health
        {
            get { return this.health+healthModifier; }
            protected set { this.health = value; }
        }

        public int Accuracy
        {
            get { return this.accuracy + accuracyModifier; }
            protected set { this.accuracy = value; }
        }

        public int Intoxication
        {
            get { return this.intoxication + intoxicationModifier; }
            protected set { this.intoxication = value; }
        }
        #endregion

        #region Constructor

        public Entity()
        {
            Name = "";
            Strength = 0;
            Health = 100;
            Accuracy = 0;
            Intoxication = 0;
        }

        #endregion

        #region Methods

        #endregion
    }
}
