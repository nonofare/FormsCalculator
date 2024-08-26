namespace FormsCalculator
{
	public partial class Calculator : Form
	{
		private OperationalNumber mainNumber;
		private OperationalNumber auxiliaryNumber;
		private bool isMianNumberActive;
		private char waitingOperation;

		public Calculator()
		{
			InitializeComponent();

			mainNumber = new OperationalNumber();
			auxiliaryNumber = new OperationalNumber();
			isMianNumberActive = true;
			waitingOperation = '0';

			screenRefresh();
		}

		private void screenRefresh()
		{
			textBox.Clear();

			switch (isMianNumberActive)
			{
				case true:
					textBox.AppendText(mainNumber.getStringValue());
					break;
				case false:
					textBox.AppendText(auxiliaryNumber.getStringValue());
					break;
			}
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.addAtEnd('1');
					break;
				case false:
					auxiliaryNumber.addAtEnd('1');
					break;
			}

			screenRefresh();
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.addAtEnd('2');
					break;
				case false:
					auxiliaryNumber.addAtEnd('2');
					break;
			}

			screenRefresh();
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.addAtEnd('3');
					break;
				case false:
					auxiliaryNumber.addAtEnd('3');
					break;
			}

			screenRefresh();
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.addAtEnd('4');
					break;
				case false:
					auxiliaryNumber.addAtEnd('4');
					break;
			}

			screenRefresh();
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.addAtEnd('5');
					break;
				case false:
					auxiliaryNumber.addAtEnd('5');
					break;
			}

			screenRefresh();
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.addAtEnd('6');
					break;
				case false:
					auxiliaryNumber.addAtEnd('6');
					break;
			}

			screenRefresh();
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.addAtEnd('7');
					break;
				case false:
					auxiliaryNumber.addAtEnd('7');
					break;
			}

			screenRefresh();
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.addAtEnd('8');
					break;
				case false:
					auxiliaryNumber.addAtEnd('8');
					break;
			}

			screenRefresh();
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.addAtEnd('9');
					break;
				case false:
					auxiliaryNumber.addAtEnd('9');
					break;
			}

			screenRefresh();
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.addAtEnd('0');
					break;
				case false:
					auxiliaryNumber.addAtEnd('0');
					break;
			}

			screenRefresh();
		}

		private void btnDot_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.addAtEnd('.');
					break;
				case false:
					auxiliaryNumber.addAtEnd('.');
					break;
			}

			screenRefresh();
		}

		private void btnNegative_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.invert();
					break;
				case false:
					auxiliaryNumber.invert();
					break;
			}

			screenRefresh();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			calculate();

			isMianNumberActive = false;
			waitingOperation = '+';
		}

		private void btnSubstract_Click(object sender, EventArgs e)
		{
			calculate();

			isMianNumberActive = false;
			waitingOperation = '-';
		}

		private void btnMultiply_Click(object sender, EventArgs e)
		{
			calculate();

			isMianNumberActive = false;
			waitingOperation = '*';
		}

		private void btnDivide_CLick(object sender, EventArgs e)
		{
			calculate();

			isMianNumberActive = false;
			waitingOperation = '/';
		}

		private void btnSqrt_Click(object sender, EventArgs e)
		{
			calculate();

			isMianNumberActive = false;
			waitingOperation = 's';

			calculate();
		}

		private void btnPowTwo_Click(object sender, EventArgs e)
		{
			calculate();

			isMianNumberActive = false;
			waitingOperation = '^';

			calculate();
		}

		private void btnFraction_Click(object sender, EventArgs e)
		{
			calculate();

			isMianNumberActive = false;
			waitingOperation = 'f';

			calculate();
		}

		private void btnPercent_Click(object sender, EventArgs e)
		{
			calculate();

			isMianNumberActive = false;
			waitingOperation = '%';
		}

		private void btnEquals_Click(object sender, EventArgs e)
		{
			calculate();
		}

		private void btnC_Click(object sender, EventArgs e)
		{
			mainNumber.clear();
			auxiliaryNumber.clear();
			isMianNumberActive = true;
			waitingOperation = '0';

			screenRefresh();
		}

		private void btnCE_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.clear();
					break;
				case false:
					auxiliaryNumber.clear();
					break;
			}

			screenRefresh();
		}

		private void btnBackspace_Click(object sender, EventArgs e)
		{
			switch (isMianNumberActive)
			{
				case true:
					mainNumber.clearAtEnd();
					break;
				case false:
					auxiliaryNumber.clearAtEnd();
					break;
			}

			screenRefresh();
		}

		private void calculate()
		{
			if (waitingOperation != '0')
			{
				switch (waitingOperation)
				{
					case '+':
						mainNumber.setDoubleValue(mainNumber.getDoubleValue() + auxiliaryNumber.getDoubleValue());
						break;
					case '-':
						mainNumber.setDoubleValue(mainNumber.getDoubleValue() - auxiliaryNumber.getDoubleValue());
						break;
					case '*':
						mainNumber.setDoubleValue(mainNumber.getDoubleValue() * auxiliaryNumber.getDoubleValue());
						break;
					case '/':
						if (auxiliaryNumber.getDoubleValue() != 0)
						{
							mainNumber.setDoubleValue(mainNumber.getDoubleValue() / auxiliaryNumber.getDoubleValue());
						}
						break;
					case 's':
						mainNumber.setDoubleValue(Math.Sqrt(mainNumber.getDoubleValue()));
						break;
					case '^':
						mainNumber.setDoubleValue(Math.Pow(mainNumber.getDoubleValue(), 2));
						break;
					case 'f':
						mainNumber.setDoubleValue(1/ mainNumber.getDoubleValue());
						break;
					case '%':
						mainNumber.setDoubleValue(mainNumber.getDoubleValue() * (auxiliaryNumber.getDoubleValue() * 0.01));
						break;
					default:
						break;
				}

				auxiliaryNumber.clear();
				isMianNumberActive = true;
				waitingOperation = '0';
			}

			screenRefresh();
		}
	}
}
