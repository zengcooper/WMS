﻿/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2014/5/6 9:00:54
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2014/5/6 9:00:54       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EResourceType
    {
        [Description("非控制")]
        NoRole = 0,

        [Description("页面")]
        Page=1,

        [Description("对话框")]
        Dialog=2,

        [Description("Ajax请求")]
        Ajax=3,

        [Description("链接")]
        Link=4
        
    }
}
