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

        public Amateur(string name, EntityGender gender, int money=1000)
            : base()
        {
            Name = name;
            Gender = gender;
            Money = money;
        }


    }
}
