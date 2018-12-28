/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2018-12-27 23:39:49
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2018-12-27 23:39:49       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EAudite
    {
        [Description("等待审核")]
        Wait=1,

        [Description("审核成功")]
        Pass=2,

        [Description("审核失败")]
        NotPass=3
    }
}
