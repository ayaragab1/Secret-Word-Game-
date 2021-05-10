
namespace serverDevice
{
    partial class ServerConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerConfig));
            this.startGame = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.computerr = new System.Windows.Forms.Button();
            this.animals = new System.Windows.Forms.Button();
            this.game = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hardd = new System.Windows.Forms.Button();
            this.mediumm = new System.Windows.Forms.Button();
            this.easyy = new System.Windows.Forms.Button();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.IndianRed;
            this.startGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.startGame.ForeColor = System.Drawing.Color.Transparent;
            this.startGame.Location = new System.Drawing.Point(608, 565);
            this.startGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(246, 48);
            this.startGame.TabIndex = 40;
            this.startGame.Text = "Continue ";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(521, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 71);
            this.label3.TabIndex = 39;
            this.label3.Text = "Choose Category ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // computerr
            // 
            this.computerr.BackColor = System.Drawing.Color.Maroon;
            this.computerr.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.computerr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.computerr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.computerr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.computerr.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.computerr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.computerr.Location = new System.Drawing.Point(444, 476);
            this.computerr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.computerr.Name = "computerr";
            this.computerr.Size = new System.Drawing.Size(565, 51);
            this.computerr.TabIndex = 38;
            this.computerr.Text = "Computer ";
            this.computerr.UseVisualStyleBackColor = false;
            this.computerr.Click += new System.EventHandler(this.computerr_Click);
            // 
            // animals
            // 
            this.animals.BackColor = System.Drawing.Color.Maroon;
            this.animals.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.animals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.animals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.animals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.animals.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.animals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.animals.Location = new System.Drawing.Point(444, 381);
            this.animals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.animals.Name = "animals";
            this.animals.Size = new System.Drawing.Size(565, 51);
            this.animals.TabIndex = 37;
            this.animals.Text = "Animals ";
            this.animals.UseVisualStyleBackColor = false;
            this.animals.Click += new System.EventHandler(this.animals_Click);
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.Maroon;
            this.game.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.game.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.game.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.game.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.game.Location = new System.Drawing.Point(447, 296);
            this.game.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(565, 51);
            this.game.TabIndex = 36;
            this.game.Text = "Games ";
            this.game.UseVisualStyleBackColor = false;
            this.game.Click += new System.EventHandler(this.game_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(550, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 71);
            this.label2.TabIndex = 35;
            this.label2.Text = "Choose Level ";
            this.label2.Visible = false;
            // 
            // hardd
            // 
            this.hardd.BackColor = System.Drawing.Color.Maroon;
            this.hardd.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.hardd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.hardd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.hardd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hardd.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.hardd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hardd.Location = new System.Drawing.Point(444, 476);
            this.hardd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hardd.Name = "hardd";
            this.hardd.Size = new System.Drawing.Size(565, 51);
            this.hardd.TabIndex = 34;
            this.hardd.Text = "Hard ";
            this.hardd.UseVisualStyleBackColor = false;
            this.hardd.Visible = false;
            this.hardd.Click += new System.EventHandler(this.hardd_Click);
            // 
            // mediumm
            // 
            this.mediumm.BackColor = System.Drawing.Color.Maroon;
            this.mediumm.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.mediumm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.mediumm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mediumm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mediumm.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.mediumm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mediumm.Location = new System.Drawing.Point(444, 381);
            this.mediumm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mediumm.Name = "mediumm";
            this.mediumm.Size = new System.Drawing.Size(565, 51);
            this.mediumm.TabIndex = 33;
            this.mediumm.Text = "Medium ";
            this.mediumm.UseVisualStyleBackColor = false;
            this.mediumm.Visible = false;
            this.mediumm.Click += new System.EventHandler(this.mediumm_Click);
            // 
            // easyy
            // 
            this.easyy.BackColor = System.Drawing.Color.Maroon;
            this.easyy.FlatAppearance.BorderColor = System.Drawing.Color.Pink;
            this.easyy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Pink;
            this.easyy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.easyy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.easyy.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.easyy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.easyy.Location = new System.Drawing.Point(447, 296);
            this.easyy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.easyy.Name = "easyy";
            this.easyy.Size = new System.Drawing.Size(565, 51);
            this.easyy.TabIndex = 32;
            this.easyy.Text = "Easy ";
            this.easyy.UseVisualStyleBackColor = false;
            this.easyy.Visible = false;
            this.easyy.Click += new System.EventHandler(this.easyy_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=\"C# Project\";Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT        Words.*\r\nFROM            Words";
            this.sqlCommand1.Connection = this.sqlConnection1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            // 
            // ServerConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 609);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.computerr);
            this.Controls.Add(this.animals);
            this.Controls.Add(this.game);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hardd);
            this.Controls.Add(this.mediumm);
            this.Controls.Add(this.easyy);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.Name = "ServerConfig";
            this.Text = "ServerConfig";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button computerr;
        private System.Windows.Forms.Button animals;
        private System.Windows.Forms.Button game;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hardd;
        private System.Windows.Forms.Button mediumm;
        private System.Windows.Forms.Button easyy;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label label1;
    }
}