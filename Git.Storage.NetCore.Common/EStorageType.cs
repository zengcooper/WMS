﻿/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2014-01-22 11:48:50
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2014-01-22 11:48:50       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EStorageType
    {
        [Description("成品仓库")]
        Product=1,

        [Description("原料仓库")]
        Material=2
    }
}
