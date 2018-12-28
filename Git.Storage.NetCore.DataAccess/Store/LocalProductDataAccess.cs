/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 代码工具自动生成
 * Create Date: 2018-12-27 23:30:48

 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2018-12-27 23:30:48
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Git.Framework.ORM;
using Git.Framework.MsSql;
using Git.Storage.Entity.Store;
using Git.Storage.IDataAccess.Store;

namespace Git.Storage.DataAccess.Store
{
	public partial class LocalProductDataAccess : DbHelper<LocalProductEntity>, ILocalProduct
	{
		public LocalProductDataAccess()
		{
		}

	}
}
