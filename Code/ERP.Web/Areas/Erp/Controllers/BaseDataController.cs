﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using ERP.Web.Models;
using ERP.Web;

namespace ERP.Web.Areas.Erp.Controllers
{
    public class BaseDataController : Controller
    {
        public ActionResult Index()
        {
            var model = new
            {
                dataSource = new
                {
                    TypeItems = Public.GetEnumTypeList<BaseType>()
        },
                urls = new
                {
                    query = "/api/erp/BaseData",
                    edit = "/api/erp/BaseData/edit"
                },
                resx = new
                {
                    noneSelect = "请先选择一条数据！",
                    editSuccess = "保存成功！",
                },
                form = new
                {
                    name = "",
                    type = ""
                },
                defaultRow = new
                {

                },
                setting = new
                {
                    postListFields = new string[] { "id", "name", "type","isenable", "remark", "create_time", "create_username" }
                }
            };
            return View(model);
        }
    }

    public class BaseDataApiController : ApiController
    {
        public dynamic Get(RequestWrapper query)
        {
            query.LoadSettingXmlString(@"
            <settings defaultOrderBy='create_time'>
                <select>*</select>
                <from>base_data</from>
                <where defaultForAll='true' defaultCp='equal' defaultIgnoreEmpty='true' >
                    <field name='name'     cp='like'></field>
                    <field name='type'  cp='equal' ></field>
                </where>
            </settings>");
            var service = new base_dataService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }

        [System.Web.Http.HttpPost]
        public void Edit(dynamic data)
        {
            var listWrapper = RequestWrapper.Instance().LoadSettingXmlString(@"
            <settings>
                <table>base_data</table>
                <where>
                    <field name='id' cp='equal'></field>
                </where>
            </settings>");
            var service = new base_dataService();
            var result = service.Edit(null, listWrapper, data);
        }
    }
}