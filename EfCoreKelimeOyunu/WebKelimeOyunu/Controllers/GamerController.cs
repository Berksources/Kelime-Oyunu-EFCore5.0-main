using DataAccesLayer;
using Entity.KelimeOyunu;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using WebKelimeOyunu.Models;

namespace WebKelimeOyunu.Controllers
{
    [Authorize(Roles = "Gamer")]
    public class GamerController : BaseController
    {
        #region /*IUnitOfWork*/
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
        private readonly IUnitOfWork<GameVariant> _unitOfWorkGameVariant;
        #endregion

        #region /*ctor*/
        public GamerController(IUnitOfWork<User> unitOfWorkUser,
        IUnitOfWork<UserRole> unitOfWorkUserRole,
        IUnitOfWork<ScoreTable> unitOfWorkScoreTable,
        IUnitOfWork<FourWord> unitOfWorkFour,
        IUnitOfWork<FifthWord> unitOfWorkFive,
        IUnitOfWork<SixthWord> unitOfWorkSix,
        IUnitOfWork<SevenWord> unitOfWorkSeven,
        IUnitOfWork<EightWord> unitOfWorkEight,
        IUnitOfWork<NineWord> unitOfWorkNine,
        IUnitOfWork<TenWord> unitOfWorkTen,
        IUnitOfWork<GameVariant> unitOfWorkGameVariant)
        {
            _unitOfWorkFour = unitOfWorkFour;
            _unitOfWorkFive = unitOfWorkFive;
            _unitOfWorkSix = unitOfWorkSix;
            _unitOfWorkSeven = unitOfWorkSeven;
            _unitOfWorkEight = unitOfWorkEight;
            _unitOfWorkNine = unitOfWorkNine;
            _unitOfWorkTen = unitOfWorkTen;
            _unitOfWorkUser = unitOfWorkUser;
            _unitOfWorkUserRole = unitOfWorkUserRole;
            _unitOfWorkScoreTable = unitOfWorkScoreTable;
            _unitOfWorkGameVariant = unitOfWorkGameVariant;
        }
        #endregion
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyScores()
        {
            var userScore = _unitOfWorkScoreTable.RepositoryScoreTable.UserScoreResult(getCurrentUser());
            var scoreTableViewModel = new ScoreTableViewModel
            {
                ScoreTableOnly = userScore
            };
            return View(scoreTableViewModel);
        }
        public IActionResult ScoreTableGamer()
        {
            var allScore = _unitOfWorkScoreTable.RepositoryScoreTable.ScoreTablesWithUser();
            var scoreTableViewModel = new ScoreTableViewModel
            {
                ScoreTables = allScore
            };
            return View(scoreTableViewModel);
        }

