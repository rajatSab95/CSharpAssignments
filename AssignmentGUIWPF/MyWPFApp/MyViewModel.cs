using System.ComponentModel;
using System.Collections.Generic;
using System;  
using System.Linq;  
using System.Collections.ObjectModel;   
using MyWPFApp;
namespace MyWPFApp{

    class MyViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Employee> Employees {get; set;} 
        public Employee SelectedEmployee { get; set; }     
        public RelayCommand AddButton { get; set; }
        public RelayCommand DeleteButton { get; set; }  

        public string SearchText { get; set; }
        public RelayCommand SearchByNameButton { get; set; }
        public RelayCommand SearchByIdButton { get; set; }
        public int SearchId { get; set; }
        public MyViewModel()
        {
            Employees = new ObservableCollection<Employee>(){ new Employee(){Id = 1, Name="Sagar", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 2, Name="Abhijeet", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 3, Name="Sayali", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 4, Name="Kajol", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 5, Name="Vishal", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 6, Name="Sakshi", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 7, Name="Naman", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 8, Name="Asmita", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 9, Name="Mudit", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 10, Name="Rohit", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 11, Name="Karan", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 12, Name="Pranit", Dob = new DateTime(2022, 06, 25)}, 
                                                            new Employee(){Id = 13, Name="Rajat", Dob = new DateTime(2022, 06, 25)}, 
                                                            };
            
            AddButton = new RelayCommand(AddEmployee, CanAddEmployee);
            DeleteButton = new RelayCommand(DeleteEmployee, CanDeleteEmployee);
            SearchByNameButton = new RelayCommand(SearchEmpByName, CanSearchEmpByName);
            SearchByIdButton = new RelayCommand(SearchEmpById, CanSearchEmpById);
        }

        public void SearchEmpById(object parameter)
        {
            var searchResult = Employees.Where(x=>x.Id==this.SearchId);
            Employees = new ObservableCollection<Employee>(searchResult);

        }

        public bool CanSearchEmpById(object parameter)
        {
            return true;
        }
        public void SearchEmpByName(object parameter)
        {
            var searchResult = Employees.Where(x=>x.Name.ToLower().Contains(SearchText));
            Employees = new ObservableCollection<Employee>(searchResult);
        }

        public bool CanSearchEmpByName(object parameter)
        {
            return true;
        }

        public void AddEmployee(object parameter)
        {
            System.Console.WriteLine("Add execute");
            Employees.Add(new Employee(){Name="New Employee Name", Id=95, Dob=DateTime.Now});
        }

        public bool CanAddEmployee(object parameter)
        {
            return true;
        }

        public void DeleteEmployee(object parameter)
        {
            Employees.Remove(SelectedEmployee);
        }

        public bool CanDeleteEmployee(object parameter)
        {
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;  
        private void OnPropertyRaised(string propertyname) {  
            if (PropertyChanged != null) {  
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));  
            }        
        }
    }
     public class Employee{
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
    }
}