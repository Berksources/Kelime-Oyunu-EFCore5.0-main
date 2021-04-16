using DataAccesLayer;
using Entity.KelimeOyunu;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using WebKelimeOyunu.Models;

namespace WebKelimeOyunu.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        private readonly IUnitOfWork<User> _unitOfWorkUser;
        private readonly IUnitOfWork<UserRole> _unitOfWorkUserRole;
        private readonly IUnitOfWork<ScoreTable> _unitOfWorkScoreTable;
        private readonly IUnitOfWork<FourWord> _unitOfWorkFour;
        private readonly IUnitOfWork<FifthWord> _unitOfWorkFive;
        private readonly IUnitOfWork<SixthWord> _unitOfWorkSix;
        private readonly IUnitOfWork<SevenWord> _unitOfWorkSeven;
        private readonly IUnitOfWork<EightWord> _unitOfWorkEight;
        private readonly IUnitOfWork<NineWord> _unitOfWorkNine;
        private readonly IUnitOfWork<TenWord> _unitOfWorkTen;


        public AdminController
        (
        IUnitOfWork<User> unitOfWorkUser,
        IUnitOfWork<UserRole> unitOfWorkUserRole,
        IUnitOfWork<ScoreTable> unitOfWorkScoreTable,
        IUnitOfWork<FourWord> unitOfWorkFour,
        IUnitOfWork<FifthWord> unitOfWorkFive,
        IUnitOfWork<SixthWord> unitOfWorkSix,
        IUnitOfWork<SevenWord> unitOfWorkSeven,
        IUnitOfWork<EightWord> unitOfWorkEight,
        IUnitOfWork<NineWord> unitOfWorkNine,
        IUnitOfWork<TenWord> unitOfWorkTen
        )
        {
            _unitOfWorkFour = unitOfWorkFour;
            _unitOfWorkFive = unitOfWorkFive;
            _unitOfWorkSix = unitOfWorkSix;
            _unitOfWorkSeven = unitOfWorkSeven;
            _unitOfWorkEight = unitOfWorkEight;
            _unitOfWorkNine = unitOfWorkNine;
            _unitOfWorkUser = unitOfWorkUser;
            _unitOfWorkUserRole = unitOfWorkUserRole;
            _unitOfWorkScoreTable = unitOfWorkScoreTable;
        }
        //
        public IActionResult Index()
        {

            return View();
        }
        //

        //
        public IActionResult Users()
        {
            var allAdmin = _unitOfWorkUser.RepositoryUser.GetAdmins();
            var allGamers = _unitOfWorkUser.RepositoryUser.GetGamers();
            var userViewModel = new UserViewModel
            {
                Gamers = allGamers,
                Admins = allAdmin
            };
            return View(userViewModel);
        }
        //

        /////+444444444
        [HttpPost]
        public IActionResult PostFourWord(FourWord fourWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkFour.RepositoryFour.Create(fourWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkFour.Complete();
                }
                else
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("FourWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("ProductIndex");
            }
        }
        [HttpPost]
        public IActionResult UpdateFourWord(FourWord fourWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                fourWord.ModifiedDate = DateTime.Now;
                _unitOfWorkFour.RepositoryFour.Update(fourWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime güncelleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkFour.Complete();
                }
                else
                {
                    TempData["Message"] = "Kelime güncelleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("FourWord");
            }
            else
            {
                TempData["Message"] = "Güncellemek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("FourWord");
            }
        }
        [HttpPost]
        public IActionResult DeleteFourWord(FourWord fourWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                fourWord.ModifiedDate = DateTime.Now;
                _unitOfWorkFour.RepositoryFour.Delete(fourWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime silme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkFour.Complete();
                }
                else
                {
                    TempData["Message"] = "Kelime silme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("FourWord");
            }
            else
            {
                TempData["Message"] = "silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("FourWord");
            }
        }
        public IActionResult FourWordIndex()
        {
            var allWordsWithFour = _unitOfWorkFour.RepositoryFour.GetAll();
            var fourWordViewModel =  new FourWordViewModel
          {
                FourWords = allWordsWithFour
          };
            return View(fourWordViewModel);
        }
        public IActionResult FourWordCreate()
        {
            return View();
        }
        public IActionResult FourWordUpdate(int ID)
        {
            var allWordsWithFour = _unitOfWorkFour.RepositoryFour.GetFourWordByID(ID);
            var fourWordViewModel = new FourWordViewModel
            {
                FourWordsOnly = allWordsWithFour
            };
            return View(fourWordViewModel);
        }
        /////+444444444

        /////+555555555
        [HttpPost]
        public IActionResult PostFiveWord(FifthWord fiveWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkFive.RepositoryFive.Create(fiveWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkFive.Complete();
                }
                else
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("FiveWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("FiveWord");
            }
        }
        [HttpPost]
        public IActionResult UpdateFiveWord(FifthWord fiveWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkFive.RepositoryFive.Update(fiveWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime GÜncelleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkFive.Complete();
                }
                else
                {
                    TempData["Message"] = "Kelime Güncelleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("FiveWord");
            }
            else
            {
                TempData["Message"] = "Silmek güncelleme veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("FiveWord");
            }
        }
        [HttpPost]
        public IActionResult DeleteFiveWord(FifthWord fiveWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkFive.RepositoryFive.Delete(fiveWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime silme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkFive.Complete();
                }
                else
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("FiveWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("FiveWord");
            }
        }
        public IActionResult FiveWordIndex()
        {
            var allWordsWithFive = _unitOfWorkFive.RepositoryFive.GetAll();
            var fiveWordViewModel =  new FiveWordViewModel
          {
                FifthWords = allWordsWithFive
          };
            return View(fiveWordViewModel);
        }
        public IActionResult FiveWordCreate()
        {
            return View();
        }
        public IActionResult FiveWordUpdate(int ID)
        {
            var allWordsWithFive = _unitOfWorkFive.RepositoryFive.GetFifthWordByID(ID);
            var fiveWordViewModel = new FiveWordViewModel
            {
                FifthWordOnly = allWordsWithFive
            };
            return View(fiveWordViewModel);
        }
        /////+555555555

        /////+666666666
        [HttpPost]
        public IActionResult PostSixWord(SixthWord sixWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkSix.RepositorySix.Create(sixWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkSix.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("SixWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("SixWord");
            }
        }
        [HttpPost]
        public IActionResult UpdateSixWord(SixthWord sixWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkSix.RepositorySix.Update(sixWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime Güncelleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkSix.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("SixWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("SixWord");
            }
        }
        [HttpPost]
        public IActionResult DeleteSixWord(SixthWord sixWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkSix.RepositorySix.Delete(sixWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime Silme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkSix.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("SixWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("SixWord");
            }
        }
        public IActionResult SixthWordIndex()
        {
            var allWordsWithSixth = _unitOfWorkSix.RepositorySix.GetAll();
            var sixWordViewModel =  new SixthWordViewModel
          {
                SixthWords = allWordsWithSixth
          };
            return View(sixWordViewModel);
        }
        public IActionResult SixthWordCreate()
        {
            return View();
        }
        public IActionResult SixthWordUpdate(int ID)
        {
            var allWordsWithSixth = _unitOfWorkSix.RepositorySix.GetSixWordByID(ID);
            var sixWordViewModel = new SixthWordViewModel
            {
                SixthWordsOnly = allWordsWithSixth
            };
            return View(sixWordViewModel);
        }
        /////+666666666

        /////+777777777
        [HttpPost]
        public IActionResult PostSevenWord(SevenWord sevenWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkSeven.RepositorySeven.Create(sevenWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkSeven.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("SevenWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("SevenWord");
            }
        }

        [HttpPost]
        public IActionResult UpdateSevenWord(SevenWord sevenWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkSeven.RepositorySeven.Update(sevenWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkSeven.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("SevenWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("SevenWord");
            }
        }

        [HttpPost]
        public IActionResult DeleteSevenWord(SevenWord sevenWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkSeven.RepositorySeven.Delete(sevenWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkSeven.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("SevenWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("SevenWord");
            }
        }
        public IActionResult SevenWordIndex()
        {
            var allWordsWithSeven = _unitOfWorkSeven.RepositorySeven.GetAll();
            var sevenWordViewModel =  new SevenWordViewModel
          {
                SevenWords = allWordsWithSeven
          };
            return View(sevenWordViewModel);
        }
        public IActionResult SevenWordCreate()
        {
            return View();
        }
        public IActionResult SevenWordUpdate(int ID)
        {
            var allWordsWithSeven = _unitOfWorkSeven.RepositorySeven.GetSevenWordByID(ID);
            var sevenWordViewModel = new SevenWordViewModel
            {
                SevenWordsOnly = allWordsWithSeven
            };
            return View(sevenWordViewModel);
        }
        /////+777777777

        /////+888888888
        [HttpPost]
        public IActionResult PostEightWord(EightWord eightWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkEight.RepositoryEight.Create(eightWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkEight.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("EightWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("EightWord");
            }
        }
        [HttpPost]
        public IActionResult UpdateEightWord(EightWord eightWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkEight.RepositoryEight.Update(eightWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkEight.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("EightWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("EightWord");
            }
        }

        [HttpPost]
        public IActionResult DeleteEightWord(EightWord eightWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkEight.RepositoryEight.Delete(eightWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkEight.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("EightWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("EightWord");
            }
        }

        public IActionResult EightWordIndex()
        {
            var allWordsWithEight = _unitOfWorkEight.RepositoryEight.GetAll();
            var eightWordViewModel =  new EightWordViewModel
          {
                EightWords = allWordsWithEight
          };
            return View(eightWordViewModel);
        }
        public IActionResult EightWordCreate()
        {
            return View();
        }
        public IActionResult EightWordUpdate(int ID)
        {
            var allWordsWithEight = _unitOfWorkEight.RepositoryEight.GetEightWordByID(ID);
            var eightWordViewModel = new EightWordViewModel
            {
                EightWordOnly = allWordsWithEight
            };
            return View(eightWordViewModel);
        }
        /////+888888888

        /////+999999999
        [HttpPost]
        public IActionResult PostNineWord(NineWord nineWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkNine.RepositoryNine.Create(nineWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkNine.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("NineWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("NineWord");
            }
        }

        [HttpPost]
        public IActionResult UpdateNineWord(NineWord nineWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkNine.RepositoryNine.Update(nineWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkNine.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("NineWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("NineWord");
            }
        }

        [HttpPost]
        public IActionResult DeleteNineWord(NineWord nineWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkNine.RepositoryNine.Delete(nineWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkNine.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("NineWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("NineWord");
            }
        }

        public IActionResult NineWordIndex()
        {
            var allWordsWithNine = _unitOfWorkNine.RepositoryNine.GetAll();
            var nineWordViewModel = new NineWordViewModel
          {
                NineWords = allWordsWithNine
          };
            return View(nineWordViewModel);
        }
        public IActionResult NineWordCreate()
        {
            return View();
        }
        public IActionResult NineWordUpdate(int ID)
        {
            var allWordsWithNine = _unitOfWorkNine.RepositoryNine.GetNineWordByID(ID);
            var nineWordViewModel = new NineWordViewModel
            {
                NineWordOnly = allWordsWithNine
            };
            return View(nineWordViewModel);
        }
        /////+999999999

        /////+10-10-10-
        [HttpPost]
        public IActionResult PostTenWord(TenWord tenWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkTen.RepositoryTen.Create(tenWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkTen.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("TenWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("TenWord");
            }
        }

        [HttpPost]
        public IActionResult UpdateTenWord(TenWord tenWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkTen.RepositoryTen.Update(tenWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkTen.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("TenWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("TenWord");
            }
        }

        [HttpPost]
        public IActionResult DeleteTenWord(TenWord tenWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkTen.RepositoryTen.Delete(tenWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkTen.Complete();
                }
                else
                {
                    TempData["Message"] = "Ürün ekleme işleminiz başarısız!";
                    TempData["JS"] = "showError();";
                }
                return RedirectToAction("TenWord");
            }
            else
            {
                TempData["Message"] = "Silmek istediğiniz veri hatalı!";
                TempData["JS"] = "showError();";
                return RedirectToAction("TenWord");
            }
        }

        public IActionResult TenWordIndex()
        {
            var allWordsWithTen = _unitOfWorkTen.RepositoryTen.GetAll();
            var tenWordViewModel =  new TenWordViewModel
          {
                TenWords = allWordsWithTen
          };
            return View(tenWordViewModel);
        }
        public IActionResult TenWordCreate()
        {
            return View();
        }
        public IActionResult TenWordUpdate(int ID)
        {
            var allWordsWithTen = _unitOfWorkTen.RepositoryTen.GetTenWordByID(ID);
            var tenWordViewModel = new TenWordViewModel
            {
                TenWordOnly = allWordsWithTen
            };
            return View(tenWordViewModel);
        }
        /////+10-10-10-

        //
        public IActionResult ScoreTable()
        {
            var allScore = _unitOfWorkScoreTable.RepositoryScoreTable.GetAll();
            var scoreTableViewModel = new ScoreTableViewModel
          {
                ScoreTables = allScore
          };
            return View(scoreTableViewModel);
        }
        //
    }
}
