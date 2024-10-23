/*
 * Created by CapinonMStudio.
 * User: CapinonM
 * Date: 22/10/2024
 * Time: 07:25 a. m.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace register
{
	/// <summary>
	/// Description of wawa.
	/// </summary>
	public partial class wawa : Form
	{
		public wawa()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		public string rfc;
		public string namep;
		
		void WawaLoad(object sender, EventArgs e)
		{
			lblname.Text = namep;
			lblrfc.Text = rfc;			
		}
	}
}
