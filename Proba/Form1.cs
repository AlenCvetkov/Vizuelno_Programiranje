using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba
{
    public partial class Form1 : Form
    {
        public int chances { get; set; }

        public int hangmanStage { get; set; }
        public int leftchances { get; set; }
        string[] targetWord = {
            "ALBANIA", "ANDORRA", "ARMENIA", "AUSTRIA", "AZERBAIJAN",
            "BELARUS", "BELGIUM", "BULGARIA", "CROATIA",
            "CYPRUS", "CZECHIA", "DENMARK", "ESTONIA", "FINLAND",
            "FRANCE", "GEORGIA", "GERMANY", "GREECE", "HUNGARY",
            "ICELAND", "IRELAND", "ITALY", "KAZAKHSTAN", "KOSOVO",
            "LATVIA", "LIECHTENSTEIN", "LITHUANIA", "LUXEMBOURG", "MALTA",
            "MOLDOVA", "MONACO", "MONTENEGRO", "NETHERLANDS", "MACEDONIA",
            "NORWAY", "POLAND", "PORTUGAL", "ROMANIA", "RUSSIA",
            "SAN MARINO", "SERBIA", "SLOVAKIA", "SLOVENIA", "SPAIN",
            "SWEDEN", "SWITZERLAND", "TURKEY", "UKRAINE" };

        char[] currentState;
        string chosenWord;
        public Form1()
        {
            InitializeComponent();
            this.chances = 0;
            this.leftchances = 6;
            this.hangmanStage = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            chosenWord = targetWord[rnd.Next(targetWord.Length)].ToUpper();
            currentState = new string('_', chosenWord.Length).ToCharArray();
            UpdateDisplay();

        }
        private void DrawHangman(Graphics g)
        {
            Pen pen = new Pen(Color.Brown, 3);

            
            g.DrawLine(pen, 400, 400, 500, 400); 
            g.DrawLine(pen, 450, 400, 450, 100); 
            g.DrawLine(pen, 450, 100, 350, 100); 
            g.DrawLine(pen, 350, 100, 350, 130); 

            
            if (hangmanStage >= 1) g.DrawEllipse(pen, 330, 130, 40, 40);
            if (hangmanStage >= 2) g.DrawLine(pen, 350, 170, 350, 250); 
            if (hangmanStage >= 3) g.DrawLine(pen, 350, 190, 320, 220); 
            if (hangmanStage >= 4) g.DrawLine(pen, 350, 190, 380, 220); 
            if (hangmanStage >= 5) g.DrawLine(pen, 350, 250, 320, 300); 
            if (hangmanStage >= 6) g.DrawLine(pen, 350, 250, 380, 300); 


            
            if (hangmanStage >= 6)
            {
                g.DrawArc(pen, 340, 150, 20, 10, 0, 180); 
                g.DrawLine(pen, 340, 140, 345, 145); 
                g.DrawLine(pen, 360, 140, 355, 145); 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;

        }

        private void btnA_MouseCaptureChanged(object sender, EventArgs e)
        {

        }
        private void UpdateDisplay()
        {
            tbWord.Text = new string(currentState);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            GuessLetter('A', btnA);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            GuessLetter('B', btnB);

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            GuessLetter('C', btnC);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuessLetter('D', btnD);
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            GuessLetter('E', btnE);
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            GuessLetter('F', btnF);
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            GuessLetter('G', btnG);
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            GuessLetter('H', btnH);
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            GuessLetter('I', btnI);
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            GuessLetter('J', btnJ);
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            GuessLetter('K', btnK);
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            GuessLetter('L', btnL);
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            GuessLetter('M', btnM);
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            GuessLetter('N', btnN);
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            GuessLetter('O', btnO);
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            GuessLetter('P', btnP);
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            GuessLetter('Q', btnQ);
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            GuessLetter('R', btnR);
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            GuessLetter('S', btnS);
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            GuessLetter('T', btnT);
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            GuessLetter('U', btnU);
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            GuessLetter('V', btnV);
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            GuessLetter('W', btnW);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            GuessLetter('X', btnX);
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            GuessLetter('Y', btnY);
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            
           GuessLetter('Z', btnZ);
        }
        private void GuessLetter(char guessed, Button btn)
        {
            bool found = false;

            for (int i = 0; i < chosenWord.Length; i++)
            {
                if (chosenWord[i] == guessed)
                {
                    found = true;
                    currentState[i] = guessed;
                }
            }

            if (found)
                btn.BackColor = Color.FromArgb(128, 0, 255, 0);
            else
            {
                btn.BackColor = Color.FromArgb(128, 255, 0, 0);
                hangmanStage++;
                leftchances--;
                this.Invalidate();
            }

            if(currentState.All(c => c != '_'))
            {
                MessageBox.Show("Браво! Зборот беше: " + chosenWord);
                Close();
            }
                if (leftchances <= 0)
            {
                MessageBox.Show("Играта заврши! Зборот беше: " + chosenWord);
                Close();
            }
                UpdateDisplay();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawHangman(e.Graphics);
        }
    }
}
