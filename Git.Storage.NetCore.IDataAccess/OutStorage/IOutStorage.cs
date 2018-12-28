/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 代码工具自动生成
 * Create Date: 2013-08-19 12:02:43

 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2013-08-19 12:02:43
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Git.Framework.ORM;
using Git.Storage.Entity.OutStorage;
using Git.Storage.Entity.Report;

namespace Git.Storage.IDataAccess.OutStorage
{
	public partial interface IOutStorage : IDbHelper<OutStorageEntity>
	{
        /// <summary>
        /// 查询指定时间段范围内各个产品的数量
        /// </summary>
        /// <param name="status"></param>
        /// <param name="storageNum"></param>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        List<ReportChart> GetChartTop(int status, string storageNum, DateTime beginTime, DateTime endTime);
	}
}
