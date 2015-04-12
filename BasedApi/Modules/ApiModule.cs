using BLL.Methods;
using Nancy;

namespace BasedApi.Modules
{
    public class ApiModule : NancyModule
    {
        public ApiModule() : base("/api")
        {
            #region  ///  Help Page  ///
            Get["/help"] = x => View["help"];
            #endregion

            #region  ///  Category  ///

            #region  ///  /api/Categories/  ///
            Get["/categories"] = x =>
            {
                var logic = new CategoryLogic();

                var result = logic.GetAll();

                return Response.AsJson(result);
            };
            #endregion

            #region  /// /api/Categories/1234  ///
            Get["/categories/{id:int}"] = x =>
            {
                var logic = new CategoryLogic();

                var result = logic.GetById((int)x.id);

                return Response.AsJson(result);
            };
            #endregion

            #endregion

            #region  ///  Customer  ///

            #region  ///  /api/Customers/  ///
            Get["/customers"] = x =>
            {
                var logic = new CustomerLogic();

                var result = logic.GetAll();

                return Response.AsJson(result);
            };
            #endregion

            #region  /// /api/Customers/1234  ///
            Get["/customers/{id*}"] = x =>
            {
                var logic = new CustomerLogic();

                var result = logic.GetById((string)x.id);

                return Response.AsJson(result);
            };
            #endregion

            #endregion

            #region  ///  Employee  ///

            #region  ///  /api/employees  ///
            Get["/employees"] = x =>
            {
                var logic = new EmployeeLogic();

                var result = logic.GetAll();

                return Response.AsJson(result);
            };
            #endregion

            #region  ///  /api/employees/1234  ///
            Get["/employees/{id:int}"] = x =>
            {
                var logic = new EmployeeLogic();

                var result = logic.GetById((int)x.id);

                return Response.AsJson(result);
            };
            #endregion

            #endregion

            #region  ///  Order  ///

            #region  ///  /api/Orders/  ///
            Get["/orders"] = x =>
            {
                var logic = new OrderLogic();

                var result = logic.GetAll();

                return Response.AsJson(result);
            };
            #endregion

            #region  /// /api/Orders/1234  ///
            Get["/orders/{id:int}"] = x =>
            {
                var logic = new OrderLogic();

                var result = logic.GetById((int)x.id);

                return Response.AsJson(result);
            };
            #endregion

            #endregion

            #region  ///  Product  ///

            #region  ///  /api/Products/  ///
            Get["/products"] = x =>
            {
                var logic = new ProductLogic();

                var result = logic.GetAll();

                return Response.AsJson(result);
            };
            #endregion

            #region  /// /api/Products/1234  ///
            Get["/products/{id:int}"] = x =>
            {
                var logic = new ProductLogic();

                var result = logic.GetById((int)x.id);

                return Response.AsJson(result);
            };
            #endregion

            #endregion

            #region  ///  Region  ///

            #region  ///  /api/Regions/  ///
            Get["/regions"] = x =>
            {
                var logic = new RegionLogic();

                var result = logic.GetAll();

                return Response.AsJson(result);
            };
            #endregion

            #region  /// /api/Regions/1234  ///
            Get["/regions/{id:int}"] = x =>
            {
                var logic = new RegionLogic();

                var result = logic.GetById((int)x.id);

                return Response.AsJson(result);
            };
            #endregion

            #endregion

            #region  ///  Shipper  ///

            #region  ///  /api/Shippers/  ///
            Get["/shippers"] = x =>
            {
                var logic = new ShipperLogic();

                var result = logic.GetAll();

                return Response.AsJson(result);
            };
            #endregion

            #region  /// /api/Shippers/1234  ///
            Get["/shippers/{id:int}"] = x =>
            {
                var logic = new ShipperLogic();

                var result = logic.GetById((int)x.id);

                return Response.AsJson(result);
            };
            #endregion

            #endregion

            #region  ///  Supplier  ///

            #region  ///  /api/Suppliers/  ///
            Get["/suppliers"] = x =>
            {
                var logic = new SupplierLogic();

                var result = logic.GetAll();

                return Response.AsJson(result);
            };
            #endregion

            #region  /// /api/Suppliers/1234  ///
            Get["/suppliers/{id:int}"] = x =>
            {
                var logic = new SupplierLogic();

                var result = logic.GetById((int)x.id);

                return Response.AsJson(result);
            };
            #endregion

            #endregion

            #region  ///  Territory  ///

            #region  ///  /api/Territories/  ///
            Get["/territories"] = x =>
            {
                var logic = new TerritoryLogic();

                var result = logic.GetAll();

                return Response.AsJson(result);
            };
            #endregion

            #region  /// /api/Territories/1234  ///
            Get["/territories/{id:string}"] = x =>
            {
                var logic = new TerritoryLogic();

                var result = logic.GetById((string)x.id);

                return Response.AsJson(result);
            };
            #endregion

            #endregion
        }
    }
}