using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame.Interfaces
{
    public interface IMovable
    {
        void Move(int deltaX, int deltaY);
    }
}
