using Syncfusion.Maui.DataForm;

namespace LoadJSONData
{
    public class ItemSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "City")
            {
                List<string> city = new List<string>() { "Los Vegas", "Chicago", "Los Angeles", "New York" };
                return city;
            }

            return new List<string>();
        }
    }
}