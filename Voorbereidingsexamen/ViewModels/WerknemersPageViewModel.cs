using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbereidingsexamen.ViewModels
{
    public partial class WerknemersPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Employee> employees;

        private IEmployeeRepository _employeeRepository;

        public WerknemersPageViewModel()
        {
            _employeeRepository = new EmployeeRepository();
        }

        [RelayCommand]
        public void CMD_OphalenWerkenemrsUSA()
        {
            IsBusy = true;
            Employees = new ObservableCollection<Employee>(_employeeRepository.OphalenWerkenemrsUSA());
            IsBusy = false;
        }
    }
}
