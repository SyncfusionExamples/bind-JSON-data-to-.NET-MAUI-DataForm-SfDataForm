using System.Text.Json;

namespace LoadJSONData
{
    public class DataFormViewModel
    {
        public DataFormModel DataFormModel { get; set; }
        private string JSONDataModel =
          "[{\"EmployeeName\": \"Robert\",\"EmployeeDepartment\": \"Development\",\"EmployeeRole\": \"Junior Developer\",\"EmployeeBranch\": \"Electronic City\", \"EmployeeCity\": \"Banglore\"}]";
        public DataFormViewModel()
        {
            this.DataFormModel = new DataFormModel();
            List<JSONDataModel> jsonDatas = JsonSerializer.Deserialize<List<JSONDataModel>>(JSONDataModel);

            foreach (var data in jsonDatas)
            {
                this.DataFormModel.Name = data.EmployeeName;
                this.DataFormModel.Department = data.EmployeeDepartment;
                this.DataFormModel.Role = data.EmployeeRole;
                this.DataFormModel.Branch = data.EmployeeBranch;
                this.DataFormModel.City = data.EmployeeCity;
            }
        }                          
    }                              
}                       