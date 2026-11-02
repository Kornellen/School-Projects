using System.Collections.ObjectModel;
using _07_mobilne.Models;

namespace _07_mobilne
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Note> Notes { get; set; } = new();

        public MainPage()
        {
            InitializeComponent();

            Notes.Add(new Note { Title = "eTst", Content = "gdsgdsg" });
            BindingContext = this;
        }

        private void add_task_btn_Clicked(object sender, EventArgs e)
        {
            string title = note_title_entr.Text;
            string content = note_content_entr.Text;
            if (title.Length == 0 || content.Length == 0) return;

            Notes.Add(new Note { Title = title, Content = content });
        }
    }
}
