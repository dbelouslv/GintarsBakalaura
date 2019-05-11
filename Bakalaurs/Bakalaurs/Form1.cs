using Bakalaurs.BusinessLogic.MainManager;
using Bakalaurs.BusinessLogic.MainModel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Bakalaurs
{
    public partial class Form1 : Form
    {
        public List<Player> players = new List<Player>();
        public Team FirstTeam = new Team();
        public Team SecondTeam = new Team();
        public Player activePlayer = new Player();

        private readonly IMainManager _mainManager;

        public Form1(IMainManager mainManager)
        {
            InitializeComponent();

            SetScrollPanelHeight(buttonHome.Height, buttonHome.Top, "Galvenā");
            SetActivePanel(PanelType.Home);

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
                    break;
                case PanelType.StartGame:
                    Controls.Add(ManageGame);
                    Controls.Remove(HomePanel);
                    Controls.Remove(StatisticOfGamePanel);
                    Controls.Remove(CreateGame);
                    break;
                case PanelType.StatisticOfGame:
                    Controls.Add(StatisticOfGamePanel);
                    Controls.Remove(HomePanel);
                    Controls.Remove(CreateGame);
                    Controls.Remove(ManageGame);
                    break;
                default:
                    Controls.Add(HomePanel);
                    Controls.Remove(StatisticOfGamePanel);
                    Controls.Remove(CreateGame);
                    Controls.Remove(ManageGame);
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
            var rosterOfFirstTeam = players.Where(w => w.Team.Id == FirstTeam.Id).ToList();
            var rosterOfSecondTeam = players.Where(w => w.Team.Id == SecondTeam.Id).ToList();

            teamOneNameLabel.Text = FirstTeam.Title;
            teamTwoNameLabel.Text = SecondTeam.Title;

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
            var rosterOfFirstTeam = players.Where(w => w.Team.Id == FirstTeam.Id).OrderByDescending(o => o.Points).ToList();
            var rosterOfSecondTeam = players.Where(w => w.Team.Id == SecondTeam.Id).OrderByDescending(o => o.Points).ToList();

            var teamOnePoints = players.Where(w => w.Team.Id == FirstTeam.Id).Sum(s => s.Points);
            var teamTwoPoints = players.Where(w => w.Team.Id == SecondTeam.Id).Sum(s => s.Points);

            StatisticTeamOne.Text = $"{FirstTeam.Title} - {teamOnePoints}";
            StatisticTeamTwo.Text = $"{SecondTeam.Title} - {teamTwoPoints}";

            int startY = 75;
            foreach (var player in rosterOfFirstTeam)
            {
                var label = new Label
                {
                    AutoSize = true,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    ForeColor = System.Drawing.Color.White,
                    Location = new System.Drawing.Point(250, startY),
                    Name = player.Id.ToString(),
                    Size = new System.Drawing.Size(200, 25),
                    Text = $"#{player.Number} {player.FirstName} {player.LastName} - {player.Points}   ({player.Missed} - {player.AST} - {player.REB})"
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
                    Location = new System.Drawing.Point(250, startY),
                    Name = player.Id.ToString(),
                    Size = new System.Drawing.Size(200, 25),
                    Text = $"#{player.Number} {player.FirstName} {player.LastName} - {player.Points}   ({player.Missed} - {player.AST} - {player.REB})"
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
                var player = players.FirstOrDefault(f => f.Id == playerId);
                if (player != null)
                {
                    activePlayer = player;
                }
            }
        }

        private void UpdateTeamPoints()
        {
            var teamOnePoints = players.Where(w => w.Team.Id == FirstTeam.Id).Sum(s => s.Points);
            var teamTwoPoints = players.Where(w => w.Team.Id == SecondTeam.Id).Sum(s => s.Points);

            teamOneNameLabel.Text = $"{FirstTeam.Title} - {teamOnePoints}";
            teamTwoNameLabel.Text = $"{SecondTeam.Title} - {teamTwoPoints}";
        }

        public void Print(object sender, EventArgs e)
        {
            SetScrollPanelHeight(buttonPrint.Height, buttonPrint.Top, "Printēt spēles statistiku");

            var fs = new FileStream("Statistics.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            var doc = new Document();
            var writer = PdfWriter.GetInstance(doc, fs);

            var teamOnePoints = players.Where(w => w.Team.Id == FirstTeam.Id).Sum(s => s.Points);
            var teamTwoPoints = players.Where(w => w.Team.Id == SecondTeam.Id).Sum(s => s.Points);

            var rosterOfFirstTeam = players.Where(w => w.Team.Id == FirstTeam.Id).OrderByDescending(o => o.Points).ToList();
            var rosterOfSecondTeam = players.Where(w => w.Team.Id == SecondTeam.Id).OrderByDescending(o => o.Points).ToList();

            doc.Open();
            doc.Add(new Paragraph($"{FirstTeam.Title} - {teamOnePoints}", new Font { Size = 20 }));

            foreach (var player in rosterOfFirstTeam)
            {
                doc.Add(new Paragraph($"#{player.Number} {player.FirstName} {player.LastName} - {player.Points}   ({player.Missed} - {player.AST} - {player.REB})", new Font { Size = 14 }));
            }

            doc.Add(new Paragraph($"{SecondTeam.Title} - {teamTwoPoints}", new Font { Size = 20 }));

            foreach (var player in rosterOfSecondTeam)
            {
                doc.Add(new Paragraph($"#{player.Number} {player.FirstName} {player.LastName} - {player.Points}   ({player.Missed} - {player.AST} - {player.REB})", new Font { Size = 14 }));
            }

            doc.Close();
            writer.Close();
            fs.Close();
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
            _mainManager.CreaTeam(ref FirstTeam, 1, ref textBox1, ref SaveFirstTeamName);

            _mainManager.SetVisability(ref label6, ref pOneFirstName,
                ref pOneLastName, ref AddTeamFirstPlayer, ref richTextBox1, ref firstNumber);
        }

        public void SaveSecondTeam(object sender, EventArgs e)
        {
            _mainManager.CreaTeam(ref SecondTeam, 2, ref textBox2, ref SaveSecondTeamName);

            _mainManager.SetVisability(ref label7, ref pSecondFirstName,
                ref pSecondLastName, ref AddTeamSecondPlayer, ref richTextBox2, ref secondNumber);
        }

        public void AddForFirstTeamPlayer(object sender, EventArgs e)
        {
            if (_mainManager.IfFieldsAreFilled(pOneFirstName.Text, pOneLastName.Text, firstNumber.Text, out int number))
            {
                players.Add(_mainManager.CreatePlayer(pOneFirstName.Text, pOneLastName.Text, FirstTeam, number, players.Count()));
                _mainManager.ResetPlayerFields(ref pOneFirstName, ref pOneLastName, ref firstNumber, ref ErrorLabel);

                var lastPlayer = players.Last();
                _mainManager.AppendRichTextBox(ref richTextBox1, $"#{lastPlayer.Number} {lastPlayer.FirstName} {lastPlayer.LastName}\n");
            }
            else
                _mainManager.SetError("Kļūda! Tukšs laukums.", ref ErrorLabel);

            _mainManager.ShowButtonManage(ref ToStartGame, players);
        }

        public void AddForSecondTeamPlayer(object sender, EventArgs e)
        {
            if (_mainManager.IfFieldsAreFilled(pSecondFirstName.Text, pSecondLastName.Text, secondNumber.Text, out int number))
            {
                players.Add(_mainManager.CreatePlayer(pSecondFirstName.Text, pSecondLastName.Text, SecondTeam, number, players.Count()));
                _mainManager.ResetPlayerFields(ref pSecondFirstName, ref pSecondLastName, ref secondNumber, ref ErrorLabel);

                var lastPlayer = players.Last();
                _mainManager.AppendRichTextBox(ref richTextBox2, $"#{lastPlayer.Number} {lastPlayer.FirstName} {lastPlayer.LastName}\n");
            }
            else
                _mainManager.SetError("Kļūda! Tukšs laukums.", ref ErrorLabel);

            _mainManager.ShowButtonManage(ref ToStartGame, players);
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

        public void AddOnePointToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.Points++;
            }

            UpdateTeamPoints();
        }        

        public void AddTwoPointToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.Points += 2;
            }

            UpdateTeamPoints();
        }

        public void AddThreePointToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.Points += 3;
            }

            UpdateTeamPoints();
        }

        public void AddRebToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.REB++;
            }
        }

        public void AddMissedToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.Missed++;
            }
        }

        public void AddAstToActivePlayer(object sender, EventArgs e)
        {
            var currentPlayer = players.FirstOrDefault(f => f.Id == activePlayer.Id);

            if (currentPlayer != null)
            {
                currentPlayer.AST++;
            }
        }

        public void SaveData(object sender, EventArgs e)
        {
            SetScrollPanelHeight(buttonShowStatistics.Height, buttonShowStatistics.Top, "Izvadīt spēles statistiku");
            SetActivePanel(PanelType.StatisticOfGame);
            SetPlayersStatistic();
        }
    }
}
