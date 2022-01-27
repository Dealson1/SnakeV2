using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeV2
{
    public class LengthException : Exception
    {
        public override string Message
        {
            get
            {
                return "Введите минимум 2 символа.";
            }
        }
    }
}
