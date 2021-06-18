using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VedioRental
{
    public partial class Form1 : Form
    {
        Data Database = new Data();
        string WhichButtonClicked = "";
        string RMID = "";
        public Form1()
        {
            InitializeComponent();
            movie.Hide();
            customer.Hide();
        }

        private void CustBtn_Click(object sender, EventArgs e)
        {
            customer.Show();
            movie.Hide();
            MainGrid.DataSource = Database.LoadCustomers();
            WhichButtonClicked = "Customer";
        }

        private void MovieBtn_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadMovies();
            WhichButtonClicked = "Movies";

            movie.Show();
            customer.Hide();
        }

        private void customer_Enter(object sender, EventArgs e)
        {

        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            Database.AddCustomer(FNTBox.Text, LNTBox.Text, PhTBox.Text, AdTBox.Text);
            CustBtn_Click(null, null);
        }

        private void UpdCustBtn_Click(object sender, EventArgs e)
        {
            Database.UpdateCustomer(CustIDTBox.Text, FNTBox.Text, LNTBox.Text, PhTBox.Text, AdTBox.Text);
            CustBtn_Click(null, null);
        }

        private void DltCustBtn_Click(object sender, EventArgs e)
        {
            Database.DeleteCustomer(CustIDTBox.Text);
            CustBtn_Click(null, null);
        }

        private void RentedaBtn_Click(object sender, EventArgs e)
        {
            customer.Hide();
            movie.Hide();
            MainGrid.DataSource = Database.LoadRentedMovies();
            WhichButtonClicked = "Rented";
        }

        private void HitBtn_Click(object sender, EventArgs e)
        {
            customer.Hide();
            movie.Hide();
            MessageBox.Show(Database.PopularMovie());
        }

        private void HitCustBtn_Click(object sender, EventArgs e)
        {
            customer.Hide();
            movie.Hide();
            MessageBox.Show(Database.PopularCustomer());
        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            customer.Hide();
            movie.Hide();
            Database.IssueMovie(MovieIDTBox.Text, CustIDTBox.Text);
            RentedaBtn_Click(null, null);
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            customer.Hide();
            movie.Hide();
            Database.ReturnMovie(RMID);
            RentedaBtn_Click(null, null);
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = MainGrid.Rows[index];

            if (WhichButtonClicked == "Customer")
            {
                CustIDTBox.Text = row.Cells[0].Value.ToString();
                FNTBox.Text = row.Cells[1].Value.ToString();
                LNTBox.Text = row.Cells[2].Value.ToString();
                AdTBox.Text = row.Cells[3].Value.ToString();
                PhTBox.Text = row.Cells[4].Value.ToString();
            }
            else if (WhichButtonClicked == "Movies")
            {
                MovieIDTBox.Text = row.Cells[0].Value.ToString();
                txtRating.Text = row.Cells[1].Value.ToString();
                txtTitle.Text = row.Cells[2].Value.ToString();
                txtYear.Text = row.Cells[3].Value.ToString();
                textRental_Cost.Text = row.Cells[4].Value.ToString();
                textCopies.Text = row.Cells[5].Value.ToString();
                txtPlot.Text = row.Cells[6].Value.ToString();
                txtGenre.Text = row.Cells[7].Value.ToString();


            }
            else if (WhichButtonClicked == "Rented")
            {
                RMID = row.Cells[0].Value.ToString();
                Console.WriteLine(RMID);
            }
        }

        private void CustIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void CustIDTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FNLabel_Click(object sender, EventArgs e)
        {

        }

        private void FNTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNLabel_Click(object sender, EventArgs e)
        {

        }

        private void LNTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhLabel_Click(object sender, EventArgs e)
        {

        }

        private void PhTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddMovies_Click(object sender, EventArgs e)
        {
            Database.AddMovies(txtRating.Text, txtTitle.Text, txtYear.Text, textRental_Cost.Text, textCopies.Text, txtPlot.Text, txtGenre.Text);
            MovieBtn_Click(null, null);
        }

        private void UpdateMovies_Click(object sender, EventArgs e)
        {
            Database.UpdateMovies(MovieIDTBox.Text, txtRating.Text, txtTitle.Text, txtYear.Text, textRental_Cost.Text, textCopies.Text, txtPlot.Text, txtGenre.Text);
            MovieBtn_Click(null, null);
        }

        private void DeleteMovies_Click(object sender, EventArgs e)
        {
            Database.DeleteMovies(MovieIDTBox.Text);
            MovieBtn_Click(null, null);
        }

        private void MovieIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void MovieIDTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rating_Click(object sender, EventArgs e)
        {

        }

        private void txtRating_TextChanged(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Year_Click(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rental_Cost_Click(object sender, EventArgs e)
        {

        }

        private void textRental_Cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void Copies_Click(object sender, EventArgs e)
        {

        }

        private void textCopies_TextChanged(object sender, EventArgs e)
        {

        }

        private void Plot_Click(object sender, EventArgs e)
        {

        }

        private void txtPlot_TextChanged(object sender, EventArgs e)
        {

        }

        private void Genre_Click(object sender, EventArgs e)
        {

        }

        private void txtGenre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
