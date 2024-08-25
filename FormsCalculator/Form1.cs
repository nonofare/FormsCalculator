namespace FormsCalculator
{
	public partial class Calculator : Form
	{
		private List<OperationalNumber> numbers;
		private int currentNumberIndex;
		private List<char> waitingOperations;

		public Calculator()
		{
			InitializeComponent();

			numbers = new List<OperationalNumber>();
			numbers.Add(new OperationalNumber());
			currentNumberIndex = 0;

			waitingOperations = new List<char>();
		}

		private void loop()
		{
			textBox.Clear();
			textBox.AppendText(numbers[currentNumberIndex].getStringValue());
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].addAtEnd('1');
			loop();
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].addAtEnd('2');
			loop();
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].addAtEnd('3');
			loop();
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].addAtEnd('4');
			loop();
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].addAtEnd('5');
			loop();
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].addAtEnd('6');
			loop();
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].addAtEnd('7');
			loop();
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].addAtEnd('8');
			loop();
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].addAtEnd('9');
			loop();
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].addAtEnd('0');
			loop();
		}

		private void btnNegative_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].invert();
			loop();
		}

		private void btnDot_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].addAtEnd('.');
			loop();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			textBox.Clear();
			textBox.AppendText("+");

			numbers.Add(new OperationalNumber());
			currentNumberIndex++;

			waitingOperations.Add('+');
		}

		private void btnSubstract_Click(object sender, EventArgs e)
		{
			textBox.Clear();
			textBox.AppendText("-");

			numbers.Add(new OperationalNumber());
			currentNumberIndex++;

			waitingOperations.Add('-');
		}

		private void btnMultiply_Click(object sender, EventArgs e)
		{
			textBox.Clear();
			textBox.AppendText("X");

			numbers.Add(new OperationalNumber());
			currentNumberIndex++;

			waitingOperations.Add('*');
		}

		private void btnDivide_CLick(object sender, EventArgs e)
		{
			textBox.Clear();
			textBox.AppendText("/");

			numbers.Add(new OperationalNumber());
			currentNumberIndex++;

			waitingOperations.Add('/');
		}

		private void btnSqrt_Click(object sender, EventArgs e)
		{
			textBox.Clear();
			textBox.AppendText("sqrt");

			numbers.Add(new OperationalNumber());
			currentNumberIndex++;

			waitingOperations.Add('s');
		}

		private void btnPowTwo_Click(object sender, EventArgs e)
		{
			textBox.Clear();
			textBox.AppendText("^2");

			numbers.Add(new OperationalNumber());
			currentNumberIndex++;

			waitingOperations.Add('p');
		}

		private void btnEquals_Click(object sender, EventArgs e)
		{
			textBox.Clear();

			double result = numbers[0].getDoubleValue();

			if (numbers.Count > 1)
			{
				for (int i = 0; i < waitingOperations.Count; i++)
				{
					switch (waitingOperations[i])
					{
						case '+':
							result += numbers[i + 1].getDoubleValue();
							break;
						case '-':
							result -= numbers[i + 1].getDoubleValue();
							break;
						case '*':
							result *= numbers[i + 1].getDoubleValue();
							break;
						case '/':
							result /= numbers[i + 1].getDoubleValue();
							break;
						case 's':
							result = Math.Sqrt(numbers[i].getDoubleValue());
							break;
						case 'p':
							result = Math.Pow(numbers[i].getDoubleValue(), 2);
							break;
					}
				}

				textBox.AppendText(result.ToString());
			}
		}

		private void btnC_Click(object sender, EventArgs e)
		{
			numbers.Clear();
			numbers.Add(new OperationalNumber());
			currentNumberIndex = 0;

			loop();
		}

		private void btnCE_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].clear();
			loop();
		}

		private void btnBackspace_Click(object sender, EventArgs e)
		{
			numbers[currentNumberIndex].clearAtEnd();
		}
	}
}
