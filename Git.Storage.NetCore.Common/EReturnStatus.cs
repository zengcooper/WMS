﻿/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2013-11-30 14:33:11
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2013-11-30 14:33:11       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EReturnStatus
    {
        [Description("Success")]
        Success=1,

        [Description("Error")]
        Error=2,

        [Description("Pass")]
        Pass=3,
    }
}
