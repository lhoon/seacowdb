﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLRDB.Core.Exceptions
{
    public class SelectException : DLRDBException 
    {
        public SelectException(String message) : base (message)
        {   
        }
    }
}