        public IActionResult GameArena()
        {
            var gameConf = _unitOfWorkGameVariant.RepositoryGameVariant.GetAll();
            var four = _unitOfWorkFour.RepositoryFour.GetAll();
            var five = _unitOfWorkFive.RepositoryFive.GetAll();
            var six = _unitOfWorkSix.RepositorySix.GetAll();
            var seven = _unitOfWorkSeven.RepositorySeven.GetAll();
            var eight = _unitOfWorkEight.RepositoryEight.GetAll();
            var nine = _unitOfWorkNine.RepositoryNine.GetAll();
            var ten = _unitOfWorkTen.RepositoryTen.GetAll();
            var gameViewModel = new GameViewModel
            {
                GameVariants = gameConf,
                FourWords = four,
                FifthWords = five,
                SixthWords = six,
                SevenWords = seven,
                EightWords = eight,
                NineWords = nine,
                TenWords = ten
            };
            return View(gameViewModel);
        }
        #region /*CheckOut*/
        public IActionResult KontrolEt(string answerUser, FourWord fourWord
            , FifthWord fifthWord, SixthWord sixthWord,
            SevenWord sevenWord, EightWord eightWord,
            NineWord nineWord, TenWord tenWord, ScoreTable scoreTable, int questionCount,string lastScore)
        {
            var gamevariant = _unitOfWorkGameVariant.RepositoryGameVariant.GetAll();
            foreach (var gameVariant in gamevariant)
            {
                if (gameVariant.GameIsCompleted == false)
                {
                    if (gameVariant.GameIsOver == false)
                    {
                        if (fourWord.FourWordAnswer == answerUser)
                        {

                            gameVariant.GameScoreCount = gameVariant.GameScoreCount + fourWord.FourWordScore;
                            gameVariant.GameQuestionCount = gameVariant.GameQuestionCount + 1;
                            gameVariant.GameIsCompleted = false;
                            gameVariant.GameIsOver = false;
                            gameVariant.GameVariantID = 1;
                            _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
                            _unitOfWorkGameVariant.Complete();
                            TempData["Message"] = "Cevabınız Doğru !!";
                            TempData["JS"] = "showSuccess();";
                        }
                        else if (fifthWord.FifthWordAnswer == answerUser)
                        {
                            gameVariant.GameScoreCount = gameVariant.GameScoreCount + fifthWord.FifthWordScore;
                            gameVariant.GameQuestionCount = gameVariant.GameQuestionCount + 1;
                            gameVariant.GameIsCompleted = false;
                            gameVariant.GameIsOver = false;
                            gameVariant.GameVariantID = 1;
                            _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
                            _unitOfWorkGameVariant.Complete();
                            TempData["Message"] = "Cevabınız Doğru !!";
                            TempData["JS"] = "showSuccess();";
                        }
                        else if (sixthWord.SixthWordAnswer == answerUser)
                        {
                            gameVariant.GameScoreCount = gameVariant.GameScoreCount + sixthWord.SixthWordScore;
                            gameVariant.GameQuestionCount = gameVariant.GameQuestionCount + 1;
                            gameVariant.GameIsCompleted = false;
                            gameVariant.GameIsOver = false;
                            gameVariant.GameVariantID = 1;
                            _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
                            _unitOfWorkGameVariant.Complete();
                            TempData["Message"] = "Cevabınız Doğru !!";
                            TempData["JS"] = "showSuccess();";
                        }
                        else if (sevenWord.SevenWordAnswer == answerUser)
                        {
                            gameVariant.GameScoreCount = gameVariant.GameScoreCount + sevenWord.SevenWordScore;
                            gameVariant.GameQuestionCount = gameVariant.GameQuestionCount + 1;
                            gameVariant.GameIsCompleted = false;
                            gameVariant.GameIsOver = false;
                            gameVariant.GameVariantID = 1;
                            _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
                            _unitOfWorkGameVariant.Complete();
                            TempData["Message"] = "Cevabınız Doğru !!";
                            TempData["JS"] = "showSuccess();";
                        }
                        else if (eightWord.EightWordAnswer == answerUser)
                        {
                            gameVariant.GameScoreCount = gameVariant.GameScoreCount + eightWord.EightWordScore;
                            gameVariant.GameQuestionCount = gameVariant.GameQuestionCount + 1;
                            gameVariant.GameIsCompleted = false;
                            gameVariant.GameIsOver = false;
                            gameVariant.GameVariantID = 1;
                            _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
                            _unitOfWorkGameVariant.Complete();
                            TempData["Message"] = "Cevabınız Doğru !!";
                            TempData["JS"] = "showSuccess();";
                        }
                        else if (nineWord.NineWordAnswer == answerUser)
                        {
                            gameVariant.GameScoreCount = gameVariant.GameScoreCount + nineWord.NineWordScore;
                            gameVariant.GameQuestionCount = gameVariant.GameQuestionCount + 1;
                            gameVariant.GameIsCompleted = false;
                            gameVariant.GameIsOver = false;
                            gameVariant.GameVariantID = 1;
                            _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
                            _unitOfWorkGameVariant.Complete();
                            TempData["Message"] = "Cevabınız Doğru !!";
                            TempData["JS"] = "showSuccess();";
                        }
                        else if (tenWord.TenWordAnswer == answerUser)
                        {
                            gameVariant.GameScoreCount = gameVariant.GameScoreCount + tenWord.TenWordScore;
                            gameVariant.GameQuestionCount = gameVariant.GameQuestionCount + 1;
                            gameVariant.GameIsCompleted = true;
                            gameVariant.GameIsOver = false;
                            gameVariant.GameVariantID = 1;
                            _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
                            _unitOfWorkGameVariant.Complete();
                            if (gameVariant.GameQuestionCount == 14)
                            {
                                scoreTable.UserID = 1;
                                scoreTable.ScoreData = gameVariant.GameScoreCount;
                                _unitOfWorkScoreTable.RepositoryScoreTable.Create(scoreTable);
                                _unitOfWorkScoreTable.Complete();
                                TempData["Message"] = "Tebrikler !! Oyunu " + scoreTable.ScoreData + " puan ile bitirdiniz!!";
                                TempData["JS"] = "showSuccess();";
                                var currentUser = _unitOfWorkUser.RepositoryUser.GetByIDForUpdate(getCurrentUser());
                                foreach (var userUpdate in currentUser)
                                {
                                    userUpdate.UserLastScore = (gameVariant.GameScoreCount).ToString();
                                    userUpdate.CreatedDate = DateTime.Now;
                                    userUpdate.ModifiedDate = DateTime.Now;
                                    _unitOfWorkUser.RepositoryUser.Update(userUpdate);
                                    int request = HttpContext.Response.StatusCode;
                                    if (request == 200)
                                    {
                                        _unitOfWorkUser.Complete();
                                    }
                                }
                                gameVariant.GameIsCompleted = false;
                                gameVariant.GameIsOver = true;
                                gameVariant.GameQuestionCount = 0;
                                gameVariant.GameScoreCount = 0;
                                gameVariant.GameVariantID = 1;
                                _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
                                int secondRequest = HttpContext.Response.StatusCode;
                                if (secondRequest == 200)
                                {
                                    _unitOfWorkGameVariant.Complete();
                                }
                            }
                            else
                            {
                                TempData["Message"] = "Cevabınız Doğru !!";
                                TempData["JS"] = "showSuccess();";
                                return RedirectToAction("GameArena");
                            }
                        }
                        else
                        {
                            gameVariant.GameScoreCount = gameVariant.GameScoreCount - questionCount;
                            gameVariant.GameQuestionCount = gameVariant.GameQuestionCount + 0;
                            gameVariant.GameIsCompleted = false;
                            gameVariant.GameIsOver = false;
                            gameVariant.GameVariantID = 1;
                            _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
                            _unitOfWorkGameVariant.Complete();
                            TempData["Message"] = "Cevabınız Yanlış !!";
                            TempData["JS"] = "showError();";
                            return RedirectToAction("GameArena");
                        }
                    }
                    else
                    {
                        var currentUser = _unitOfWorkUser.RepositoryUser.GetByIDForUpdate(getCurrentUser());
                        gameVariant.GameIsCompleted = true;
                        gameVariant.GameIsOver = true;
                        gameVariant.GameQuestionCount = 0;
                        gameVariant.GameScoreCount = 0;
                        gameVariant.GameVariantID = 1;
                        _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
                        int secondRequest = HttpContext.Response.StatusCode;
                        if (secondRequest == 200)
                        {
                            _unitOfWorkGameVariant.Complete();
                        }
                        foreach (var x in currentUser)
                        {
                            TempData["Message"] = "Tebrikler !! Oyunu " + x.UserLastScore + " puan ile bitirdiniz!!";
                            TempData["JS"] = "showSuccess();";
                            return RedirectToAction("GameArena");
                        }
                    }
                }
                else
                {
                    gameVariant.GameScoreCount = 0;
                    gameVariant.GameQuestionCount = 0;
                    gameVariant.GameIsCompleted = false;
                    gameVariant.GameIsOver = false;
                    gameVariant.GameVariantID = 1;
                    _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
                    int request = HttpContext.Response.StatusCode;
                    if (request == 200)
                    {
                        TempData["Message"] = "Önceki oyunu başarıyla tamamladınız. Skorunuz:"+ lastScore +" Yeni oyuna başlayabilirsiniz.";
                        TempData["JS"] = "showSuccess();";
                        _unitOfWorkGameVariant.Complete();
                        return RedirectToAction("GameArena");
                    }
                    else
                    {
                        TempData["Message"] = "Bir sorun oluştu,tekrar deneyiniz";
                        TempData["JS"] = "showError();";
                        return RedirectToAction("GameArena");
                    }
                }
            }
            return RedirectToAction("GameArena");
        }
        #endregion

