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
        [ObservableProperty]
        private ObservableCollection<Employee> employees;

        [ObservableProperty]
        public string id;

        [ObservableProperty]
        public DateTime selectedDate = DateTime.Now;

        [ObservableProperty]
        public ObservableCollection<Job> jobs;

        [ObservableProperty]
        public ObservableCollection<Publisher> publishers;

        [ObservableProperty]
        public Job selectedJob;

        [ObservableProperty]
        public Publisher selectedPublisher;

        private IEmployeeRepository _employeesRepository;
        private IJobsRepository _jobsRepository;
        private IPublishersRepository _publishersRepository;

        public EmployeeViewModel()
        {
            _employeesRepository = new EmployeeRepository();
            _jobsRepository = new JobsRepository();
            _publishersRepository = new PublishersRepository();

            Jobs = new ObservableCollection<Job>(_jobsRepository.OphalenJobs());
            Publishers = new ObservableCollection<Publisher>(_publishersRepository.OphalenPublishers());
        }

        [RelayCommand]
        public void AlleWerknemersOphalen()
        {
            IsBusy = true;
            Employees = new ObservableCollection<Employee>(_employeesRepository.OphalenEmployees());
            IsBusy = false;
        }

        [RelayCommand]
        public void WerknemersOphalenViaJob()
        {
            if (SelectedJob == null)
            {
                Shell.Current.DisplayAlert("Error", "Please select a job.", "Ok");
                return;
            }

            IsBusy = true;
            Employees = new ObservableCollection<Employee>(_employeesRepository.OphalenEmployeesViaJob_id(SelectedJob.id));
            IsBusy = false;
        }

        [RelayCommand]
        public void WerknemersOphalenViaPublisher()
        {
            if (SelectedPublisher == null)
            {
                Shell.Current.DisplayAlert("Error", "Please select a publisher.", "Ok");
                return;
            }

            IsBusy = true;
            Employees = new ObservableCollection<Employee>(_employeesRepository.OphalenEmployeesViaPub_id(SelectedPublisher.id));
            IsBusy = false;
        }

        [RelayCommand]
        public void WerknemersOphalenViaJobEnPublisher()
        {
            if (SelectedJob == null)
            {
                Shell.Current.DisplayAlert("Error", "Please select a job.", "Ok");
                return;
            }

            if (SelectedPublisher == null)
            {
                Shell.Current.DisplayAlert("Error", "Please select a publisher.", "Ok");
                return;
            }

            IsBusy = true;
            Employees = new ObservableCollection<Employee>(_employeesRepository.OphalenEmployeesViaPub_idEnJob_id(SelectedPublisher.id, SelectedJob.id));
            IsBusy = false;
        }

        [RelayCommand]
        public void WerknemersOphalenViaAanwerfdatum()
        {
            IsBusy = true;
            Employees = new ObservableCollection<Employee>(_employeesRepository.OphalenEmployeesViaHireDate(SelectedDate));
            IsBusy = false;
        }

        [RelayCommand]
        public void WerknemerOphalenViaId()
        {
            if (!int.TryParse(Id, out int id))
            {
                Shell.Current.DisplayAlert("Fout", "Geef een geldige ID.", "Sluiten");
                return;
            }
            IsBusy = true;
            var employee = _employeesRepository.OphalenEmployeeViaPK(id);
            if (employee == null)
                Shell.Current.DisplayAlert("Fout", $"Employee met ID {id} werd niet gevonden.", "Sluiten");
            else
                Shell.Current.DisplayAlert("Employee gevonden", employee.firstName, "Sluiten");

            IsBusy = false;
        }
    }
}
