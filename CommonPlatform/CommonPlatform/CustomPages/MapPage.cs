using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CommonPlatform
{
    class MapPage : ContentPage
    {
        private Map map;
        private StackLayout stackLayout;
        public MapPage()
        {
            MapSpan span = MapSpan.FromCenterAndRadius(
              new Position(50.289192, 18.659656),
              Distance.FromMiles(0.4));

            map = new Map(span)
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Position position = new Position(50.289192, 18.659656);
            Pin pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = "Helion",
                Address = "Helion"
            };
            map.Pins.Add(pin);

            stackLayout = new StackLayout
            {
                Spacing = 0,
                Children = {
            map
          }
            };
            Content = stackLayout;
        }
    }
}
