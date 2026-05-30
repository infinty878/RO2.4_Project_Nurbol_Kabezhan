using System.Collections.ObjectModel;
using System.ComponentModel;
using SchoolApp.Models;

namespace SchoolApp.ViewModels;

public class StudentsViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Student> Students { get; } = new();

    private string _newName = "";
    public string NewName
    {
        get => _newName;
        set
        {
            _newName = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewName)));
        }
    }

    public StudentsViewModel()
    {
        Students.Add(new Student { Name = "Aida Tulegenova", Gpa = 3.85 });
        Students.Add(new Student { Name = "Bekzat Sarsenov", Gpa = 3.20 });
        Students.Add(new Student { Name = "Dana Iskakova", Gpa = 3.95 });
        Students.Add(new Student { Name = "Erlan Nurpeisov", Gpa = 2.75 });
        Students.Add(new Student { Name = "Madina Akhmetova", Gpa = 3.60 });
    }

    public void AddStudent()
    {
        if (string.IsNullOrWhiteSpace(NewName)) return;

        Students.Add(new Student { Name = NewName, Gpa = 3.0 });
        NewName = "";
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}