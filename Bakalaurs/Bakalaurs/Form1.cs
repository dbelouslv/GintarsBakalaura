using Bakalaurs.BusinessLogic.MainManager;
using Bakalaurs.BusinessLogic.MainModel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bakalaurs
{
    public partial class Form1 : Form
    {
        public Player activePlayer = new Player();
        public MainInformation activeMatch = new MainInformation();

        private readonly IMainManager _mainManager;

        public Form1(IMainManager mainManager)
        {
            InitializeComponent();

            SetScrollPanelHeight(buttonHome.Height, buttonHome.Top, "Galvenā");
            SetActivePanel(PanelType.Home);

            buttonShowStatistics.Visible = buttonPrint.Visible = false;

            _mainManager = mainManager;
        }

        private void SetActivePanel(PanelType panel)
        {
            switch (panel)
            {
                case PanelType.CreateGame:                                     
                    Controls.Add(CreateGame);
                    Controls.Remove(HomePanel);
                    Controls.Remove(ManageGame);
                    Controls.Remove(StatisticOfGamePanel);
                    Controls.Remove(PrintEvent);
                    break;
                case PanelType.StartGame:
                    Controls.Add(ManageGame);
                    Controls.Remove(HomePanel);
                    Controls.Remove(StatisticOfGamePanel);
                    Controls.Remove(CreateGame);
                    Controls.Remove(PrintEvent);
                    break;
                case PanelType.StatisticOfGame:
                    Controls.Add(StatisticOfGamePanel);
                    Controls.Remove(HomePanel);
                    Controls.Remove(CreateGame);
                    Controls.Remove(ManageGame);
                    Controls.Remove(PrintEvent);
                    break;
                case PanelType.SaveStatistic:
                    Controls.Add(PrintEvent);
                    Controls.Remove(HomePanel);
                    Controls.Remove(CreateGame);
                    Controls.Remove(ManageGame);
                    Controls.Remove(StatisticOfGamePanel);
                    break;
                default:
                    Controls.Add(HomePanel);
                    Controls.Remove(StatisticOfGamePanel);
                    Controls.Remove(CreateGame);
                    Controls.Remove(ManageGame);
                    Controls.Remove(PrintEvent);
                    break;
            }
        }

        private void SetScrollPanelHeight(int height, int top, string headerName)
        {
            panelScroll.Height = height;
            panelScroll.Top = top;
            header.Text = headerName;
            ErrorLabel.Text = string.Empty;
        }

        private void SetRadioButtonsForManage()
        {
            var rosterOfFirstTeam = activeMatch.Players.Where(w => w.Team.Id == activeMatch.FirstTeam.Id).ToList();
            var rosterOfSecondTeam = activeMatch.Players.Where(w => w.Team.Id == activeMatch.SecondTeam.Id).ToList();

            teamOneNameLabel.Text = activeMatch.FirstTeam.Title;
            teamTwoNameLabel.Text = activeMatch.SecondTeam.Title;

            int startY = 70;
            foreach (var player in rosterOfFirstTeam)
            {
                var radioButton = new RadioButton
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    ForeColor = System.Drawing.Color.White,
                    Location = new System.Drawing.Point(20, startY),
                    Name = player.Id.ToString(),
                    Size = new System.Drawing.Size(150, 25),
                    Text = $"#{player.Number} {player.FirstName} {player.LastName}",
                    UseVisualStyleBackColor = true
                };

                radioButton.CheckedChanged += new EventHandler(SetActivePlayer);
                ManageGame.Controls.Add(radioButton);
                startY += 25;
            }

            startY = 70;
            foreach (var player in rosterOfSecondTeam)
            {
                var radioButton = new RadioButton
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    ForeColor = System.Drawing.Color.White,
                    Location = new System.Drawing.Point(480, startY),
                    Name = player.Id.ToString(),
                    Size = new System.Drawing.Size(150, 25),
                    Text = $"#{player.Number} {player.FirstName} {player.LastName}",
                    UseVisualStyleBackColor = true
                };

                radioButton.CheckedChanged += new EventHandler(SetActivePlayer);
                ManageGame.Controls.Add(radioButton);
                startY += 25;
            }
        }

        private void SetPlayersStatistic()
        {           
            var rosterOfFirstTeam = activeMatch.Players.Where(w => w.Team.Id == activeMatch.FirstTeam.Id).OrderByDescending(o => o.Points).ToList();
            var rosterOfSecondTeam = activeMatch.Players.Where(w => w.Team.Id == activeMatch.SecondTeam.Id).OrderByDescending(o => o.Points).ToList();

            var teamOnePoints = activeMatch.Players.Where(w => w.Team.Id == activeMatch.FirstTeam.Id).Sum(s => s.Points);
            var teamTwoPoints = activeMatch.Players.Where(w => w.Team.Id == activeMatch.SecondTeam.Id).Sum(s => s.Points);

            StatisticTeamOne.Text = $"{activeMatch.FirstTeam.Title} - {teamOnePoints}";
            StatisticTeamTwo.Text = $"{activeMatch.SecondTeam.Title} - {teamTwoPoints}";

            int startY = 75;
            foreach (var player in rosterOfFirstTeam)
            {
                var label = new Label
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    ForeColor = System.Drawing.Color.White,
                    Location = new System.Drawing.Point(150, startY),
                    Name = player.Id.ToString(),
                    Size = new System.Drawing.Size(200, 25),
                    Text = $"#{player.Number} {player.FirstName} {player.LastName} - {player.Points} Points ({player.Missed} missed shots - {player.AST} assists - {player.REB} rebounds - {player.Foul} fouls)"
                };

                StatisticOfGamePanel.Controls.Add(label);
                startY += 25;
            }

            startY = 300;
            foreach (var player in rosterOfSecondTeam)
            {
                var label = new Label
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    ForeColor = System.Drawing.Color.White,
                    Location = new System.Drawing.Point(150, startY),
                    Name = player.Id.ToString(),
                    Size = new System.Drawing.Size(200, 25),
                    Text = $"#{player.Number} {player.FirstName} {player.LastName} - {player.Points} Points ({player.Missed} missed shots - {player.AST} assists - {player.REB} rebounds - {player.Foul} fouls)"
                };

                StatisticOfGamePanel.Controls.Add(label);
                startY += 25;
            }
        }

        private void SetActivePlayer(object sender, EventArgs e)
        {
            RadioButton radio = (RadioButton)sender;

            if (int.TryParse(radio.Name, out int playerId))
            {
                var player = activeMatch.Players.FirstOrDefault(f => f.Id == playerId);
                if (player != null)
                {
                    activePlayer = player;
                }
            }
        }

        private void UpdateTeamPoints()
        {
            var teamOnePoints = activeMatch.Players.Where(w => w.Team.Id == activeMatch.FirstTeam.Id).Sum(s => s.Points);
            var teamTwoPoints = activeMatch.Players.Where(w => w.Team.Id == activeMatch.SecondTeam.Id).Sum(s => s.Points);

            teamOneNameLabel.Text = $"{activeMatch.FirstTeam.Title} - {teamOnePoints}";
            teamTwoNameLabel.Text = $"{activeMatch.SecondTeam.Title} - {teamTwoPoints}";
        }

        public void Print(object sender, EventArgs e)
        {
            SetScrollPanelHeight(buttonPrint.Height, buttonPrint.Top, "Printēt spēles statistiku");

            var path = savedPath.Text + "//Statistics.pdf";
            var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            var doc = new Document();
            var writer = PdfWriter.GetInstance(doc, fs);

            var teamOnePoints = activeMatch.Players.Where(w => w.Team.Id == activeMatch.FirstTeam.Id).Sum(s => s.Points);
            var teamTwoPoints = activeMatch.Players.Where(w => w.Team.Id == activeMatch.SecondTeam.Id).Sum(s => s.Points);

            var rosterOfFirstTeam = activeMatch.Players.Where(w => w.Team.Id == activeMatch.FirstTeam.Id).OrderByDescending(o => o.Points).ToList();
            var rosterOfSecondTeam = activeMatch.Players.Where(w => w.Team.Id == activeMatch.SecondTeam.Id).OrderByDescending(o => o.Points).ToList();

            doc.Open();

            doc.Add(new Paragraph($"Vieta: { placeInput.Text }"));
            doc.Add(new Paragraph($"Laiks: { timeInput.Text }"));
            doc.Add(new Paragraph($"Tiesnieši: { tesniesi.Text }"));

            var beforeTop = new Paragraph($"{activeMatch.FirstTeam.Title} - {teamOnePoints}", new Font { Size = 20 })
            {
                SpacingBefore = 50,
                SpacingAfter = 15
            };
            doc.Add(beforeTop);

            foreach (var player in rosterOfFirstTeam)
            {
                doc.Add(new Paragraph($"#{player.Number} {player.FirstName} {player.LastName} - {player.Points} Points ({player.Missed} missed shots - {player.AST} assists - {player.REB} rebounds - {player.Foul} fouls)", new Font { Size = 12 }));
            }

            beforeTop = new Paragraph($"{activeMatch.SecondTeam.Title} - {teamTwoPoints}", new Font { Size = 20 })
            {
                SpacingBefore = 15,
                SpacingAfter = 15
            };
            doc.Add(beforeTop);

            foreach (var player in rosterOfSecondTeam)
            {
                doc.Add(new Paragraph($"#{player.Number} {player.FirstName} {player.LastName} - {player.Points} Points ({player.Missed} missed shots - {player.AST} assists - {player.REB} rebounds - {player.Foul} fouls)", new Font { Size = 12 }));
            }

            doc.Close();
            writer.Close();
            fs.Close();

            textSaglabat.Text = "PDF saglabāt!";
        }

        public void Exit(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Vai vēlaties iziet? ", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
                Environment.Exit(1);
        }

        public void SaveFirstTeam(object sender, EventArgs e)
        {
            activeMatch.FirstTeam = new Team();
            _mainManager.CreaTeam(ref activeMatch.FirstTeam, 1, ref textBox1, ref SaveFirstTeamName);

            _mainManager.SetVisability(ref label6, ref pOneFirstName,
                ref pOneLastName, ref AddTeamFirstPlayer, ref richTextBox1, ref firstNumber);
        }

        public void SaveSecondTeam(object sender, EventArgs e)
        {
            activeMatch.SecondTeam = new Team();
            _mainManager.CreaTeam(ref activeMatch.SecondTeam, 2, ref textBox2, ref SaveSecondTeamName);

            _mainManager.SetVisability(ref label7, ref pSecondFirstName,
                ref pSecondLastName, ref AddTeamSecondPlayer, ref richTextBox2, ref secondNumber);
        }

        public void AddForFirstTeamPlayer(object sender, EventArgs e)
        {
            if (_mainManager.IfFieldsAreFilled(pOneFirstName.Text, pOneLastName.Text, firstNumber.Text, out int number))
            {
                activeMatch.Players.Add(_mainManager.CreatePlayer(pOneFirstName.Text, pOneLastName.Text, activeMatch.FirstTeam, number, activeMatch.Players.Count()));
                _mainManager.ResetPlayerFields(ref pOneFirstName, ref pOneLastName, ref firstNumber, ref ErrorLabel);

                var lastPlayer = activeMatch.Players.Last();
                _mainManager.AppendRichTextBox(ref richTextBox1, $"#{lastPlayer.Number} {lastPlayer.FirstName} {lastPlayer.LastName}\n");
            }
            else
                _mainManager.SetError("Kļūda! Tukšs laukums.", ref ErrorLabel);

            _mainManager.ShowButtonManage(ref ToStartGame, activeMatch.Players, timeInput, placeInput, tesniesi);
        }

        public void AddForSecondTeamPlayer(object sender, EventArgs e)
        {
            if (_mainManager.IfFieldsAreFilled(pSecondFirstName.Text, pSecondLastName.Text, secondNumber.Text, out int number))
            {
                activeMatch.Players.Add(_mainManager.CreatePlayer(pSecondFirstName.Text, pSecondLastName.Text, activeMatch.SecondTeam, number, activeMatch.Players.Count()));
                _mainManager.ResetPlayerFields(ref pSecondFirstName, ref pSecondLastName, ref secondNumber, ref ErrorLabel);

                var lastPlayer = activeMatch.Players.Last();
                _mainManager.AppendRichTextBox(ref richTextBox2, $"#{lastPlayer.Number} {lastPlayer.FirstName} {lastPlayer.LastName}\n");
            }
            else
                _mainManager.SetError("Kļūda! Tukšs laukums.", ref ErrorLabel);

            _mainManager.ShowButtonManage(ref ToStartGame, activeMatch.Players, timeInput, placeInput, tesniesi);
        }

        public void GoToHome(object sender, EventArgs e)
        {
            SetScrollPanelHeight(buttonHome.Height, buttonHome.Top, "Galvenā");
            SetActivePanel(PanelType.Home);
        }

        public void GoToNewGame(object sender, EventArgs e)
        {
            SetScrollPanelHeight(buttonNewGame.Height, buttonNewGame.Top, "Izveidot jaunu spēli");
            SetActivePanel(PanelType.CreateGame);
            activeMatch = new MainInformation();
            ResetNewGameDate();
        }

        public void ShowGameStatistic(object sender, EventArgs e)
        {
            SetScrollPanelHeight(buttonShowStatistics.Height, buttonShowStatistics.Top, "Spēles statistika");
            SetActivePanel(PanelType.StatisticOfGame);
        }

        public void GoToManage(object sender, EventArgs e)
        {
            SetScrollPanelHeight(buttonNewGame.Height, buttonNewGame.Top, "Sakt jaunu spēli");
            SetActivePanel(PanelType.StartGame);
            SetRadioButtonsForManage();
        }

        public void GoToPrint(object sender, EventArgs e)
        {
            SetScrollPanelHeight(buttonNewGame.Height, buttonNewGame.Top, "Saglabāt statistiku");
            SetActivePanel(PanelType.SaveStatistic);
            textSaglabat.Text = savedPath.Text = string.Empty;
        }

        public void AddOnePointToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.Points++;
            }

            UpdateTeamPoints();
        }        

        public void AddTwoPointToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.Points += 2;
            }

            UpdateTeamPoints();
        }

        public void AddThreePointToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.Points += 3;
            }

            UpdateTeamPoints();
        }

        public void AddRebToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.REB++;
            }
        }

        public void AddMissedToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.Missed++;
            }
        }

        public void AddAstToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.AST++;
            }
        }

        public void AddToFromActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.Foul++;
            }
        }

        public void SaveData(object sender, EventArgs e)
        {
            SetScrollPanelHeight(buttonShowStatistics.Height, buttonShowStatistics.Top, "Izvadīt spēles statistiku");
            SetActivePanel(PanelType.StatisticOfGame);
            SetPlayersStatistic();
            buttonShowStatistics.Visible = true;
            buttonPrint.Visible = true;
        }

        public void RemoveOnePointFromActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                if (currentPlayer.Points > 0)
                    currentPlayer.Points -= 1;
            }

            UpdateTeamPoints();
        }

        public void RemoveTwoPointFromActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                if (currentPlayer.Points > 1)
                    currentPlayer.Points -= 2;
            }

            UpdateTeamPoints();
        }

        public void RemoveThreePointFromActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                if (currentPlayer.Points > 2)
                    currentPlayer.Points -= 3;
            }

            UpdateTeamPoints();
        }

        public void RemoveREBFromActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                if (currentPlayer.REB > 0)
                    currentPlayer.REB--;
            }
        }

        public void RemoveMSDFromActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                if (currentPlayer.Missed > 0)
                    currentPlayer.Missed--;
            }
        }

        public void RemoveASTFromActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                if (currentPlayer.AST > 0)
                    currentPlayer.AST--;
            }
        }        

        public void RemoveFoulFromActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = activeMatch.Players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                if (currentPlayer.Foul > 0)
                    currentPlayer.Foul--;
            }
        }

        private void ResetNewGameDate()
        {
            pOneFirstName.Text = pOneLastName.Text = firstNumber.Text = pSecondFirstName.Text = pSecondLastName.Text 
                = secondNumber.Text = textBox1.Text = textBox2.Text = timeInput.Text = placeInput.Text = tesniesi.Text = string.Empty;

            richTextBox1.Clear();
            richTextBox2.Clear();

            pOneFirstName.Visible = pOneLastName.Visible = firstNumber.Visible 
                = pSecondFirstName.Visible = pSecondLastName.Visible = secondNumber.Visible = ToStartGame.Visible 
                = AddTeamFirstPlayer.Visible = AddTeamSecondPlayer.Visible = label6.Visible = label7.Visible = false;

            SaveFirstTeamName.Visible = SaveSecondTeamName.Visible = textBox1.Enabled
                = textBox2.Enabled = timeInput.Enabled = placeInput.Enabled = btnSaveTime.Visible = tesniesi.Enabled  = true;
        }

        private void SavePlaceAndTime(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(placeInput.Text) && !string.IsNullOrEmpty(timeInput.Text) && !string.IsNullOrEmpty(tesniesi.Text))
            {
                placeInput.Enabled = timeInput.Enabled = tesniesi.Enabled = false;
                btnSaveTime.Visible = false;
                ErrorLabel.Text = string.Empty;

                activeMatch.Place = placeInput.Text;
                activeMatch.Time = timeInput.Text;

                _mainManager.ShowButtonManage(ref ToStartGame, activeMatch.Players, timeInput, placeInput, tesniesi);
            }
            else
                _mainManager.SetError("Laiks, vieta vai tiesnieši bija tukši", ref ErrorLabel);
        }

        public void OpenFolderDialog(object sender, EventArgs e)
        {
            if (selectFolder.ShowDialog() == DialogResult.OK)
            {
                savedPath.Text = selectFolder.SelectedPath;
            }
        }       
    }
}
