﻿/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: Cooper
 * Create Date: 2017-01-01 14:38:43
 *
 * Description: Git.Framework
 * 
 * 瑞慈云仓储：http://yun.gitwms.com/
 * 瑞慈仓储系统:http://www.gitwms.com/
 * 
 * Revision History:
 * Date         Author               Description
 * 2013-09-01 15:10:06       Cooper
*********************************************************************************/

using Git.Framework.DataTypes;
using Git.Framework.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Git.Framework.DataTypes.ExtensionMethods;

namespace Git.Storage.Common.EnumJson
{
    public partial class EnumToJsonHelper
    {
        private static IDictionary<string, Type> listType = null;

        /// <summary>
        /// 注册枚举值类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="en"></param>
        /// <returns></returns>
        public static void Reg<T>(T en)
        {
            listType = listType.IsNull() ? new Dictionary<string, Type>() : listType;
            Type type = typeof(T);
            string name = type.Name;
            if (!listType.ContainsKey(name))
            {
                listType.Add(name, type);
            }
        }

        /// <summary>
        /// 注册枚举值类型
        /// </summary>
        /// <param name="type"></param>
        public static void Reg(params Type[] types)
        {
            listType = listType.IsNull() ? new Dictionary<string, Type>() : listType;
            if (types != null)
            {
                foreach (Type type in types)
                {
                    string name = type.Name;
                    if (!listType.ContainsKey(name))
                    {
                        listType.Add(name, type);
                    }
                }
            }
        }

        /// <summary>
        /// 将枚举类型转化为JSON字符串
        /// </summary>
        /// <returns></returns>
        public static string GetJson(Type type)
        {
            List<ReadEnum> list = EnumHelper.GetEnumList(type);
            JsonProperty property = new JsonProperty();
            foreach (ReadEnum item in list)
            {
                JsonObject jsonItem = new JsonObject();
                jsonItem.AddProperty("Name", item.Name);
                jsonItem.AddProperty("Value", item.Value);
                jsonItem.AddProperty("Description", item.Description);
                property.Add(jsonItem);
            }
            return property.ToString();
        }

        /// <summary>
        /// 获得枚举类型转化为json对象
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetJsonObject(Type type)
        {
            List<ReadEnum> list = EnumHelper.GetEnumList(type);
            JsonObject jsonObject = new JsonObject();
            foreach (ReadEnum item in list)
            {
                jsonObject.AddProperty(item.Name,item.Value);
            }
            return jsonObject.ToString();
        }

        /// <summary>
        /// 获得js内容
        /// </summary>
        /// <returns></returns>
        public static string GetJs()
        {
            StringBuilder sb = new StringBuilder();
            if (listType != null)
            {
                foreach (Type type in listType.Values)
                {
                    sb.AppendFormat("var {0}={1};", type.Name, GetJson(type));
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获得所有的枚举对象集合
        /// </summary>
        /// <returns></returns>
        public static string GetMenuObject()
        {
            StringBuilder sb = new StringBuilder();
            if (listType != null)
            {
                foreach (Type type in listType.Values)
                {
                    sb.AppendFormat("var {0}={1};", type.Name+"Json", GetJsonObject(type));
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static string GetJson<T>(T entity)
        {
            Type type = typeof(T);
            return GetJson(type);
        }
    }
}
