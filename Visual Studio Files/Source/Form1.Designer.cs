﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReinforcementLearning
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonRestart = new System.Windows.Forms.Button();
            this.groupboxCurrentposition = new System.Windows.Forms.GroupBox();
            this.textboxEncodedas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxCurrentsquare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxUp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxDown = new System.Windows.Forms.TextBox();
            this.textboxRight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxLeft = new System.Windows.Forms.TextBox();
            this.buttonStartAlgorithm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEpisodestextbox = new System.Windows.Forms.Button();
            this.buttonEpisodesdropdown = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxEpisodesinput = new System.Windows.Forms.TextBox();
            this.comboboxEpisode = new System.Windows.Forms.ComboBox();
            this.groupboxInitialsettings = new System.Windows.Forms.GroupBox();
            this.textboxBeerreward = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textboxEmptysquare = new System.Windows.Forms.TextBox();
            this.textboxWallpunishment = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textboxNinitial = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textboxY = new System.Windows.Forms.TextBox();
            this.textboxEpsilon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textboxNumberofepisodes = new System.Windows.Forms.TextBox();
            this.textboxNumberofsteps = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonStepstextbox = new System.Windows.Forms.Button();
            this.buttonStepsdropdown = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textboxStepsinput = new System.Windows.Forms.TextBox();
            this.comboboxSteps = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonNtextbox = new System.Windows.Forms.Button();
            this.buttonNdropdown = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textboxNinput = new System.Windows.Forms.TextBox();
            this.comboboxN = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonYtextbox = new System.Windows.Forms.Button();
            this.buttonYdropdown = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textboxYinput = new System.Windows.Forms.TextBox();
            this.comboboxY = new System.Windows.Forms.ComboBox();
            this.groupboxConfiguration = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.buttonAdvancestepstextbox = new System.Windows.Forms.Button();
            this.comboboxAdvancesteps = new System.Windows.Forms.ComboBox();
            this.buttonAdvancestepsdropdown = new System.Windows.Forms.Button();
            this.textboxAdvancestepsinput = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupboxAdvanceepisodes = new System.Windows.Forms.GroupBox();
            this.buttonAdvanceepisodestextbox = new System.Windows.Forms.Button();
            this.comboboxAdvanceepisodes = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonAdvanceepisodesdropdown = new System.Windows.Forms.Button();
            this.textboxAdvanceepisodesinput = new System.Windows.Forms.TextBox();
            this.groupboxAlgorithmprogress = new System.Windows.Forms.GroupBox();
            this.groupboxSessionprogress = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textboxYprogress = new System.Windows.Forms.TextBox();
            this.textboxNprogress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textboxEpisodesprogress = new System.Windows.Forms.TextBox();
            this.textboxStepsprogress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textboxQmatrixcurrent = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textboxQmatrixup = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textboxQmatrixdown = new System.Windows.Forms.TextBox();
            this.textboxQmatrixright = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textboxQmatrixleft = new System.Windows.Forms.TextBox();
            this.groupboxQmatrix = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.groupboxHistory = new System.Windows.Forms.GroupBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.groupboxStatusmessage = new System.Windows.Forms.GroupBox();
            this.textboxStatus = new System.Windows.Forms.RichTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textboxCansremaining = new System.Windows.Forms.TextBox();
            this.textboxCanscollected = new System.Windows.Forms.TextBox();
            this.groupboxCans = new System.Windows.Forms.GroupBox();
            this.label37 = new System.Windows.Forms.Label();
            this.groupboxRewarddata = new System.Windows.Forms.GroupBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textboxRewardepisode = new System.Windows.Forms.TextBox();
            this.textboxRewardtotal = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.groupboxCurrentposition.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupboxInitialsettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupboxConfiguration.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupboxAdvanceepisodes.SuspendLayout();
            this.groupboxAlgorithmprogress.SuspendLayout();
            this.groupboxSessionprogress.SuspendLayout();
            this.groupboxQmatrix.SuspendLayout();
            this.groupboxHistory.SuspendLayout();
            this.groupboxStatusmessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupboxCans.SuspendLayout();
            this.groupboxRewarddata.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRestart
            // 
            this.buttonRestart.Enabled = false;
            this.buttonRestart.Location = new System.Drawing.Point(1114, 979);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(289, 25);
            this.buttonRestart.TabIndex = 5;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.reset_algorithm);
            // 
            // groupboxCurrentposition
            // 
            this.groupboxCurrentposition.Controls.Add(this.textboxEncodedas);
            this.groupboxCurrentposition.Controls.Add(this.label6);
            this.groupboxCurrentposition.Controls.Add(this.textboxCurrentsquare);
            this.groupboxCurrentposition.Controls.Add(this.label5);
            this.groupboxCurrentposition.Controls.Add(this.textboxUp);
            this.groupboxCurrentposition.Controls.Add(this.label3);
            this.groupboxCurrentposition.Controls.Add(this.textboxDown);
            this.groupboxCurrentposition.Controls.Add(this.textboxRight);
            this.groupboxCurrentposition.Controls.Add(this.label4);
            this.groupboxCurrentposition.Controls.Add(this.label2);
            this.groupboxCurrentposition.Controls.Add(this.label1);
            this.groupboxCurrentposition.Controls.Add(this.textboxLeft);
            this.groupboxCurrentposition.Enabled = false;
            this.groupboxCurrentposition.Location = new System.Drawing.Point(21, 176);
            this.groupboxCurrentposition.Margin = new System.Windows.Forms.Padding(4);
            this.groupboxCurrentposition.Name = "groupboxCurrentposition";
            this.groupboxCurrentposition.Padding = new System.Windows.Forms.Padding(4);
            this.groupboxCurrentposition.Size = new System.Drawing.Size(515, 130);
            this.groupboxCurrentposition.TabIndex = 6;
            this.groupboxCurrentposition.TabStop = false;
            this.groupboxCurrentposition.Text = "Current position";
            // 
            // textboxEncodedas
            // 
            this.textboxEncodedas.Location = new System.Drawing.Point(24, 43);
            this.textboxEncodedas.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEncodedas.Name = "textboxEncodedas";
            this.textboxEncodedas.ReadOnly = true;
            this.textboxEncodedas.Size = new System.Drawing.Size(431, 22);
            this.textboxEncodedas.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Encoded as";
            // 
            // textboxCurrentsquare
            // 
            this.textboxCurrentsquare.Location = new System.Drawing.Point(375, 96);
            this.textboxCurrentsquare.Margin = new System.Windows.Forms.Padding(4);
            this.textboxCurrentsquare.Name = "textboxCurrentsquare";
            this.textboxCurrentsquare.ReadOnly = true;
            this.textboxCurrentsquare.Size = new System.Drawing.Size(80, 22);
            this.textboxCurrentsquare.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current square";
            // 
            // textboxUp
            // 
            this.textboxUp.Location = new System.Drawing.Point(287, 96);
            this.textboxUp.Margin = new System.Windows.Forms.Padding(4);
            this.textboxUp.Name = "textboxUp";
            this.textboxUp.ReadOnly = true;
            this.textboxUp.Size = new System.Drawing.Size(80, 22);
            this.textboxUp.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Up";
            // 
            // textboxDown
            // 
            this.textboxDown.Location = new System.Drawing.Point(199, 96);
            this.textboxDown.Margin = new System.Windows.Forms.Padding(4);
            this.textboxDown.Name = "textboxDown";
            this.textboxDown.ReadOnly = true;
            this.textboxDown.Size = new System.Drawing.Size(80, 22);
            this.textboxDown.TabIndex = 3;
            // 
            // textboxRight
            // 
            this.textboxRight.Location = new System.Drawing.Point(111, 96);
            this.textboxRight.Margin = new System.Windows.Forms.Padding(4);
            this.textboxRight.Name = "textboxRight";
            this.textboxRight.ReadOnly = true;
            this.textboxRight.Size = new System.Drawing.Size(80, 22);
            this.textboxRight.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Right";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Down";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left";
            // 
            // textboxLeft
            // 
            this.textboxLeft.Location = new System.Drawing.Point(23, 96);
            this.textboxLeft.Margin = new System.Windows.Forms.Padding(4);
            this.textboxLeft.Name = "textboxLeft";
            this.textboxLeft.ReadOnly = true;
            this.textboxLeft.Size = new System.Drawing.Size(80, 22);
            this.textboxLeft.TabIndex = 1;
            // 
            // buttonStartAlgorithm
            // 
            this.buttonStartAlgorithm.Location = new System.Drawing.Point(15, 719);
            this.buttonStartAlgorithm.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartAlgorithm.Name = "buttonStartAlgorithm";
            this.buttonStartAlgorithm.Size = new System.Drawing.Size(259, 28);
            this.buttonStartAlgorithm.TabIndex = 7;
            this.buttonStartAlgorithm.Text = "Start algorithm";
            this.buttonStartAlgorithm.UseVisualStyleBackColor = true;
            this.buttonStartAlgorithm.Click += new System.EventHandler(this.start_algorithm);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEpisodestextbox);
            this.groupBox2.Controls.Add(this.buttonEpisodesdropdown);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textboxEpisodesinput);
            this.groupBox2.Controls.Add(this.comboboxEpisode);
            this.groupBox2.Location = new System.Drawing.Point(15, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 80);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "How many episodes will there be?";
            // 
            // buttonEpisodestextbox
            // 
            this.buttonEpisodestextbox.Location = new System.Drawing.Point(157, 48);
            this.buttonEpisodestextbox.Name = "buttonEpisodestextbox";
            this.buttonEpisodestextbox.Size = new System.Drawing.Size(75, 23);
            this.buttonEpisodestextbox.TabIndex = 4;
            this.buttonEpisodestextbox.Text = "Set";
            this.buttonEpisodestextbox.UseVisualStyleBackColor = true;
            this.buttonEpisodestextbox.Click += new System.EventHandler(this.set_episode_from_textbox);
            // 
            // buttonEpisodesdropdown
            // 
            this.buttonEpisodesdropdown.Location = new System.Drawing.Point(157, 18);
            this.buttonEpisodesdropdown.Name = "buttonEpisodesdropdown";
            this.buttonEpisodesdropdown.Size = new System.Drawing.Size(75, 23);
            this.buttonEpisodesdropdown.TabIndex = 3;
            this.buttonEpisodesdropdown.Text = "Set";
            this.buttonEpisodesdropdown.UseVisualStyleBackColor = true;
            this.buttonEpisodesdropdown.Click += new System.EventHandler(this.set_episode_from_dropdown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "or";
            // 
            // textboxEpisodesinput
            // 
            this.textboxEpisodesinput.Location = new System.Drawing.Point(29, 50);
            this.textboxEpisodesinput.Name = "textboxEpisodesinput";
            this.textboxEpisodesinput.Size = new System.Drawing.Size(121, 22);
            this.textboxEpisodesinput.TabIndex = 1;
            // 
            // comboboxEpisode
            // 
            this.comboboxEpisode.FormattingEnabled = true;
            this.comboboxEpisode.Location = new System.Drawing.Point(29, 18);
            this.comboboxEpisode.Name = "comboboxEpisode";
            this.comboboxEpisode.Size = new System.Drawing.Size(121, 24);
            this.comboboxEpisode.TabIndex = 0;
            // 
            // groupboxInitialsettings
            // 
            this.groupboxInitialsettings.Controls.Add(this.textboxBeerreward);
            this.groupboxInitialsettings.Controls.Add(this.label30);
            this.groupboxInitialsettings.Controls.Add(this.label29);
            this.groupboxInitialsettings.Controls.Add(this.textboxEmptysquare);
            this.groupboxInitialsettings.Controls.Add(this.textboxWallpunishment);
            this.groupboxInitialsettings.Controls.Add(this.label28);
            this.groupboxInitialsettings.Controls.Add(this.textboxNinitial);
            this.groupboxInitialsettings.Controls.Add(this.label21);
            this.groupboxInitialsettings.Controls.Add(this.textboxY);
            this.groupboxInitialsettings.Controls.Add(this.textboxEpsilon);
            this.groupboxInitialsettings.Controls.Add(this.label11);
            this.groupboxInitialsettings.Controls.Add(this.label10);
            this.groupboxInitialsettings.Controls.Add(this.label8);
            this.groupboxInitialsettings.Controls.Add(this.textboxNumberofepisodes);
            this.groupboxInitialsettings.Controls.Add(this.textboxNumberofsteps);
            this.groupboxInitialsettings.Controls.Add(this.label9);
            this.groupboxInitialsettings.Location = new System.Drawing.Point(1407, 13);
            this.groupboxInitialsettings.Name = "groupboxInitialsettings";
            this.groupboxInitialsettings.Size = new System.Drawing.Size(546, 127);
            this.groupboxInitialsettings.TabIndex = 10;
            this.groupboxInitialsettings.TabStop = false;
            this.groupboxInitialsettings.Text = "Initial Settings";
            // 
            // textboxBeerreward
            // 
            this.textboxBeerreward.Location = new System.Drawing.Point(421, 96);
            this.textboxBeerreward.Margin = new System.Windows.Forms.Padding(4);
            this.textboxBeerreward.Name = "textboxBeerreward";
            this.textboxBeerreward.ReadOnly = true;
            this.textboxBeerreward.Size = new System.Drawing.Size(113, 22);
            this.textboxBeerreward.TabIndex = 25;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(453, 75);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(85, 17);
            this.label30.TabIndex = 24;
            this.label30.Text = "Beer reward";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(362, 23);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(172, 17);
            this.label29.TabIndex = 22;
            this.label29.Text = "Empty square punishment";
            // 
            // textboxEmptysquare
            // 
            this.textboxEmptysquare.Location = new System.Drawing.Point(362, 42);
            this.textboxEmptysquare.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEmptysquare.Name = "textboxEmptysquare";
            this.textboxEmptysquare.ReadOnly = true;
            this.textboxEmptysquare.Size = new System.Drawing.Size(172, 22);
            this.textboxEmptysquare.TabIndex = 23;
            // 
            // textboxWallpunishment
            // 
            this.textboxWallpunishment.Location = new System.Drawing.Point(287, 96);
            this.textboxWallpunishment.Margin = new System.Windows.Forms.Padding(4);
            this.textboxWallpunishment.Name = "textboxWallpunishment";
            this.textboxWallpunishment.ReadOnly = true;
            this.textboxWallpunishment.Size = new System.Drawing.Size(113, 22);
            this.textboxWallpunishment.TabIndex = 21;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(288, 77);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(112, 17);
            this.label28.TabIndex = 20;
            this.label28.Text = "Wall punishment";
            // 
            // textboxNinitial
            // 
            this.textboxNinitial.Location = new System.Drawing.Point(109, 96);
            this.textboxNinitial.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNinitial.Name = "textboxNinitial";
            this.textboxNinitial.ReadOnly = true;
            this.textboxNinitial.Size = new System.Drawing.Size(80, 22);
            this.textboxNinitial.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 76);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 17);
            this.label21.TabIndex = 18;
            this.label21.Text = "Ɛ";
            // 
            // textboxY
            // 
            this.textboxY.Location = new System.Drawing.Point(199, 96);
            this.textboxY.Margin = new System.Windows.Forms.Padding(4);
            this.textboxY.Name = "textboxY";
            this.textboxY.ReadOnly = true;
            this.textboxY.Size = new System.Drawing.Size(80, 22);
            this.textboxY.TabIndex = 13;
            // 
            // textboxEpsilon
            // 
            this.textboxEpsilon.Location = new System.Drawing.Point(23, 96);
            this.textboxEpsilon.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEpsilon.Name = "textboxEpsilon";
            this.textboxEpsilon.ReadOnly = true;
            this.textboxEpsilon.Size = new System.Drawing.Size(80, 22);
            this.textboxEpsilon.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 77);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "γ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Number of episodes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "η";
            // 
            // textboxNumberofepisodes
            // 
            this.textboxNumberofepisodes.Location = new System.Drawing.Point(24, 43);
            this.textboxNumberofepisodes.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNumberofepisodes.Name = "textboxNumberofepisodes";
            this.textboxNumberofepisodes.ReadOnly = true;
            this.textboxNumberofepisodes.Size = new System.Drawing.Size(165, 22);
            this.textboxNumberofepisodes.TabIndex = 13;
            // 
            // textboxNumberofsteps
            // 
            this.textboxNumberofsteps.Location = new System.Drawing.Point(197, 43);
            this.textboxNumberofsteps.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNumberofsteps.Name = "textboxNumberofsteps";
            this.textboxNumberofsteps.ReadOnly = true;
            this.textboxNumberofsteps.Size = new System.Drawing.Size(157, 22);
            this.textboxNumberofsteps.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Steps per episode";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonStepstextbox);
            this.groupBox3.Controls.Add(this.buttonStepsdropdown);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textboxStepsinput);
            this.groupBox3.Controls.Add(this.comboboxSteps);
            this.groupBox3.Location = new System.Drawing.Point(15, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 80);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "How many steps per episode?";
            // 
            // buttonStepstextbox
            // 
            this.buttonStepstextbox.Location = new System.Drawing.Point(157, 48);
            this.buttonStepstextbox.Name = "buttonStepstextbox";
            this.buttonStepstextbox.Size = new System.Drawing.Size(75, 23);
            this.buttonStepstextbox.TabIndex = 4;
            this.buttonStepstextbox.Text = "Set";
            this.buttonStepstextbox.UseVisualStyleBackColor = true;
            this.buttonStepstextbox.Click += new System.EventHandler(this.set_steps_from_textbox);
            // 
            // buttonStepsdropdown
            // 
            this.buttonStepsdropdown.Location = new System.Drawing.Point(157, 18);
            this.buttonStepsdropdown.Name = "buttonStepsdropdown";
            this.buttonStepsdropdown.Size = new System.Drawing.Size(75, 23);
            this.buttonStepsdropdown.TabIndex = 3;
            this.buttonStepsdropdown.Text = "Set";
            this.buttonStepsdropdown.UseVisualStyleBackColor = true;
            this.buttonStepsdropdown.Click += new System.EventHandler(this.set_steps_from_dropdown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "or";
            // 
            // textboxStepsinput
            // 
            this.textboxStepsinput.Location = new System.Drawing.Point(29, 50);
            this.textboxStepsinput.Name = "textboxStepsinput";
            this.textboxStepsinput.Size = new System.Drawing.Size(121, 22);
            this.textboxStepsinput.TabIndex = 1;
            // 
            // comboboxSteps
            // 
            this.comboboxSteps.FormattingEnabled = true;
            this.comboboxSteps.Location = new System.Drawing.Point(29, 18);
            this.comboboxSteps.Name = "comboboxSteps";
            this.comboboxSteps.Size = new System.Drawing.Size(121, 24);
            this.comboboxSteps.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonNtextbox);
            this.groupBox5.Controls.Add(this.buttonNdropdown);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.textboxNinput);
            this.groupBox5.Controls.Add(this.comboboxN);
            this.groupBox5.Location = new System.Drawing.Point(15, 193);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 80);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "η";
            // 
            // buttonNtextbox
            // 
            this.buttonNtextbox.Location = new System.Drawing.Point(157, 48);
            this.buttonNtextbox.Name = "buttonNtextbox";
            this.buttonNtextbox.Size = new System.Drawing.Size(75, 23);
            this.buttonNtextbox.TabIndex = 4;
            this.buttonNtextbox.Text = "Set";
            this.buttonNtextbox.UseVisualStyleBackColor = true;
            this.buttonNtextbox.Click += new System.EventHandler(this.set_n_from_textbox);
            // 
            // buttonNdropdown
            // 
            this.buttonNdropdown.Location = new System.Drawing.Point(157, 18);
            this.buttonNdropdown.Name = "buttonNdropdown";
            this.buttonNdropdown.Size = new System.Drawing.Size(75, 23);
            this.buttonNdropdown.TabIndex = 3;
            this.buttonNdropdown.Text = "Set";
            this.buttonNdropdown.UseVisualStyleBackColor = true;
            this.buttonNdropdown.Click += new System.EventHandler(this.set_n_from_dropdown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "or";
            // 
            // textboxNinput
            // 
            this.textboxNinput.Location = new System.Drawing.Point(29, 50);
            this.textboxNinput.Name = "textboxNinput";
            this.textboxNinput.Size = new System.Drawing.Size(121, 22);
            this.textboxNinput.TabIndex = 1;
            // 
            // comboboxN
            // 
            this.comboboxN.FormattingEnabled = true;
            this.comboboxN.Location = new System.Drawing.Point(29, 18);
            this.comboboxN.Name = "comboboxN";
            this.comboboxN.Size = new System.Drawing.Size(121, 24);
            this.comboboxN.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonYtextbox);
            this.groupBox6.Controls.Add(this.buttonYdropdown);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.textboxYinput);
            this.groupBox6.Controls.Add(this.comboboxY);
            this.groupBox6.Location = new System.Drawing.Point(15, 279);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(259, 80);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "γ";
            // 
            // buttonYtextbox
            // 
            this.buttonYtextbox.Location = new System.Drawing.Point(157, 49);
            this.buttonYtextbox.Name = "buttonYtextbox";
            this.buttonYtextbox.Size = new System.Drawing.Size(75, 24);
            this.buttonYtextbox.TabIndex = 4;
            this.buttonYtextbox.Text = "Set";
            this.buttonYtextbox.UseVisualStyleBackColor = true;
            this.buttonYtextbox.Click += new System.EventHandler(this.set_y_from_textbox);
            // 
            // buttonYdropdown
            // 
            this.buttonYdropdown.Location = new System.Drawing.Point(157, 18);
            this.buttonYdropdown.Name = "buttonYdropdown";
            this.buttonYdropdown.Size = new System.Drawing.Size(75, 23);
            this.buttonYdropdown.TabIndex = 3;
            this.buttonYdropdown.Text = "Set";
            this.buttonYdropdown.UseVisualStyleBackColor = true;
            this.buttonYdropdown.Click += new System.EventHandler(this.set_y_from_dropdown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "or";
            // 
            // textboxYinput
            // 
            this.textboxYinput.Location = new System.Drawing.Point(29, 50);
            this.textboxYinput.Name = "textboxYinput";
            this.textboxYinput.Size = new System.Drawing.Size(121, 22);
            this.textboxYinput.TabIndex = 1;
            // 
            // comboboxY
            // 
            this.comboboxY.FormattingEnabled = true;
            this.comboboxY.Location = new System.Drawing.Point(29, 18);
            this.comboboxY.Name = "comboboxY";
            this.comboboxY.Size = new System.Drawing.Size(121, 24);
            this.comboboxY.TabIndex = 0;
            // 
            // groupboxConfiguration
            // 
            this.groupboxConfiguration.Controls.Add(this.groupBox11);
            this.groupboxConfiguration.Controls.Add(this.groupBox10);
            this.groupboxConfiguration.Controls.Add(this.groupBox9);
            this.groupboxConfiguration.Controls.Add(this.groupBox7);
            this.groupboxConfiguration.Controls.Add(this.groupBox2);
            this.groupboxConfiguration.Controls.Add(this.groupBox6);
            this.groupboxConfiguration.Controls.Add(this.buttonStartAlgorithm);
            this.groupboxConfiguration.Controls.Add(this.groupBox5);
            this.groupboxConfiguration.Controls.Add(this.groupBox3);
            this.groupboxConfiguration.Location = new System.Drawing.Point(1112, 12);
            this.groupboxConfiguration.Name = "groupboxConfiguration";
            this.groupboxConfiguration.Size = new System.Drawing.Size(289, 755);
            this.groupboxConfiguration.TabIndex = 11;
            this.groupboxConfiguration.TabStop = false;
            this.groupboxConfiguration.Text = "Configuration";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.button7);
            this.groupBox11.Controls.Add(this.button8);
            this.groupBox11.Controls.Add(this.label34);
            this.groupBox11.Controls.Add(this.textBox14);
            this.groupBox11.Controls.Add(this.comboBox5);
            this.groupBox11.Location = new System.Drawing.Point(17, 632);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(259, 80);
            this.groupBox11.TabIndex = 11;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Beer reward";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(157, 49);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 24);
            this.button7.TabIndex = 4;
            this.button7.Text = "Set";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(157, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 24);
            this.button8.TabIndex = 3;
            this.button8.Text = "Set";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(7, 52);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(21, 17);
            this.label34.TabIndex = 2;
            this.label34.Text = "or";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(29, 50);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(121, 22);
            this.textBox14.TabIndex = 1;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(29, 18);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button5);
            this.groupBox10.Controls.Add(this.button6);
            this.groupBox10.Controls.Add(this.label33);
            this.groupBox10.Controls.Add(this.textBox13);
            this.groupBox10.Controls.Add(this.comboBox4);
            this.groupBox10.Location = new System.Drawing.Point(17, 537);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(259, 80);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Empty square punishment";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(157, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 24);
            this.button5.TabIndex = 4;
            this.button5.Text = "Set";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(157, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Set";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 52);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(21, 17);
            this.label33.TabIndex = 2;
            this.label33.Text = "or";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(29, 50);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(121, 22);
            this.textBox13.TabIndex = 1;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(29, 18);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button3);
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Controls.Add(this.label32);
            this.groupBox9.Controls.Add(this.textBox12);
            this.groupBox9.Controls.Add(this.comboBox3);
            this.groupBox9.Location = new System.Drawing.Point(15, 451);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(259, 80);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Wall punishment";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 4;
            this.button3.Text = "Set";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(157, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Set";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(7, 52);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(21, 17);
            this.label32.TabIndex = 2;
            this.label32.Text = "or";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(29, 50);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(121, 22);
            this.textBox12.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(29, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.label31);
            this.groupBox7.Controls.Add(this.textBox11);
            this.groupBox7.Controls.Add(this.comboBox2);
            this.groupBox7.Location = new System.Drawing.Point(15, 365);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(259, 80);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ɛ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(7, 52);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(21, 17);
            this.label31.TabIndex = 2;
            this.label31.Text = "or";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(29, 50);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(121, 22);
            this.textBox11.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(29, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.buttonAdvancestepstextbox);
            this.groupBox8.Controls.Add(this.comboboxAdvancesteps);
            this.groupBox8.Controls.Add(this.buttonAdvancestepsdropdown);
            this.groupBox8.Controls.Add(this.textboxAdvancestepsinput);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Location = new System.Drawing.Point(6, 25);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(268, 80);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Advance steps";
            // 
            // buttonAdvancestepstextbox
            // 
            this.buttonAdvancestepstextbox.Location = new System.Drawing.Point(166, 51);
            this.buttonAdvancestepstextbox.Name = "buttonAdvancestepstextbox";
            this.buttonAdvancestepstextbox.Size = new System.Drawing.Size(75, 26);
            this.buttonAdvancestepstextbox.TabIndex = 9;
            this.buttonAdvancestepstextbox.Text = "Step";
            this.buttonAdvancestepstextbox.UseVisualStyleBackColor = true;
            // 
            // comboboxAdvancesteps
            // 
            this.comboboxAdvancesteps.FormattingEnabled = true;
            this.comboboxAdvancesteps.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "25",
            "100"});
            this.comboboxAdvancesteps.Location = new System.Drawing.Point(38, 21);
            this.comboboxAdvancesteps.Name = "comboboxAdvancesteps";
            this.comboboxAdvancesteps.Size = new System.Drawing.Size(121, 24);
            this.comboboxAdvancesteps.TabIndex = 5;
            // 
            // buttonAdvancestepsdropdown
            // 
            this.buttonAdvancestepsdropdown.Location = new System.Drawing.Point(166, 20);
            this.buttonAdvancestepsdropdown.Name = "buttonAdvancestepsdropdown";
            this.buttonAdvancestepsdropdown.Size = new System.Drawing.Size(75, 27);
            this.buttonAdvancestepsdropdown.TabIndex = 8;
            this.buttonAdvancestepsdropdown.Text = "Step";
            this.buttonAdvancestepsdropdown.UseVisualStyleBackColor = true;
            // 
            // textboxAdvancestepsinput
            // 
            this.textboxAdvancestepsinput.Location = new System.Drawing.Point(38, 53);
            this.textboxAdvancestepsinput.Name = "textboxAdvancestepsinput";
            this.textboxAdvancestepsinput.Size = new System.Drawing.Size(121, 22);
            this.textboxAdvancestepsinput.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "or";
            // 
            // groupboxAdvanceepisodes
            // 
            this.groupboxAdvanceepisodes.Controls.Add(this.buttonAdvanceepisodestextbox);
            this.groupboxAdvanceepisodes.Controls.Add(this.comboboxAdvanceepisodes);
            this.groupboxAdvanceepisodes.Controls.Add(this.label16);
            this.groupboxAdvanceepisodes.Controls.Add(this.buttonAdvanceepisodesdropdown);
            this.groupboxAdvanceepisodes.Controls.Add(this.textboxAdvanceepisodesinput);
            this.groupboxAdvanceepisodes.Location = new System.Drawing.Point(6, 119);
            this.groupboxAdvanceepisodes.Name = "groupboxAdvanceepisodes";
            this.groupboxAdvanceepisodes.Size = new System.Drawing.Size(268, 80);
            this.groupboxAdvanceepisodes.TabIndex = 10;
            this.groupboxAdvanceepisodes.TabStop = false;
            this.groupboxAdvanceepisodes.Text = "Advance episodes";
            // 
            // buttonAdvanceepisodestextbox
            // 
            this.buttonAdvanceepisodestextbox.Location = new System.Drawing.Point(166, 51);
            this.buttonAdvanceepisodestextbox.Name = "buttonAdvanceepisodestextbox";
            this.buttonAdvanceepisodestextbox.Size = new System.Drawing.Size(75, 24);
            this.buttonAdvanceepisodestextbox.TabIndex = 14;
            this.buttonAdvanceepisodestextbox.Text = "Step";
            this.buttonAdvanceepisodestextbox.UseVisualStyleBackColor = true;
            // 
            // comboboxAdvanceepisodes
            // 
            this.comboboxAdvanceepisodes.FormattingEnabled = true;
            this.comboboxAdvanceepisodes.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "25",
            "100"});
            this.comboboxAdvanceepisodes.Location = new System.Drawing.Point(38, 21);
            this.comboboxAdvanceepisodes.Name = "comboboxAdvanceepisodes";
            this.comboboxAdvanceepisodes.Size = new System.Drawing.Size(121, 24);
            this.comboboxAdvanceepisodes.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 17);
            this.label16.TabIndex = 12;
            this.label16.Text = "or";
            // 
            // buttonAdvanceepisodesdropdown
            // 
            this.buttonAdvanceepisodesdropdown.Location = new System.Drawing.Point(166, 21);
            this.buttonAdvanceepisodesdropdown.Name = "buttonAdvanceepisodesdropdown";
            this.buttonAdvanceepisodesdropdown.Size = new System.Drawing.Size(75, 24);
            this.buttonAdvanceepisodesdropdown.TabIndex = 13;
            this.buttonAdvanceepisodesdropdown.Text = "Step";
            this.buttonAdvanceepisodesdropdown.UseVisualStyleBackColor = true;
            // 
            // textboxAdvanceepisodesinput
            // 
            this.textboxAdvanceepisodesinput.Location = new System.Drawing.Point(38, 53);
            this.textboxAdvanceepisodesinput.Name = "textboxAdvanceepisodesinput";
            this.textboxAdvanceepisodesinput.Size = new System.Drawing.Size(121, 22);
            this.textboxAdvanceepisodesinput.TabIndex = 11;
            // 
            // groupboxAlgorithmprogress
            // 
            this.groupboxAlgorithmprogress.Controls.Add(this.groupBox8);
            this.groupboxAlgorithmprogress.Controls.Add(this.groupboxAdvanceepisodes);
            this.groupboxAlgorithmprogress.Enabled = false;
            this.groupboxAlgorithmprogress.Location = new System.Drawing.Point(1114, 773);
            this.groupboxAlgorithmprogress.Name = "groupboxAlgorithmprogress";
            this.groupboxAlgorithmprogress.Size = new System.Drawing.Size(289, 207);
            this.groupboxAlgorithmprogress.TabIndex = 12;
            this.groupboxAlgorithmprogress.TabStop = false;
            this.groupboxAlgorithmprogress.Text = "Algorithm progress";
            // 
            // groupboxSessionprogress
            // 
            this.groupboxSessionprogress.Controls.Add(this.groupboxCans);
            this.groupboxSessionprogress.Controls.Add(this.groupboxRewarddata);
            this.groupboxSessionprogress.Controls.Add(this.label23);
            this.groupboxSessionprogress.Controls.Add(this.textBox2);
            this.groupboxSessionprogress.Controls.Add(this.label19);
            this.groupboxSessionprogress.Controls.Add(this.label22);
            this.groupboxSessionprogress.Controls.Add(this.textboxYprogress);
            this.groupboxSessionprogress.Controls.Add(this.textboxNprogress);
            this.groupboxSessionprogress.Controls.Add(this.label18);
            this.groupboxSessionprogress.Controls.Add(this.textboxEpisodesprogress);
            this.groupboxSessionprogress.Controls.Add(this.textboxStepsprogress);
            this.groupboxSessionprogress.Controls.Add(this.groupboxCurrentposition);
            this.groupboxSessionprogress.Controls.Add(this.label20);
            this.groupboxSessionprogress.Location = new System.Drawing.Point(1409, 292);
            this.groupboxSessionprogress.Name = "groupboxSessionprogress";
            this.groupboxSessionprogress.Size = new System.Drawing.Size(546, 317);
            this.groupboxSessionprogress.TabIndex = 18;
            this.groupboxSessionprogress.TabStop = false;
            this.groupboxSessionprogress.Text = "Session progress";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(467, 26);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 17);
            this.label23.TabIndex = 20;
            this.label23.Text = "γ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(379, 47);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(80, 22);
            this.textBox2.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(289, 28);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 17);
            this.label19.TabIndex = 20;
            this.label19.Text = "Ɛ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(377, 27);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 17);
            this.label22.TabIndex = 20;
            this.label22.Text = "η";
            // 
            // textboxYprogress
            // 
            this.textboxYprogress.Location = new System.Drawing.Point(466, 47);
            this.textboxYprogress.Margin = new System.Windows.Forms.Padding(4);
            this.textboxYprogress.Name = "textboxYprogress";
            this.textboxYprogress.ReadOnly = true;
            this.textboxYprogress.Size = new System.Drawing.Size(73, 22);
            this.textboxYprogress.TabIndex = 13;
            // 
            // textboxNprogress
            // 
            this.textboxNprogress.Location = new System.Drawing.Point(293, 47);
            this.textboxNprogress.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNprogress.Name = "textboxNprogress";
            this.textboxNprogress.ReadOnly = true;
            this.textboxNprogress.Size = new System.Drawing.Size(81, 22);
            this.textboxNprogress.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(132, 27);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 17);
            this.label18.TabIndex = 12;
            this.label18.Text = "Episode number";
            // 
            // textboxEpisodesprogress
            // 
            this.textboxEpisodesprogress.Location = new System.Drawing.Point(133, 51);
            this.textboxEpisodesprogress.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEpisodesprogress.Name = "textboxEpisodesprogress";
            this.textboxEpisodesprogress.ReadOnly = true;
            this.textboxEpisodesprogress.Size = new System.Drawing.Size(70, 22);
            this.textboxEpisodesprogress.TabIndex = 13;
            // 
            // textboxStepsprogress
            // 
            this.textboxStepsprogress.Location = new System.Drawing.Point(50, 51);
            this.textboxStepsprogress.Margin = new System.Windows.Forms.Padding(4);
            this.textboxStepsprogress.Name = "textboxStepsprogress";
            this.textboxStepsprogress.ReadOnly = true;
            this.textboxStepsprogress.Size = new System.Drawing.Size(72, 22);
            this.textboxStepsprogress.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(47, 27);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 17);
            this.label20.TabIndex = 14;
            this.label20.Text = "Step #";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "No board states have been added yet."});
            this.comboBox1.Location = new System.Drawing.Point(22, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(513, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Select a board state...";
            // 
            // textboxQmatrixcurrent
            // 
            this.textboxQmatrixcurrent.Location = new System.Drawing.Point(375, 96);
            this.textboxQmatrixcurrent.Margin = new System.Windows.Forms.Padding(4);
            this.textboxQmatrixcurrent.Name = "textboxQmatrixcurrent";
            this.textboxQmatrixcurrent.ReadOnly = true;
            this.textboxQmatrixcurrent.Size = new System.Drawing.Size(80, 22);
            this.textboxQmatrixcurrent.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(370, 79);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Current square";
            // 
            // textboxQmatrixup
            // 
            this.textboxQmatrixup.Location = new System.Drawing.Point(287, 96);
            this.textboxQmatrixup.Margin = new System.Windows.Forms.Padding(4);
            this.textboxQmatrixup.Name = "textboxQmatrixup";
            this.textboxQmatrixup.ReadOnly = true;
            this.textboxQmatrixup.Size = new System.Drawing.Size(79, 22);
            this.textboxQmatrixup.TabIndex = 19;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(287, 77);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(26, 17);
            this.label24.TabIndex = 18;
            this.label24.Text = "Up";
            // 
            // textboxQmatrixdown
            // 
            this.textboxQmatrixdown.Location = new System.Drawing.Point(199, 96);
            this.textboxQmatrixdown.Margin = new System.Windows.Forms.Padding(4);
            this.textboxQmatrixdown.Name = "textboxQmatrixdown";
            this.textboxQmatrixdown.ReadOnly = true;
            this.textboxQmatrixdown.Size = new System.Drawing.Size(80, 22);
            this.textboxQmatrixdown.TabIndex = 15;
            // 
            // textboxQmatrixright
            // 
            this.textboxQmatrixright.Location = new System.Drawing.Point(111, 96);
            this.textboxQmatrixright.Margin = new System.Windows.Forms.Padding(4);
            this.textboxQmatrixright.Name = "textboxQmatrixright";
            this.textboxQmatrixright.ReadOnly = true;
            this.textboxQmatrixright.Size = new System.Drawing.Size(80, 22);
            this.textboxQmatrixright.TabIndex = 17;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(108, 75);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 17);
            this.label25.TabIndex = 16;
            this.label25.Text = "Right";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(197, 77);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 17);
            this.label26.TabIndex = 14;
            this.label26.Text = "Down";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(21, 76);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 17);
            this.label27.TabIndex = 12;
            this.label27.Text = "Left";
            // 
            // textboxQmatrixleft
            // 
            this.textboxQmatrixleft.Location = new System.Drawing.Point(23, 96);
            this.textboxQmatrixleft.Margin = new System.Windows.Forms.Padding(4);
            this.textboxQmatrixleft.Name = "textboxQmatrixleft";
            this.textboxQmatrixleft.ReadOnly = true;
            this.textboxQmatrixleft.Size = new System.Drawing.Size(80, 22);
            this.textboxQmatrixleft.TabIndex = 13;
            // 
            // groupboxQmatrix
            // 
            this.groupboxQmatrix.Controls.Add(this.comboBox1);
            this.groupboxQmatrix.Controls.Add(this.textboxQmatrixright);
            this.groupboxQmatrix.Controls.Add(this.textboxQmatrixcurrent);
            this.groupboxQmatrix.Controls.Add(this.label25);
            this.groupboxQmatrix.Controls.Add(this.textboxQmatrixdown);
            this.groupboxQmatrix.Controls.Add(this.label17);
            this.groupboxQmatrix.Controls.Add(this.label26);
            this.groupboxQmatrix.Controls.Add(this.label24);
            this.groupboxQmatrix.Controls.Add(this.label27);
            this.groupboxQmatrix.Controls.Add(this.textboxQmatrixleft);
            this.groupboxQmatrix.Controls.Add(this.textboxQmatrixup);
            this.groupboxQmatrix.Enabled = false;
            this.groupboxQmatrix.Location = new System.Drawing.Point(1408, 147);
            this.groupboxQmatrix.Margin = new System.Windows.Forms.Padding(4);
            this.groupboxQmatrix.Name = "groupboxQmatrix";
            this.groupboxQmatrix.Padding = new System.Windows.Forms.Padding(4);
            this.groupboxQmatrix.Size = new System.Drawing.Size(545, 138);
            this.groupboxQmatrix.TabIndex = 12;
            this.groupboxQmatrix.TabStop = false;
            this.groupboxQmatrix.Text = "Q-Matrix";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(21, 45);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(241, 24);
            this.comboBox6.TabIndex = 22;
            this.comboBox6.Text = "View prior episodes...";
            // 
            // groupboxHistory
            // 
            this.groupboxHistory.Controls.Add(this.comboBox7);
            this.groupboxHistory.Controls.Add(this.comboBox6);
            this.groupboxHistory.Location = new System.Drawing.Point(1408, 913);
            this.groupboxHistory.Name = "groupboxHistory";
            this.groupboxHistory.Size = new System.Drawing.Size(546, 91);
            this.groupboxHistory.TabIndex = 22;
            this.groupboxHistory.TabStop = false;
            this.groupboxHistory.Text = "History";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(268, 45);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(263, 24);
            this.comboBox7.TabIndex = 23;
            this.comboBox7.Text = "View steps this episode...";
            // 
            // groupboxStatusmessage
            // 
            this.groupboxStatusmessage.Controls.Add(this.textboxStatus);
            this.groupboxStatusmessage.Location = new System.Drawing.Point(1407, 615);
            this.groupboxStatusmessage.Name = "groupboxStatusmessage";
            this.groupboxStatusmessage.Size = new System.Drawing.Size(546, 292);
            this.groupboxStatusmessage.TabIndex = 23;
            this.groupboxStatusmessage.TabStop = false;
            this.groupboxStatusmessage.Text = "Status message";
            // 
            // textboxStatus
            // 
            this.textboxStatus.Location = new System.Drawing.Point(21, 21);
            this.textboxStatus.Name = "textboxStatus";
            this.textboxStatus.ReadOnly = true;
            this.textboxStatus.Size = new System.Drawing.Size(511, 265);
            this.textboxStatus.TabIndex = 0;
            this.textboxStatus.Text = "";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ReinforcementLearning.Properties.Resources._1;
            this.pictureBox3.Location = new System.Drawing.Point(203, 998);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ReinforcementLearning.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(38, 842);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1063, 55);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ReinforcementLearning.Properties.Resources._0;
            this.pictureBox4.Location = new System.Drawing.Point(38, 932);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ReinforcementLearning.Properties.Resources._0;
            this.pictureBox5.Location = new System.Drawing.Point(103, 998);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::ReinforcementLearning.Properties.Resources._2;
            this.pictureBox8.Location = new System.Drawing.Point(303, 998);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::ReinforcementLearning.Properties.Resources._3;
            this.pictureBox9.Location = new System.Drawing.Point(403, 998);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 30;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = global::ReinforcementLearning.Properties.Resources._8;
            this.pictureBox16.Location = new System.Drawing.Point(903, 998);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(25, 30);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox16.TabIndex = 43;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = global::ReinforcementLearning.Properties.Resources._9;
            this.pictureBox17.Location = new System.Drawing.Point(1003, 998);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(25, 30);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox17.TabIndex = 42;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = global::ReinforcementLearning.Properties.Resources._6;
            this.pictureBox18.Location = new System.Drawing.Point(703, 998);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(25, 30);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 41;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = global::ReinforcementLearning.Properties.Resources._7;
            this.pictureBox19.Location = new System.Drawing.Point(803, 998);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(25, 30);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 40;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = global::ReinforcementLearning.Properties.Resources._4;
            this.pictureBox20.Location = new System.Drawing.Point(503, 998);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(25, 30);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox20.TabIndex = 39;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = global::ReinforcementLearning.Properties.Resources._5;
            this.pictureBox21.Location = new System.Drawing.Point(603, 998);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(25, 30);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox21.TabIndex = 38;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::ReinforcementLearning.Properties.Resources._2;
            this.pictureBox10.Location = new System.Drawing.Point(38, 742);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(25, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 47;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::ReinforcementLearning.Properties.Resources._3;
            this.pictureBox11.Location = new System.Drawing.Point(38, 652);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(25, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 46;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = global::ReinforcementLearning.Properties.Resources._6;
            this.pictureBox24.Location = new System.Drawing.Point(38, 382);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(25, 30);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox24.TabIndex = 55;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = global::ReinforcementLearning.Properties.Resources._4;
            this.pictureBox26.Location = new System.Drawing.Point(38, 562);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(25, 30);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox26.TabIndex = 53;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = global::ReinforcementLearning.Properties.Resources._5;
            this.pictureBox27.Location = new System.Drawing.Point(38, 467);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(25, 30);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox27.TabIndex = 52;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::ReinforcementLearning.Properties.Resources._7;
            this.pictureBox12.Location = new System.Drawing.Point(38, 287);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(25, 30);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 57;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::ReinforcementLearning.Properties.Resources._8;
            this.pictureBox13.Location = new System.Drawing.Point(38, 192);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(25, 30);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 56;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ReinforcementLearning.Properties.Resources._9;
            this.pictureBox6.Location = new System.Drawing.Point(38, 102);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 58;
            this.pictureBox6.TabStop = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(25, 28);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(75, 17);
            this.label36.TabIndex = 22;
            this.label36.Text = "Remaining";
            // 
            // textboxCansremaining
            // 
            this.textboxCansremaining.Location = new System.Drawing.Point(28, 50);
            this.textboxCansremaining.Margin = new System.Windows.Forms.Padding(4);
            this.textboxCansremaining.Name = "textboxCansremaining";
            this.textboxCansremaining.ReadOnly = true;
            this.textboxCansremaining.Size = new System.Drawing.Size(72, 22);
            this.textboxCansremaining.TabIndex = 23;
            // 
            // textboxCanscollected
            // 
            this.textboxCanscollected.Location = new System.Drawing.Point(110, 50);
            this.textboxCanscollected.Margin = new System.Windows.Forms.Padding(4);
            this.textboxCanscollected.Name = "textboxCanscollected";
            this.textboxCanscollected.ReadOnly = true;
            this.textboxCanscollected.Size = new System.Drawing.Size(71, 22);
            this.textboxCanscollected.TabIndex = 28;
            // 
            // groupboxCans
            // 
            this.groupboxCans.Controls.Add(this.label37);
            this.groupboxCans.Controls.Add(this.textboxCanscollected);
            this.groupboxCans.Controls.Add(this.textboxCansremaining);
            this.groupboxCans.Controls.Add(this.label36);
            this.groupboxCans.Location = new System.Drawing.Point(22, 78);
            this.groupboxCans.Name = "groupboxCans";
            this.groupboxCans.Size = new System.Drawing.Size(217, 97);
            this.groupboxCans.TabIndex = 59;
            this.groupboxCans.TabStop = false;
            this.groupboxCans.Text = "Can data this episode";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(108, 28);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 17);
            this.label37.TabIndex = 29;
            this.label37.Text = "Collected";
            // 
            // groupboxRewarddata
            // 
            this.groupboxRewarddata.Controls.Add(this.label38);
            this.groupboxRewarddata.Controls.Add(this.textboxRewardtotal);
            this.groupboxRewarddata.Controls.Add(this.textboxRewardepisode);
            this.groupboxRewarddata.Controls.Add(this.label39);
            this.groupboxRewarddata.Location = new System.Drawing.Point(282, 78);
            this.groupboxRewarddata.Name = "groupboxRewarddata";
            this.groupboxRewarddata.Size = new System.Drawing.Size(250, 97);
            this.groupboxRewarddata.TabIndex = 60;
            this.groupboxRewarddata.TabStop = false;
            this.groupboxRewarddata.Text = "Reward data";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(23, 29);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(89, 17);
            this.label39.TabIndex = 22;
            this.label39.Text = "This episode";
            // 
            // textboxRewardepisode
            // 
            this.textboxRewardepisode.Location = new System.Drawing.Point(26, 50);
            this.textboxRewardepisode.Margin = new System.Windows.Forms.Padding(4);
            this.textboxRewardepisode.Name = "textboxRewardepisode";
            this.textboxRewardepisode.ReadOnly = true;
            this.textboxRewardepisode.Size = new System.Drawing.Size(80, 22);
            this.textboxRewardepisode.TabIndex = 23;
            // 
            // textboxRewardtotal
            // 
            this.textboxRewardtotal.Location = new System.Drawing.Point(115, 50);
            this.textboxRewardtotal.Margin = new System.Windows.Forms.Padding(4);
            this.textboxRewardtotal.Name = "textboxRewardtotal";
            this.textboxRewardtotal.ReadOnly = true;
            this.textboxRewardtotal.Size = new System.Drawing.Size(79, 22);
            this.textboxRewardtotal.TabIndex = 28;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(160, 29);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(40, 17);
            this.label38.TabIndex = 29;
            this.label38.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1986, 1055);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupboxStatusmessage);
            this.Controls.Add(this.groupboxHistory);
            this.Controls.Add(this.groupboxQmatrix);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.groupboxSessionprogress);
            this.Controls.Add(this.groupboxAlgorithmprogress);
            this.Controls.Add(this.groupboxConfiguration);
            this.Controls.Add(this.groupboxInitialsettings);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupboxCurrentposition.ResumeLayout(false);
            this.groupboxCurrentposition.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupboxInitialsettings.ResumeLayout(false);
            this.groupboxInitialsettings.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupboxConfiguration.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupboxAdvanceepisodes.ResumeLayout(false);
            this.groupboxAdvanceepisodes.PerformLayout();
            this.groupboxAlgorithmprogress.ResumeLayout(false);
            this.groupboxSessionprogress.ResumeLayout(false);
            this.groupboxSessionprogress.PerformLayout();
            this.groupboxQmatrix.ResumeLayout(false);
            this.groupboxQmatrix.PerformLayout();
            this.groupboxHistory.ResumeLayout(false);
            this.groupboxStatusmessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupboxCans.ResumeLayout(false);
            this.groupboxCans.PerformLayout();
            this.groupboxRewarddata.ResumeLayout(false);
            this.groupboxRewarddata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private Button buttonRestart;
        private GroupBox groupboxCurrentposition;
        private TextBox textboxEncodedas;
        private Label label6;
        private TextBox textboxCurrentsquare;
        private Label label5;
        private TextBox textboxUp;
        private Label label3;
        private TextBox textboxRight;
        private Label label4;
        private TextBox textboxDown;
        private Label label2;
        private TextBox textboxLeft;
        private Label label1;
        private Button buttonStartAlgorithm;
        private GroupBox groupBox2;
        private Button buttonEpisodestextbox;
        private Button buttonEpisodesdropdown;
        private Label label7;
        private TextBox textboxEpisodesinput;
        private ComboBox comboboxEpisode;
        private GroupBox groupboxInitialsettings;
        private TextBox textboxY;
        private TextBox textboxEpsilon;
        private Label label11;
        private Label label10;
        private Label label8;
        private TextBox textboxNumberofepisodes;
        private TextBox textboxNumberofsteps;
        private Label label9;
        private GroupBox groupBox3;
        private Button buttonStepstextbox;
        private Button buttonStepsdropdown;
        private Label label12;
        private TextBox textboxStepsinput;
        private ComboBox comboboxSteps;
        private GroupBox groupBox5;
        private Button buttonNtextbox;
        private Button buttonNdropdown;
        private Label label13;
        private TextBox textboxNinput;
        private ComboBox comboboxN;
        private GroupBox groupBox6;
        private Button buttonYtextbox;
        private Button buttonYdropdown;
        private Label label14;
        private TextBox textboxYinput;
        private ComboBox comboboxY;
        private GroupBox groupboxConfiguration;
        private GroupBox groupBox8;
        private Button buttonAdvancestepstextbox;
        private ComboBox comboboxAdvancesteps;
        private Button buttonAdvancestepsdropdown;
        private TextBox textboxAdvancestepsinput;
        private Label label15;
        private GroupBox groupboxAdvanceepisodes;
        private Button buttonAdvanceepisodestextbox;
        private ComboBox comboboxAdvanceepisodes;
        private Label label16;
        private Button buttonAdvanceepisodesdropdown;
        private TextBox textboxAdvanceepisodesinput;
        private GroupBox groupboxAlgorithmprogress;
        private GroupBox groupboxSessionprogress;
        private TextBox textboxYprogress;
        private TextBox textboxNprogress;
        private Label label18;
        private TextBox textboxEpisodesprogress;
        private TextBox textboxStepsprogress;
        private Label label20;
        private TextBox textboxNinitial;
        private Label label21;
        private Label label23;
        private TextBox textBox2;
        private Label label19;
        private Label label22;
        private ComboBox comboBox1;
        private TextBox textboxQmatrixcurrent;
        private Label label17;
        private TextBox textboxQmatrixup;
        private Label label24;
        private TextBox textboxQmatrixdown;
        private TextBox textboxQmatrixright;
        private Label label25;
        private Label label26;
        private Label label27;
        private TextBox textboxQmatrixleft;
        private GroupBox groupboxQmatrix;
        private TextBox textboxBeerreward;
        private Label label30;
        private Label label29;
        private TextBox textboxEmptysquare;
        private TextBox textboxWallpunishment;
        private Label label28;
        private GroupBox groupBox11;
        private Button button7;
        private Button button8;
        private Label label34;
        private TextBox textBox14;
        private ComboBox comboBox5;
        private GroupBox groupBox10;
        private Button button5;
        private Button button6;
        private Label label33;
        private TextBox textBox13;
        private ComboBox comboBox4;
        private GroupBox groupBox9;
        private Button button3;
        private Button button4;
        private Label label32;
        private TextBox textBox12;
        private ComboBox comboBox3;
        private GroupBox groupBox7;
        private Button button1;
        private Button button2;
        private Label label31;
        private TextBox textBox11;
        private ComboBox comboBox2;
        private ComboBox comboBox6;
        private GroupBox groupboxHistory;
        private ComboBox comboBox7;
        private GroupBox groupboxStatusmessage;
        private RichTextBox textboxStatus;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox24;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox6;
        private Label label36;
        private TextBox textboxCansremaining;
        private TextBox textboxCanscollected;
        private GroupBox groupboxCans;
        private Label label37;
        private GroupBox groupboxRewarddata;
        private Label label38;
        private TextBox textboxRewardtotal;
        private TextBox textboxRewardepisode;
        private Label label39;
    }
}

