using System;
using System.Windows.Forms;

namespace Rental_Movie_Database
{


    public partial class Rental_Movie_Form : Form
    {
        //create an instance of the Database class
        Database myDatabase = new Database();

        public Rental_Movie_Form()
        {

            InitializeComponent();
            txtDateTime2.Text = (DateTime.Now.Date.Year).ToString();
            txtDateTime.Text = (DateTime.Now).ToString();
            loadDB();
        }

        public void loadDB()
        {
            DisplayDataGridViewMovies();
            DisplayDataGridViewCustomers();
            DisplayDataGridViewRentals();
            DisplayDataGridViewTopCustomers();
            DisplayDataGridViewTopMovies();

        }
        //LOAD THE MOVIES DATAGRID
        private void DisplayDataGridViewMovies()
        {
            DGVMovies.DataSource = null;
            try
            {
                DGVMovies.DataSource = myDatabase.FillDGVMoviesWithMovies();
                //pass the datatable data to the DataGridView
                DGVMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataGridViewCustomers()
        {
            //clear out the old data
            DGVCustomers.DataSource = null;
            try
            {
                DGVCustomers.DataSource = myDatabase.FillDGVCustomersWithCustomers();
                //pass the datatable data to the DataGridView
                DGVCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void DisplayDataGridViewRentals()
        {
            //clear out the old data
            DGVMoviesRented.DataSource = null;
            try
            {
                DGVMoviesRented.DataSource = myDatabase.FillDGVRentalsWithRentals();
                //pass the datatable data to the DataGridView
                DGVMoviesRented.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayDataGridViewTopCustomers()
        {
            //clear out the old data
            DGVTopCustomers.DataSource = null;
            try
            {
                DGVTopCustomers.DataSource = myDatabase.FillDGVTopCustomersWithTopCustomers();
                //pass the datatable data to the DataGridView
                DGVTopCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DisplayDataGridViewTopMovies()
        {
            //clear out the old data
            DGVTopMovies.DataSource = null;
            try
            {
                DGVTopMovies.DataSource = myDatabase.FillDGVTopMoviesWithTopMovies();
                //pass the datatable data to the DataGridView
                DGVTopMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DGVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int CustID = 0;
            //these are the cell clicks for the values in the row that you click on

            CustID = (int)DGVCustomers.Rows[e.RowIndex].Cells[0].Value;
            txtCustFirstName.Text = DGVCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCustLastName.Text = DGVCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCustAddress.Text = DGVCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCustPhone.Text = DGVCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (e.RowIndex >= 0)
            {


                txtCustID.Text = CustID.ToString();

            }

        }


        private void DGVMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            var today = DateTime.Now;
            try
            {
                //show the data in the DGV in the text boxes
                string newvalue = DGVMovies.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //pass data to the text boxes
                txtMovieID.Text = DGVMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMovieRating.Text = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMovieTitle.Text = DGVMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMovieYear.Text = DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtMoviePlot.Text = DGVMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtMovieGenre.Text = DGVMovies.Rows[e.RowIndex].Cells[5].Value.ToString();



            }
            catch
            {
            }
            int thisYear = Convert.ToInt16(txtDateTime2.Text);
            int Year = Convert.ToInt16(txtMovieYear.Text);

            int fee = myDatabase.FeeCalculation(Year, thisYear);

            txtMovieFee.Text = "$" + fee.ToString() + ".00";

        }


        //add Movie to database from form
        private void btnAddMovie_Click(object sender, EventArgs e)
        {

            if (txtMovieTitle.Text != string.Empty && txtMovieYear.Text != string.Empty &&
                txtMovieGenre.Text != string.Empty && txtMovieRating.Text != string.Empty &&
                txtMoviePlot.Text != string.Empty)
            {

                string cat = myDatabase.AddMovie(txtMovieRating.Text, txtMovieTitle.Text, txtMovieYear.Text,
                    txtMoviePlot.Text,
                    txtMovieGenre.Text);

                MessageBox.Show(cat);
            }
            else
            {
                MessageBox.Show("Please enter all fields");
            }



            DisplayDataGridViewMovies();
        }




        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {

            string cat = myDatabase.UpdateMovie(txtMovieID.Text, txtMovieRating.Text, txtMovieTitle.Text,
                txtMovieYear.Text, txtMoviePlot.Text, txtMovieGenre.Text);

            MessageBox.Show(cat);


            DisplayDataGridViewMovies();
        }



        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            myDatabase.DeleteMovie(txtMovieID.Text);


            DisplayDataGridViewMovies();
        }





        //Add Customer based from form information
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            if (txtCustFirstName.Text != string.Empty && txtCustLastName.Text != string.Empty &&
                txtCustAddress.Text != string.Empty && txtCustPhone.Text != string.Empty)
            {
                string dog = myDatabase.AddCustomer(txtCustFirstName.Text, txtCustLastName.Text, txtCustAddress.Text,
                    txtCustPhone.Text);

                MessageBox.Show(dog);
            }
            else
            {
                MessageBox.Show("Please enter all fields");
            }


        }



        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            myDatabase.DeleteCustomer(txtCustID.Text);



            DisplayDataGridViewCustomers();
        }



        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            myDatabase.UpdateCustomer(txtCustID.Text, txtCustFirstName.Text, txtCustLastName.Text, txtCustAddress.Text, txtCustPhone.Text);


            DisplayDataGridViewCustomers();
        }




        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtMovieID.Text != string.Empty && txtCustID.Text != string.Empty)
            {

                DateTime Date = Convert.ToDateTime(txtDateTime.Text);
                myDatabase.CheckOut(txtMovieID.Text, txtCustID.Text, Date);


                DisplayDataGridViewRentals();
            }
            else
            {
                MessageBox.Show("Please select and movie and a customer");

            }

        }


        private void DGVMoviesRented_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //show the data in the DGV in the text boxes
                string newvalue = DGVMoviesRented.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //pass data to the text boxes
                txtRentalID.Text = DGVMoviesRented.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            catch
            {
            }

        }

        //return selected movie
        private void btnReturn_Click(object sender, EventArgs e)


        {
            if (txtRentalID.Text != string.Empty)
            {



                DateTime Date = Convert.ToDateTime(txtDateTime.Text);
                myDatabase.returnMovie(txtRentalID.Text, Date);
                MessageBox.Show("Movie Returned");

                DisplayDataGridViewRentals();
            }
            else
            {
                MessageBox.Show("Please select a movie rental from the rental tab");
            }
        }


        private void rdoShowMoviesOut_CheckedChanged(object sender, EventArgs e)
        {
            DGVMovies.DataSource = null;
            try
            {
                DGVMovies.DataSource = myDatabase.FillDGVMoviesWithMoviesOut();
                //pass the datatable data to the DataGridView
                DGVMovies.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdoAllMovies_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDataGridViewMovies();
        }

    }
}
