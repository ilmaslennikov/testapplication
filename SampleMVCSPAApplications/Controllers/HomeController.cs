using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVCAplicationServices;
using MVCAplicationServices.ViewModel;

namespace SampleMVCSPAApplications.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEventService _eventService;
        private readonly IBeaconService _beaconService;
        public HomeController(IEventService eventService, IBeaconService beaconService)
        {
            _eventService = eventService;
            _beaconService = beaconService;
        }

        /// <summary>
        /// Домашняя страница
        /// </summary>
        /// <returns>
        /// Домашняя страница
        /// </returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Страница разбора сообщений
        /// </summary>
        /// <returns>
        /// Страница разбора сообщений
        /// </returns>
        public ActionResult Message()
        {
            return View();
        }

        /// <summary>
        /// Страница списка радиомаяков
        /// </summary>
        /// <returns>
        /// Страница списка радиомаяков
        /// </returns>
        public ActionResult BeaconList()
        {
            return View();
        }


        /// <summary>
        /// Страница редактирование радиомаяка
        /// </summary>
        /// <returns>
        /// Страница редактирование радиомаяка
        /// </returns>
        public ActionResult BeaconEdit()
        {
            return View();
        }

        /// <summary>
        /// Возвращает список радиомаяков
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetBeacons()
        {
            return Json(_beaconService.GeBeacons());
        }

        /// <summary>
        /// Разбирает файл с событиями от радиомаяков
        /// </summary>
        /// <returns>
        /// Результат разбора файла
        /// </returns>
        [HttpPost]
        public ActionResult ParseEventFile()
        {

            IEnumerable<BeaconEventParseResult> result = new BeaconEventParseResult[] { };
            if (System.Web.HttpContext.Current.Request.Files.AllKeys.Any())
            {
                var httpPostedFile = System.Web.HttpContext.Current.Request.Files["File"];
                if (httpPostedFile != null)
                {
                    var stringReader = new System.IO.StreamReader(httpPostedFile.InputStream);
                    var content = stringReader.ReadToEnd();
                    var filesText = content.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    result = _eventService.ParseMessages(filesText.ToArray()).ToArray();
                }
            }
            return Json(result);
        }
    }
}