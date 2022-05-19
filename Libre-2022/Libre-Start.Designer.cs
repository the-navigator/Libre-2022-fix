namespace Libre_2022
{
    partial class Libre_Home
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
            this.dashBoard_searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // dashBoard_searchTextBox
            // 
            this.dashBoard_searchTextBox.Animated = true;
            this.dashBoard_searchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.dashBoard_searchTextBox.BorderColor = System.Drawing.Color.Black;
            this.dashBoard_searchTextBox.BorderRadius = 12;
            this.dashBoard_searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dashBoard_searchTextBox.DefaultText = "";
            this.dashBoard_searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.dashBoard_searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.dashBoard_searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dashBoard_searchTextBox.DisabledState.Parent = this.dashBoard_searchTextBox;
            this.dashBoard_searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.dashBoard_searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.dashBoard_searchTextBox.FocusedState.Parent = this.dashBoard_searchTextBox;
            this.dashBoard_searchTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dashBoard_searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.dashBoard_searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.dashBoard_searchTextBox.HoverState.Parent = this.dashBoard_searchTextBox;
            this.dashBoard_searchTextBox.IconLeft = global::Libre_2022.Properties.Resources.search_96px;
            this.dashBoard_searchTextBox.IconLeftOffset = new System.Drawing.Point(5, 1);
            this.dashBoard_searchTextBox.Location = new System.Drawing.Point(26, 27);
            this.dashBoard_searchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashBoard_searchTextBox.Name = "dashBoard_searchTextBox";
            this.dashBoard_searchTextBox.PasswordChar = '\0';
            this.dashBoard_searchTextBox.PlaceholderForeColor = System.Drawing.Color.RoyalBlue;
            this.dashBoard_searchTextBox.PlaceholderText = "Search...";
            this.dashBoard_searchTextBox.SelectedText = "";
            this.dashBoard_searchTextBox.ShadowDecoration.Parent = this.dashBoard_searchTextBox;
            this.dashBoard_searchTextBox.Size = new System.Drawing.Size(391, 27);
            this.dashBoard_searchTextBox.TabIndex = 4;
            this.dashBoard_searchTextBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // Libre_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 509);
            this.Controls.Add(this.dashBoard_searchTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Libre_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Libre";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox dashBoard_searchTextBox;
    }
}