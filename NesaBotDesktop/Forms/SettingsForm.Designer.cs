﻿namespace NesaBotDesktop {
  partial class SettingsForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.lb_interval = new System.Windows.Forms.Label();
      this.lb_title = new System.Windows.Forms.Label();
      this.ns_interval = new System.Windows.Forms.NumericUpDown();
      this.lb_activateDiscordBot = new System.Windows.Forms.Label();
      this.cb_activateDiscordBot = new System.Windows.Forms.CheckBox();
      this.lb_autostart = new System.Windows.Forms.Label();
      this.cb_autostart = new System.Windows.Forms.CheckBox();
      this.lb_botToken = new System.Windows.Forms.Label();
      this.tb_botToken = new System.Windows.Forms.TextBox();
      this.lb_pushNotifications = new System.Windows.Forms.Label();
      this.cb_pushNotifications = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.ns_interval)).BeginInit();
      this.SuspendLayout();
      // 
      // lb_interval
      // 
      this.lb_interval.AutoSize = true;
      this.lb_interval.Location = new System.Drawing.Point(12, 68);
      this.lb_interval.Name = "lb_interval";
      this.lb_interval.Size = new System.Drawing.Size(160, 15);
      this.lb_interval.TabIndex = 1;
      this.lb_interval.Text = "Noten abfrage Intervall (min)";
      // 
      // lb_title
      // 
      this.lb_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lb_title.AutoSize = true;
      this.lb_title.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.lb_title.Location = new System.Drawing.Point(24, 9);
      this.lb_title.Name = "lb_title";
      this.lb_title.Size = new System.Drawing.Size(217, 24);
      this.lb_title.TabIndex = 9;
      this.lb_title.Text = "Einstellungen ändern";
      // 
      // ns_interval
      // 
      this.ns_interval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.ns_interval.Location = new System.Drawing.Point(205, 66);
      this.ns_interval.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
      this.ns_interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.ns_interval.Name = "ns_interval";
      this.ns_interval.Size = new System.Drawing.Size(50, 23);
      this.ns_interval.TabIndex = 10;
      this.ns_interval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
      // 
      // lb_activateDiscordBot
      // 
      this.lb_activateDiscordBot.AutoSize = true;
      this.lb_activateDiscordBot.Location = new System.Drawing.Point(12, 177);
      this.lb_activateDiscordBot.Name = "lb_activateDiscordBot";
      this.lb_activateDiscordBot.Size = new System.Drawing.Size(124, 15);
      this.lb_activateDiscordBot.TabIndex = 11;
      this.lb_activateDiscordBot.Text = "Discord-Bot aktivieren";
      // 
      // cb_activateDiscordBot
      // 
      this.cb_activateDiscordBot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cb_activateDiscordBot.AutoSize = true;
      this.cb_activateDiscordBot.Location = new System.Drawing.Point(242, 179);
      this.cb_activateDiscordBot.Name = "cb_activateDiscordBot";
      this.cb_activateDiscordBot.Size = new System.Drawing.Size(15, 14);
      this.cb_activateDiscordBot.TabIndex = 0;
      this.cb_activateDiscordBot.UseVisualStyleBackColor = true;
      this.cb_activateDiscordBot.CheckedChanged += new System.EventHandler(this.cb_activateDiscordBot_CheckedChanged);
      // 
      // lb_autostart
      // 
      this.lb_autostart.AutoSize = true;
      this.lb_autostart.Location = new System.Drawing.Point(12, 106);
      this.lb_autostart.Name = "lb_autostart";
      this.lb_autostart.Size = new System.Drawing.Size(114, 15);
      this.lb_autostart.TabIndex = 13;
      this.lb_autostart.Text = "Automatisch starten";
      // 
      // cb_autostart
      // 
      this.cb_autostart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cb_autostart.AutoSize = true;
      this.cb_autostart.Location = new System.Drawing.Point(242, 108);
      this.cb_autostart.Name = "cb_autostart";
      this.cb_autostart.Size = new System.Drawing.Size(15, 14);
      this.cb_autostart.TabIndex = 12;
      this.cb_autostart.UseVisualStyleBackColor = true;
      // 
      // lb_botToken
      // 
      this.lb_botToken.AutoSize = true;
      this.lb_botToken.Enabled = false;
      this.lb_botToken.Location = new System.Drawing.Point(12, 215);
      this.lb_botToken.Name = "lb_botToken";
      this.lb_botToken.Size = new System.Drawing.Size(61, 15);
      this.lb_botToken.TabIndex = 14;
      this.lb_botToken.Text = "Bot-Token";
      // 
      // tb_botToken
      // 
      this.tb_botToken.Enabled = false;
      this.tb_botToken.Location = new System.Drawing.Point(92, 212);
      this.tb_botToken.Name = "tb_botToken";
      this.tb_botToken.Size = new System.Drawing.Size(163, 23);
      this.tb_botToken.TabIndex = 15;
      // 
      // lb_pushNotifications
      // 
      this.lb_pushNotifications.AutoSize = true;
      this.lb_pushNotifications.Location = new System.Drawing.Point(12, 141);
      this.lb_pushNotifications.Name = "lb_pushNotifications";
      this.lb_pushNotifications.Size = new System.Drawing.Size(143, 15);
      this.lb_pushNotifications.TabIndex = 17;
      this.lb_pushNotifications.Text = "Push Benachrichtigungen";
      // 
      // cb_pushNotifications
      // 
      this.cb_pushNotifications.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cb_pushNotifications.AutoSize = true;
      this.cb_pushNotifications.Location = new System.Drawing.Point(242, 143);
      this.cb_pushNotifications.Name = "cb_pushNotifications";
      this.cb_pushNotifications.Size = new System.Drawing.Size(15, 14);
      this.cb_pushNotifications.TabIndex = 16;
      this.cb_pushNotifications.UseVisualStyleBackColor = true;
      // 
      // SettingsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(267, 441);
      this.Controls.Add(this.lb_pushNotifications);
      this.Controls.Add(this.cb_pushNotifications);
      this.Controls.Add(this.tb_botToken);
      this.Controls.Add(this.lb_botToken);
      this.Controls.Add(this.lb_autostart);
      this.Controls.Add(this.cb_autostart);
      this.Controls.Add(this.lb_activateDiscordBot);
      this.Controls.Add(this.ns_interval);
      this.Controls.Add(this.lb_title);
      this.Controls.Add(this.lb_interval);
      this.Controls.Add(this.cb_activateDiscordBot);
      this.Name = "SettingsForm";
      this.Text = "Settings";
      this.Load += new System.EventHandler(this.SettingsForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.ns_interval)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private Label lb_interval;
    private Label lb_title;
    private NumericUpDown ns_interval;
    private Label lb_activateDiscordBot;
    private CheckBox cb_activateDiscordBot;
    private Label lb_autostart;
    private CheckBox cb_autostart;
    private Label lb_botToken;
    private TextBox tb_botToken;
    private Label lb_pushNotifications;
    private CheckBox cb_pushNotifications;
  }
}