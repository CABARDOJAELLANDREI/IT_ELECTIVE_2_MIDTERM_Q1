using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_BSIT312E_Cabardo_JaellAndrei.Models;
using System.Collections.Generic;

namespace IT_ELECTIVE_BSIT312E_Cabardo_JaellAndrei.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Username == "admin" && model.Password == "123456")
            {
                return RedirectToAction("Welcome");
            }

            ModelState.AddModelError("", "Invalid username or password.");
            return View(model);
        }

        [HttpGet]
        public IActionResult Welcome()
        {
            return View(new MBTIViewModel());
        }

        [HttpPost]
        public IActionResult Welcome(MBTIViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.ResultCode = $"{model.Axis1}{model.Axis2}{model.Axis3}{model.Axis4}";

                var descriptions = new Dictionary<string, string>
                {
                    { "INTJ", "Innovative, independent, strategic, logical, reserved, insightful. Driven by original ideas to achieve improvements." },
                    { "INTP", "Intellectual, logical, precise, reserved, flexible, imaginative. Thinkers who enjoy speculation & creative problem solving." },
                    { "ENTJ", "Strategic, logical, efficient, outgoing, ambitious, independent. Effective organizers of people and planners." },
                    { "ENTP", "Inventive, enthusiastic, strategic, enterprising, inquisitive, versatile. Enjoy new ideas and challenges, value inspiration." },
                    { "INFJ", "Idealistic, organized, insightful, dependable, compassionate, gentle. Peace & cooperation." },
                    { "INFP", "Sensitive, creative, idealistic, perceptive, caring, loyal. Harmony and growth, dreams and possibilities." },
                    { "ENFJ", "Caring, enthusiastic, idealistic, organized, diplomatic, responsible. Skilled communicators who value connection." },
                    { "ENFP", "Enthusiastic, creative, spontaneous, optimistic, supportive, playful. Inspiration, new projects, see potential." },
                    { "ISTJ", "Responsible, sincere, analytical, reserved, realistic, systematic. Hardworking and trustworthy with practical judgement." },
                    { "ISFJ", "Warm, considerate, gentle, responsible, pragmatic, thorough. Devoted caretakers who enjoy being helpful to others." },
                    { "ESTJ", "Efficient, outgoing, analytical, systematic, dependable, realistic. Like to run the show and get things done in an orderly fashion." },
                    { "ESFJ", "Friendly, outgoing, reliable, conscientious, organized, practical. Helpful and please others, enjoy being active and productive." },
                    { "ISTP", "Action-oriented, logical, analytical, spontaneous, reserved, independent. Enjoy adventure, skilled at understanding things." },
                    { "ISFP", "Gentle, sensitive, nurturing, helpful, flexible, realistic. Personal environment is beautiful & practical." },
                    { "ESTP", "Outgoing, realistic, action-oriented, curious, versatile, spontaneous. Pragmatic problem solvers & negotiators." },
                    { "ESFP", "Playful, enthusiastic, friendly, spontaneous, tactful, flexible. Have common sense, enjoy helping people." }
                };

                if (descriptions.ContainsKey(model.ResultCode))
                {
                    model.Description = descriptions[model.ResultCode];
                }
            }

            return View(model);
        }
    }
}