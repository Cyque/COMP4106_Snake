using System.Windows.Forms;
namespace AI_Snake
{
    partial class OthelloGameForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkP2AB = new System.Windows.Forms.CheckBox();
            this.radP2Other = new System.Windows.Forms.RadioButton();
            this.radP2BW = new System.Windows.Forms.RadioButton();
            this.radP2Player = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudTimerSpeed = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkP1AB = new System.Windows.Forms.CheckBox();
            this.radP1Other = new System.Windows.Forms.RadioButton();
            this.radP1BW = new System.Windows.Forms.RadioButton();
            this.radP1Player = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.stsGame = new System.Windows.Forms.StatusStrip();
            this.lblGameStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrGameAI = new System.Windows.Forms.Timer(this.components);
            this.btnExecAI = new System.Windows.Forms.Button();
            this.pnlOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlGame.SuspendLayout();
            this.stsGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.btnExecAI);
            this.pnlOptions.Controls.Add(this.groupBox1);
            this.pnlOptions.Controls.Add(this.groupBox3);
            this.pnlOptions.Controls.Add(this.groupBox2);
            this.pnlOptions.Controls.Add(this.btnCreate);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOptions.Location = new System.Drawing.Point(581, 0);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(161, 504);
            this.pnlOptions.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkP2AB);
            this.groupBox1.Controls.Add(this.radP2Other);
            this.groupBox1.Controls.Add(this.radP2BW);
            this.groupBox1.Controls.Add(this.radP2Player);
            this.groupBox1.Location = new System.Drawing.Point(4, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(159, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player 2";
            // 
            // chkP2AB
            // 
            this.chkP2AB.AutoSize = true;
            this.chkP2AB.Location = new System.Drawing.Point(4, 82);
            this.chkP2AB.Name = "chkP2AB";
            this.chkP2AB.Size = new System.Drawing.Size(100, 17);
            this.chkP2AB.TabIndex = 3;
            this.chkP2AB.Text = "Use Alpha Beta";
            this.chkP2AB.UseVisualStyleBackColor = true;
            // 
            // radP2Other
            // 
            this.radP2Other.AutoSize = true;
            this.radP2Other.Location = new System.Drawing.Point(4, 60);
            this.radP2Other.Margin = new System.Windows.Forms.Padding(2);
            this.radP2Other.Name = "radP2Other";
            this.radP2Other.Size = new System.Drawing.Size(98, 17);
            this.radP2Other.TabIndex = 2;
            this.radP2Other.Text = "Minimax - Other";
            this.radP2Other.UseVisualStyleBackColor = true;
            // 
            // radP2BW
            // 
            this.radP2BW.AutoSize = true;
            this.radP2BW.Location = new System.Drawing.Point(4, 39);
            this.radP2BW.Margin = new System.Windows.Forms.Padding(2);
            this.radP2BW.Name = "radP2BW";
            this.radP2BW.Size = new System.Drawing.Size(90, 17);
            this.radP2BW.TabIndex = 1;
            this.radP2BW.Text = "Minimax - BW";
            this.radP2BW.UseVisualStyleBackColor = true;
            // 
            // radP2Player
            // 
            this.radP2Player.AutoSize = true;
            this.radP2Player.Checked = true;
            this.radP2Player.Location = new System.Drawing.Point(4, 17);
            this.radP2Player.Margin = new System.Windows.Forms.Padding(2);
            this.radP2Player.Name = "radP2Player";
            this.radP2Player.Size = new System.Drawing.Size(54, 17);
            this.radP2Player.TabIndex = 0;
            this.radP2Player.TabStop = true;
            this.radP2Player.Text = "Player";
            this.radP2Player.UseVisualStyleBackColor = true;
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
            this.groupBox2.Controls.Add(this.chkP1AB);
            this.groupBox2.Controls.Add(this.radP1Other);
            this.groupBox2.Controls.Add(this.radP1BW);
            this.groupBox2.Controls.Add(this.radP1Player);
            this.groupBox2.Location = new System.Drawing.Point(2, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(159, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 1";
            // 
            // chkP1AB
            // 
            this.chkP1AB.AutoSize = true;
            this.chkP1AB.Location = new System.Drawing.Point(4, 82);
            this.chkP1AB.Name = "chkP1AB";
            this.chkP1AB.Size = new System.Drawing.Size(100, 17);
            this.chkP1AB.TabIndex = 3;
            this.chkP1AB.Text = "Use Alpha Beta";
            this.chkP1AB.UseVisualStyleBackColor = true;
            // 
            // radP1Other
            // 
            this.radP1Other.AutoSize = true;
            this.radP1Other.Location = new System.Drawing.Point(4, 60);
            this.radP1Other.Margin = new System.Windows.Forms.Padding(2);
            this.radP1Other.Name = "radP1Other";
            this.radP1Other.Size = new System.Drawing.Size(98, 17);
            this.radP1Other.TabIndex = 2;
            this.radP1Other.Text = "Minimax - Other";
            this.radP1Other.UseVisualStyleBackColor = true;
            // 
            // radP1BW
            // 
            this.radP1BW.AutoSize = true;
            this.radP1BW.Location = new System.Drawing.Point(4, 39);
            this.radP1BW.Margin = new System.Windows.Forms.Padding(2);
            this.radP1BW.Name = "radP1BW";
            this.radP1BW.Size = new System.Drawing.Size(90, 17);
            this.radP1BW.TabIndex = 1;
            this.radP1BW.Text = "Minimax - BW";
            this.radP1BW.UseVisualStyleBackColor = true;
            // 
            // radP1Player
            // 
            this.radP1Player.AutoSize = true;
            this.radP1Player.Checked = true;
            this.radP1Player.Location = new System.Drawing.Point(4, 17);
            this.radP1Player.Margin = new System.Windows.Forms.Padding(2);
            this.radP1Player.Name = "radP1Player";
            this.radP1Player.Size = new System.Drawing.Size(54, 17);
            this.radP1Player.TabIndex = 0;
            this.radP1Player.TabStop = true;
            this.radP1Player.Text = "Player";
            this.radP1Player.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(8, 298);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(145, 38);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create / Reset";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            this.pnlGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseClick);
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
            // btnExecAI
            // 
            this.btnExecAI.Location = new System.Drawing.Point(8, 243);
            this.btnExecAI.Name = "btnExecAI";
            this.btnExecAI.Size = new System.Drawing.Size(145, 23);
            this.btnExecAI.TabIndex = 6;
            this.btnExecAI.Text = "Exec AI";
            this.btnExecAI.UseVisualStyleBackColor = true;
            this.btnExecAI.Click += new System.EventHandler(this.btnExecAI_Click);
            // 
            // OthelloGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 504);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlOptions);
            this.KeyPreview = true;
            this.Name = "OthelloGameForm";
            this.Text = "Damian\'s Snake Game With AI";
            this.pnlOptions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.stsGame.ResumeLayout(false);
            this.stsGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radP1BW;
        private System.Windows.Forms.RadioButton radP1Player;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudTimerSpeed;
        private StatusStrip stsGame;
        private ToolStripStatusLabel lblGameStatus;
        private Timer tmrGameAI;
        private CheckBox chkP1AB;
        private RadioButton radP1Other;
        private GroupBox groupBox1;
        private CheckBox chkP2AB;
        private RadioButton radP2Other;
        private RadioButton radP2BW;
        private RadioButton radP2Player;
        private Button btnExecAI;
    }
}

