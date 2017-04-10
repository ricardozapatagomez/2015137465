using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensambladora.Entities
{
    public class RandomNumber
    {
        public int getrandom()
        {
            Random random= new Random();
            int i = random.Next(11111, 99999);
            return i;
        }
    }
}
