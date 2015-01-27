using System.Windows.Forms;
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudTimerSpeed = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radMixed = new System.Windows.Forms.RadioButton();
            this.radEuclidean = new System.Windows.Forms.RadioButton();
            this.radManhattan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudNumbSnakes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSnakeLength = new System.Windows.Forms.NumericUpDown();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.radManual = new System.Windows.Forms.RadioButton();
            this.RadAStar = new System.Windows.Forms.RadioButton();
            this.radDepth = new System.Windows.Forms.RadioButton();
            this.radBreadth = new System.Windows.Forms.RadioButton();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.stsGame = new System.Windows.Forms.StatusStrip();
            this.lblGameStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbSnakes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnakeLength)).BeginInit();
            this.grpMode.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.stsGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.groupBox3);
            this.pnlOptions.Controls.Add(this.groupBox2);
            this.pnlOptions.Controls.Add(this.groupBox1);
            this.pnlOptions.Controls.Add(this.grpMode);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOptions.Location = new System.Drawing.Point(774, 0);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(215, 478);
            this.pnlOptions.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudTimerSpeed);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 428);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 50);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer Speed";
            // 
            // nudTimerSpeed
            // 
            this.nudTimerSpeed.Location = new System.Drawing.Point(10, 16);
            this.nudTimerSpeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTimerSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimerSpeed.Name = "nudTimerSpeed";
            this.nudTimerSpeed.Size = new System.Drawing.Size(120, 22);
            this.nudTimerSpeed.TabIndex = 0;
            this.nudTimerSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTimerSpeed.ValueChanged += new System.EventHandler(this.nudTimerSpeed_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radMixed);
            this.groupBox2.Controls.Add(this.radEuclidean);
            this.groupBox2.Controls.Add(this.radManhattan);
            this.groupBox2.Location = new System.Drawing.Point(3, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 102);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Heuristic";
            // 
            // radMixed
            // 
            this.radMixed.AutoSize = true;
            this.radMixed.Location = new System.Drawing.Point(7, 77);
            this.radMixed.Name = "radMixed";
            this.radMixed.Size = new System.Drawing.Size(65, 21);
            this.radMixed.TabIndex = 2;
            this.radMixed.TabStop = true;
            this.radMixed.Text = "Mixed";
            this.radMixed.UseVisualStyleBackColor = true;
            // 
            // radEuclidean
            // 
            this.radEuclidean.AutoSize = true;
            this.radEuclidean.Location = new System.Drawing.Point(6, 48);
            this.radEuclidean.Name = "radEuclidean";
            this.radEuclidean.Size = new System.Drawing.Size(91, 21);
            this.radEuclidean.TabIndex = 1;
            this.radEuclidean.TabStop = true;
            this.radEuclidean.Text = "Euclidean";
            this.radEuclidean.UseVisualStyleBackColor = true;
            // 
            // radManhattan
            // 
            this.radManhattan.AutoSize = true;
            this.radManhattan.Location = new System.Drawing.Point(6, 21);
            this.radManhattan.Name = "radManhattan";
            this.radManhattan.Size = new System.Drawing.Size(96, 21);
            this.radManhattan.TabIndex = 0;
            this.radManhattan.TabStop = true;
            this.radManhattan.Text = "Manhattan";
            this.radManhattan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudNumbSnakes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudHeight);
            this.groupBox1.Controls.Add(this.nudWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudSnakeLength);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            // 
            // nudNumbSnakes
            // 
            this.nudNumbSnakes.Location = new System.Drawing.Point(108, 72);
            this.nudNumbSnakes.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumbSnakes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumbSnakes.Name = "nudNumbSnakes";
            this.nudNumbSnakes.Size = new System.Drawing.Size(101, 22);
            this.nudNumbSnakes.TabIndex = 7;
            this.nudNumbSnakes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Snakes";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 100);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(193, 47);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create / Reset";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            // grpMode
            // 
            this.grpMode.Controls.Add(this.radManual);
            this.grpMode.Controls.Add(this.RadAStar);
            this.grpMode.Controls.Add(this.radDepth);
            this.grpMode.Controls.Add(this.radBreadth);
            this.grpMode.Location = new System.Drawing.Point(3, 267);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(212, 129);
            this.grpMode.TabIndex = 0;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Mode";
            // 
            // radManual
            // 
            this.radManual.AutoSize = true;
            this.radManual.Checked = true;
            this.radManual.Location = new System.Drawing.Point(7, 103);
            this.radManual.Name = "radManual";
            this.radManual.Size = new System.Drawing.Size(75, 21);
            this.radManual.TabIndex = 3;
            this.radManual.TabStop = true;
            this.radManual.Text = "Manual";
            this.radManual.UseVisualStyleBackColor = true;
            // 
            // RadAStar
            // 
            this.RadAStar.AutoSize = true;
            this.RadAStar.Location = new System.Drawing.Point(6, 76);
            this.RadAStar.Name = "RadAStar";
            this.RadAStar.Size = new System.Drawing.Size(43, 21);
            this.RadAStar.TabIndex = 2;
            this.RadAStar.Text = "A*";
            this.RadAStar.UseVisualStyleBackColor = true;
            // 
            // radDepth
            // 
            this.radDepth.AutoSize = true;
            this.radDepth.Location = new System.Drawing.Point(6, 49);
            this.radDepth.Name = "radDepth";
            this.radDepth.Size = new System.Drawing.Size(98, 21);
            this.radDepth.TabIndex = 1;
            this.radDepth.Text = "Depth First";
            this.radDepth.UseVisualStyleBackColor = true;
            // 
            // radBreadth
            // 
            this.radBreadth.AutoSize = true;
            this.radBreadth.Location = new System.Drawing.Point(7, 22);
            this.radBreadth.Name = "radBreadth";
            this.radBreadth.Size = new System.Drawing.Size(110, 21);
            this.radBreadth.TabIndex = 0;
            this.radBreadth.Text = "Breadth First";
            this.radBreadth.UseVisualStyleBackColor = true;
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlGame.Controls.Add(this.stsGame);
            this.pnlGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGame.Location = new System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(774, 478);
            this.pnlGame.TabIndex = 1;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // stsGame
            // 
            this.stsGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGameStatus});
            this.stsGame.Location = new System.Drawing.Point(0, 456);
            this.stsGame.Name = "stsGame";
            this.stsGame.Size = new System.Drawing.Size(774, 22);
            this.stsGame.TabIndex = 0;
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 478);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlOptions);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "Damian\'s Snake Game With AI";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GameForm_KeyPress);
            this.pnlOptions.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbSnakes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSnakeLength)).EndInit();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.stsGame.ResumeLayout(false);
            this.stsGame.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radMixed;
        private System.Windows.Forms.RadioButton radEuclidean;
        private System.Windows.Forms.RadioButton radManhattan;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudTimerSpeed;
        private System.Windows.Forms.Timer tmrGameAI;
        private System.Windows.Forms.NumericUpDown nudNumbSnakes;
        private System.Windows.Forms.Label label3;
        private StatusStrip stsGame;
        private ToolStripStatusLabel lblGameStatus;
    }
}

