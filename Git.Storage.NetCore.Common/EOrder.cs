﻿/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2015/9/10 22:41:11
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2015/9/10 22:41:11       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EOrder
    {
        [Description("入库单")]
        InOrder=1,

        [Description("出库单")]
        OutOrder=2
    }
}
