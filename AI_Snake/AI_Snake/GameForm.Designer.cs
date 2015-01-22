namespace AI_Snake
{
    partial class GameForm
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
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.radBreadth = new System.Windows.Forms.RadioButton();
            this.radDepth = new System.Windows.Forms.RadioButton();
            this.RadAStar = new System.Windows.Forms.RadioButton();
            this.radManual = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSnakeLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlOptions.SuspendLayout();
            this.grpMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnakeLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.groupBox1);
            this.pnlOptions.Controls.Add(this.grpMode);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOptions.Location = new System.Drawing.Point(765, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(215, 575);
            this.pnlOptions.TabIndex = 0;
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGame.Location = new System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(765, 575);
            this.pnlGame.TabIndex = 1;
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.radManual);
            this.grpMode.Controls.Add(this.RadAStar);
            this.grpMode.Controls.Add(this.radDepth);
            this.grpMode.Controls.Add(this.radBreadth);
            this.grpMode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpMode.Location = new System.Drawing.Point(0, 420);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(215, 155);
            this.grpMode.TabIndex = 0;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Mode";
            // 
            // radBreadth
            // 
            this.radBreadth.AutoSize = true;
            this.radBreadth.Location = new System.Drawing.Point(7, 22);
            this.radBreadth.Name = "radBreadth";
            this.radBreadth.Size = new System.Drawing.Size(110, 21);
            this.radBreadth.TabIndex = 0;
            this.radBreadth.TabStop = true;
            this.radBreadth.Text = "Breadth First";
            this.radBreadth.UseVisualStyleBackColor = true;
            // 
            // radDepth
            // 
            this.radDepth.AutoSize = true;
            this.radDepth.Location = new System.Drawing.Point(6, 49);
            this.radDepth.Name = "radDepth";
            this.radDepth.Size = new System.Drawing.Size(98, 21);
            this.radDepth.TabIndex = 1;
            this.radDepth.TabStop = true;
            this.radDepth.Text = "Depth First";
            this.radDepth.UseVisualStyleBackColor = true;
            // 
            // RadAStar
            // 
            this.RadAStar.AutoSize = true;
            this.RadAStar.Location = new System.Drawing.Point(6, 76);
            this.RadAStar.Name = "RadAStar";
            this.RadAStar.Size = new System.Drawing.Size(43, 21);
            this.RadAStar.TabIndex = 2;
            this.RadAStar.TabStop = true;
            this.RadAStar.Text = "A*";
            this.RadAStar.UseVisualStyleBackColor = true;
            // 
            // radManual
            // 
            this.radManual.AutoSize = true;
            this.radManual.Location = new System.Drawing.Point(7, 103);
            this.radManual.Name = "radManual";
            this.radManual.Size = new System.Drawing.Size(75, 21);
            this.radManual.TabIndex = 3;
            this.radManual.TabStop = true;
            this.radManual.Text = "Manual";
            this.radManual.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Snake Length";
            // 
            // nudSnakeLength
            // 
            this.nudSnakeLength.Location = new System.Drawing.Point(108, 16);
            this.nudSnakeLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSnakeLength.Name = "nudSnakeLength";
            this.nudSnakeLength.Size = new System.Drawing.Size(101, 22);
            this.nudSnakeLength.TabIndex = 2;
            this.nudSnakeLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudHeight);
            this.groupBox1.Controls.Add(this.nudWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudSnakeLength);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(108, 44);
            this.nudWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(45, 22);
            this.nudWidth.TabIndex = 3;
            this.nudWidth.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(159, 44);
            this.nudHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(50, 22);
            this.nudHeight.TabIndex = 4;
            this.nudHeight.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dimentions";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 575);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlOptions);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameForm";
            this.Text = "Damian\'s Snake Game With AI";
            this.pnlOptions.ResumeLayout(false);
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnakeLength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.RadioButton radManual;
        private System.Windows.Forms.RadioButton RadAStar;
        private System.Windows.Forms.RadioButton radDepth;
        private System.Windows.Forms.RadioButton radBreadth;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.NumericUpDown nudSnakeLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label2;
    }
}

