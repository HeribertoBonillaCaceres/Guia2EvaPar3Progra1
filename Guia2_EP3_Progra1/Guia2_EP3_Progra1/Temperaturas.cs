/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 22/04/2019
 * Time: 06:30 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guia2_EP3_Progra1
{
	/// <summary>
	/// Description of Temperaturas.
	/// </summary>
	public partial class Temperaturas : Form
	{
		public Temperaturas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		private void Button1Click(object sender, EventArgs e)
		{
			double gfarenheit, ct1;

			ct1 = Convert.ToDouble(textBox1.Text);
			gfarenheit = ct1*1.8 + 32;
			textBox2.Text = gfarenheit.ToString();
		}
		
		private void Button2Click(object sender, EventArgs e)
		{
			double gcentigrados, ct1;

			ct1 = Convert.ToDouble(textBox1.Text);
			gcentigrados = (ct1 - 32)/1.8;
			textBox2.Text = gcentigrados.ToString();
		}
		
		private void Button3Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
		}
		
		private void Button4Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
