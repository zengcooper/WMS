/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2014-01-23 10:48:14
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2014-01-23 10:48:14       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EUnit
    {
        [Description("件")]
        Jian=1,

        [Description("台")]
        Tai=2,

        [Description("张")]
        Zhang = 3
    }
}
