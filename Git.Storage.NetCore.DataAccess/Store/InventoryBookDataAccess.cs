/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 代码工具自动生成
 * Create Date: 2014/03/02 22:02:54

 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2014/03/02 22:02:54
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
	public partial class InventoryBookDataAccess : DbHelper<InventoryBookEntity>, IInventoryBook
	{
		public InventoryBookDataAccess()
		{
		}

	}
}
