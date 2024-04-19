using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MickolPaige.Assets.Utils
{
    class Maid
    {
        Dictionary<Action, Action> boundActions = new();

        public void Bind<T>(Action<T> a, Action<T> func)
        {
            a += func;
        }

        public void Destroy()
        {

        }
    }
}
