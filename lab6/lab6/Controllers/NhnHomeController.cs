using Microsoft.AspNetCore.Mvc;

namespace NhnLab06.Controllers
{
    public class NhnHomeController : Controller
    {
        public ActionResult NhnIndex()
        {
            ViewBag.StudentInfo = "Họ tên: Nguyễn Văn A - MSSV: 123456 - Lớp: K23CNT1";
            return View();
        }
    }
}
