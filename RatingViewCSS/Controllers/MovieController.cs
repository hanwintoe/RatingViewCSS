using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RatingViewCSS.Data;
using RatingViewCSS.Models;

namespace RatingViewCSS.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovieController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<MovieDto> movieDtos = new();

            var result = (from mv in _context.Movies
                          join rt in _context.RatingDatas
                          on mv.Id equals rt.MovieId
                          select new
                          {
                              mv.Id,
                              mv.Name,
                              rt.OneStarCount,
                              rt.OneStarTotal,
                              rt.TwoStarCount,
                              rt.TwoStarTotal,
                              rt.ThreeStarCount,
                              rt.ThreeStarTotal,
                              rt.FourStarCount,
                              rt.FourStarTotal,
                              rt.FiveStarCount,
                              rt.FiveStarTotal
                          }).ToList();
            movieDtos.AddRange(from rst in result
                               let movieDto = new MovieDto()
                               {
                                   Id = rst.Id,
                                   Title = rst.Name,
                                   OneCount = rst.OneStarCount,
                                   OneTotal = rst.OneStarTotal,
                                   TwoCount = rst.TwoStarCount,
                                   TwoTotal = rst.TwoStarTotal,
                                   ThrCount = rst.ThreeStarCount,
                                   ThrTotal = rst.ThreeStarTotal,
                                   FouCount = rst.FourStarCount,
                                   FouTotal = rst.FourStarTotal,
                                   FivCount = rst.FiveStarCount,
                                   FivTotal = rst.FiveStarTotal,
                                   TotalCount = rst.OneStarCount + rst.TwoStarCount + rst.ThreeStarCount + rst.FourStarCount + rst.FiveStarCount,
                                   VoteTotal = rst.OneStarTotal + rst.TwoStarTotal + rst.ThreeStarTotal + rst.FourStarTotal + rst.FiveStarTotal,

                               }
                               select movieDto); 

            return View(movieDtos);
        }

        [HttpPost]
        public async Task<JsonResult> PostRating(int rating, int mid)
        {
            var curRt = _context.RatingDatas.FirstOrDefault(m => m.MovieId == mid);

            switch (rating)
            {
                case 5:
                    curRt.FiveStarCount += 1;
                    curRt.FiveStarTotal += rating;
                    break;
                case 4:
                    curRt.FourStarCount += 1;
                    curRt.FourStarTotal += rating;
                    break;
                case 3:
                    curRt.ThreeStarCount += 1;
                    curRt.ThreeStarTotal += rating;
                    break;
                case 2:
                    curRt.TwoStarCount += 1;
                    curRt.TwoStarTotal += rating;
                    break;
                case 1:
                    curRt.OneStarCount += 1;
                    curRt.OneStarTotal += rating;
                    break;
                default:
                    break;
            }

            _context.RatingDatas.Update(curRt);
            await _context.SaveChangesAsync();

            return Json(" You rate this " + rating.ToString() + " star(s).");

        }



    }
}
