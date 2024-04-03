using Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Area
{
    public class StudentAreaController : Controller
    {
        private readonly StudentInterface _studentInterface;
        private readonly CompetitionInterface _competitionInterface;
        private readonly QuestionInterface _questionInterface;

        public StudentAreaController(StudentInterface studentInterface, CompetitionInterface competitionInterface, QuestionInterface questionInterface)
        {
            _studentInterface = studentInterface;
            _competitionInterface = competitionInterface;
            _questionInterface = questionInterface;
        }

        
        public async Task<IActionResult> Index(int studentId)
        {
            var competitions = await _studentInterface.GetRegisteredCompetitions(studentId);
            return View(competitions);
        }
    }
}