        #region /*YeniOyun*/
        public IActionResult YeniOyun()
        {
            var gameVariant = new GameVariant();
            gameVariant.GameScoreCount = 0;
            gameVariant.GameQuestionCount = 0;
            gameVariant.GameIsCompleted = false;
            gameVariant.GameIsOver = false;
            gameVariant.GameVariantID = 1;
            _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
            int request = HttpContext.Response.StatusCode;
            if (request == 200)
            {
                TempData["Message"] = "Yeni oyuna başlayabilirsiniz.";
                TempData["JS"] = "showSuccess();";
                _unitOfWorkGameVariant.Complete();
                return RedirectToAction("GameArena");
            }
            else
            {
                TempData["Message"] = "Bir sorun oluştu,tekrar deneyiniz";
                TempData["JS"] = "showError();";
                return RedirectToAction("GameArena");
            }
        }
        public IActionResult SureBitti()
        {
            var gameVariant = new GameVariant();
            gameVariant.GameScoreCount = 0;
            gameVariant.GameQuestionCount = 0;
            gameVariant.GameIsCompleted = false;
            gameVariant.GameIsOver = false;
            gameVariant.GameVariantID = 1;
            _unitOfWorkGameVariant.RepositoryGameVariant.Update(gameVariant);
            int request = HttpContext.Response.StatusCode;
            if (request == 200)
            {
                TempData["Message"] = "Süreniz bitti !!!";
                TempData["JS"] = "showSuccess();";
                _unitOfWorkGameVariant.Complete();
                return RedirectToAction("GameArena");
            }
            else
            {
                TempData["Message"] = "Bir sorun oluştu,tekrar deneyiniz";
                TempData["JS"] = "showError();";
                return RedirectToAction("GameArena");
            }
        }
        #endregion
    }
}
