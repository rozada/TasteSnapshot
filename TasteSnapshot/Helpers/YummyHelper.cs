using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TasteSnapshot.ViewModels;
using TasteSnapshot.Infrastructure;

namespace TasteSnapshot.Helpers
{
    public class YummyHelper
    {
        public static YummyViewModel GetFeaturedYummyItem()
        {
            InquiryService inquiryService = new InquiryService();

            var yummies  = inquiryService.GetYummies();
            return yummies.First();
        }

        public static void SaveYummyItem(YummyViewModel vm)
        {

        }
    }
}