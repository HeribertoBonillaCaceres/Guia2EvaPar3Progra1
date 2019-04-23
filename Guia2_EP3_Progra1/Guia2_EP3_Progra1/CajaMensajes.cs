/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 22/04/2019
 * Time: 06:28 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guia2_EP3_Progra1
{
	/// <summary>
	/// Description of CajaMensajes.
	/// </summary>
	public partial class CajaMensajes : Form
	{
		public CajaMensajes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private MessageBoxButtons tipoDeBoton = MessageBoxButtons.OK;
		private MessageBoxIcon tipoDeIcono = MessageBoxIcon.Error;
		
		private void tipoDeBoton_CheckedChanged(object sender,EventArgs e)
		{
			if (sender == radioButton1)
				tipoDeBoton = MessageBoxButtons.OK;
			else if (sender == radioButton2)
				tipoDeBoton = MessageBoxButtons.OKCancel;
			else if (sender == radioButton3)
				tipoDeBoton = MessageBoxButtons.YesNo;
			else if (sender == radioButton4)
				tipoDeBoton = MessageBoxButtons.YesNoCancel;
			else if (sender == radioButton5)
				tipoDeBoton = MessageBoxButtons.RetryCancel;
			else
				tipoDeBoton = MessageBoxButtons.AbortRetryIgnore;
		}
		
		private void tipoDeIcono_CheckedChanged(object sender, EventArgs e)
		{
			if (sender == radioButton7)
				tipoDeIcono = MessageBoxIcon.Information;
			else if (sender == radioButton8)
				tipoDeIcono = MessageBoxIcon.Exclamation;
			else if (sender == radioButton9)
				tipoDeIcono = MessageBoxIcon.Question;
			else
				tipoDeIcono = MessageBoxIcon.Error;
		}
		
		private void Button1Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Mensaje a desplegar","Titulo de la Ventana",tipoDeBoton,tipoDeIcono);
			
			switch (result)
			{
				case DialogResult.OK:
					label2.Text = "Selecciono OK";
					break;
				case DialogResult.Cancel:
					label2.Text = "Selecciono Cancel";
					break;
				case DialogResult.Yes:
					label2.Text = "Selecciono Yes";
					break;
				case DialogResult.No:
					label2.Text = "Selecciono No";
					break;
				case DialogResult.Ignore:
					label2.Text = "Selecciono Ignore";
					break;
				case DialogResult.Abort:
					label2.Text = "Selecciono Abort";
					break;
				case DialogResult.Retry:
					label2.Text = "Selecciono Retry";
					break;
				
			}
		}
	}
}
