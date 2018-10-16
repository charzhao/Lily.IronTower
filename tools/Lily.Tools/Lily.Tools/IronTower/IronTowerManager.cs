using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EPPlus.Core.Extensions;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace Lily.Tools
{
    public class IronTowerManager
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public IronTowerManager(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public void Handle()
        {
            var rootPath = _hostingEnvironment.ContentRootPath;
            var excelFileName = @"IronTower\兴庆区基站信息\兴庆区基站信息（中心点）.xlsx";
            FileInfo file = new FileInfo(Path.Combine(rootPath, excelFileName));

            using (var package = new ExcelPackage(file))
            {
                var table = package.GetWorksheet(0);
                List<IronTowerInfo> list = table.ToList<IronTowerInfo>();
                var distinctList=list.GroupBy(o => o.AddressCode)
                    .Select(o => o.FirstOrDefault());

                string json = JsonConvert.SerializeObject(distinctList.ToArray());
                System.IO.File.WriteAllText($"{rootPath}\\兴庆区基站信息（中心点）.json", json);
            }
        }
    }
}
