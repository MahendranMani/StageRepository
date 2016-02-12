using ShapeShifters.UI.Models;
using System.Collections.Generic;

namespace ShapeShifters.UI.ViewModels
{
    public class ViewModel<T>
    {
        public T Data { get; set; }
    }

    public class HotelViewModel : ViewModel<IEnumerable<Hotel>>
    {
        public string SelectedCountry { get; set; }
        
    }
}