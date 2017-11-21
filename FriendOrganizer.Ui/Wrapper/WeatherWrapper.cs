using FriendOrganizer.Ui.Data.FinderFriendOrganizer.Ui.Data.Finder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.Ui.Wrapper
{
    public class WeatherWrapper : ModelWrapper<ConsolidatedWeather>
    {
        public WeatherWrapper(ConsolidatedWeather model) : base(model)
        {
        }


        public string weather_state_name
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public string title
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string the_temp
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string wind_speed
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }


       
    }
}

