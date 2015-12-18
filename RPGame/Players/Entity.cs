using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame.Players

{
    public enum EntityGender { Male, Female, Other}
    public enum playerLevel { Amateur, Beginner, Pro, Expert, Legend, Other }
    public abstract class Entity
    {
        #region Fields

        protected EntityGender gender;

        protected int health;
        protected int strength;
        protected int accuracy;
        protected int intoxication;

        
        #endregion

        #region Properties

       public EntityGender Gender
        {
            get { return this.gender; }

            protected set { this.gender = value; }
        }

        public virtual int Strength
        {
            get { return this.strength; }    
            protected set { this.strength = value; }
        }

        public virtual int Health
        {
            get { return this.health; }
            protected set { this.health = value; }
        }

        public virtual int Accuracy
        {
            get { return this.accuracy; }
            protected set { this.accuracy = value; }
        }

        public virtual int Intoxication
        {
            get { return this.intoxication; }
            protected set { this.intoxication = value; }
        }
        #endregion

        #region Constructor

        protected Entity()
        {
            Gender = gender;
            Strength = 50;
            Health = 100;
            Accuracy = 50;
            Intoxication = 0;
        }

        #endregion

        #region Methods

        #endregion
    }
}
