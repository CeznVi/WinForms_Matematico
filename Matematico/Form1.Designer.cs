﻿namespace Matematico
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
            statusStrip = new StatusStrip();
            toolStripStatusLabel_info = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            gameFieldControl_Player = new GameFieldControl.GameFieldControl();
            gameFieldControl_Computer = new GameFieldControl.GameFieldControl();
            Player = new Label();
            Computer = new Label();
            button_nextNumber = new Button();
            statusStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_info });
            statusStrip.Location = new Point(0, 507);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(928, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_info
            // 
            toolStripStatusLabel_info.Name = "toolStripStatusLabel_info";
            toolStripStatusLabel_info.Size = new Size(95, 17);
            toolStripStatusLabel_info.Text = "Инициализация";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(928, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // gameFieldControl_Player
            // 
            gameFieldControl_Player.BackColor = SystemColors.ActiveCaption;
            gameFieldControl_Player.Location = new Point(0, 73);
            gameFieldControl_Player.Name = "gameFieldControl_Player";
            gameFieldControl_Player.Size = new Size(400, 400);
            gameFieldControl_Player.TabIndex = 2;
            // 
            // gameFieldControl_Computer
            // 
            gameFieldControl_Computer.BackColor = SystemColors.ActiveCaption;
            gameFieldControl_Computer.Location = new Point(527, 73);
            gameFieldControl_Computer.Name = "gameFieldControl_Computer";
            gameFieldControl_Computer.Size = new Size(400, 400);
            gameFieldControl_Computer.TabIndex = 3;
            // 
            // Player
            // 
            Player.AutoSize = true;
            Player.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Player.Location = new Point(153, 24);
            Player.Name = "Player";
            Player.Size = new Size(89, 37);
            Player.TabIndex = 4;
            Player.Text = "Player";
            // 
            // Computer
            // 
            Computer.AutoSize = true;
            Computer.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Computer.Location = new Point(652, 24);
            Computer.Name = "Computer";
            Computer.Size = new Size(136, 37);
            Computer.TabIndex = 5;
            Computer.Text = "Computer";
            // 
            // button_nextNumber
            // 
            button_nextNumber.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            button_nextNumber.Location = new Point(419, 73);
            button_nextNumber.Margin = new Padding(15);
            button_nextNumber.Name = "button_nextNumber";
            button_nextNumber.Size = new Size(90, 90);
            button_nextNumber.TabIndex = 6;
            button_nextNumber.Text = "13";
            button_nextNumber.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 529);
            Controls.Add(button_nextNumber);
            Controls.Add(Computer);
            Controls.Add(Player);
            Controls.Add(gameFieldControl_Computer);
            Controls.Add(gameFieldControl_Player);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel_info;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private GameFieldControl.GameFieldControl gameFieldControl_Player;
        private GameFieldControl.GameFieldControl gameFieldControl_Computer;
        private Label Player;
        private Label Computer;
        private Button button_nextNumber;
    }
}