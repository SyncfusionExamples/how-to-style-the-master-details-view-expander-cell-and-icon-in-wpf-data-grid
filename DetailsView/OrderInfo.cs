using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class SalesInfo : INotifyPropertyChanged
    {
        private int _orderID;
        private string _salesID;
        private string _productName;
        private ObservableCollection<ProductInfo> products;

        public ObservableCollection<ProductInfo> Products
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged("Sales");
            }
        }
        public int OrderID
        {
            get { return _orderID; }
            set
            {
                _orderID = value;
                OnPropertyChanged("OrderID");
            }
        }

        public string SalesID
        {
            get { return _salesID; }
            set
            {
                _salesID = value;
                OnPropertyChanged("SalesID");
            }
        }

        public string ProductName
        {
            get { return _productName; }
            set
            {
                _productName = value;
                OnPropertyChanged("ProductName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String name)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public class ProductInfo : INotifyPropertyChanged
    {

        private int orderId;
        private int _quantity;

        public int OrderID
        {
            get { return orderId; }
            set
            {
                orderId = value;
                OnPropertyChanged("OrderID");
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String name)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
    public class OrderInfo : INotifyPropertyChanged
    {
        private int orderId;
        private int _quantity;

        public int OrderID
        {
            get { return orderId; }
            set
            {
                orderId = value;
                OnPropertyChanged("OrderID");
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String name)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public class Employee : INotifyPropertyChanged
    {
        private string _customerID;
        private int _orderId;
        private string _city;
        private ObservableCollection<SalesInfo> _sales;
        private ObservableCollection<OrderInfo> _orders;

        public string CustomerID
        {
            get { return this._customerID; }
            set
            {
                this._customerID = value;
                OnPropertyChanged("EmployeeID");
            }
        }

        public int OrderID
        {
            get { return this._orderId; }
            set
            {
                this._orderId = value;
                OnPropertyChanged("OrderID");
            }
        }

        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                OnPropertyChanged("City");
            }
        }

        public ObservableCollection<SalesInfo> Sales
        {
            get { return _sales; }
            set
            {
                _sales = value;
                OnPropertyChanged("Sales");
            }
        }

        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set
            {
                _orders = value;
                OnPropertyChanged("Orders");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String name)
        {

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    
}
