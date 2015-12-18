using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGame.Players;

namespace RPGame.Players
{
    public class Amateur : Player
    {
        public Amateur()
            : base()
        {
           
        }
        protected new int health=100;
        protected new int strength = 40;
        protected new int accuracy=30;
        protected new int intoxication=0;

        protected int healthModifier;
        protected int strengthModifier;
        protected int accuracyModifier;
        protected int intoxicationModifier;

    
        #region Properties

       public int Strength
        {
            get { return strength + this.strengthModifier; }
            protected set { strength = value + this.strengthModifier; }
        }

        public int Health
        {
            get { return health + this.healthModifier; }
            protected set { health = value + this.healthModifier; }
        }

        public int AccuracyModifier
        {
            get { return accuracy + this.accuracyModifier; }
            protected set { accuracy = value + this.accuracy; }
        }

        public int IntoxicationModifier
        {
            get { return intoxication + this.intoxicationModifier; }
            protected set { intoxication = value + this.intoxicationModifier; }
        }
        #endregion


        public Amateur(int strengthModifier, EntityGender gender, int money = 1000)
            : base()
        {
            Strength = strengthModifier;
            Health = healthModifier;
            Accuracy = accuracyModifier;
            Intoxication = intoxicationModifier;
            Money = money;
        }

    }
}
