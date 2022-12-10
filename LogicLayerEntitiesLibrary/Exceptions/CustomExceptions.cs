using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LogicLayerEntitiesLibrary.Exceptions
{
    public class NullValueException : Exception
    {
        public NullValueException(string message) : base(message) { }
    }

    public class OutOfrangeException : Exception 
    {
        public OutOfrangeException(string message) : base(message) { }
    }

    public class NoResultException : Exception
    {
        public NoResultException(string message) : base(message) { }
    }
}
