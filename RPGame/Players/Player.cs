using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RPGame.Interfaces;

namespace RPGame.Players
{
    public partial class Player : Entity, IMovable
    {

        public Player()
           : base()
        {

        }

        #region Fields

        protected string name;
        protected int money;
        protected playerLevel level;


        #endregion

        #region Properties

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }

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

        #endregion

        #region Constructor

        public Player(string name,EntityGender gender, playerLevel level, int money)
         : base()
        {
            Name = this.name;
            Gender = this.gender;
            Level = this.level;
            Money = this.money;
            
        }


        #endregion

        #region Methods

        #endregion

       

       
        }
}

