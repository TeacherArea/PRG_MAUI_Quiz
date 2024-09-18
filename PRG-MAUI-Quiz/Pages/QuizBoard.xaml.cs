namespace PRG_MAUI_Quiz.Pages;

public partial class QuizBoard : ContentPage
{
	private string question = "Vad heter huvustaden i Sverige?";
	private string correctAnswer = "Stockholm";
	private int questionPoints = 0;

	public QuizBoard()
	{
		InitializeComponent();
		QuestionLabel.Text = question;
	}

	private void OnCheckAnswerClicked(object sender, EventArgs e)
	{
		string userAnswer = AnswerEntry.Text?.Trim();

		if (string.IsNullOrEmpty(userAnswer))
		{
			ResultLabel.Text = "Fyll i ditt svar";
			ResultLabel.TextColor = Colors.Red;
			return;
		}

		if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
		{
			ResultLabel.Text = "Rätt!";
			ResultLabel.TextColor = Colors.Green;
			questionPoints++;
			PointsLabel.Text = questionPoints.ToString();
		}
		else
		{
			ResultLabel.Text = "Fel! Försök igen";
			ResultLabel.TextColor = Colors.Red;
		}
	}
}