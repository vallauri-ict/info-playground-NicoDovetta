using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Function
{
	public partial class Functions : Form
	{
		public static readonly string workingDirectory = Environment.CurrentDirectory;
		public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
		public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\DriverDB.mdf;Integrated Security=True;Connect Timeout=30";

		private BindingSource bsDriver = new BindingSource();
		private DataTable dtDriver;
		private DataTable dtAus;
		private SqlDataAdapter daDriver;
		private SqlDataAdapter daAus;

		public Functions()
		{
			InitializeComponent();
		}

		private void Functions_Load(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
			{

				using (SqlCommand command = new SqlCommand($"SELECT MAX(podiums_number) FROM Driver", connection))
				{
					connection.Open();

					// create data adapter
					numPodium.Maximum = Convert.ToInt32(command.ExecuteScalar());
				}
			}

			dgvDriver.RowHeadersVisible = false;
			dgvDriver.DataSource = bsDriver;
			QueryDt("SELECT * FROM Driver", out daDriver);
			if (daDriver != null)
			{
				dtDriver = new DataTable();
				daDriver.Fill(dtDriver);
				dgvDriver.DataSource = dtDriver;
			}
			dgvDriver.AutoResizeColumns();

			List<string> lstNat = null;
			Query_lstString("SELECT country FROM Driver", out lstNat);
			if (lstNat != null)
			{
				cmbNat.DataSource = lstNat;
			}
		}

		private void btnFunct1_Click(object sender, EventArgs e)
		{
			dgvFunction1.RowHeadersVisible = false;
			dgvFunction1.DataSource = bsDriver;
			QueryDt($"SELECT * FROM [dbo].getByNation('{cmbNat.SelectedItem}')", out daAus);
			if (daAus != null)
			{
				dtAus = new DataTable();
				daAus.Fill(dtAus);
				dgvFunction1.DataSource = dtAus;
			}
			dgvFunction1.AutoResizeColumns();
		}

		private void btnFunction2_Click(object sender, EventArgs e)
		{
			using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
			{

				using (SqlCommand command = new SqlCommand($"SELECT [dbo].getPodiumCount({numPodium.Value})", connection))
				{
					connection.Open();

					int pilotNumber = (Int32)command.ExecuteScalar();
					MessageBox.Show($"There {(pilotNumber > 1 ? "are" : "is")} {pilotNumber} pilot{(pilotNumber > 1 ? "s" : "")} that have equal or more than {numPodium.Value} podium{(numPodium.Value > 1 ? "s" : "")}","Function 2 - Result");
				}
			}
		}

		private void Query_lstString(string selectCommand, out List<string> lstNat)
		{
			lstNat = new List<string>();
			try
			{
				using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
				{

					using (SqlCommand command = new SqlCommand(selectCommand, connection))
					{
						connection.Open();

						// create data adapter
						using (SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								string countryCode = reader.GetString(0);
								if (!lstNat.Contains(countryCode))
								{
									lstNat.Add(countryCode);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void QueryDt(string selectCommand, out SqlDataAdapter da)
		{
			da = null;
			try
			{
				// Crea un nuovo data adapter basato su selectCommand
				da = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

				// Creo un command builder per generare un comando SQL update, insert, delete
				SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}