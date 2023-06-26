using System.ComponentModel;
using System.Collections.Generic;
using System;  
using System.Collections.ObjectModel;   
using MyWPFApp;
namespace MyWPFApp{

    class MyViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Employee> Employees {get; set;} 
        public Employee SelectedEmployee { get; set; }     
        public RelayCommand AddButton { get; set; }
        public RelayCommand DeleteButton { get; set; }        

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
            System.Console.WriteLine("Delete Executed");
            Employees.Add(new Employee(){Name="New Employee Name", Id=95, Dob=DateTime.Now});
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