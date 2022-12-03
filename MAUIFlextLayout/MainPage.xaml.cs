using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MAUIFlextLayout;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    private ObservableCollection<string> _skills;
    public ObservableCollection<string> Skills
    {
        get
        {
            return _skills;
        }
        set
        {
            _skills = value;
            OnPropertyChanged("Skills");
        }
    }

	public MainPage()
	{
		InitializeComponent();
        Skills = new ObservableCollection<string>();
        BindingContext = this;
    }

    void OnAddSkillClicked(System.Object sender, System.EventArgs e)
    {
        Skills.Add(SkillEntry.Text);
        SkillEntry.Text = "";
    }

    void OnDeleteSkillClicked(System.Object sender, System.EventArgs e)
    {
        string skill = (sender as Image).BindingContext as string;

        if(!string.IsNullOrEmpty(skill))
        {
            Skills.Remove(skill);
        }
    }
}


