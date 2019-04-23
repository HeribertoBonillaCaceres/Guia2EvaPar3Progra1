/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 22/04/2019
 * Time: 06:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Guia2_EP3_Progra1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void ConvertidorTemperaturaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Temperaturas hijo3 = new Temperaturas();
			hijo3.MdiParent = this;
			hijo3.Show();
		}
		
		private void VisorImagenesEnlacesToolStripMenuItemClick(object sender, EventArgs e)
		{
			Visor hijo2 = new Visor();
			hijo2.MdiParent = this;
			hijo2.Show();
		}
		
		private void CajasDeMensajesToolStripMenuItemClick(object sender, EventArgs e)
		{
			CajaMensajes hijo1 = new CajaMensajes();
			hijo1.MdiParent = this;
			hijo1.Show();
		}
	}
}
