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
            this.components = new System.ComponentModel.Container();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudTimerSpeed = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radModMan = new System.Windows.Forms.RadioButton();
            this.radMixed = new System.Windows.Forms.RadioButton();
            this.radEuclidean = new System.Windows.Forms.RadioButton();
            this.radManhattan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudBlocks = new System.Windows.Forms.NumericUpDown();
            this.lblblocks = new System.Windows.Forms.Label();
            this.nudNumbSnakes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSnakeLength = new System.Windows.Forms.NumericUpDown();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.btnAI = new System.Windows.Forms.Button();
            this.radManual = new System.Windows.Forms.RadioButton();
            this.RadAStar = new System.Windows.Forms.RadioButton();
            this.radDepth = new System.Windows.Forms.RadioButton();
            this.radBreadth = new System.Windows.Forms.RadioButton();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.stsGame = new System.Windows.Forms.StatusStrip();
            this.lblGameStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrGameAI = new System.Windows.Forms.Timer(this.components);
            this.radClosestToCenter = new System.Windows.Forms.RadioButton();
            this.pnlOptions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlocks)).BeginInit();
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
            this.pnlOptions.Location = new System.Drawing.Point(581, 0);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(161, 504);
            this.pnlOptions.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudTimerSpeed);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 463);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(161, 41);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer Speed";
            // 
            // nudTimerSpeed
            // 
            this.nudTimerSpeed.Location = new System.Drawing.Point(8, 13);
            this.nudTimerSpeed.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudTimerSpeed.Size = new System.Drawing.Size(90, 20);
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
            this.groupBox2.Controls.Add(this.radClosestToCenter);
            this.groupBox2.Controls.Add(this.radModMan);
            this.groupBox2.Controls.Add(this.radMixed);
            this.groupBox2.Controls.Add(this.radEuclidean);
            this.groupBox2.Controls.Add(this.radManhattan);
            this.groupBox2.Location = new System.Drawing.Point(2, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(159, 132);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Heuristic";
            // 
            // radModMan
            // 
            this.radModMan.AutoSize = true;
            this.radModMan.Location = new System.Drawing.Point(4, 79);
            this.radModMan.Margin = new System.Windows.Forms.Padding(2);
            this.radModMan.Name = "radModMan";
            this.radModMan.Size = new System.Drawing.Size(111, 17);
            this.radModMan.TabIndex = 3;
            this.radModMan.Text = "Best First (mod A*)";
            this.radModMan.UseVisualStyleBackColor = true;
            // 
            // radMixed
            // 
            this.radMixed.AutoSize = true;
            this.radMixed.Location = new System.Drawing.Point(4, 100);
            this.radMixed.Margin = new System.Windows.Forms.Padding(2);
            this.radMixed.Name = "radMixed";
            this.radMixed.Size = new System.Drawing.Size(53, 17);
            this.radMixed.TabIndex = 2;
            this.radMixed.Text = "Mixed";
            this.radMixed.UseVisualStyleBackColor = true;
            // 
            // radEuclidean
            // 
            this.radEuclidean.AutoSize = true;
            this.radEuclidean.Location = new System.Drawing.Point(4, 39);
            this.radEuclidean.Margin = new System.Windows.Forms.Padding(2);
            this.radEuclidean.Name = "radEuclidean";
            this.radEuclidean.Size = new System.Drawing.Size(72, 17);
            this.radEuclidean.TabIndex = 1;
            this.radEuclidean.Text = "Euclidean";
            this.radEuclidean.UseVisualStyleBackColor = true;
            // 
            // radManhattan
            // 
            this.radManhattan.AutoSize = true;
            this.radManhattan.Checked = true;
            this.radManhattan.Location = new System.Drawing.Point(4, 17);
            this.radManhattan.Margin = new System.Windows.Forms.Padding(2);
            this.radManhattan.Name = "radManhattan";
            this.radManhattan.Size = new System.Drawing.Size(76, 17);
            this.radManhattan.TabIndex = 0;
            this.radManhattan.TabStop = true;
            this.radManhattan.Text = "Manhattan";
            this.radManhattan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudBlocks);
            this.groupBox1.Controls.Add(this.lblblocks);
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(161, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            // 
            // nudBlocks
            // 
            this.nudBlocks.Location = new System.Drawing.Point(81, 81);
            this.nudBlocks.Margin = new System.Windows.Forms.Padding(2);
            this.nudBlocks.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudBlocks.Name = "nudBlocks";
            this.nudBlocks.Size = new System.Drawing.Size(76, 20);
            this.nudBlocks.TabIndex = 9;
            this.nudBlocks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblblocks
            // 
            this.lblblocks.AutoSize = true;
            this.lblblocks.Location = new System.Drawing.Point(4, 83);
            this.lblblocks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblblocks.Name = "lblblocks";
            this.lblblocks.Size = new System.Drawing.Size(49, 13);
            this.lblblocks.TabIndex = 8;
            this.lblblocks.Text = "# Blocks";
            // 
            // nudNumbSnakes
            // 
            this.nudNumbSnakes.Location = new System.Drawing.Point(81, 58);
            this.nudNumbSnakes.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudNumbSnakes.Size = new System.Drawing.Size(76, 20);
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
            this.label3.Location = new System.Drawing.Point(4, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Snakes";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(8, 104);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(145, 38);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create / Reset";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dimentions";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(119, 36);
            this.nudHeight.Margin = new System.Windows.Forms.Padding(2);
            this.nudHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(38, 20);
            this.nudHeight.TabIndex = 4;
            this.nudHeight.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(81, 36);
            this.nudWidth.Margin = new System.Windows.Forms.Padding(2);
            this.nudWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(34, 20);
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
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Snake Length";
            // 
            // nudSnakeLength
            // 
            this.nudSnakeLength.Location = new System.Drawing.Point(81, 13);
            this.nudSnakeLength.Margin = new System.Windows.Forms.Padding(2);
            this.nudSnakeLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSnakeLength.Name = "nudSnakeLength";
            this.nudSnakeLength.Size = new System.Drawing.Size(76, 20);
            this.nudSnakeLength.TabIndex = 2;
            this.nudSnakeLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.btnAI);
            this.grpMode.Controls.Add(this.radManual);
            this.grpMode.Controls.Add(this.RadAStar);
            this.grpMode.Controls.Add(this.radDepth);
            this.grpMode.Controls.Add(this.radBreadth);
            this.grpMode.Location = new System.Drawing.Point(4, 319);
            this.grpMode.Margin = new System.Windows.Forms.Padding(2);
            this.grpMode.Name = "grpMode";
            this.grpMode.Padding = new System.Windows.Forms.Padding(2);
            this.grpMode.Size = new System.Drawing.Size(159, 140);
            this.grpMode.TabIndex = 0;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Mode";
            // 
            // btnAI
            // 
            this.btnAI.Location = new System.Drawing.Point(4, 105);
            this.btnAI.Margin = new System.Windows.Forms.Padding(2);
            this.btnAI.Name = "btnAI";
            this.btnAI.Size = new System.Drawing.Size(151, 27);
            this.btnAI.TabIndex = 10;
            this.btnAI.Text = "Evaluate AI";
            this.btnAI.UseVisualStyleBackColor = true;
            this.btnAI.Click += new System.EventHandler(this.btnAI_Click);
            // 
            // radManual
            // 
            this.radManual.AutoSize = true;
            this.radManual.Checked = true;
            this.radManual.Location = new System.Drawing.Point(5, 84);
            this.radManual.Margin = new System.Windows.Forms.Padding(2);
            this.radManual.Name = "radManual";
            this.radManual.Size = new System.Drawing.Size(60, 17);
            this.radManual.TabIndex = 3;
            this.radManual.TabStop = true;
            this.radManual.Text = "Manual";
            this.radManual.UseVisualStyleBackColor = true;
            // 
            // RadAStar
            // 
            this.RadAStar.AutoSize = true;
            this.RadAStar.Location = new System.Drawing.Point(4, 62);
            this.RadAStar.Margin = new System.Windows.Forms.Padding(2);
            this.RadAStar.Name = "RadAStar";
            this.RadAStar.Size = new System.Drawing.Size(36, 17);
            this.RadAStar.TabIndex = 2;
            this.RadAStar.Text = "A*";
            this.RadAStar.UseVisualStyleBackColor = true;
            // 
            // radDepth
            // 
            this.radDepth.AutoSize = true;
            this.radDepth.Location = new System.Drawing.Point(4, 40);
            this.radDepth.Margin = new System.Windows.Forms.Padding(2);
            this.radDepth.Name = "radDepth";
            this.radDepth.Size = new System.Drawing.Size(76, 17);
            this.radDepth.TabIndex = 1;
            this.radDepth.Text = "Depth First";
            this.radDepth.UseVisualStyleBackColor = true;
            // 
            // radBreadth
            // 
            this.radBreadth.AutoSize = true;
            this.radBreadth.Location = new System.Drawing.Point(5, 18);
            this.radBreadth.Margin = new System.Windows.Forms.Padding(2);
            this.radBreadth.Name = "radBreadth";
            this.radBreadth.Size = new System.Drawing.Size(84, 17);
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
            this.pnlGame.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(581, 504);
            this.pnlGame.TabIndex = 1;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // stsGame
            // 
            this.stsGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblGameStatus});
            this.stsGame.Location = new System.Drawing.Point(0, 482);
            this.stsGame.Name = "stsGame";
            this.stsGame.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.stsGame.Size = new System.Drawing.Size(581, 22);
            this.stsGame.TabIndex = 0;
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tmrGameAI
            // 
            this.tmrGameAI.Enabled = true;
            this.tmrGameAI.Tick += new System.EventHandler(this.tmrGameAI_Tick);
            // 
            // radClosestToCenter
            // 
            this.radClosestToCenter.AutoSize = true;
            this.radClosestToCenter.Location = new System.Drawing.Point(4, 58);
            this.radClosestToCenter.Margin = new System.Windows.Forms.Padding(2);
            this.radClosestToCenter.Name = "radClosestToCenter";
            this.radClosestToCenter.Size = new System.Drawing.Size(109, 17);
            this.radClosestToCenter.TabIndex = 4;
            this.radClosestToCenter.Text = "Closest To Center";
            this.radClosestToCenter.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 504);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlOptions);
            this.KeyPreview = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.nudBlocks)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nudNumbSnakes;
        private System.Windows.Forms.Label label3;
        private StatusStrip stsGame;
        private ToolStripStatusLabel lblGameStatus;
        private NumericUpDown nudBlocks;
        private Label lblblocks;
        private Timer tmrGameAI;
        private Button btnAI;
        private RadioButton radModMan;
        private RadioButton radClosestToCenter;
    }
}

