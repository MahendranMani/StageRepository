using ShapeShifters.UI.Models;
using ShapeShifters.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShapeShifters.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Hotels(int countryId)
        {
            var hotelList = GetHotels();
            var hotelsBycountry = hotelList.Where(hl => hl.CountryId == countryId);

            var hotelViewModel = new HotelViewModel();
            Hotel selectedHotel = hotelsBycountry.Take(1).SingleOrDefault();
            hotelViewModel.SelectedCountry = selectedHotel.CountryName;
            hotelViewModel.Data = hotelsBycountry;
            return View(hotelViewModel);
        }

        public ActionResult HotelsByCity(int countryId, string city)
        {
            var hotelList = GetHotels();
            var hotelsBycountry = hotelList.Where(hl => hl.CountryId == countryId && hl.City == city);

            var hotelViewModel = new HotelViewModel();
            Hotel selectedHotel = hotelsBycountry.Take(1).SingleOrDefault();
            hotelViewModel.SelectedCountry = selectedHotel.City + ", " + selectedHotel.CountryName;
            hotelViewModel.Data = hotelsBycountry;
            return View("Hotels", hotelViewModel);
        }

        private List<Hotel> GetHotels()
        {
            var hotelList = new List<Hotel> {

                new Hotel { Name = "The Wheatbaker" , CountryId = 1 , CountryName = "Nigeria",   WebUrl =string.Empty,
                    AddressLine1 = "4 Onitolo Rd" , City="Lagos"},
                new Hotel { Name = "The Federal Palace Hotel " , CountryId = 1 , CountryName = "Nigeria",   WebUrl =string.Empty,
                    AddressLine1 = "6-8 Ahmadu Bello Way" , City="Lagos"},
                new Hotel { Name = "Welcome Centre Hotels" , CountryId = 1 , CountryName = "Nigeria",   WebUrl ="http://welcomecentrehotels.com/?page_id=644",
                    AddressLine1 = "70 International Airport Rd" , City="Lagos"},
                new Hotel { Name = "Eko Hotels and Suites" , CountryId = 1 , CountryName = "Nigeria",   WebUrl ="http://ekohotels.com/contact.php",
                    AddressLine1 = "Plot 1415 Adetokunbo, Ademola St" , City="Lagos"},
                new Hotel { Name = "The Blowfish Hotel " , CountryId = 1 , CountryName = "Nigeria",   WebUrl ="http://theblowfishhotellagos.com/",
                    AddressLine1 = "17 Oju Olobun St" , City="Lagos"},


                new Hotel { Name = "The Winston Hotel" , CountryId = 2 , CountryName = "South Africa",   WebUrl ="www.thewinstonhotel.co.za",
                    AddressLine1 = "6 Tottenham Ave, Melrose Estate" , City="Johannesburg"},
                new Hotel { Name = "Karos Johannesburger" , CountryId = 2 , CountryName = "South Africa",   WebUrl =string.Empty,
                    AddressLine1 = "60 Twist St" , City="Johannesburg"},
                new Hotel { Name = "The Bannister Hotel" , CountryId = 2 , CountryName = "South Africa",   WebUrl ="http://bannisterhotel.co.za/",
                    AddressLine1 = "9 De Beer St, Braamfontein" , City="Johannesburg"},
                new Hotel { Name = "The Orient Hotel" , CountryId = 2 , CountryName = "South Africa",   WebUrl = "www.orienthotel.co.za",
                    AddressLine1 = "48 Central Road, Fordsburg" , City="Johannesburg"},
                new Hotel { Name = "Springbok Hotel" , CountryId = 2 , CountryName = "South Africa",    WebUrl =string.Empty,
                    AddressLine1 = "73 Joubert Street" , City="Johannesburg"},

                new Hotel { Name = "Bowood Lodge", CountryId = 3 , CountryName = "Zimbabwe",   WebUrl ="http://www.bowoodlodge.net/",
                    AddressLine1 = "Bowood Road, Mount Pleasant " , City = "Harare"},
                new Hotel { Name = "Villa Franca", CountryId = 3 , CountryName = "Zimbabwe",   WebUrl ="http://villafranca.co.zw‎",
                    AddressLine1 = "4 Saint Anne's Road " , City = "Harare"},
                new Hotel { Name = "Woodlands Guest Lodge", CountryId = 3 , CountryName = "Zimbabwe",   WebUrl ="http://woodlandsguestlodge.com‎",
                    AddressLine1 = "9 Princes Cl " , City = "Harare"},
                new Hotel { Name = "Pandhari Lodge", CountryId = 3 , CountryName = "Zimbabwe",   WebUrl ="http://www.pandharihotel.co.zw/",
                    AddressLine1 = "Gainsville Drive " , City = "Harare"},
                new Hotel { Name = "Armadale Lodge", CountryId = 3 , CountryName = "Zimbabwe",   WebUrl ="http://www.armadalelodge.com/",
                    AddressLine1 = "9 Armadale Rd, Borrowdale " , City = "Harare"},

                new Hotel { Name = "Victoria Falls Safari Lodge", CountryId = 3 , CountryName = "Zimbabwe",   WebUrl ="http://www.victoria-falls-safari-lodge.com",
                    AddressLine1 = "Stand 471 Squire Cummings Ave, Victoria Falls, " , City = "Victoria Falls"},
                new Hotel { Name = "Amadeus Garden Guesshouse", CountryId = 3 , CountryName = "Zimbabwe",   WebUrl ="http://amadeusgarden.com",
                    AddressLine1 = "Reynard Rd" , City = "Victoria Falls"},
                new Hotel { Name = "Pamusha Lodge", CountryId = 3 , CountryName = "Zimbabwe",   WebUrl ="http://pamushalogdevifalls.com",
                    AddressLine1 = "583 Manyika Rd " , City = "Victoria Falls"},
                new Hotel { Name = "Teak Lodge", CountryId = 3 , CountryName = "Zimbabwe",   WebUrl ="http://teaklogde.com",
                    AddressLine1 = "581 Masuie Road " , City = "Victoria Falls"},

             
                };

            return hotelList;

        }
    }
}