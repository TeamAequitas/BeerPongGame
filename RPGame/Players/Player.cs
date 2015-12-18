using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPGame.Players
{
    public partial class Player : Entity
    {
        private int money;
        private playerLevel level;
        

        public int Money
        {
            get { return this.money; }
            protected set { this.money = value; }
        }

        public playerLevel Level
        {
            get { return this.level; }
            protected set { this.level = value; }
        }

        public Player()
            : base()
        {
           
        }

        public Player(string name, EntityGender gender, playerLevel level, int money)
            : base()
        {
            Name = this.name;
            Gender = this.gender;
            Money = this.money;
            Level = this.level;
        }
    }
}
