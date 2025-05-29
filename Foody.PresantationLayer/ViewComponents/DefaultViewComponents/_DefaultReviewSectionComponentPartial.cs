using AutoMapper;
using Foody.BusinessLayer.Abstract;
using Foody.DtoLayer.Dtos.ReviewDtos;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresantationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultReviewSectionComponentPartial :ViewComponent
    {
        private readonly IReviewService _reviewService;
        private readonly IMapper _mapper;
        public _DefaultReviewSectionComponentPartial(IReviewService reviewService, IMapper mapper)
        {
            _reviewService = reviewService; 
            _mapper = mapper;

        }

        public IViewComponentResult Invoke()
        {
            var values = _reviewService.TgetAll();
            return View(_mapper.Map<List<ResultReviewDto>>(values));
        }
    }
}
