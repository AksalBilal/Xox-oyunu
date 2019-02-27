using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XoX
{
    public partial class XOX : Form
    {

        bool turn = true; // doğru ise x yanlış ise y dönecek
        int turn_count = 0;
        bool against_computer = false;
        public XOX()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked==false&&radioButton2.Checked==false)
                {
                foreach (Control c in Controls)
                {
                    if (c is Button)
                    {
                        c.Enabled = false;
                    }
                }
            }
            //setPlayerDefaultsToolStripMenuItem.PerformClick();
            p1.Text = "";
            p2.Text = "";
        }
        
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {


            if((p1.Text=="player 1")||(p2.Text=="player 2"))
            {
                MessageBox.Show("Test");
            }
            else
            {
                Button b = (Button)sender;
                if (turn)
                    b.Text = "X";
               
                else
                    b.Text = "O";
                

                turn = !turn;
                b.Enabled = false;
                turn_count++;

                label2.Focus();
               

                if (p2.Text!="computer"&&turn_count%2==1)
                {
                    timer2.Start();
                   
                    timer1.Stop();
                    
                }
                if (p2.Text != "computer" && turn_count % 2 == 0)
                {
                    timer1.Start();
                    timer2.Stop();
                }
                checkForWinner();
            }
            //Bilgisayara karşı oynayıp oynamadığını kontrol et ve eğer sırası geldiğinde

            if((!turn)&&(against_computer))
            {
                computer_make_move();
            }
            
        }

        private void computer_make_move()
        {
            //priority 1:  get tick tac toe
            //priority 2:  block x tic tac toe
            //priority 3:  go for corner space
            //priority 4:  pick open space

            Button move = null;

            //look for tic tac toe opportunities
            move = look_for_win_or_block("O"); //look for win
            if (move == null)
            {
                move = look_for_win_or_block("X"); //look for block
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }//end if
                }//end if
            }//end if
            if (turn_count<9)
            {
                move.PerformClick();
            }
            
        }

        private Button look_for_open_space()
        {
            Console.WriteLine("Looking for open space");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }//end if
            }//end if

            return null;
        }

        private Button look_for_corner()
        {
            Console.WriteLine("Looking for corner");
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                if (C3.Text == "")
                    return C3;
                if (C1.Text == "")
                    return C1;
            }

            if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C1.Text == "")
                    return C1;
            }

            if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                if (A3.Text == "")
                    return A3;
                if (C3.Text == "")
                    return C3;
            }

            if (A1.Text == "")
                return A1;
            if (A3.Text == "")
                return A3;
            if (C1.Text == "")
                return C1;
            if (C3.Text == "")
                return C3;

            return null;


        }

        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("Looking for win or block:  " + mark);
            //HORIZONTAL TESTS
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //VERTICAL TESTS
            if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //DIAGONAL TESTS
            if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }
            
        private void checkForWinner()//kananan için kotrol et
        {
            bool there_is_a_winner = false;

            //yatayda kontrol
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text)&&(!A1.Enabled))
                there_is_a_winner = true; 
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //dikeyde kontrol
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            //çaprazda kontrol
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                
                disableButtons();
                String winner = "";
                if (turn)
                {
                    winner = p2.Text;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = p1.Text;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                foreach (Control c in Controls)
                {
                    if (c is Button )
                    {
                        c.Enabled = false;
                    }
                }
               
                timer1.Stop();
                timer2.Stop();
                PlayerBar1.Value = 0;
                PlayerBar2.Value = 0;
                MessageBox.Show(winner+" Kazandı", "KAZANAN PENCERESİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                if(turn_count ==9)
                {
                                        if (PlayerBar1.Value>PlayerBar2.Value)
                    {
                        MessageBox.Show("Hamle Kalmadı "+ "Süreden dolayı " + p2.Text + " kazandı","SÜREYE GÖRE KAZANAN PENCERESİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                      
                    }
                    else if (PlayerBar1.Value<PlayerBar2.Value)
                    {
                        x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                        MessageBox.Show("Hamle Kalmadı " + "Süreden dolayı "+p1.Text+" kazandı", "SÜREYE GÖRE KAZANAN PENCERESİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Hamle Kalmadı " + " Berabere", "SÜREYE GÖRE KAZANAN PENCERESİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    }
                    timer1.Stop();
                    timer2.Stop();
                    PlayerBar1.Value = 0;
                    PlayerBar2.Value = 0;

                }
            }

        }// bitir

        private void disableButtons()
        {
            try
            { 

            foreach(Control c in Controls)
            {
                Button b = (Button)c;
                b.Enabled = false;
            }//end foraech

            }
            catch
            {

            }
        }
        
        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if(turn)
                b.Text = "X";
            else
                b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
                b.Text = "";
        }

        private void puanlarıSıfırlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x_win_count.Text = "0";
            o_win_count.Text = "0";
            draw_count.Text = "0";
            turn = true;
            turn_count = 0;
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch
                {

                }
            }
            
        }

        private void p2_TextChanged(object sender, EventArgs e)
        {
            if (p2.Text.ToUpper() == "COMPUTER")
                against_computer = true;
            else
                against_computer = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label8.Text = label8.Text.Substring(1) + label8.Text.Substring(0, 1);
            if (PlayerBar1.Value == 100)
            {
                o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                timer1.Stop();
                
                foreach (Control c in Controls)
                {
                    if (c is Button)
                    {
                        c.Enabled = false;
                    }
                }
            }
            this.PlayerBar1.Increment(1);
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label9.Text = label9.Text.Substring(1) + label9.Text.Substring(0, 1);
            if (PlayerBar2.Value == 100)
            {
                x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                timer2.Stop();
               
                foreach (Control c in Controls)
                {
                    if (c is Button)
                    {
                        c.Enabled = false;
                    }
                }
            }
            this.PlayerBar2.Increment(1);
         
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            p2.Text = "computer";
            p2.Enabled = false;
            PlayerBar1.Visible = false;
            PlayerBar2.Visible = false;
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("LÜTFEN OYUNCU İSİMLERİNİ GİRİNİZ","BİLGİLENDİRME PENCERESİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            p2.Text = "";
            PlayerBar1.Visible = true;
            PlayerBar2.Visible = true;
            p2.Enabled = true;
            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                }
            }
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            PlayerBar1.Value = 0;
            PlayerBar2.Value = 0;
            timer1.Stop();
            timer2.Stop();

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch
                {

                }
            }//end foraech
        }

        private void XOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                turn = true;
                turn_count = 0;
                PlayerBar1.Value = 0;
                PlayerBar2.Value = 0;
                timer1.Stop();
                timer2.Stop();

                foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                    }
                    catch
                    {

                    }
                }//end foraech
               
            }
            else if (e.KeyCode == Keys.Escape)
            {

                DialogResult secenek = MessageBox.Show("Uygulama Kapanacak.","Uygulama Kapatma", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (secenek== DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else if (e.KeyCode==Keys.R)
            {
                x_win_count.Text = "0";
                o_win_count.Text = "0";
                draw_count.Text = "0";


                turn = true;
                turn_count = 0;



                foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                    }
                    catch
                    {

                    }
                }//end foraech
            }
        }
    }
}
