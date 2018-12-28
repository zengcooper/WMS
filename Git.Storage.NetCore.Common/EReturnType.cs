/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2014/4/20 21:58:13
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2014/4/20 21:58:13       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EReturnType
    {
        [Description("销售退货")]
        Sell = 1,

        [Description("采购退货")]
        Purchase = 2
    }
}
