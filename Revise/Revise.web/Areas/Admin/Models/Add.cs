using Revise.web.AdoNetCodes;

namespace Revise.web.Areas.Admin.Models
{
    public class Add : IAdd
    {
        internal void Insert(string connectionString)
        {
            var Shirt = "Rich Man(Slim Fit)";
            var Size = "XL";
            var ShirtType = "Full Sleve";
            var Price = 1800.00;

            Dictionary<string, object> data = new Dictionary<string, object>();
            data.Add("@Shirt", Shirt);
            data.Add("@Size", Size);
            data.Add("@ShirtType", ShirtType);
            data.Add("@Price", Price);

            var command = @"Insert into Products(Shirt, Size, [Shirt-Type], Price) values(@Shirt, @Size, @ShirtType, @Price)";
            var dataUtility = new DataUtility(connectionString);
            dataUtility.InsertData(command, data);
        }
    }
}
