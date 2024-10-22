/*
 * Created by CapinonMStudio.
 * User: CapinonM
 * Date: 22/10/2024
 * Time: 07:25 a. m.
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace register
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
		
		void BtncalcClick(object sender, EventArgs e)
		{
			calculation();
		}

		string bida;

		void calculation()
		{
			// declaracion de variables
			DateTime birthdate = dtpbirthdate.Value;
			bida = birthdate.ToString();
			bool emp = compempty();
			bool siize;
			//bool

			if(!emp)
			{
				siize = ssize();

				if(siize) rfc_calc();
				else { MessageBox.Show("El nombre, appelido1 o appellido 2 estan mal"); }
			}
				
			else { MessageBox.Show("Ningun campo puede estar vacio"); }
		}

		bool compempty()
		{
			if(txtname.Text == "") return true;
			else if (txtphone.Text == "" ) return true;
			else if (txtape1.Text == "" ) return true;
			else if (txtaddress.Text == "" ) return true;
			else if (txtape2.Text == "" ) return true;
			else return false;
		}

		bool ssize()
		{
			string temp = txtname.Text;
			int size = temp.Length;

			string temp2 = txtape1.Text;
			int size2 = temp.Length;
 
			string temp3 = txtape2.Text;
			int size3 = temp.Length;

			if(size < 2) return false;
			else if(size2 < 2) return false;
			else if(size3 < 2) return false;
			else {return true;}
		}

		void rfc_calc()
		{
			string rfc = "";
			string trash = txtape1.Text;
			rfc += trash.Substring(0,2);
			trash = txtape2.Text;
			rfc += trash.Substring(0,1);
			trash = txtname.Text;
			rfc += trash.Substring(0,1);

			rfc = rfc.ToUpper();
			
			trash = bida;
			rfc += trash.Substring(8,9);
			
			MessageBox.Show(rfc);
		}
	}
}
