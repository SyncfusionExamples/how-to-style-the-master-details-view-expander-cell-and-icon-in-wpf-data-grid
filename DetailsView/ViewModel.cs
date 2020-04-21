using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ViewModel
    {
        ObservableCollection<Employee> _employees;

        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set { _employees = value; }
        }

        public ViewModel()
        {
            this.GenerateProd();
            this.GenerateOrders();
            this.GenerateSales();
            
            _employees = GetEmployeesDetails();
        }

        public ObservableCollection<Employee> GetEmployeesDetails()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { CustomerID = "ALFKI", OrderID = 1001, City = "Berlin", Orders = GetOrders(1001), Sales = GetSales(1001) });
            employees.Add(new Employee() { CustomerID = "ANATR", OrderID = 1002, City = "Mexico D.F.", Orders = GetOrders(1002), Sales = GetSales(1002) });
            employees.Add(new Employee() { CustomerID = "Sweden", OrderID = 1003, City = "London", Orders = GetOrders(1002), Sales = GetSales(1003) });
            employees.Add(new Employee() { CustomerID = "BOLID", OrderID = 1004, City = "BERGS", Orders = GetOrders(1002), Sales = GetSales(1004) });
            employees.Add(new Employee() { CustomerID = "AROUT", OrderID = 1005, City = "Mannheim", Orders = GetOrders(1002), Sales = GetSales(1005) });
            return employees;
        }

        //Orders collection is initialized here.
        ObservableCollection<OrderInfo> Orders = new ObservableCollection<OrderInfo>();

        public void GenerateOrders()
        {
            Orders.Add(new OrderInfo() { OrderID = 1001, Quantity = 10 });
            Orders.Add(new OrderInfo() { OrderID = 1001, Quantity = 10 });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 20 });
            Orders.Add(new OrderInfo() { OrderID = 1002, Quantity = 20 });
            Orders.Add(new OrderInfo() { OrderID = 1003, Quantity = 50 });
            Orders.Add(new OrderInfo() { OrderID = 1004, Quantity = 70 });
            Orders.Add(new OrderInfo() { OrderID = 1005, Quantity = 20 });
            Orders.Add(new OrderInfo() { OrderID = 1005, Quantity = 20 });
        }

        private ObservableCollection<OrderInfo> GetOrders(int orderID)
        {
            ObservableCollection<OrderInfo> orders = new ObservableCollection<OrderInfo>();

            foreach (var order in Orders)

                if (order.OrderID == orderID)
                    orders.Add(order);
            return orders;
        }

        //Sales collection is initialized here.
        ObservableCollection<SalesInfo> Sales = new ObservableCollection<SalesInfo>();

        public void GenerateSales()
        {
            Sales.Add(new SalesInfo() { OrderID = 1001, SalesID = "A00001", ProductName = "Bike1", Products = GetProd(1001) });
            Sales.Add(new SalesInfo() { OrderID = 1001, SalesID = "A00002", ProductName = "Bike1", Products = GetProd(1001) });
            Sales.Add(new SalesInfo() { OrderID = 1002, SalesID = "A00003", ProductName = "Cycle", Products = GetProd(1002) });
            Sales.Add(new SalesInfo() { OrderID = 1003, SalesID = "A00004", ProductName = "Car", Products = GetProd(1003) });
            Sales.Add(new SalesInfo() { OrderID = 1003, SalesID = "A00001", ProductName = "Bike1", Products = GetProd(1003) });
            Sales.Add(new SalesInfo() { OrderID = 1004, SalesID = "A00002", ProductName = "Bike1", Products = GetProd(1004) });
            Sales.Add(new SalesInfo() { OrderID = 1005, SalesID = "A00003", ProductName = "Cycle", Products = GetProd(1005) });
            Sales.Add(new SalesInfo() { OrderID = 1005, SalesID = "A00004", ProductName = "Car", Products = GetProd(1005) });
        }

        private ObservableCollection<SalesInfo> GetSales(int orderID)
        {
            ObservableCollection<SalesInfo> sales = new ObservableCollection<SalesInfo>();

            foreach (var sale in Sales)

                if (sale.OrderID == orderID)
                    sales.Add(sale);
            return sales;
        }

        ObservableCollection<ProductInfo> Products = new ObservableCollection<ProductInfo>();

        public void GenerateProd()
        {
            Products.Add(new ProductInfo() { OrderID = 1001, Quantity=12});
            Products.Add(new ProductInfo() { OrderID = 1001,Quantity=11  });
            Products.Add(new ProductInfo() { OrderID = 1002, Quantity=13 });
            Products.Add(new ProductInfo() { OrderID = 1003, Quantity=13 });
            Products.Add(new ProductInfo() { OrderID = 1003, Quantity = 12 });
            Products.Add(new ProductInfo() { OrderID = 1004, Quantity = 11 });
            Products.Add(new ProductInfo() { OrderID = 1004, Quantity = 13 });
            Products.Add(new ProductInfo() { OrderID = 1005, Quantity = 13 });
        }

        private ObservableCollection<ProductInfo> GetProd(int orderID)
        {
            ObservableCollection<ProductInfo> sales = new ObservableCollection<ProductInfo>();

            foreach (var sale in Products)

                if (sale.OrderID == orderID)
                    sales.Add(sale);
            return sales;
        }
    }

    
}
