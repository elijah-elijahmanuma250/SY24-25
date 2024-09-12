namespace minesweeper
{
    public partial class Form1 : Form
    {
        Button[] btngrid=new Button[100];
        public Form1()
        {
            InitializeComponent();
           /* btngrid[0] = button1;
            btngrid[1] = button2;
            btngrid[2] = button3;
            btngrid[3] = button4;
            btngrid[4] = button5;
            btngrid[5] = button6;
            btngrid[6] = button7;
            btngrid[7] = button8;
            btngrid[8] = button9;
            btngrid[9] = button10; */
            for (int i = 0; i < 100; i++)
            {
                btngrid[i] = (Button)Controls["button" + (i+1)];
            }
            for(int i = 0; i<100; i++)
            {
                btngrid[i].BackColor = Color.Green;
            }
            
        }

     
    }
}
