/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2015/10/8 13:04:17
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2015/10/8 13:04:17       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum ESequence
    {
        [Description("常量")]
        Constant = 1,

        [Description("GUID")]
        Guid = 2,

        [Description("自定义时间")]
        CustomerTime = 3,

        [Description("流水号")]
        Sequence = 4,

        [Description("每日流水号")]
        SequenceOfDay = 5
    }
}
