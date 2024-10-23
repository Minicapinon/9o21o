/*
 * Created by SharpDevelop.
 * User: cc2-pc06
 * Date: 23/10/2024
 * Time: 07:52 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace register
{
	partial class wawa
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wawa));
			this.lblname = new System.Windows.Forms.Label();
			this.lblrfc = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblname
			// 
			this.lblname.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblname.Location = new System.Drawing.Point(15, 10);
			this.lblname.MaximumSize = new System.Drawing.Size(260, 23);
			this.lblname.MinimumSize = new System.Drawing.Size(260, 23);
			this.lblname.Name = "lblname";
			this.lblname.Size = new System.Drawing.Size(260, 23);
			this.lblname.TabIndex = 0;
			this.lblname.Text = "__";
			// 
			// lblrfc
			// 
			this.lblrfc.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblrfc.Location = new System.Drawing.Point(15, 80);
			this.lblrfc.MaximumSize = new System.Drawing.Size(260, 23);
			this.lblrfc.MinimumSize = new System.Drawing.Size(260, 23);
			this.lblrfc.Name = "lblrfc";
			this.lblrfc.Size = new System.Drawing.Size(260, 23);
			this.lblrfc.TabIndex = 1;
			this.lblrfc.Text = "__";
			// 
			// wawa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.ClientSize = new System.Drawing.Size(284, 111);
			this.Controls.Add(this.lblrfc);
			this.Controls.Add(this.lblname);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(300, 150);
			this.MinimumSize = new System.Drawing.Size(300, 150);
			this.Name = "wawa";
			this.Text = "Resultado";
			this.Load += new System.EventHandler(this.WawaLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblrfc;
		private System.Windows.Forms.Label lblname;
	}
}
