using Gecko;
using Gecko.DOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace MartingaleBot
{
    public partial class MainWindow : Form
    {
        private string username;
        private int credits;
        private int startCredits;
        private int concurrentLosses = 0;
        private int concurrentWins = 0;
        private int wins = 0;
        private int betStreak = 0;
        private int previousBet;
        private bool stopNext = false;

        private System.Timers.Timer timer;

        private GeckoElement usernameElement;
        private GeckoElement creditElement;
        private GeckoInputElement textboxElement;
        private GeckoHtmlElement redButton;
        private GeckoHtmlElement blackButton;
        private GeckoElement resultList;
        private GeckoElement statusText;
        private GeckoElement betRedStatusText;
        private GeckoElement betBlackStatusText;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            browser.Navigate("https://www.csgohill.com/");
            colourCombo.SelectedIndex = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            int loggedIn = browser.Document.GetElementsByClassName("mobile_menu loginButton").Count();
            if (loggedIn == 1)
            {
                MessageBox.Show("Please log in.");
            }
            else if (loggedIn == 0)
            {

                startButton.Enabled = false;
                colourCombo.Enabled = false;
                startAmountTextbox.Enabled = false;
                //browser.Enabled = false;

                initializeElements();

                getName();
                getCredits();
                setStartCredits();

                timer = new System.Timers.Timer(5000);
                timer.Elapsed += logic;
                timer.Start();

            }


        }

        private void initializeElements()
        {
            usernameElement = (GeckoElement)browser.Document.GetElementsByClassName("username")[0];
            creditElement = (GeckoElement)browser.Document.GetElementsByClassName("credits")[0];

            GeckoElement textboxParent = (GeckoElement)browser.Document.GetElementsByClassName("bet_system")[0];
            foreach (GeckoNode child in textboxParent.ChildNodes)
            {
                if (child.NodeName.ToLower() == "input")
                {
                    textboxElement = (GeckoInputElement)child;
                }
            }

            GeckoNode redDiv = browser.Document.GetElementsByClassName("table")[0];
            foreach (GeckoNode child in redDiv.ChildNodes)
            {
                if (NodeType.Element == child.NodeType)
                {
                    GeckoElement convert = (GeckoElement)child;
                    if (convert.GetAttribute("data-color") == "red")
                    {
                        redButton = (GeckoHtmlElement)child;
                        Console.WriteLine("Got Red");
                    }
                }

            }

            GeckoNode blackDiv = browser.Document.GetElementsByClassName("table")[2];
            foreach (GeckoNode child in blackDiv.ChildNodes)
            {
                if (NodeType.Element == child.NodeType)
                {
                    GeckoElement convert = (GeckoElement)child;
                    if (convert.GetAttribute("data-color") == "black")
                    {
                        blackButton = (GeckoHtmlElement)child;
                        Console.WriteLine("Got Black");
                    }
                }

            }

            GeckoNode resultListParent = browser.Document.GetElementsByClassName("winner_history")[0];
            foreach (GeckoNode child in resultListParent.ChildNodes)
            {
                if (NodeType.Element == child.NodeType)
                {
                    GeckoElement convert = (GeckoElement)child;
                    if (convert.GetAttribute("class") == "holder")
                    {
                        resultList = (GeckoElement)child;
                    }
                }

            }

            GeckoNode statusTextParent = browser.Document.GetElementsByClassName("roll_timer")[0];
            foreach (GeckoNode child in statusTextParent.ChildNodes)
            {
                if (NodeType.Element == child.NodeType)
                {
                    GeckoElement convert = (GeckoElement)child;
                    if (convert.GetAttribute("class") == "bg")
                    {
                        statusText = (GeckoElement)child;
                    }
                }

            }

            betRedStatusText = (GeckoElement)browser.Document.GetElementsByClassName("your")[0];
            betBlackStatusText = (GeckoElement)browser.Document.GetElementsByClassName("your")[2];


        }

        private void logic(object source, ElapsedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {

                string betText;

                if (colourCombo.Text == "red")
                {
                    betText = betRedStatusText.TextContent;

                }
                else {
                    betText = betBlackStatusText.TextContent;
                }


                String[] textParts = betText.Split(':');
                int currentBet = Int32.Parse(textParts[1]);
                if (currentBet == 0)
                {
                    if (betStreak > 0)
                    {
                        checkIfWon();
                        updateLabels();
                    }

                    if (stopNext == true && betStreak == 0)
                    {
                        timer.Stop();
                        updateLabels();
                        startButton.Enabled = true;
                        colourCombo.Enabled = true;
                        startAmountTextbox.Enabled = true;
                        stopCheckbox.Checked = false;
                    }
                    else {

                        if (statusText.TextContent.Contains("Rolling in"))
                        {
                            bet();
                            updateLabels();
                        }
                    }

                }


            }));

        }

        public void getName()
        {
            username = usernameElement.TextContent;
            userLabel.Text = "User: " + username;
        }

        public void getCredits()
        {
            string creditsText = creditElement.TextContent;
            string[] creditsSplit = creditsText.Split(':');
            credits = Int32.Parse(creditsSplit[1]);
            creditsLabel.Text = "Credits: " + credits;
        }

        public void setStartCredits()
        {
            startCredits = credits;
            startCreditsLabel.Text = "Credits on start: " + startCredits;
        }

        public void bet()
        {
            int bet = 0;
            if (betStreak == 0)
            {
                bet = Int32.Parse(startAmountTextbox.Text);
            }
            else {
                bet = previousBet * 2;
            }

            betStreak++;
            previousBet = bet;
            textboxElement.Value = bet.ToString();

            if (colourCombo.Text == "red")
            {
                redButton.Click();
            }
            else {
                blackButton.Click();
            }
        }

        private bool checkIfWon()
        {
            string wonColor = getBetResult();
            string selectedColor = colourCombo.Text;

            if (wonColor == selectedColor)
            {
                //We Won
                concurrentWins++;
                concurrentLosses = 0;
                wins++;
                betStreak = 0;
                return true;

            }
            else {
                //We Lost
                concurrentWins = 0;
                concurrentLosses++;
                return false;
            }

        }

        public string getBetResult()
        {
            GeckoElement lastChild = (GeckoElement)resultList.LastChild;
            string color = lastChild.GetAttribute("data-color");
            return color;

        }

        private void updateLabels()
        {
            getCredits();

            winsLabel.Text = "Wins: " + wins;
            concurLossLabel.Text = "Concurrent losses: " + concurrentLosses;
            concurWinLabel.Text = "Concurrent wins: " + concurrentWins;

        }

        private void setStopNext(object sender, System.EventArgs e)
        {
            stopNext = stopCheckbox.Checked;
        }
    }
}
