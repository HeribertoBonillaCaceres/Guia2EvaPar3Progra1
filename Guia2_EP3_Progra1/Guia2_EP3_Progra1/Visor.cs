/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 22/04/2019
 * Time: 08:57 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Guia2_EP3_Progra1
{
	/// <summary>
	/// Description of Visor.
	/// </summary>
	public partial class Visor : Form
	{
		public Visor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();			
		}
		
		private void Button1Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
				this.Text = string.Concat("Visor de Imagenes(" + openFileDialog1.FileName + ")");
			}
		}
		
		private void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel1.LinkVisited = true;			
			System.Diagnostics.Process.Start("Calc");
		}
		
		private void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel2.LinkVisited = true;			
			System.Diagnostics.Process.Start("IExplore","http://www.utec.edu.sv");		
		}
		
		private void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			linkLabel3.LinkVisited = true;			
			System.Diagnostics.Process.Start("C:\\");			
		}
	}
}
