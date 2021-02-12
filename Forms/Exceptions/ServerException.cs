using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Exceptions
{
    public class ServerException : Exception
    {
        public ServerException() : base("Server je ugasen!")
        {

        }


    }
}
