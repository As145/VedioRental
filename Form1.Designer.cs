
namespace VedioRental
{
    partial class Form1
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
            this.HitBtn = new System.Windows.Forms.Button();
            this.HitCustBtn = new System.Windows.Forms.Button();
            this.RentedaBtn = new System.Windows.Forms.Button();
            this.IssueBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.MovieBtn = new System.Windows.Forms.Button();
            this.CustBtn = new System.Windows.Forms.Button();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.customer = new System.Windows.Forms.GroupBox();
            this.FNTBox = new System.Windows.Forms.TextBox();
            this.LNTBox = new System.Windows.Forms.TextBox();
            this.DltCustBtn = new System.Windows.Forms.Button();
            this.UpdCustBtn = new System.Windows.Forms.Button();
            this.AdTBox = new System.Windows.Forms.TextBox();
            this.AddCustBtn = new System.Windows.Forms.Button();
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.PhTBox = new System.Windows.Forms.TextBox();
            this.CustIDTBox = new System.Windows.Forms.TextBox();
            this.FNLabel = new System.Windows.Forms.Label();
            this.LNLabel = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.Label();
            this.PhLabel = new System.Windows.Forms.Label();
            this.UpdateMovies = new System.Windows.Forms.Button();
            this.MovieIDLabel = new System.Windows.Forms.Label();
            this.DeleteMovies = new System.Windows.Forms.Button();
            this.MovieIDTBox = new System.Windows.Forms.TextBox();
            this.AddMovies = new System.Windows.Forms.Button();
            this.Year = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Rental_Cost = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.Plot = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.textRental_Cost = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.movie = new System.Windows.Forms.GroupBox();
            this.Copies = new System.Windows.Forms.Label();
            this.textCopies = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.customer.SuspendLayout();
            this.movie.SuspendLayout();
            this.SuspendLayout();
            // 
            // HitBtn
            // 
            this.HitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HitBtn.ForeColor = System.Drawing.Color.Red;
            this.HitBtn.Location = new System.Drawing.Point(270, 77);
            this.HitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HitBtn.Name = "HitBtn";
            this.HitBtn.Size = new System.Drawing.Size(169, 36);
            this.HitBtn.TabIndex = 37;
            this.HitBtn.Text = "Best Movie";
            this.HitBtn.UseVisualStyleBackColor = false;
            this.HitBtn.Click += new System.EventHandler(this.HitBtn_Click);
            // 
            // HitCustBtn
            // 
            this.HitCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HitCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HitCustBtn.ForeColor = System.Drawing.Color.Red;
            this.HitCustBtn.Location = new System.Drawing.Point(19, 77);
            this.HitCustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.HitCustBtn.Name = "HitCustBtn";
            this.HitCustBtn.Size = new System.Drawing.Size(243, 38);
            this.HitCustBtn.TabIndex = 36;
            this.HitCustBtn.Text = "Best Customer";
            this.HitCustBtn.UseVisualStyleBackColor = false;
            this.HitCustBtn.Click += new System.EventHandler(this.HitCustBtn_Click);
            // 
            // RentedaBtn
            // 
            this.RentedaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RentedaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentedaBtn.ForeColor = System.Drawing.Color.Red;
            this.RentedaBtn.Location = new System.Drawing.Point(667, 522);
            this.RentedaBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RentedaBtn.Name = "RentedaBtn";
            this.RentedaBtn.Size = new System.Drawing.Size(211, 37);
            this.RentedaBtn.TabIndex = 35;
            this.RentedaBtn.Text = "Rented Movies";
            this.RentedaBtn.UseVisualStyleBackColor = false;
            this.RentedaBtn.Click += new System.EventHandler(this.RentedaBtn_Click);
            // 
            // IssueBtn
            // 
            this.IssueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.IssueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBtn.ForeColor = System.Drawing.Color.Red;
            this.IssueBtn.Location = new System.Drawing.Point(458, 76);
            this.IssueBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IssueBtn.Name = "IssueBtn";
            this.IssueBtn.Size = new System.Drawing.Size(200, 37);
            this.IssueBtn.TabIndex = 34;
            this.IssueBtn.Text = "Issue Movie";
            this.IssueBtn.UseVisualStyleBackColor = false;
            this.IssueBtn.Click += new System.EventHandler(this.IssueBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBtn.ForeColor = System.Drawing.Color.Red;
            this.ReturnBtn.Location = new System.Drawing.Point(679, 77);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(181, 36);
            this.ReturnBtn.TabIndex = 33;
            this.ReturnBtn.Text = "Return Movie";
            this.ReturnBtn.UseVisualStyleBackColor = false;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // MovieBtn
            // 
            this.MovieBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieBtn.ForeColor = System.Drawing.Color.Red;
            this.MovieBtn.Location = new System.Drawing.Point(348, 520);
            this.MovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MovieBtn.Name = "MovieBtn";
            this.MovieBtn.Size = new System.Drawing.Size(119, 40);
            this.MovieBtn.TabIndex = 32;
            this.MovieBtn.Text = "Movies";
            this.MovieBtn.UseVisualStyleBackColor = false;
            this.MovieBtn.Click += new System.EventHandler(this.MovieBtn_Click);
            // 
            // CustBtn
            // 
            this.CustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustBtn.ForeColor = System.Drawing.Color.Red;
            this.CustBtn.Location = new System.Drawing.Point(87, 522);
            this.CustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CustBtn.Name = "CustBtn";
            this.CustBtn.Size = new System.Drawing.Size(138, 40);
            this.CustBtn.TabIndex = 31;
            this.CustBtn.Text = "Customers";
            this.CustBtn.UseVisualStyleBackColor = false;
            this.CustBtn.Click += new System.EventHandler(this.CustBtn_Click);
            // 
            // MainGrid
            // 
            this.MainGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(19, 138);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(4);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersWidth = 51;
            this.MainGrid.Size = new System.Drawing.Size(872, 361);
            this.MainGrid.TabIndex = 38;
            this.MainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainGrid_CellContentClick);
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.customer.Controls.Add(this.FNTBox);
            this.customer.Controls.Add(this.LNTBox);
            this.customer.Controls.Add(this.DltCustBtn);
            this.customer.Controls.Add(this.UpdCustBtn);
            this.customer.Controls.Add(this.AdTBox);
            this.customer.Controls.Add(this.AddCustBtn);
            this.customer.Controls.Add(this.CustIDLabel);
            this.customer.Controls.Add(this.PhTBox);
            this.customer.Controls.Add(this.CustIDTBox);
            this.customer.Controls.Add(this.FNLabel);
            this.customer.Controls.Add(this.LNLabel);
            this.customer.Controls.Add(this.AdLabel);
            this.customer.Controls.Add(this.PhLabel);
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.ForeColor = System.Drawing.Color.Black;
            this.customer.Location = new System.Drawing.Point(909, 135);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(538, 211);
            this.customer.TabIndex = 48;
            this.customer.TabStop = false;
            this.customer.Text = "CUSTOMER";
            this.customer.Enter += new System.EventHandler(this.customer_Enter);
            // 
            // FNTBox
            // 
            this.FNTBox.Location = new System.Drawing.Point(227, 41);
            this.FNTBox.Margin = new System.Windows.Forms.Padding(4);
            this.FNTBox.Name = "FNTBox";
            this.FNTBox.Size = new System.Drawing.Size(132, 27);
            this.FNTBox.TabIndex = 31;
            this.FNTBox.TextChanged += new System.EventHandler(this.FNTBox_TextChanged);
            // 
            // LNTBox
            // 
            this.LNTBox.Location = new System.Drawing.Point(54, 93);
            this.LNTBox.Margin = new System.Windows.Forms.Padding(4);
            this.LNTBox.Name = "LNTBox";
            this.LNTBox.Size = new System.Drawing.Size(132, 27);
            this.LNTBox.TabIndex = 32;
            this.LNTBox.TextChanged += new System.EventHandler(this.LNTBox_TextChanged);
            // 
            // DltCustBtn
            // 
            this.DltCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DltCustBtn.ForeColor = System.Drawing.Color.Black;
            this.DltCustBtn.Location = new System.Drawing.Point(348, 143);
            this.DltCustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DltCustBtn.Name = "DltCustBtn";
            this.DltCustBtn.Size = new System.Drawing.Size(97, 32);
            this.DltCustBtn.TabIndex = 43;
            this.DltCustBtn.Text = "DELETE";
            this.DltCustBtn.UseVisualStyleBackColor = false;
            this.DltCustBtn.Click += new System.EventHandler(this.DltCustBtn_Click);
            // 
            // UpdCustBtn
            // 
            this.UpdCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UpdCustBtn.Location = new System.Drawing.Point(206, 140);
            this.UpdCustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdCustBtn.Name = "UpdCustBtn";
            this.UpdCustBtn.Size = new System.Drawing.Size(77, 32);
            this.UpdCustBtn.TabIndex = 40;
            this.UpdCustBtn.Text = "EDIT";
            this.UpdCustBtn.UseVisualStyleBackColor = false;
            this.UpdCustBtn.Click += new System.EventHandler(this.UpdCustBtn_Click);
            // 
            // AdTBox
            // 
            this.AdTBox.Location = new System.Drawing.Point(220, 91);
            this.AdTBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdTBox.Name = "AdTBox";
            this.AdTBox.Size = new System.Drawing.Size(132, 27);
            this.AdTBox.TabIndex = 33;
            this.AdTBox.TextChanged += new System.EventHandler(this.AdTBox_TextChanged);
            // 
            // AddCustBtn
            // 
            this.AddCustBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AddCustBtn.Location = new System.Drawing.Point(50, 140);
            this.AddCustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustBtn.Name = "AddCustBtn";
            this.AddCustBtn.Size = new System.Drawing.Size(72, 35);
            this.AddCustBtn.TabIndex = 39;
            this.AddCustBtn.Text = "ADD";
            this.AddCustBtn.UseVisualStyleBackColor = false;
            this.AddCustBtn.Click += new System.EventHandler(this.AddCustBtn_Click);
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Location = new System.Drawing.Point(50, 20);
            this.CustIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(28, 20);
            this.CustIDLabel.TabIndex = 42;
            this.CustIDLabel.Text = "ID";
            this.CustIDLabel.Click += new System.EventHandler(this.CustIDLabel_Click);
            // 
            // PhTBox
            // 
            this.PhTBox.Location = new System.Drawing.Point(381, 63);
            this.PhTBox.Margin = new System.Windows.Forms.Padding(4);
            this.PhTBox.Name = "PhTBox";
            this.PhTBox.Size = new System.Drawing.Size(132, 27);
            this.PhTBox.TabIndex = 34;
            this.PhTBox.TextChanged += new System.EventHandler(this.PhTBox_TextChanged);
            // 
            // CustIDTBox
            // 
            this.CustIDTBox.Enabled = false;
            this.CustIDTBox.Location = new System.Drawing.Point(50, 41);
            this.CustIDTBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustIDTBox.Name = "CustIDTBox";
            this.CustIDTBox.Size = new System.Drawing.Size(132, 27);
            this.CustIDTBox.TabIndex = 41;
            this.CustIDTBox.TextChanged += new System.EventHandler(this.CustIDTBox_TextChanged);
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Location = new System.Drawing.Point(233, 20);
            this.FNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(119, 20);
            this.FNLabel.TabIndex = 35;
            this.FNLabel.Text = "FIRST NAME";
            this.FNLabel.Click += new System.EventHandler(this.FNLabel_Click);
            // 
            // LNLabel
            // 
            this.LNLabel.AutoSize = true;
            this.LNLabel.Location = new System.Drawing.Point(65, 72);
            this.LNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNLabel.Name = "LNLabel";
            this.LNLabel.Size = new System.Drawing.Size(113, 20);
            this.LNLabel.TabIndex = 36;
            this.LNLabel.Text = "LAST NAME";
            this.LNLabel.Click += new System.EventHandler(this.LNLabel_Click);
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Location = new System.Drawing.Point(240, 72);
            this.AdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(98, 20);
            this.AdLabel.TabIndex = 37;
            this.AdLabel.Text = "ADDRESS";
            this.AdLabel.Click += new System.EventHandler(this.AdLabel_Click);
            // 
            // PhLabel
            // 
            this.PhLabel.AutoSize = true;
            this.PhLabel.Location = new System.Drawing.Point(399, 30);
            this.PhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhLabel.Name = "PhLabel";
            this.PhLabel.Size = new System.Drawing.Size(74, 20);
            this.PhLabel.TabIndex = 38;
            this.PhLabel.Text = "PHONE";
            this.PhLabel.Click += new System.EventHandler(this.PhLabel_Click);
            // 
            // UpdateMovies
            // 
            this.UpdateMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdateMovies.Location = new System.Drawing.Point(104, 315);
            this.UpdateMovies.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateMovies.Name = "UpdateMovies";
            this.UpdateMovies.Size = new System.Drawing.Size(92, 33);
            this.UpdateMovies.TabIndex = 67;
            this.UpdateMovies.Text = "EDIT";
            this.UpdateMovies.UseVisualStyleBackColor = false;
            this.UpdateMovies.Click += new System.EventHandler(this.UpdateMovies_Click);
            // 
            // MovieIDLabel
            // 
            this.MovieIDLabel.AutoSize = true;
            this.MovieIDLabel.Location = new System.Drawing.Point(55, 50);
            this.MovieIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieIDLabel.Name = "MovieIDLabel";
            this.MovieIDLabel.Size = new System.Drawing.Size(28, 20);
            this.MovieIDLabel.TabIndex = 45;
            this.MovieIDLabel.Text = "ID";
            this.MovieIDLabel.Click += new System.EventHandler(this.MovieIDLabel_Click);
            // 
            // DeleteMovies
            // 
            this.DeleteMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DeleteMovies.Location = new System.Drawing.Point(218, 315);
            this.DeleteMovies.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteMovies.Name = "DeleteMovies";
            this.DeleteMovies.Size = new System.Drawing.Size(96, 33);
            this.DeleteMovies.TabIndex = 66;
            this.DeleteMovies.Text = "DELETE";
            this.DeleteMovies.UseVisualStyleBackColor = false;
            this.DeleteMovies.Click += new System.EventHandler(this.DeleteMovies_Click);
            // 
            // MovieIDTBox
            // 
            this.MovieIDTBox.Enabled = false;
            this.MovieIDTBox.Location = new System.Drawing.Point(9, 78);
            this.MovieIDTBox.Margin = new System.Windows.Forms.Padding(4);
            this.MovieIDTBox.Name = "MovieIDTBox";
            this.MovieIDTBox.Size = new System.Drawing.Size(132, 27);
            this.MovieIDTBox.TabIndex = 44;
            this.MovieIDTBox.TextChanged += new System.EventHandler(this.MovieIDTBox_TextChanged);
            // 
            // AddMovies
            // 
            this.AddMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddMovies.Location = new System.Drawing.Point(18, 315);
            this.AddMovies.Margin = new System.Windows.Forms.Padding(4);
            this.AddMovies.Name = "AddMovies";
            this.AddMovies.Size = new System.Drawing.Size(78, 33);
            this.AddMovies.TabIndex = 65;
            this.AddMovies.Text = "ADD";
            this.AddMovies.UseVisualStyleBackColor = false;
            this.AddMovies.Click += new System.EventHandler(this.AddMovies_Click);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(214, 111);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(57, 20);
            this.Year.TabIndex = 63;
            this.Year.Text = "YEAR";
            this.Year.Click += new System.EventHandler(this.Year_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(49, 114);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(59, 20);
            this.Title.TabIndex = 61;
            this.Title.Text = "TITLE";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Rental_Cost
            // 
            this.Rental_Cost.AutoSize = true;
            this.Rental_Cost.Location = new System.Drawing.Point(50, 175);
            this.Rental_Cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rental_Cost.Name = "Rental_Cost";
            this.Rental_Cost.Size = new System.Drawing.Size(59, 20);
            this.Rental_Cost.TabIndex = 60;
            this.Rental_Cost.Text = "COST";
            this.Rental_Cost.Click += new System.EventHandler(this.Rental_Cost_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(191, 137);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(132, 27);
            this.txtYear.TabIndex = 50;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // Plot
            // 
            this.Plot.AutoSize = true;
            this.Plot.Location = new System.Drawing.Point(50, 242);
            this.Plot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(57, 20);
            this.Plot.TabIndex = 59;
            this.Plot.Text = "PLOT";
            this.Plot.Click += new System.EventHandler(this.Plot_Click);
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(214, 245);
            this.Genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(73, 20);
            this.Genre.TabIndex = 58;
            this.Genre.Text = "GENRE";
            this.Genre.Click += new System.EventHandler(this.Genre_Click);
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(200, 46);
            this.Rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(77, 20);
            this.Rating.TabIndex = 56;
            this.Rating.Text = "RATING";
            this.Rating.Click += new System.EventHandler(this.Rating_Click);
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(18, 269);
            this.txtPlot.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(132, 27);
            this.txtPlot.TabIndex = 55;
            this.txtPlot.TextChanged += new System.EventHandler(this.txtPlot_TextChanged);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(191, 269);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(132, 27);
            this.txtGenre.TabIndex = 53;
            this.txtGenre.TextChanged += new System.EventHandler(this.txtGenre_TextChanged);
            // 
            // textRental_Cost
            // 
            this.textRental_Cost.Location = new System.Drawing.Point(13, 204);
            this.textRental_Cost.Margin = new System.Windows.Forms.Padding(4);
            this.textRental_Cost.Name = "textRental_Cost";
            this.textRental_Cost.Size = new System.Drawing.Size(132, 27);
            this.textRental_Cost.TabIndex = 52;
            this.textRental_Cost.TextChanged += new System.EventHandler(this.textRental_Cost_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(13, 135);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(132, 27);
            this.txtTitle.TabIndex = 48;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(179, 77);
            this.txtRating.Margin = new System.Windows.Forms.Padding(4);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(132, 27);
            this.txtRating.TabIndex = 47;
            this.txtRating.TextChanged += new System.EventHandler(this.txtRating_TextChanged);
            // 
            // movie
            // 
            this.movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.movie.Controls.Add(this.UpdateMovies);
            this.movie.Controls.Add(this.MovieIDLabel);
            this.movie.Controls.Add(this.DeleteMovies);
            this.movie.Controls.Add(this.MovieIDTBox);
            this.movie.Controls.Add(this.AddMovies);
            this.movie.Controls.Add(this.Year);
            this.movie.Controls.Add(this.Title);
            this.movie.Controls.Add(this.Rental_Cost);
            this.movie.Controls.Add(this.Plot);
            this.movie.Controls.Add(this.Genre);
            this.movie.Controls.Add(this.Copies);
            this.movie.Controls.Add(this.Rating);
            this.movie.Controls.Add(this.txtPlot);
            this.movie.Controls.Add(this.txtGenre);
            this.movie.Controls.Add(this.textRental_Cost);
            this.movie.Controls.Add(this.textCopies);
            this.movie.Controls.Add(this.txtYear);
            this.movie.Controls.Add(this.txtTitle);
            this.movie.Controls.Add(this.txtRating);
            this.movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie.ForeColor = System.Drawing.Color.Black;
            this.movie.Location = new System.Drawing.Point(1038, 102);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(360, 356);
            this.movie.TabIndex = 50;
            this.movie.TabStop = false;
            this.movie.Text = "MOVIE";
            // 
            // Copies
            // 
            this.Copies.AutoSize = true;
            this.Copies.Location = new System.Drawing.Point(208, 174);
            this.Copies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(77, 20);
            this.Copies.TabIndex = 57;
            this.Copies.Text = "COPIES";
            this.Copies.Click += new System.EventHandler(this.Copies_Click);
            // 
            // textCopies
            // 
            this.textCopies.Location = new System.Drawing.Point(191, 206);
            this.textCopies.Margin = new System.Windows.Forms.Padding(4);
            this.textCopies.Name = "textCopies";
            this.textCopies.Size = new System.Drawing.Size(132, 27);
            this.textCopies.TabIndex = 51;
            this.textCopies.TextChanged += new System.EventHandler(this.textCopies_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1459, 733);
            this.Controls.Add(this.movie);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.HitBtn);
            this.Controls.Add(this.HitCustBtn);
            this.Controls.Add(this.RentedaBtn);
            this.Controls.Add(this.IssueBtn);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.MovieBtn);
            this.Controls.Add(this.CustBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.customer.ResumeLayout(false);
            this.customer.PerformLayout();
            this.movie.ResumeLayout(false);
            this.movie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HitBtn;
        private System.Windows.Forms.Button HitCustBtn;
        private System.Windows.Forms.Button RentedaBtn;
        private System.Windows.Forms.Button IssueBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button MovieBtn;
        private System.Windows.Forms.Button CustBtn;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.GroupBox customer;
        private System.Windows.Forms.TextBox FNTBox;
        private System.Windows.Forms.TextBox LNTBox;
        private System.Windows.Forms.Button DltCustBtn;
        private System.Windows.Forms.Button UpdCustBtn;
        private System.Windows.Forms.TextBox AdTBox;
        private System.Windows.Forms.Button AddCustBtn;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.TextBox PhTBox;
        private System.Windows.Forms.TextBox CustIDTBox;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.Label LNLabel;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label PhLabel;
        private System.Windows.Forms.Button UpdateMovies;
        private System.Windows.Forms.Label MovieIDLabel;
        private System.Windows.Forms.Button DeleteMovies;
        private System.Windows.Forms.TextBox MovieIDTBox;
        private System.Windows.Forms.Button AddMovies;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Rental_Cost;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label Plot;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox textRental_Cost;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.GroupBox movie;
        private System.Windows.Forms.Label Copies;
        private System.Windows.Forms.TextBox textCopies;
    }
}

