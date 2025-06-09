using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLAB5.Models;

namespace NetCoreMVCLAB5.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        // GET: Account
        public ActionResult Index()
        {
            List<Account> accounts = new List<Account>();
            return View(accounts);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        public IActionResult Create(Account account)
        {
            if (ModelState.IsValid)
            {
                // Sau này sẽ lưu vào database, tạm thời chuyển về Index
                return RedirectToAction("Index");
            }

            return View(account); // Trả về form cùng lỗi
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyPhone(string phone)
        {
            Regex _isPhone = new Regex(@"^(\(?[0-9]{3}\)?)[-.\s]?[0-9]{3}[-.\s]?[0-9]{4}$");
            if (!_isPhone.IsMatch(phone))
            {
                return Json($"Số điện thoại {phone} không đúng định dạng, VĐ: 0986421127, hotline: 098.421.1327");
            }
            return Json(true);
        }
        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}