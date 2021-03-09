using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise04
{
    enum Mode { AnyLetter, FirstLetter }
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        Mode mode;

        public Form1()
        {
            InitializeComponent();
            stats.UpdatedStats += OnUpdateStats;
            timer1.Stop();
            timer1.Tick += OnTimerTick;
        }

        private void OnUpdateStats(object sender, EventArgs e)
        {
            correctLabel.Text = $"Correct: {stats.Correct}";
            missedLabel.Text = $"Missed: {stats.Missed}";
            accurancyLabel.Text = $"Accuracy: {stats.Accuracy} %";
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (gameListBox.Items.Count > 6)
            {
                timer1.Stop();
                gameListBox.KeyDown -= OnKeyDown;
                gameListBox.Items.Clear();
                gameListBox.Items.Add("Game over");
                return;
            }
            gameListBox.Items.Add((Keys)random.Next(65, 91));
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (mode == Mode.AnyLetter)
            {
                if (gameListBox.Items.Contains(e.KeyCode))
                {
                    gameListBox.Items.Remove(e.KeyCode);
                    gameListBox.Refresh();
                    updateTimer();
                    stats.Update(true);
                }
                else
                {
                    stats.Update(false);
                }
            } else
            {
                if ((Keys)gameListBox.Items[0] == e.KeyCode)
                {
                    gameListBox.Items.RemoveAt(0);
                    gameListBox.Refresh();
                    updateTimer();
                    stats.Update(true);
                }
                else
                {
                    stats.Update(false);
                }
            }
            int difficulty = 800 - timer1.Interval;
            difficultProgressBar.Value = difficulty;

        }

        private void updateTimer()
        {
            if (timer1.Interval > 400)
                timer1.Interval -= 60;

            if (timer1.Interval > 250)
                timer1.Interval -= 15;

            if (timer1.Interval > 150)
                timer1.Interval -= 8;
        }

        private void NewGameButtonAnyLetter_Click(object sender, EventArgs e)
        {
            mode = Mode.AnyLetter;
            StartNewGame();
        }

        private void StartNewGame()
        {
            gameListBox.Items.Clear();
            stats.clearStats();
            timer1.Interval = 800;
            gameListBox.KeyDown += OnKeyDown;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewGameFirstLetter_Click(object sender, EventArgs e)
        {
            mode = Mode.FirstLetter;
            StartNewGame();
        }
    }
}
