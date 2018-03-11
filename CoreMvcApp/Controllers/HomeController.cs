using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreMvcApp.Models;

namespace CoreMvcApp.Controllers
{
    public class HomeController : Controller
    {
        //首页
        public IActionResult Index()
        {            
            return View();
        }

        // 音乐
        public IActionResult Music(int id = 0)
        {
            return View();
        }

        // 演唱会
        public IActionResult LiveVedio(int id = 0)
        {
            return View();
        }

        // 专辑
        public IActionResult Album(int id = 0)
        {
            return View();
        }

        // 动态
        public IActionResult Dynamic(int id = 0)
        {

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
