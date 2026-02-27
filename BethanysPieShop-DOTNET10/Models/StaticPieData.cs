namespace BethanysPieShop_DOTNET10.Models
{
    public class StaticPieData
    {
        private static readonly List<Pie> _pies = new List<Pie>()
    {
        new Pie { PieId = 1, Name = "Apple Pie", Price = 15.95M, ShortDescription = "Classic apple pie", InStock = true, IsPieOfTheWeek = false, ImageUrl = "https://th.bing.com/th/id/OIP.LmfeNLBmRLe_v_t55SYBBAHaHU?w=190&h=188&c=7&r=0&o=7&dpr=1.3&pid=1.7&rm=3", ImageThumbnailUrl = "https://th.bing.com/th/id/OIP.LmfeNLBmRLe_v_t55SYBBAHaHU?w=190&h=188&c=7&r=0&o=7&dpr=1.3&pid=1.7&rm=3" },
        new Pie { PieId = 2, Name = "Cherry Pie", Price = 18.95M, ShortDescription = "Sweet cherry pie", InStock = true, IsPieOfTheWeek = true, ImageUrl = "https://tse1.mm.bing.net/th/id/OIP.1n45IdKpSqY_2GGnV3ppHAHaKX?rs=1&pid=ImgDetMain&o=7&rm=3", ImageThumbnailUrl = "https://tse1.mm.bing.net/th/id/OIP.1n45IdKpSqY_2GGnV3ppHAHaKX?rs=1&pid=ImgDetMain&o=7&rm=3" },
        new Pie { PieId = 3, Name = "Pumpkin Pie", Price = 12.95M, ShortDescription = "Seasonal favorite", InStock = false, IsPieOfTheWeek = false, ImageUrl = "https://tse4.mm.bing.net/th/id/OIP.3g6eNvyUNmLnpva7_dORWgHaLF?rs=1&pid=ImgDetMain&o=7&rm=3", ImageThumbnailUrl = "https://tse4.mm.bing.net/th/id/OIP.3g6eNvyUNmLnpva7_dORWgHaLF?rs=1&pid=ImgDetMain&o=7&rm=3" }
    };

        public static IEnumerable<Pie> GetAll() => _pies.OrderBy(p=>p.PieId);

        public static Pie? GetById(int id) => _pies.FirstOrDefault(x => x.PieId == id);
    }
}
