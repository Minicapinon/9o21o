/*
 * Created by CapinonMStudio.
 * User: CapinonM
 * Date: 22/10/2024
 * Time: 07:25 a. m.
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
		
		// Se usa para detectar el boton
		void BtncalcClick(object sender, EventArgs e)
		{
			calculation();
		}

		// String para la fecha de nacimiento
		string bida;

		// Funcion para calcular y comprobar
		void calculation()
		{
			// declaracion de variables
			DateTime birthdate = dtpbirthdate.Value; // PAra la fecha de nacimiento
			bida = birthdate.ToString(); // Lo convierte a string
			
			bool emp = compempty(); // Bool para saber si no esta vacio
			bool siize; // Bool para saber el tamaño

			if(!emp) // Comprueba si no esta vacio
			{
				siize = ssize(); // Se comprueba el tamano

				if(siize) rfc_calc(); // Si es mayor a 2
				else { MessageBox.Show("El nombre, appelido1 o appellido 2 estan mal"); } // Mensaje si no
			}
			// En caso contrario
			else { MessageBox.Show("Ningun campo puede estar vacio"); } 
		}

		// Funcion para saber si es vacio
		bool compempty()
		{
			if(txtname.Text == "") return true;
			else if (txtphone.Text == "" ) return true;
			else if (txtape1.Text == "" ) return true;
			else if (txtaddress.Text == "" ) return true;
			else if (txtape2.Text == "" ) return true;
			else return false;
		}

		// comprueba el tamaño
		bool ssize()
		{
			string temp = txtname.Text;
			int size = temp.Length;
			if(size < 2) return false;

			temp = txtape1.Text;
			size = temp.Length;
			if(size < 2) return false;
 
			temp = txtape2.Text;
			size = temp.Length;
			if(size < 2) return false;
			
			return true;
		}

		// Para la homoclave
		string homoclave = "0H0";	

		string rfc = "";
		// Calcula el rfc a partir de los datos dados
		void rfc_calc()
		{
			string trash = txtape1.Text;
			rfc += trash.Substring(0,2);
			trash = txtape2.Text;
			rfc += trash.Substring(0,1);
			trash = txtname.Text;
			rfc += trash.Substring(0,1);

			rfc = rfc.ToUpper();
			
			trash = bida;

			rfc += trash[8];
			rfc += trash[9];

			rfc += trash[3];
			rfc += trash[4];

			rfc += trash[0];
			rfc += trash[1];

			rfc += homoclave.ToString();
			
			opennewform();
		}

		void opennewform()
		{
			wawa form = new wawa();
			form.rfc = rfc;
			form.namep = txtname.Text;

			form.FormClosed += (s, args) => { this.Show();};

			form.Show();
			this.Hide();
		}
	}
}
