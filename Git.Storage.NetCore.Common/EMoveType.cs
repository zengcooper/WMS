/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2018-12-27 23:42:29
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2018-12-27 23:42:29       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EMoveType
    {
        [Description("移库上架")]
        ToRack=1,

        [Description("仓库移库")]
        RackToRack=2,

        [Description("报损移库")]
        MoveToBad = 3
    }
}
