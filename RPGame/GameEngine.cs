using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGame
{
    class GameEngine
    {
        public void Run()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BeerPongStartScreen());
        }
    }
}
