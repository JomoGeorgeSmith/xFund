using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace Xfund.Pages
{
    public class PropertyModel : PageModel
    {
        public class PropertiesModel
        {
            public string? Name { get; set; }
            public string? Description { get; set; }
            public string? ImagePath { get; set; }
        }
        public List<PropertiesModel>? Properties { get; set; }
        public void OnGet()
        {

            Properties = new List<PropertiesModel>
            {
                new () { Name = "The Asian Mews", Description = "Luxurious apartment with a modern design.", ImagePath = "/images/home1.jpg" },
                new () { Name = "The Grand Oak", Description = "Elegant apartments surrounded by nature.", ImagePath = "/images/home2.jpg" },
                new () { Name = "Ocean View Residences", Description = "Apartments with a breathtaking view of the ocean.", ImagePath = "/images/home3.jpg" },
                new () { Name = "City Lights Tower", Description = "Skyscraper apartments in the heart of downtown.", ImagePath = "/images/home4.jpg" },
                new () { Name = "Mountain Vista", Description = "Serene living with mountain views.", ImagePath = "/images/double_tree.png" },
                new () { Name = "Urban Heights", Description = "Modern apartments in the urban center.", ImagePath = "/images/property1.jpg" },
                new () { Name = "Parkside Villas", Description = "Charming villas next to a beautiful park.", ImagePath = "/images/property2.png" },
                new () { Name = "Riverside Suites", Description = "Waterfront apartments with stunning views.", ImagePath = "/images/property3.png" },
               // new () { Name = "Downtown Lofts", Description = "Spacious lofts in the downtown area.", ImagePath = "/images/property4.png" },
                
            };

        }
    }
}
