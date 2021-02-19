
namespace MontyHallRecreate
{
    partial class MontyHall
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
            this.door_1 = new System.Windows.Forms.PictureBox();
            this.door_2 = new System.Windows.Forms.PictureBox();
            this.door_3 = new System.Windows.Forms.PictureBox();
            this.wins_label = new System.Windows.Forms.Label();
            this.losses_label = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.cbxModeSelection = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.door_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_3)).BeginInit();
            this.SuspendLayout();
            // 
            // door_1
            // 
            this.door_1.Location = new System.Drawing.Point(14, 44);
            this.door_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.door_1.Name = "door_1";
            this.door_1.Size = new System.Drawing.Size(271, 325);
            this.door_1.TabIndex = 0;
            this.door_1.TabStop = false;
            // 
            // door_2
            // 
            this.door_2.Location = new System.Drawing.Point(337, 44);
            this.door_2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.door_2.Name = "door_2";
            this.door_2.Size = new System.Drawing.Size(271, 325);
            this.door_2.TabIndex = 1;
            this.door_2.TabStop = false;
            // 
            // door_3
            // 
            this.door_3.Location = new System.Drawing.Point(649, 44);
            this.door_3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.door_3.Name = "door_3";
            this.door_3.Size = new System.Drawing.Size(271, 325);
            this.door_3.TabIndex = 2;
            this.door_3.TabStop = false;
            // 
            // wins_label
            // 
            this.wins_label.AutoSize = true;
            this.wins_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wins_label.Location = new System.Drawing.Point(356, 399);
            this.wins_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wins_label.Name = "wins_label";
            this.wins_label.Size = new System.Drawing.Size(66, 25);
            this.wins_label.TabIndex = 3;
            this.wins_label.Text = "Wins:";
            // 
            // losses_label
            // 
            this.losses_label.AutoSize = true;
            this.losses_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.losses_label.Location = new System.Drawing.Point(331, 453);
            this.losses_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.losses_label.Name = "losses_label";
            this.losses_label.Size = new System.Drawing.Size(87, 25);
            this.losses_label.TabIndex = 4;
            this.losses_label.Text = "Losses:";
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start_button.Location = new System.Drawing.Point(14, 399);
            this.start_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(271, 106);
            this.start_button.TabIndex = 5;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // stop_button
            // 
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stop_button.Location = new System.Drawing.Point(649, 396);
            this.stop_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(271, 106);
            this.stop_button.TabIndex = 6;
            this.stop_button.Text = "STOP";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // cbxModeSelection
            // 
            this.cbxModeSelection.FormattingEnabled = true;
            this.cbxModeSelection.Location = new System.Drawing.Point(799, 12);
            this.cbxModeSelection.Name = "cbxModeSelection";
            this.cbxModeSelection.Size = new System.Drawing.Size(121, 23);
            this.cbxModeSelection.TabIndex = 7;
            this.cbxModeSelection.Text = "Stay";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset Score";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MontyHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbxModeSelection);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.losses_label);
            this.Controls.Add(this.wins_label);
            this.Controls.Add(this.door_3);
            this.Controls.Add(this.door_2);
            this.Controls.Add(this.door_1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MontyHall";
            this.Text = "Monty Hall Test";
            ((System.ComponentModel.ISupportInitialize)(this.door_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox door_1;
        private System.Windows.Forms.PictureBox door_2;
        private System.Windows.Forms.PictureBox door_3;
        private System.Windows.Forms.Label wins_label;
        private System.Windows.Forms.Label losses_label;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.ComboBox cbxModeSelection;
        private System.Windows.Forms.Button btnReset;
    }
}



