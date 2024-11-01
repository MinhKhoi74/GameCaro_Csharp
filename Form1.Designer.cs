namespace Game_Caro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlChessBeard = new Panel();
            pctbAvatar = new PictureBox();
            NewGame_btn = new Button();
            panel2 = new Panel();
            pctbXO = new PictureBox();
            lbNameXO = new Label();
            lbRole = new Label();
            panel3 = new Panel();
            label1 = new Label();
            Quit_btn = new Button();
            Undo_btn = new Button();
            lbLoading = new Label();
            btnLan = new Button();
            pctbMark = new PictureBox();
            prcbCoolDown = new ProgressBar();
            txbIP = new TextBox();
            txbPlayerName = new TextBox();
            tmCoolDown = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbXO).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).BeginInit();
            SuspendLayout();
            // 
            // pnlChessBeard
            // 
            pnlChessBeard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlChessBeard.BackColor = SystemColors.Control;
            pnlChessBeard.Location = new Point(12, 12);
            pnlChessBeard.Name = "pnlChessBeard";
            pnlChessBeard.Size = new Size(863, 451);
            pnlChessBeard.TabIndex = 0;
            pnlChessBeard.Paint += pnlChessBeard_Paint;
            pnlChessBeard.DoubleClick += pnlChessBeard_DoubleClick;
            pnlChessBeard.Resize += pnlChessBeard_Resize;
            pnlChessBeard.SystemColorsChanged += pnlChessBeard_SystemColorsChanged;
            // 
            // pctbAvatar
            // 
            pctbAvatar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pctbAvatar.BackgroundImage = Properties.Resources.xo;
            pctbAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            pctbAvatar.Location = new Point(20, 7);
            pctbAvatar.Name = "pctbAvatar";
            pctbAvatar.Size = new Size(79, 79);
            pctbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbAvatar.TabIndex = 0;
            pctbAvatar.TabStop = false;
            // 
            // NewGame_btn
            // 
            NewGame_btn.BackColor = SystemColors.ControlLight;
            NewGame_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NewGame_btn.Location = new Point(23, 12);
            NewGame_btn.Name = "NewGame_btn";
            NewGame_btn.Size = new Size(104, 39);
            NewGame_btn.TabIndex = 0;
            NewGame_btn.Text = "New game";
            NewGame_btn.UseVisualStyleBackColor = false;
            NewGame_btn.Click += NewGame_btn_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pctbAvatar);
            panel2.Controls.Add(pctbXO);
            panel2.Controls.Add(lbNameXO);
            panel2.Controls.Add(lbRole);
            panel2.Location = new Point(12, 473);
            panel2.Name = "panel2";
            panel2.Size = new Size(114, 114);
            panel2.TabIndex = 0;
            // 
            // pctbXO
            // 
            pctbXO.BackColor = SystemColors.ButtonHighlight;
            pctbXO.Location = new Point(66, 89);
            pctbXO.Name = "pctbXO";
            pctbXO.Size = new Size(25, 25);
            pctbXO.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbXO.TabIndex = 4;
            pctbXO.TabStop = false;
            pctbXO.Click += pctbXO_Click;
            // 
            // lbNameXO
            // 
            lbNameXO.AutoSize = true;
            lbNameXO.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbNameXO.Location = new Point(6, 89);
            lbNameXO.Name = "lbNameXO";
            lbNameXO.Size = new Size(0, 18);
            lbNameXO.TabIndex = 4;
            // 
            // lbRole
            // 
            lbRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbRole.ForeColor = Color.Crimson;
            lbRole.Location = new Point(20, 2);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(0, 25);
            lbRole.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(Quit_btn);
            panel3.Controls.Add(Undo_btn);
            panel3.Controls.Add(NewGame_btn);
            panel3.Controls.Add(lbLoading);
            panel3.Controls.Add(btnLan);
            panel3.Controls.Add(pctbMark);
            panel3.Controls.Add(prcbCoolDown);
            panel3.Controls.Add(txbIP);
            panel3.Controls.Add(txbPlayerName);
            panel3.Location = new Point(132, 473);
            panel3.Name = "panel3";
            panel3.Size = new Size(743, 114);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(635, 7);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Lượt chơi";
            // 
            // Quit_btn
            // 
            Quit_btn.BackColor = SystemColors.ControlLight;
            Quit_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Quit_btn.Location = new Point(133, 12);
            Quit_btn.Name = "Quit_btn";
            Quit_btn.Size = new Size(104, 39);
            Quit_btn.TabIndex = 0;
            Quit_btn.Text = "Quit";
            Quit_btn.UseVisualStyleBackColor = false;
            Quit_btn.Click += Quit_btn_Click;
            // 
            // Undo_btn
            // 
            Undo_btn.BackColor = SystemColors.ControlLight;
            Undo_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Undo_btn.Location = new Point(78, 57);
            Undo_btn.Name = "Undo_btn";
            Undo_btn.Size = new Size(104, 39);
            Undo_btn.TabIndex = 0;
            Undo_btn.Text = "Undo";
            Undo_btn.UseVisualStyleBackColor = false;
            Undo_btn.Click += Undo_btn_Click;
            // 
            // lbLoading
            // 
            lbLoading.AutoSize = true;
            lbLoading.Location = new Point(355, 50);
            lbLoading.Name = "lbLoading";
            lbLoading.Size = new Size(0, 20);
            lbLoading.TabIndex = 4;
            // 
            // btnLan
            // 
            btnLan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLan.Location = new Point(395, 78);
            btnLan.Name = "btnLan";
            btnLan.Size = new Size(94, 29);
            btnLan.TabIndex = 3;
            btnLan.Text = "LAN";
            btnLan.UseVisualStyleBackColor = true;
            btnLan.Click += btnLan_Click;
            // 
            // pctbMark
            // 
            pctbMark.Location = new Point(636, 30);
            pctbMark.Name = "pctbMark";
            pctbMark.Size = new Size(71, 71);
            pctbMark.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbMark.TabIndex = 2;
            pctbMark.TabStop = false;
            // 
            // prcbCoolDown
            // 
            prcbCoolDown.Location = new Point(495, 45);
            prcbCoolDown.Name = "prcbCoolDown";
            prcbCoolDown.Size = new Size(105, 29);
            prcbCoolDown.TabIndex = 1;
            // 
            // txbIP
            // 
            txbIP.Location = new Point(495, 80);
            txbIP.Name = "txbIP";
            txbIP.Size = new Size(105, 27);
            txbIP.TabIndex = 0;
            txbIP.Text = "127.0.0.1";
            // 
            // txbPlayerName
            // 
            txbPlayerName.Location = new Point(495, 12);
            txbPlayerName.Name = "txbPlayerName";
            txbPlayerName.ReadOnly = true;
            txbPlayerName.Size = new Size(105, 27);
            txbPlayerName.TabIndex = 0;
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(887, 599);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlChessBeard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Game Caro";
            FormClosing += Form1_FormClosed;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)pctbAvatar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbXO).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbMark).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlChessBeard;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pctbAvatar;
        private PictureBox pctbMark;
        private ProgressBar prcbCoolDown;
        private TextBox textBox2;
        private TextBox txbPlayerName;
        private Button btnLan;
        private PictureBox pictureBox2;
        private TextBox txbIP;
        private Label lbRole;
        private System.Windows.Forms.Timer tmCoolDown;
        private Label lbNameXO;
        private PictureBox pctbXO;
        private Label lbLoading;
        private Button NewGame_btn;
        private Button Undo_btn;
        private Button Quit_btn;
        private Label label1;
    }
}