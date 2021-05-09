namespace Rental_Movie_Database
{
    partial class Rental_Movie_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVMoviesRented = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DGVTopCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DGVTopMovies = new System.Windows.Forms.DataGridView();
            this.txtCustFirstName = new System.Windows.Forms.TextBox();
            this.txtCustLastName = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtMoviePlot = new System.Windows.Forms.TextBox();
            this.txtMovieRating = new System.Windows.Forms.TextBox();
            this.txtMovieGenre = new System.Windows.Forms.TextBox();
            this.txtMovieYear = new System.Windows.Forms.TextBox();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.MovieFee = new System.Windows.Forms.Label();
            this.rdoShowMoviesOut = new System.Windows.Forms.RadioButton();
            this.rdoAllMovies = new System.Windows.Forms.RadioButton();
            this.txtDateTime = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.Label();
            this.txtDateTime2 = new System.Windows.Forms.Label();
            this.txtRentalID = new System.Windows.Forms.Label();
            this.txtMovieFee = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMoviesRented)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopCustomers)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1117, 327);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVMovies);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1109, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movies";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVMovies
            // 
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMovies.Location = new System.Drawing.Point(4, 4);
            this.DGVMovies.Margin = new System.Windows.Forms.Padding(4);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.RowHeadersWidth = 51;
            this.DGVMovies.Size = new System.Drawing.Size(1101, 290);
            this.DGVMovies.TabIndex = 1;
            this.DGVMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 26;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVCustomers);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1109, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomers.Location = new System.Drawing.Point(4, 4);
            this.DGVCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.RowHeadersWidth = 51;
            this.DGVCustomers.Size = new System.Drawing.Size(1101, 290);
            this.DGVCustomers.TabIndex = 1;
            this.DGVCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVMoviesRented);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1109, 298);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MoviesRented";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVMoviesRented
            // 
            this.DGVMoviesRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMoviesRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMoviesRented.Location = new System.Drawing.Point(4, 4);
            this.DGVMoviesRented.Margin = new System.Windows.Forms.Padding(4);
            this.DGVMoviesRented.Name = "DGVMoviesRented";
            this.DGVMoviesRented.RowHeadersWidth = 51;
            this.DGVMoviesRented.Size = new System.Drawing.Size(1101, 290);
            this.DGVMoviesRented.TabIndex = 0;
            this.DGVMoviesRented.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMoviesRented_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DGVTopCustomers);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1109, 298);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "TopCustomers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DGVTopCustomers
            // 
            this.DGVTopCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTopCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTopCustomers.Location = new System.Drawing.Point(4, 4);
            this.DGVTopCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.DGVTopCustomers.Name = "DGVTopCustomers";
            this.DGVTopCustomers.RowHeadersWidth = 51;
            this.DGVTopCustomers.Size = new System.Drawing.Size(1101, 290);
            this.DGVTopCustomers.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DGVTopMovies);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(1109, 298);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "TopMovies";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DGVTopMovies
            // 
            this.DGVTopMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTopMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTopMovies.Location = new System.Drawing.Point(4, 4);
            this.DGVTopMovies.Margin = new System.Windows.Forms.Padding(4);
            this.DGVTopMovies.Name = "DGVTopMovies";
            this.DGVTopMovies.RowHeadersWidth = 51;
            this.DGVTopMovies.Size = new System.Drawing.Size(1101, 290);
            this.DGVTopMovies.TabIndex = 0;
            // 
            // txtCustFirstName
            // 
            this.txtCustFirstName.Location = new System.Drawing.Point(100, 354);
            this.txtCustFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustFirstName.Name = "txtCustFirstName";
            this.txtCustFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtCustFirstName.TabIndex = 2;
            // 
            // txtCustLastName
            // 
            this.txtCustLastName.Location = new System.Drawing.Point(100, 400);
            this.txtCustLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustLastName.Name = "txtCustLastName";
            this.txtCustLastName.Size = new System.Drawing.Size(132, 22);
            this.txtCustLastName.TabIndex = 3;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(100, 443);
            this.txtCustAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(132, 22);
            this.txtCustAddress.TabIndex = 4;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(100, 481);
            this.txtCustPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(132, 22);
            this.txtCustPhone.TabIndex = 5;
            // 
            // txtMoviePlot
            // 
            this.txtMoviePlot.Location = new System.Drawing.Point(608, 481);
            this.txtMoviePlot.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoviePlot.Name = "txtMoviePlot";
            this.txtMoviePlot.Size = new System.Drawing.Size(132, 22);
            this.txtMoviePlot.TabIndex = 9;
            // 
            // txtMovieRating
            // 
            this.txtMovieRating.Location = new System.Drawing.Point(608, 443);
            this.txtMovieRating.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieRating.Name = "txtMovieRating";
            this.txtMovieRating.Size = new System.Drawing.Size(132, 22);
            this.txtMovieRating.TabIndex = 10;
            // 
            // txtMovieGenre
            // 
            this.txtMovieGenre.Location = new System.Drawing.Point(608, 520);
            this.txtMovieGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieGenre.Name = "txtMovieGenre";
            this.txtMovieGenre.Size = new System.Drawing.Size(132, 22);
            this.txtMovieGenre.TabIndex = 11;
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Location = new System.Drawing.Point(608, 400);
            this.txtMovieYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(132, 22);
            this.txtMovieYear.TabIndex = 12;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(608, 354);
            this.txtMovieTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(132, 22);
            this.txtMovieTitle.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Movie Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 514);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 400);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Movie Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 481);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Plot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 442);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rating";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(778, 427);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(139, 28);
            this.btnAddMovie.TabIndex = 20;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(776, 475);
            this.btnUpdateMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(141, 28);
            this.btnUpdateMovie.TabIndex = 22;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(776, 520);
            this.btnDeleteMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(141, 28);
            this.btnDeleteMovie.TabIndex = 23;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(277, 354);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(137, 28);
            this.btnAddCustomer.TabIndex = 24;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 354);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 481);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 443);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 400);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "Last Name";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(277, 470);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(137, 28);
            this.btnDeleteCustomer.TabIndex = 30;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(277, 411);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(137, 28);
            this.btnUpdateCustomer.TabIndex = 31;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(1006, 411);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(100, 28);
            this.btnCheckOut.TabIndex = 32;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1006, 481);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 28);
            this.btnReturn.TabIndex = 33;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // MovieFee
            // 
            this.MovieFee.AutoSize = true;
            this.MovieFee.Location = new System.Drawing.Point(505, 555);
            this.MovieFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieFee.Name = "MovieFee";
            this.MovieFee.Size = new System.Drawing.Size(32, 17);
            this.MovieFee.TabIndex = 36;
            this.MovieFee.Text = "Fee";
            // 
            // rdoShowMoviesOut
            // 
            this.rdoShowMoviesOut.AutoSize = true;
            this.rdoShowMoviesOut.Location = new System.Drawing.Point(779, 396);
            this.rdoShowMoviesOut.Margin = new System.Windows.Forms.Padding(4);
            this.rdoShowMoviesOut.Name = "rdoShowMoviesOut";
            this.rdoShowMoviesOut.Size = new System.Drawing.Size(138, 21);
            this.rdoShowMoviesOut.TabIndex = 37;
            this.rdoShowMoviesOut.TabStop = true;
            this.rdoShowMoviesOut.Text = "Show Movies Out";
            this.rdoShowMoviesOut.UseVisualStyleBackColor = true;
            this.rdoShowMoviesOut.CheckedChanged += new System.EventHandler(this.rdoShowMoviesOut_CheckedChanged);
            // 
            // rdoAllMovies
            // 
            this.rdoAllMovies.AutoSize = true;
            this.rdoAllMovies.Checked = true;
            this.rdoAllMovies.Location = new System.Drawing.Point(778, 350);
            this.rdoAllMovies.Margin = new System.Windows.Forms.Padding(4);
            this.rdoAllMovies.Name = "rdoAllMovies";
            this.rdoAllMovies.Size = new System.Drawing.Size(129, 21);
            this.rdoAllMovies.TabIndex = 38;
            this.rdoAllMovies.TabStop = true;
            this.rdoAllMovies.Text = "Show all Movies";
            this.rdoAllMovies.UseVisualStyleBackColor = true;
            this.rdoAllMovies.CheckedChanged += new System.EventHandler(this.rdoAllMovies_CheckedChanged);
            // 
            // txtDateTime
            // 
            this.txtDateTime.AutoSize = true;
            this.txtDateTime.Location = new System.Drawing.Point(1003, 514);
            this.txtDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(0, 17);
            this.txtDateTime.TabIndex = 39;
            this.txtDateTime.Visible = false;
            // 
            // txtCustID
            // 
            this.txtCustID.AutoSize = true;
            this.txtCustID.Location = new System.Drawing.Point(775, 68);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(0, 17);
            this.txtCustID.TabIndex = 40;
            this.txtCustID.Visible = false;
            // 
            // txtMovieID
            // 
            this.txtMovieID.AutoSize = true;
            this.txtMovieID.Location = new System.Drawing.Point(691, 44);
            this.txtMovieID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(0, 17);
            this.txtMovieID.TabIndex = 41;
            this.txtMovieID.Visible = false;
            // 
            // txtDateTime2
            // 
            this.txtDateTime2.AutoSize = true;
            this.txtDateTime2.Location = new System.Drawing.Point(947, 175);
            this.txtDateTime2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDateTime2.Name = "txtDateTime2";
            this.txtDateTime2.Size = new System.Drawing.Size(0, 17);
            this.txtDateTime2.TabIndex = 42;
            this.txtDateTime2.Visible = false;
            // 
            // txtRentalID
            // 
            this.txtRentalID.AutoSize = true;
            this.txtRentalID.Location = new System.Drawing.Point(943, 228);
            this.txtRentalID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(0, 17);
            this.txtRentalID.TabIndex = 43;
            this.txtRentalID.Visible = false;
            // 
            // txtMovieFee
            // 
            this.txtMovieFee.AutoSize = true;
            this.txtMovieFee.Location = new System.Drawing.Point(615, 555);
            this.txtMovieFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMovieFee.Name = "txtMovieFee";
            this.txtMovieFee.Size = new System.Drawing.Size(0, 17);
            this.txtMovieFee.TabIndex = 44;
            // 
            // Rental_Movie_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1143, 581);
            this.Controls.Add(this.txtMovieFee);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.txtDateTime2);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.rdoAllMovies);
            this.Controls.Add(this.rdoShowMoviesOut);
            this.Controls.Add(this.MovieFee);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMovieTitle);
            this.Controls.Add(this.txtMovieYear);
            this.Controls.Add(this.txtMovieGenre);
            this.Controls.Add(this.txtMovieRating);
            this.Controls.Add(this.txtMoviePlot);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtCustLastName);
            this.Controls.Add(this.txtCustFirstName);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rental_Movie_Form";
            this.Text = "Movie Rental System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMoviesRented)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopCustomers)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVMoviesRented;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.TextBox txtCustFirstName;
        private System.Windows.Forms.TextBox txtCustLastName;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtMoviePlot;
        private System.Windows.Forms.TextBox txtMovieRating;
        private System.Windows.Forms.TextBox txtMovieGenre;
        private System.Windows.Forms.TextBox txtMovieYear;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label MovieFee;
        private System.Windows.Forms.RadioButton rdoShowMoviesOut;
        private System.Windows.Forms.RadioButton rdoAllMovies;
        private System.Windows.Forms.Label txtDateTime;
        private System.Windows.Forms.Label txtCustID;
        private System.Windows.Forms.Label txtMovieID;
        private System.Windows.Forms.Label txtDateTime2;
        private System.Windows.Forms.Label txtRentalID;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView DGVTopCustomers;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView DGVTopMovies;
        private System.Windows.Forms.Label txtMovieFee;
    }
}
