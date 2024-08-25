namespace FormsCalculator
{
	public partial class Form1 : Form
	{
		private List<OperationalNumber> numbers;
		private int currentNumberIndex;

		public Form1()
		{
			InitializeComponent();
			numbers = new List<OperationalNumber>();
			numbers.Add(new OperationalNumber());
			currentNumberIndex = 0;
		}

		private void loop()
		{
			textBox.AppendText(numbers[currentNumberIndex].getStringValue());
		}

		private void btn1Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].add('1');
			loop();
		}

		private void btn2Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].add('2');
			loop();
		}

		private void btn3Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].add('3');
			loop();
		}

		private void btn4Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].add('4');
			loop();
		}

		private void btn5Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].add('5');
			loop();
		}

		private void btn6Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].add('6');
			loop();
		}

		private void btn7Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].add('7');
			loop();
		}

		private void btn8Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].add('8');
			loop();
		}

		private void btn9Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].add('9');
			loop();
		}

		private void btnNegativeClick(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].invert();
			loop();
		}

		private void btn0Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].add('0');
			loop();
		}
	}
}
