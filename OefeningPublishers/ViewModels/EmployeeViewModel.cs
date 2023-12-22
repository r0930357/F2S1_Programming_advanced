using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPublishers.ViewModels
{
    public partial class EmployeeViewModel : BaseViewModel
    {
        private IEmployeeRepository _employeesRepository;

        [ObservableProperty]
        private ObservableCollection<Employee> employees;

        [ObservableProperty]
        public string id;

        [ObservableProperty]
        public DateTime selectedDate = DateTime.Now;


        public EmployeeViewModel()
        {
            _employeesRepository = new EmployeeRepository();
        }

        [RelayCommand]
        public void AlleWerknemersOphalen()
        {
            IsBusy = true;
            Employees = new ObservableCollection<Employee>(_employeesRepository.OphalenEmployees());
            IsBusy = false;
        }

        [RelayCommand]
        public void WerknemersOphalenViaAanwerfdatum()
        {
            IsBusy = true;
            Employees = new ObservableCollection<Employee>(_employeesRepository.OphalenEmployeesViaHireDate(SelectedDate));
            IsBusy = false;
        }
    }
}
