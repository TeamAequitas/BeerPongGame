using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGame.Players;

namespace RPGame.Players
{
    public class Amateur : Entity
    {
        public Amateur()
            : base()
        {
           
        }

        public Amateur(string name, EntityGender gender)
            : base()
        {
            Name = name;
            Gender = gender;
        }


    }
}
