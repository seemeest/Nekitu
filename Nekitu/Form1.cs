namespace Nekitu
{
    public partial class Form1 : Form
    {

        List<int> list = new List<int>();
        int ListCount;
        int MaxId;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Ввести очередной\nЭллемент масив";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            if (textBox1.Text !="")
            {
                list.Add(Convert.ToInt32(textBox1.Text));
                listBox1.Items.Add(list[ListCount]);
                ListCount++;
            }
            else
            {
                MessageBox.Show("Поле пустое");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MaxId=list.FindIndex(x => x == list.Max()) ;//через ламбада вырожение получаю индекс максимальеого числа

            for(int i = 0; i < ListCount; i++)
            {
                if (i <MaxId)
                {
                    listBox2.Items.Add(list[i] * list[MaxId]);
                   
                }
                else
                {
                    listBox2.Items.Add(list[i]);
                }
            }
        }
    }
}