using System.Collections.Generic;
using System.Linq;
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
        void ShowButtonManage(ref Button toStartGame, List<Player> players, TextBox time, TextBox place, TextBox tesniesi);
        void CreaTeam(ref Team team, int id, ref TextBox textBox, ref Button button);
        void SetVisability(ref Label label, ref TextBox textboxFirstName, ref TextBox textboxLastName, ref Button button, ref RichTextBox richTextBox, ref TextBox numberTextBox);
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
                Id = id + 1,
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

        public void ShowButtonManage(ref Button toStartGame, List<Player> players, TextBox time, TextBox place, TextBox tesniesi) 
        {
            if (players.Any(a => a.Team.Id == 1) && players.Any(a => a.Team.Id == 2))
            {
                if (!string.IsNullOrEmpty(time.Text) && !string.IsNullOrEmpty(place.Text) && !string.IsNullOrEmpty(tesniesi.Text))
                    toStartGame.Visible = true;
            }
        }

        public void CreaTeam(ref Team team, int id, ref TextBox textBox, ref Button button)
        {
            team.Id = id;
            team.Title = textBox.Text;

            textBox.Enabled = button.Visible = false;
        }

        public void SetVisability(ref Label label, ref TextBox textboxFirstName, ref TextBox textboxLastName, ref Button button, ref RichTextBox richTextBox, ref TextBox numberTextBox)
        {
            label.Visible = textboxFirstName.Visible = textboxLastName.Visible = button.Visible = richTextBox.Visible = numberTextBox.Visible = true;
        }
    }
}
