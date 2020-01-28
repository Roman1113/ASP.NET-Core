using MyIntroShop2._2.Main.Interfaces;
using MyIntroShop2._2.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyIntroShop2._2.Main.MockData
{
    public class MockPhones : IAllPhones
    {

        private readonly IPhoneCategory _phoneCategory = new MockCategory();
        public IEnumerable<Phone> phones
        {
            get
            {
                return new List<Phone>
                {
                    new Phone
                    {
                        name = "Samsung S10",
                        description = "Best phone by sumsung",
                        img = "https://www.google.com/url?q=https://i1.rozetka.ua/goods/11052575/samsung_galaxy_s10_6_128_gb_white_sm_g973fzwdsek_images_11052575871.jpg&sa=D&source=hangouts&ust=1580285652161000&usg=AFQjCNG_tIxwMxCRioUH5piiSHz7bp8Rhw",
                        price = 23000,
                        Category = _phoneCategory.AllCategories.First()
                    },
                    new Phone
                    {
                        name = "Nokia 3310",
                        description = "Old phone",
                        img = "https://static.turbosquid.com/Preview/001329/666/6L/_DHQ.jpg",
                        price = 700,
                        Category = _phoneCategory.AllCategories.Last()
                    },
                };
            }
        }
    }
}
