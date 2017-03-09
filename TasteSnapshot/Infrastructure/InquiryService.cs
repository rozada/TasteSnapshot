using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TasteSnapshot.Models;
using TasteSnapshot.ViewModels;
using TasteSnapshot.DAL;

namespace TasteSnapshot.Infrastructure
{
    public class InquiryService
    {
        TSContext _dbContext;
        public InquiryService()
        {
            _dbContext = new TSContext();
        }

        public IList<YummyViewModel> GetYummies()
        {
            return MapToViewModel(_dbContext.Yummies.ToList());
        }

        private static IList<YummyViewModel> MapToViewModel(IList<Yummy> yummies)
        {
            IList<YummyViewModel> yummyViewModels = new List<YummyViewModel>();

            foreach (var y in yummies)
            {
                yummyViewModels.Add(new YummyViewModel { Name = y.Name, Description = y.Description });
            }
            return yummyViewModels;
        }
    }
}