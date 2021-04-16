using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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


      public AdminController(
      IUnitOfWork<User> unitOfWorkUser;
      IUnitOfWork<UserRole> unitOfWorkUserRole;
      IUnitOfWork<ScoreTable> unitOfWorkScoreTable;
      IUnitOfWork<FourWord> unitOfWorkFour;
      IUnitOfWork<FifthWord> unitOfWorkFive;
      IUnitOfWork<SixthWord> unitOfWorkSix;
      IUnitOfWork<SevenWord> unitOfWorkSeven;
      IUnitOfWork<EightWord> unitOfWorkEight;
      IUnitOfWork<NineWord> unitOfWorkNine;
      IUnitOfWork<TenWord> unitOfWorkTen;
      )
      {
        _unitOfWorkFour=unitOfWorkFour;
        _unitOfWorkFive=unitOfWorkFive;
        _unitOfWorkSix=unitOfWorkSix;
        _unitOfWorkSeven=unitOfWorkSeven;
        _unitOfWorkEight=unitOfWorkEight;
        _unitOfWorkNine=unitOfWorkNine;
        _unitOfWorkUser=unitOfWorkUser;
        _unitOfWorkUserRole=unitOfWorkUserRole;
        _unitOfWorkScoreTable=unitOfWorkScoreTable;
      }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Users()
        {
          var allAdmin= _unitOfWorkUser.RepositoryUser.GetAdmins();
          var allGamers= _unitOfWorkUser.RepositoryUser.GetGamers();
          var userViewModel= new userViewModel
          {
            Gamers=allGamers,
            Admins=allAdmin
          };
            return View(userViewModel);
        }


        /////+444444444
        [HttpPost]
