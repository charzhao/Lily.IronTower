using System;
using System.Collections.Generic;
using System.Text;
using EPPlus.Core.Extensions;
using Newtonsoft.Json;

namespace Lily.Tools
{
    [ExcelWorksheet("兴庆区基站加补测属性挂接1中心点")]
    public class IronTowerInfo
    {
        /// <summary>
        /// 基站编号
        /// </summary>
        [ExcelTableColumn("基站编号")]
        [JsonProperty(PropertyName = "基站编号")]
        public string Number { get; set; }

        /// <summary>
        /// 站址编码
        /// </summary>
        [ExcelTableColumn("站址编码")]
        [JsonProperty(PropertyName = "站址编码")]
        public string AddressCode { get; set; }
        /// <summary>
        /// 市县区
        /// </summary>
        [ExcelTableColumn("市县区")]
        [JsonProperty(PropertyName = "市县区")]
        public string BelongTo { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [ExcelTableColumn("地址")]
        [JsonProperty(PropertyName = "地址")]
        public string Adress { get; set; }
        /// <summary>
        /// 面积（平方米）
        /// </summary>
        [ExcelTableColumn("面积（平方米）")]
        [JsonProperty(PropertyName = "面积（平方米）")]
        public string Area { get; set; }


        /// <summary>
        /// 类型
        /// </summary>
        [ExcelTableColumn("类型")]
        [JsonProperty(PropertyName = "类型")]
        public string Type { get; set; }


        /// <summary>
        /// 坐落单位代码
        /// </summary>
        [ExcelTableColumn("坐落单位代码")]
        [JsonProperty(PropertyName = "坐落单位代码")]
        public string ZuoLuoDepartmentCode { get; set; }

        /// <summary>
        /// 坐落单位名称
        /// </summary>
        [ExcelTableColumn("坐落单位名称")]
        [JsonProperty(PropertyName = "坐落单位名称")]
        public string ZuoLuoDepartmentName { get; set; }

        /// <summary>
        /// 权属性质
        /// </summary>
        [ExcelTableColumn("权属性质")]
        [JsonProperty(PropertyName = "权属性质")]
        public string QuanShuXingZhi { get; set; }


        /// <summary>
        /// 地类编码
        /// </summary>
        [ExcelTableColumn("地类编码")]
        [JsonProperty(PropertyName = "地类编码")]
        public string DiLeiCode { get; set; }

        /// <summary>
        /// 地类名称
        /// </summary>
        [ExcelTableColumn("地类名称")]
        [JsonProperty(PropertyName = "地类名称")]
        public string DileiName { get; set; }


        /// <summary>
        /// 纬度
        /// </summary>
        [ExcelTableColumn("纬度")]
        [JsonProperty(PropertyName = "纬度")]
        public string Longitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [ExcelTableColumn("经度")]
        [JsonProperty(PropertyName = "经度")]
        public string Latitude { get; set; }
        /// <summary>
        /// 业主名称
        /// </summary>
        [ExcelTableColumn("业主名称")]
        [JsonProperty(PropertyName = "业主名称")]
        public string YeZhuName { get; set; }

        /// <summary>
        /// 合同编码
        /// </summary>
        [ExcelTableColumn("合同编码")]
        [JsonProperty(PropertyName = "合同编码")]
        public string ContractCode { get; set; }
        /// <summary>
        /// 起始日期
        /// </summary>
        [ExcelTableColumn("起始日期")]
        [JsonProperty(PropertyName = "起始日期")]
        public string StartDate { get; set; }
        /// <summary>
        /// 终止日期
        /// </summary>
        [ExcelTableColumn("终止日期")]
        [JsonProperty(PropertyName = "终止日期")]
        public string EndDate { get; set; }


        /// <summary>
        /// 年租金
        /// </summary>
        [ExcelTableColumn("年租金")]
        [JsonProperty(PropertyName = "年租金")]
        public string AnnualRent { get; set; }

        /// <summary>
        /// 基站属性备注
        /// </summary>
        [ExcelTableColumn("基站属性备注")]
        [JsonProperty(PropertyName = "基站属性备注")]
        public string JiZhanPropertyCommonts { get; set; }
    }
}
