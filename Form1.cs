
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HigherLuck
{
    public partial class Form1 : Form
    {
        private Player? player1;
        private Player? player2;

        private readonly Random random = new Random();

        private readonly string resultFile =
                Path.GetFullPath(
                Path.Combine(
                AppContext.BaseDirectory,
                @"..\..\..",
               "HigherLuckResults.txt"));

        private int totalRounds;
        private int currentRound;
        private int currentTurn;
        private int firstRoll;
        private int secondRoll;
        private bool gameStarted;

        public Form1()
        {
            InitializeComponent();

            textBox1.TextChanged += NamesChanged;
            textBox2.TextChanged += NamesChanged;

            btnSetupP1.Click += SetupPlayer1;
            btnSetupP2.Click += SetupPlayer2;
            btnStart.Click += btnStart_Click;
            btnRoll.Click += RollDice;
            btnReset.Click += ResetGame;
            btnShowResult.Click += ShowResults;

            ResetValues();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void NamesChanged(object? sender, EventArgs e)
        {
            bool bothNamesEntered =
                !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox1.Text);

            btnSetupP1.Enabled =
                bothNamesEntered && player1 == null;

            btnSetupP2.Enabled =
                bothNamesEntered && player2 == null;
        }

        private int SelectedAvatar()
        {
            if (rbAvatar1.Checked) return 1;
            if (rbAvatar2.Checked) return 2;
            if (rbAvatar3.Checked) return 3;
            if (rbAvatar4.Checked) return 4;

            return 0;
        }

        private Image? AvatarImage(int index)
        {
            switch (index)
            {
                case 1: return pictureBox1.Image;
                case 2: return pictureBox2.Image;
                case 3: return pictureBox3.Image;
                case 4: return pictureBox4.Image;
                default: return null;
            }
        }

        private void SetupPlayer1(object? sender, EventArgs e)
        {
            int avatar = SelectedAvatar();

            if (avatar == 0)
            {
                MessageBox.Show("Please select an avatar.");
                return;
            }

            if (player2 != null &&
                player2.AvatarIndex == avatar)
            {
                MessageBox.Show(
                    "Both players cannot use the same avatar.");
                return;
            }

            player1 = new Player(textBox2.Text.Trim(), avatar);
            if (avatar == 1) rbAvatar1.Enabled = false;
            if (avatar == 2) rbAvatar2.Enabled = false;
            if (avatar == 3) rbAvatar3.Enabled = false;
            if (avatar == 4) rbAvatar4.Enabled = false;

            rbAvatar1.Checked = false;
            rbAvatar2.Checked = false;
            rbAvatar3.Checked = false;
            rbAvatar4.Checked = false;

            lblNameP1.Text = player1.Name;
            picAvatarP1.Image = AvatarImage(avatar);

            btnSetupP1.Enabled = false;
            textBox2.Enabled = false;

            UpdateStartButton();
        }

        private void SetupPlayer2(object? sender, EventArgs e)
        {
            int avatar = SelectedAvatar();

            if (avatar == 0)
            {
                MessageBox.Show("Please select an avatar.");
                return;
            }

            if (player1 != null &&
                player1.AvatarIndex == avatar)
            {
                MessageBox.Show(
                    "Both players cannot use the same avatar.");
                return;
            }

            player2 = new Player(textBox1.Text.Trim(), avatar);

            grpPlayer2.Text = player2.Name;
            picAvatarP2.Image = AvatarImage(avatar);

            btnSetupP2.Enabled = false;
            textBox1.Enabled = false;

            UpdateStartButton();
        }

        private void UpdateStartButton()
        {
            btnStart.Enabled =
                player1 != null &&
                player2 != null &&
                !gameStarted;
        }

        private void btnStart_Click(object? sender, EventArgs e)
        {
            if (player1 == null || player2 == null)
            {
                MessageBox.Show("Please set up both players.");
                return;
            }

            totalRounds = (int)numericUpDown1.Value;

            if (totalRounds < 5 || totalRounds > 30)
            {
                MessageBox.Show(
                    "Rounds must be between 5 and 30.");
                return;
            }

            currentRound = 1;
            currentTurn = 1;
            gameStarted = true;

            player1.Points = 0;
            player2.Points = 0;

            lblPointsP1.Text = "0";
            lblPointsP2.Text = "0";

            lblRound.Text =
                $"Round: {currentRound}/{totalRounds}";

            lblTurn.ForeColor = Color.White;
            lblTurn.Text = $"{player1.Name}'s turn";

            btnStart.Enabled = false;
            btnRoll.Enabled = true;

            numericUpDown1.Enabled = false;
            groupBox3.Enabled = false;

            picDice.Image = null;
        }

        private void RollDice(object? sender, EventArgs e)
        {
            if (!gameStarted ||
                player1 == null ||
                player2 == null)
                return;

            int dice = random.Next(1, 7);
            ShowDice(dice);

            if (currentTurn == 1)
            {
                firstRoll = dice;
                currentTurn = 2;
                lblTurn.Text = $"{player2.Name}'s turn";
            }
            else
            {
                secondRoll = dice;

                if (firstRoll > secondRoll)
                {
                    player1.AddPoint();
                }
                else if (secondRoll > firstRoll)
                {
                    player2.AddPoint();
                }
                else
                {
                    player1.AddPoint();
                    player2.AddPoint();
                }

                lblPointsP1.Text = player1.Points.ToString();
                lblPointsP2.Text = player2.Points.ToString();

                if (currentRound >= totalRounds)
                {
                    FinishGame();
                    return;
                }

                currentRound++;
                currentTurn = 1;

                lblRound.Text =
                    $"Round: {currentRound}/{totalRounds}";

                lblTurn.Text = $"{player1.Name}'s turn";
            }
        }

        private void ShowDice(int value)
        {
            if (value == 1)
            {
                picDice.Image = Image.FromFile("image/dice1.jpg");
            }
            else if (value == 2)
            {
                picDice.Image = Image.FromFile("image/dice2.jpg");
            }
            else if (value == 3)
            {
                picDice.Image = Image.FromFile("image/dice3.jpg");
            }
            else if (value == 4)
            {
                picDice.Image = Image.FromFile("image/dice4.jpg");
            }
            else if (value == 5)
            {
                picDice.Image = Image.FromFile("image/dice5.jpg");
            }
            else if (value == 6)
            {
                picDice.Image = Image.FromFile("image/dice6.jpg");
            }
        }

        private void FinishGame()
        {
            if (player1 == null || player2 == null)
                return;

            gameStarted = false;
            btnRoll.Enabled = false;

            string winner;

            if (player1.Points > player2.Points)
                winner = player1.Name;
            else if (player2.Points > player1.Points)
                winner = player2.Name;
            else
                winner = "DRAW";

            string result =
                $"{DateTime.Now:yyyy-MM-dd HH:mm} | " +
                $"{player1.Name}: {player1.Points} | " +
                $"{player2.Name}: {player2.Points} | " +
                $"Winner: {winner}";

            lblTurn.Text = $"Winner: {winner}";


            try
            {
                Directory.CreateDirectory(
                    Path.GetDirectoryName(resultFile)!);

                FileStream fs = new FileStream(
                    resultFile,
                    FileMode.Append,
                    FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(result);

                sw.Close();
                fs.Close();
                MessageBox.Show(
                         "The game result has been saved successfully!",
                         "Saved Successfully",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                btnShowResult.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saving result: " + ex.Message);
            }


            MessageBox.Show(
                winner == "DRAW"
                    ? "The game ended in a draw!"
                    : $"The winner is {winner}!",
                "Game Finished");
        }


        private void ShowResults(object? sender, EventArgs e)
        {
            try
            {
                lstReport.Items.Clear();

                if (!File.Exists(resultFile))
                {
                    MessageBox.Show("No results saved yet.");
                    return;
                }

                FileStream fs = new FileStream(
                    resultFile,
                    FileMode.Open,
                    FileAccess.Read);

                StreamReader sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() ?? "";
                    lstReport.Items.Add(line);
                }

                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading results: " + ex.Message);
            }
        }


        private void ResetGame(object? sender, EventArgs e)
        {
            ResetValues();
        }

        private void ResetValues()
        {
            player1 = null;
            player2 = null;

            gameStarted = false;
            currentRound = 0;
            currentTurn = 0;
            firstRoll = 0;
            secondRoll = 0;
            totalRounds = 5;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();

            numericUpDown1.Enabled = true;
            numericUpDown1.Value = 5;

            groupBox3.Enabled = true;

            rbAvatar1.Enabled = true;
            rbAvatar2.Enabled = true;
            rbAvatar3.Enabled = true;
            rbAvatar4.Enabled = true;

            rbAvatar1.Checked = false;
            rbAvatar2.Checked = false;
            rbAvatar3.Checked = false;
            rbAvatar4.Checked = false;

            lblNameP1.Text = "First Player";
            grpPlayer2.Text = "Second Player";

            lblPointsP1.Text = "0";
            lblPointsP2.Text = "0";

            lblRound.Text = "Round: 0";
            lblTurn.Text = "";

            picAvatarP1.Image = null;
            picAvatarP2.Image = null;

            Image? oldImage = picDice.Image;
            picDice.Image = null;

            if (oldImage is Bitmap)
                oldImage.Dispose();

            btnSetupP1.Enabled = false;
            btnSetupP2.Enabled = false;
            btnStart.Enabled = false;
            btnRoll.Enabled = false;

            btnShowResult.Enabled = File.Exists(resultFile);

            lstReport.Items.Clear();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void picDice_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

    }
}
