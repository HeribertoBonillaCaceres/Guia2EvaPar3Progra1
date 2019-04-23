/*
 * Created by SharpDevelop.
 * User: Heriberto
 * Date: 22/04/2019
 * Time: 06:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Guia2_EP3_Progra1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ejerciciosGuia2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cajasDeMensajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.visorImagenesEnlacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.convertidorTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.ejerciciosGuia2ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(391, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ejerciciosGuia2ToolStripMenuItem
			// 
			this.ejerciciosGuia2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cajasDeMensajesToolStripMenuItem,
									this.visorImagenesEnlacesToolStripMenuItem,
									this.convertidorTemperaturaToolStripMenuItem,
									this.salirToolStripMenuItem});
			this.ejerciciosGuia2ToolStripMenuItem.Name = "ejerciciosGuia2ToolStripMenuItem";
			this.ejerciciosGuia2ToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
			this.ejerciciosGuia2ToolStripMenuItem.Text = "EjerciciosGuia2";
			// 
			// cajasDeMensajesToolStripMenuItem
			// 
			this.cajasDeMensajesToolStripMenuItem.Name = "cajasDeMensajesToolStripMenuItem";
			this.cajasDeMensajesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.cajasDeMensajesToolStripMenuItem.Text = "CajasDeMensajes";
			this.cajasDeMensajesToolStripMenuItem.Click += new System.EventHandler(this.CajasDeMensajesToolStripMenuItemClick);
			// 
			// visorImagenesEnlacesToolStripMenuItem
			// 
			this.visorImagenesEnlacesToolStripMenuItem.Name = "visorImagenesEnlacesToolStripMenuItem";
			this.visorImagenesEnlacesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.visorImagenesEnlacesToolStripMenuItem.Text = "VisorImagenesEnlaces";
			this.visorImagenesEnlacesToolStripMenuItem.Click += new System.EventHandler(this.VisorImagenesEnlacesToolStripMenuItemClick);
			// 
			// convertidorTemperaturaToolStripMenuItem
			// 
			this.convertidorTemperaturaToolStripMenuItem.Name = "convertidorTemperaturaToolStripMenuItem";
			this.convertidorTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.convertidorTemperaturaToolStripMenuItem.Text = "ConvertidorTemperatura";
			this.convertidorTemperaturaToolStripMenuItem.Click += new System.EventHandler(this.ConvertidorTemperaturaToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 261);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Guia2_EP3_Progra1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem convertidorTemperaturaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem visorImagenesEnlacesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cajasDeMensajesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejerciciosGuia2ToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
