namespace PRG_MAUI_Quiz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pages.QuizBoard();
        }
    }
}
