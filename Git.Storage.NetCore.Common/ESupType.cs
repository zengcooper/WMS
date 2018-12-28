﻿/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2014-08-11 18:52:24
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2014-08-11 18:52:24       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum ESupType
    {
        /// <summary>
        /// 虚拟供应商
        /// </summary>
        [Description("虚拟供应商")]
        Invented = 1,

        [Description("合作供应商")]
        Cooperation = 2
    }
}
