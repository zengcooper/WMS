/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2015/9/5 20:58:16
 *
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2015/9/5 20:58:16       Cooper
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum EReportType
    {
        [Description("单据")]
        Bill=1,

        [Description("报表")]
        Report=2
    }
}
