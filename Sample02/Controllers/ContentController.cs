using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01.Controllers
{
    /// <summary>
    /// 2018.11.19
    /// 祝雷
    /// Content控制器
    /// </summary>
    public class ContentController : Controller
    {
        private readonly Content contents;

        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }
        public IActionResult Index()
        {

            return View(new ContentViewModel { Contents = new List<Content> { contents } });
        }
    }
}