public IActionResult PostFourWord(FourWord fourWord)
{
    if (ModelState.IsValid)
    {
        int request;
        _unitOfWorkFourWord.RepositoryFourWord.Create(fourWord);
        request = HttpContext.Response.StatusCode;
        if (request == 200)
        {
            TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
            TempData["JS"] = "showSuccess();";
            _unitOfWorkFourWord.Complete();
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
                product.ModifiedDate = DateTime.Now;
                _unitOfWorkFourWord.RepositoryFourWord.Update(fourWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime güncelleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkFourWord.Complete();
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
                        product.ModifiedDate = DateTime.Now;
                        _unitOfWorkFourWord.RepositoryFourWord.Delete(fourWord);
                        request = HttpContext.Response.StatusCode;
                        if (request == 200)
                        {
                            TempData["Message"] = "Kelime silme işleminiz başarılı!";
                            TempData["JS"] = "showSuccess();";
                            _unitOfWorkFourWord.Complete();
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
        public IActionResult FourWord()
        {
          var allWordsWithFour=_unitOfWorkFour.RepositoryFour.GetAll();
          var fourWordViewModel=FourWordViewModel
          {
            FourWords=allWordsWithFour
          };
            return View(fourWordViewModel);
        }


        [HttpPost]
public IActionResult PostFiveWord(FifthWord fiveWord)
{
    if (ModelState.IsValid)
    {
        int request;
        _unitOfWorkFiveWord.RepositoryFiveWord.Create(fiveWord);
        request = HttpContext.Response.StatusCode;
        if (request == 200)
        {
            TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
            TempData["JS"] = "showSuccess();";
            _unitOfWorkFiveWord.Complete();
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
_unitOfWorkFiveWord.RepositoryFiveWord.Update(fiveWord);
request = HttpContext.Response.StatusCode;
if (request == 200)
{
    TempData["Message"] = "Kelime GÜncelleme işleminiz başarılı!";
    TempData["JS"] = "showSuccess();";
    _unitOfWorkFiveWord.Complete();
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
_unitOfWorkFiveWord.RepositoryFiveWord.Delete(fiveWord);
request = HttpContext.Response.StatusCode;
if (request == 200)
{
    TempData["Message"] = "Kelime silme işleminiz başarılı!";
    TempData["JS"] = "showSuccess();";
    _unitOfWorkFiveWord.Complete();
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
        public IActionResult FiveWord()
        {
          var allWordsWithFive=_unitOfWorkFive.RepositoryFive.GetAll();
          var fiveWordViewModel=FiveWordViewModel
          {
            FiveWords=allWordsWithFive
          };
            return View(allWordsWithFive);
        }



        [HttpPost]
               public IActionResult PostSixWord(SixthWord sixWord)
               {
                   if (ModelState.IsValid)
                   {
                       int request;
                       _unitOfWorkSixWord.RepositorySixWord.Create(sixWord);
                       request = HttpContext.Response.StatusCode;
                       if (request == 200)
                       {
                           TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                           TempData["JS"] = "showSuccess();";
                           _unitOfWorkSixWord.Complete();
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
                              _unitOfWorkSixWord.RepositorySixWord.Update(sixWord);
                              request = HttpContext.Response.StatusCode;
                              if (request == 200)
                              {
                                  TempData["Message"] = "Kelime Güncelleme işleminiz başarılı!";
                                  TempData["JS"] = "showSuccess();";
                                  _unitOfWorkSixWord.Complete();
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
                                     _unitOfWorkSixWord.RepositorySixWord.Delete(sixWord);
                                     request = HttpContext.Response.StatusCode;
                                     if (request == 200)
                                     {
                                         TempData["Message"] = "Kelime Silme işleminiz başarılı!";
                                         TempData["JS"] = "showSuccess();";
                                         _unitOfWorkSixWord.Complete();
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


        public IActionResult SixthWord()
        {
          var allWordsWithSixth=_unitOfWorkSix.RepositorySix.GetAll();
          var sixWordViewModel=SixWordViewModel
          {
            SixWords=allWordsWithSixth
          };
            return View(sixWordViewModel);
        }


        [HttpPost]
        public IActionResult PostSevenWord(SevenWord sevenWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkSevenWord.RepositorySevenWord.Create(sevenWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkSevenWord.Complete();
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
                _unitOfWorkSevenWord.RepositorySevenWord.Update(sevenWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkSevenWord.Complete();
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
                _unitOfWorkSevenWord.RepositorySevenWord.Delete(sevenWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkSevenWord.Complete();
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
        public IActionResult SevenWord()
        {
          var allWordsWithSeven=_unitOfWorkSeven.RepositorySeven.GetAll();
          var sevenWordViewModel=SevenWordViewModel
          {
            SevenWords=allWordsWithSeven
          };
            return View(sevenWordViewModel);
        }


        [HttpPost]
        public IActionResult PostEightWord(EightWord eightWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkEightWord.RepositoryEightWord.Create(eightWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkEightWord.Complete();
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
                _unitOfWorkEightWord.RepositoryEightWord.Update(eightWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkEightWord.Complete();
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
                _unitOfWorkEightWord.RepositoryEightWord.Delete(eightWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkEightWord.Complete();
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

        public IActionResult EightWord()
        {
          var allWordsWithEight=_unitOfWorkEight.RepositoryEight.GetAll();
          var eightWordViewModel=EightWordViewModel
          {
            EightWords=allWordsWithEight
          };
            return View(eightWordViewModel);
        }


        [HttpPost]
        public IActionResult PostNineWord(NineWord nineWord)
        {
            if (ModelState.IsValid)
            {
                int request;
                _unitOfWorkNineWord.RepositoryNineWord.Create(nineWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkNineWord.Complete();
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
                _unitOfWorkNineWord.RepositoryNineWord.Update(nineWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkNineWord.Complete();
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
                _unitOfWorkNineWord.RepositoryNineWord.Delete(nineWord);
                request = HttpContext.Response.StatusCode;
                if (request == 200)
                {
                    TempData["Message"] = "Kelime ekleme işleminiz başarılı!";
                    TempData["JS"] = "showSuccess();";
                    _unitOfWorkNineWord.Complete();
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

        public IActionResult NineWord()
        {
          var allWordsWithNine=_unitOfWorkNine.RepositoryNine.GetAll();
          var nineWordViewModel=NineWordViewModel
          {
            NineWords=allWordsWithNine
          };
            return View(nineWordViewModel);
        }


        [HttpPost]
public IActionResult PostTenWord(TenWord tenWord)
{
    if (ModelState.IsValid)
    {
        int request;
        _unitOfWorkTenWord.RepositoryTenWord.Create(tenWord);
        request = HttpContext.Response.StatusCode;
        if (request == 200)
        {
            TempData["Message"] = "Ürün ekleme işleminiz başarılı!";
            TempData["JS"] = "showSuccess();";
            _unitOfWorkTenWord.Complete();
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
_unitOfWorkTenWord.RepositoryTenWord.Update(tenWord);
request = HttpContext.Response.StatusCode;
if (request == 200)
{
    TempData["Message"] = "Ürün ekleme işleminiz başarılı!";
    TempData["JS"] = "showSuccess();";
    _unitOfWorkTenWord.Complete();
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
_unitOfWorkTenWord.RepositoryTenWord.Delete(tenWord);
request = HttpContext.Response.StatusCode;
if (request == 200)
{
    TempData["Message"] = "Ürün ekleme işleminiz başarılı!";
    TempData["JS"] = "showSuccess();";
    _unitOfWorkTenWord.Complete();
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

        public IActionResult TenWord()
        {
          var allWordsWithTen=_unitOfWorkTen.RepositoryTen.GetAll();
          var tenWordViewModel=TenWordViewModel
          {
            TenWords=allWordsWithTen
          };
            return View(tenWordViewModel);
        }
        public IActionResult ScoreTable()
        {
          var allScore=_unitOfWorkScoreTable.RepositoryScoreTable.GetAll();
          var scoreTableViewModel=ScoreTableViewModel
          {
            ScoreTables=allScore
          };
            return View(scoreTableViewModel);
        }
    }
}
