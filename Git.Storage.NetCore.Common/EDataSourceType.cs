﻿/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2015/9/5 20:59:26
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2015/9/5 20:59:26       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EDataSourceType
    {
        [Description("SQL语句")]
        SQL=1,

        [Description("存储过程")]
        Procedure=2
    }
}
