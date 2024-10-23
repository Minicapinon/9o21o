/*
 * Created by SharpDevelop.
 * User: cc2-pc06
 * Date: 22/10/2024
 * Time: 07:25 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace register
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lbltittle = new System.Windows.Forms.Label();
			this.txtname = new System.Windows.Forms.TextBox();
			this.txtape1 = new System.Windows.Forms.TextBox();
			this.txtape2 = new System.Windows.Forms.TextBox();
			this.lblname = new System.Windows.Forms.Label();
			this.lblape1 = new System.Windows.Forms.Label();
			this.lblape2 = new System.Windows.Forms.Label();
			this.lblpho = new System.Windows.Forms.Label();
			this.lbladdr = new System.Windows.Forms.Label();
			this.cmbsemsel = new System.Windows.Forms.ComboBox();
			this.lblsemes = new System.Windows.Forms.Label();
			this.txtphone = new System.Windows.Forms.TextBox();
			this.txtaddress = new System.Windows.Forms.TextBox();
			this.dtpbirthdate = new System.Windows.Forms.DateTimePicker();
			this.lblbithdate = new System.Windows.Forms.Label();
			this.btncalc = new System.Windows.Forms.Button();
			this.btnab = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbltittle
			// 
			this.lbltittle.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbltittle.Location = new System.Drawing.Point(130, 45);
			this.lbltittle.MaximumSize = new System.Drawing.Size(255, 35);
			this.lbltittle.MinimumSize = new System.Drawing.Size(255, 35);
			this.lbltittle.Name = "lbltittle";
			this.lbltittle.Size = new System.Drawing.Size(255, 35);
			this.lbltittle.TabIndex = 0;
			this.lbltittle.Text = "Registro de RFC";
			// 
			// txtname
			// 
			this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtname.Location = new System.Drawing.Point(50, 125);
			this.txtname.MaximumSize = new System.Drawing.Size(200, 20);
			this.txtname.MinimumSize = new System.Drawing.Size(200, 20);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(200, 20);
			this.txtname.TabIndex = 1;
			// 
			// txtape1
			// 
			this.txtape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtape1.Location = new System.Drawing.Point(50, 185);
			this.txtape1.MaximumSize = new System.Drawing.Size(200, 20);
			this.txtape1.MinimumSize = new System.Drawing.Size(200, 20);
			this.txtape1.Name = "txtape1";
			this.txtape1.Size = new System.Drawing.Size(200, 20);
			this.txtape1.TabIndex = 2;
			// 
			// txtape2
			// 
			this.txtape2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtape2.Location = new System.Drawing.Point(50, 250);
			this.txtape2.MaximumSize = new System.Drawing.Size(200, 20);
			this.txtape2.MinimumSize = new System.Drawing.Size(200, 20);
			this.txtape2.Name = "txtape2";
			this.txtape2.Size = new System.Drawing.Size(200, 20);
			this.txtape2.TabIndex = 3;
			// 
			// lblname
			// 
			this.lblname.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblname.Location = new System.Drawing.Point(50, 100);
			this.lblname.MaximumSize = new System.Drawing.Size(100, 20);
			this.lblname.MinimumSize = new System.Drawing.Size(100, 20);
			this.lblname.Name = "lblname";
			this.lblname.Size = new System.Drawing.Size(100, 20);
			this.lblname.TabIndex = 4;
			this.lblname.Text = "Nombre:";
			// 
			// lblape1
			// 
			this.lblape1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblape1.Location = new System.Drawing.Point(50, 160);
			this.lblape1.MaximumSize = new System.Drawing.Size(100, 20);
			this.lblape1.MinimumSize = new System.Drawing.Size(100, 20);
			this.lblape1.Name = "lblape1";
			this.lblape1.Size = new System.Drawing.Size(100, 20);
			this.lblape1.TabIndex = 5;
			this.lblape1.Text = "Apellido 1:";
			// 
			// lblape2
			// 
			this.lblape2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblape2.Location = new System.Drawing.Point(50, 230);
			this.lblape2.MaximumSize = new System.Drawing.Size(100, 20);
			this.lblape2.MinimumSize = new System.Drawing.Size(100, 20);
			this.lblape2.Name = "lblape2";
			this.lblape2.Size = new System.Drawing.Size(100, 20);
			this.lblape2.TabIndex = 6;
			this.lblape2.Text = "Apellido 2:";
			// 
			// lblpho
			// 
			this.lblpho.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblpho.Location = new System.Drawing.Point(260, 100);
			this.lblpho.MaximumSize = new System.Drawing.Size(100, 20);
			this.lblpho.MinimumSize = new System.Drawing.Size(100, 20);
			this.lblpho.Name = "lblpho";
			this.lblpho.Size = new System.Drawing.Size(100, 20);
			this.lblpho.TabIndex = 7;
			this.lblpho.Text = "Telefono:";
			// 
			// lbladdr
			// 
			this.lbladdr.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbladdr.Location = new System.Drawing.Point(260, 160);
			this.lbladdr.MaximumSize = new System.Drawing.Size(100, 20);
			this.lbladdr.MinimumSize = new System.Drawing.Size(100, 20);
			this.lbladdr.Name = "lbladdr";
			this.lbladdr.Size = new System.Drawing.Size(100, 20);
			this.lbladdr.TabIndex = 8;
			this.lbladdr.Text = "Direccion:";
			// 
			// cmbsemsel
			// 
			this.cmbsemsel.FormattingEnabled = true;
			this.cmbsemsel.Items.AddRange(new object[] {
									"Primero",
									"Segundo",
									"Tercero",
									"Cuarto",
									"Quinto",
									"Sexto"});
			this.cmbsemsel.Location = new System.Drawing.Point(260, 250);
			this.cmbsemsel.MaximumSize = new System.Drawing.Size(200, 0);
			this.cmbsemsel.MinimumSize = new System.Drawing.Size(200, 0);
			this.cmbsemsel.Name = "cmbsemsel";
			this.cmbsemsel.Size = new System.Drawing.Size(200, 21);
			this.cmbsemsel.TabIndex = 9;
			// 
			// lblsemes
			// 
			this.lblsemes.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsemes.Location = new System.Drawing.Point(260, 230);
			this.lblsemes.MaximumSize = new System.Drawing.Size(100, 20);
			this.lblsemes.MinimumSize = new System.Drawing.Size(100, 20);
			this.lblsemes.Name = "lblsemes";
			this.lblsemes.Size = new System.Drawing.Size(100, 20);
			this.lblsemes.TabIndex = 10;
			this.lblsemes.Text = "Semestre:";
			// 
			// txtphone
			// 
			this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtphone.Location = new System.Drawing.Point(260, 125);
			this.txtphone.MaximumSize = new System.Drawing.Size(200, 20);
			this.txtphone.MinimumSize = new System.Drawing.Size(200, 20);
			this.txtphone.Name = "txtphone";
			this.txtphone.Size = new System.Drawing.Size(200, 20);
			this.txtphone.TabIndex = 11;
			// 
			// txtaddress
			// 
			this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtaddress.Location = new System.Drawing.Point(260, 185);
			this.txtaddress.MaximumSize = new System.Drawing.Size(200, 20);
			this.txtaddress.MinimumSize = new System.Drawing.Size(200, 20);
			this.txtaddress.Name = "txtaddress";
			this.txtaddress.Size = new System.Drawing.Size(200, 20);
			this.txtaddress.TabIndex = 12;
			// 
			// dtpbirthdate
			// 
			this.dtpbirthdate.Location = new System.Drawing.Point(130, 310);
			this.dtpbirthdate.MaximumSize = new System.Drawing.Size(255, 20);
			this.dtpbirthdate.MinimumSize = new System.Drawing.Size(255, 20);
			this.dtpbirthdate.Name = "dtpbirthdate";
			this.dtpbirthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtpbirthdate.Size = new System.Drawing.Size(255, 20);
			this.dtpbirthdate.TabIndex = 15;
			// 
			// lblbithdate
			// 
			this.lblbithdate.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblbithdate.Location = new System.Drawing.Point(130, 287);
			this.lblbithdate.MaximumSize = new System.Drawing.Size(255, 20);
			this.lblbithdate.MinimumSize = new System.Drawing.Size(255, 20);
			this.lblbithdate.Name = "lblbithdate";
			this.lblbithdate.Size = new System.Drawing.Size(255, 20);
			this.lblbithdate.TabIndex = 16;
			this.lblbithdate.Text = "Fecha de naciemto";
			this.lblbithdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btncalc
			// 
			this.btncalc.Location = new System.Drawing.Point(220, 400);
			this.btncalc.Name = "btncalc";
			this.btncalc.Size = new System.Drawing.Size(75, 23);
			this.btncalc.TabIndex = 17;
			this.btncalc.Text = "Calcular";
			this.btncalc.UseVisualStyleBackColor = true;
			this.btncalc.Click += new System.EventHandler(this.BtncalcClick);
			// 
			// btnab
			// 
			this.btnab.Location = new System.Drawing.Point(12, 426);
			this.btnab.Name = "btnab";
			this.btnab.Size = new System.Drawing.Size(75, 23);
			this.btnab.TabIndex = 18;
			this.btnab.Text = "Acerca de";
			this.btnab.UseVisualStyleBackColor = true;
			this.btnab.Click += new System.EventHandler(this.BtnabClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.ClientSize = new System.Drawing.Size(509, 461);
			this.Controls.Add(this.btnab);
			this.Controls.Add(this.btncalc);
			this.Controls.Add(this.lblbithdate);
			this.Controls.Add(this.dtpbirthdate);
			this.Controls.Add(this.txtaddress);
			this.Controls.Add(this.txtphone);
			this.Controls.Add(this.lblsemes);
			this.Controls.Add(this.cmbsemsel);
			this.Controls.Add(this.lbladdr);
			this.Controls.Add(this.lblpho);
			this.Controls.Add(this.lblape2);
			this.Controls.Add(this.lblape1);
			this.Controls.Add(this.lblname);
			this.Controls.Add(this.txtape2);
			this.Controls.Add(this.txtape1);
			this.Controls.Add(this.txtname);
			this.Controls.Add(this.lbltittle);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(525, 500);
			this.MinimumSize = new System.Drawing.Size(525, 500);
			this.Name = "MainForm";
			this.Text = "register";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnab;
		private System.Windows.Forms.Button btncalc;
		private System.Windows.Forms.Label lblbithdate;
		private System.Windows.Forms.DateTimePicker dtpbirthdate;
		private System.Windows.Forms.TextBox txtaddress;
		private System.Windows.Forms.TextBox txtphone;
		private System.Windows.Forms.Label lblsemes;
		private System.Windows.Forms.ComboBox cmbsemsel;
		private System.Windows.Forms.Label lbladdr;
		private System.Windows.Forms.Label lblpho;
		private System.Windows.Forms.Label lblape2;
		private System.Windows.Forms.Label lblape1;
		private System.Windows.Forms.Label lblname;
		private System.Windows.Forms.TextBox txtape2;
		private System.Windows.Forms.TextBox txtape1;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.Label lbltittle;
	}
}
