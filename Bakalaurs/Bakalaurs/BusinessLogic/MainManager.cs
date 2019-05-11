using System.Windows.Forms;
using Bakalaurs.BusinessLogic.MainModel;

namespace Bakalaurs.BusinessLogic.MainManager
{
    public interface IMainManager
    {
        bool IfFieldsAreFilled(string firstName, string lastName, string numberString, out int number);
        Player CreatePlayer(string firstName, string lastName, Team team, int number, int id);
        void SetError(string errorMessage, ref Label label);
        void ResetPlayerFields(ref TextBox firstTextBox, ref TextBox secondTextBox, ref TextBox numberTextBox, ref Label label);
        void AppendRichTextBox(ref RichTextBox richTextBox1, string message);
        void SetActivePanel(ref Panel activepanel);
    }

    public class MainManager : IMainManager
    {
        public MainManager()
        {
        }

        public bool IfFieldsAreFilled(string firstName, string lastName, string numberString, out int number)
        {
            number = 0;

            return !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(numberString) && int.TryParse(numberString, out number);
        }

        public Player CreatePlayer(string firstName, string lastName, Team team, int number, int id)
        {
            return new Player
            {
                FirstName = firstName,
                Id = id,
                LastName = lastName,
                Team = team,
                Number = number
            };
        }

        public void SetError(string errorMessage, ref Label label)
        {
            label.Text = errorMessage;
        }

        public void ResetPlayerFields(ref TextBox firstTextBox, ref TextBox secondTextBox, ref TextBox numberTextBox, ref Label label)
        {
            firstTextBox.Text = secondTextBox.Text = numberTextBox.Text = label.Text = string.Empty;
        }

        public void AppendRichTextBox(ref RichTextBox richTextBox, string message)
        {
            richTextBox.AppendText(message);
        }

        public void SetActivePanel(ref Panel activepanel)
        {

        }
    }
}
