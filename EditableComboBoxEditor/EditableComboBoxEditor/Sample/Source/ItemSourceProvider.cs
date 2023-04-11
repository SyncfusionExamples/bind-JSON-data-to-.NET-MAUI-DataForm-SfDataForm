using Syncfusion.Maui.DataForm;

namespace EditableComboBoxEditor
{
    public class ItemSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "Country")
            {
                List<string> country = new List<string>() { "Italy", "India", "Indonesia", "Ireland", "USA" };
                return country;
            }

            return new List<string>();
        }
    }
}