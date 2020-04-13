using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationLogic.Exceptions
{
    class TwiceVoteException: Exception
    {
        public string EntityLabel { get; private set; }
        public TwiceVoteException(string entityLabel): base($"Voting twice for {entityLabel} is not permit")
        {
        }
    }
}
