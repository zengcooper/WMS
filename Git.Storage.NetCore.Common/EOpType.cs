/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2014-02-17 16:15:22
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2014-02-17 16:15:22       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EOpType
    {
        [Description("电脑")]
        PC=1,

        [Description("PDA")]
        PDA=2
    }
}
