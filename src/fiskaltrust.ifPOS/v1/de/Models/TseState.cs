﻿using System.Runtime.Serialization;

namespace fiskaltrust.ifPOS.v1.de
{
    [DataContract]
    public class TseState
    {
        [DataMember(Order = 1)]
        public TseStates CurrentState;
    }
}
