/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 代码工具自动生成
 * Create Date: 2018-12-27 23:33:14

 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2018-12-27 23:33:14
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Git.Framework.ORM;
using Git.Framework.MsSql;
using Git.Storage.Entity.Move;
using Git.Storage.IDataAccess.Move;

namespace Git.Storage.DataAccess.Move
{
	public partial class MoveOrderDataAccess : DbHelper<MoveOrderEntity>, IMoveOrder
	{
		public MoveOrderDataAccess()
		{
		}

	}
}
