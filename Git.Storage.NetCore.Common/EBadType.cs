/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2018-12-27 23:45:39
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2018-12-27 23:45:39       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EBadType
    {
        [Description("损坏报损")]
        Bad = 1,

        [Description("丢失报损")]
        Loss = 2,
    }
}
