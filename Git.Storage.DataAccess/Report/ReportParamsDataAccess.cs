/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 代码工具自动生成
 * Create Date: 2015/09/05 13:07:36

 * Copyright: 太数智能科技（上海）有限公司 
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2015/09/05 13:07:36
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Git.Framework.ORM;
using Git.Framework.MsSql;
using Git.Storage.Entity.Report;
using Git.Storage.IDataAccess.Report;

namespace Git.Storage.DataAccess.Report
{
	public partial class ReportParamsDataAccess : DbHelper<ReportParamsEntity>, IReportParams
	{
		public ReportParamsDataAccess()
		{
		}

	}
}
