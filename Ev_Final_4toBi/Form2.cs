using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBi
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void BtnProducto_Click(object sender, EventArgs e)
		{
			int num1 =
			int.Parse(TextVar1.Text);
			int num2 =
			int.Parse(TextVar2.Text);
			int multiplicacion = num1 * num2;
			MessageBox.Show("El resultado de la multiplicacion es" + multiplicacion);

		}

		private void BtnSuma_Click(object sender, EventArgs e)
		{
			int num1 =
			int.Parse(TextVar1.Text);
			int num2 =
			int.Parse(TextVar2.Text);
			int suma = num1 + num2;
			MessageBox.Show("El resultado de la suma es" + suma);

		}

		private void BtnPotencia_Click(object sender, EventArgs e)
		{
			//este es el codigo del expotente
			int num1 =
			int.Parse(TextVar1.Text);
			int num2 =
			int.Parse(TextVar2.Text);
			int num3 = 0;
			int potencia = 1;
			while (num3 != num2)
			{
				potencia = potencia * num1;
				num3++;
			}
			MessageBox.Show("el resultado es" + potencia);
		}

		private void BtnDivision_Click(object sender, EventArgs e)
		{
			float Num1 =
			float.Parse(TextVar1.Text);
			float Num2 =
			float.Parse(TextVar2.Text);

			if (Num2 > 0)
			{
				float division = Num1 / Num2;
				MessageBox.Show("el resultado es" + division);
			}
			else
			{
				MessageBox.Show("La division es indefinida");
		}
	}
	}
}
