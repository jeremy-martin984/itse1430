﻿/*Jeremy Martin
 * ITSE 1430
 * Lab 3
 * 4/6/2020
 */

namespace CharacterCreator.Winforms
{
    partial class CharacterCreatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBio = new System.Windows.Forms.RichTextBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.txtPointsRemaining = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnPlusStr = new System.Windows.Forms.Button();
            this.btnMinStr = new System.Windows.Forms.Button();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtAgi = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtCha = new System.Windows.Forms.TextBox();
            this.btnPlusInt = new System.Windows.Forms.Button();
            this.btnPlusAgi = new System.Windows.Forms.Button();
            this.btnPlusCon = new System.Windows.Forms.Button();
            this.btnPlusCha = new System.Windows.Forms.Button();
            this.btnMinInt = new System.Windows.Forms.Button();
            this.btnMinAgi = new System.Windows.Forms.Button();
            this.btnMinCon = new System.Windows.Forms.Button();
            this.btnMinCha = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 26);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(432, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 35);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSave);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(546, 512);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(442, 398);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(133, 20);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "Remaining Points";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(56, 155);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(52, 20);
            this.lblClass.TabIndex = 5;
            this.lblClass.Text = "Class:";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(56, 202);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(51, 20);
            this.lblRace.TabIndex = 6;
            this.lblRace.Text = "Race:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Character Attributes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Strength:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Intelligence:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Constitution:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Agility:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Charisma:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Character Description:";
            // 
            // richTextBio
            // 
            this.richTextBio.Location = new System.Drawing.Point(60, 295);
            this.richTextBio.Name = "richTextBio";
            this.richTextBio.Size = new System.Drawing.Size(360, 161);
            this.richTextBio.TabIndex = 15;
            this.richTextBio.Text = "Enter Character biography here.";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "Bard",
            "Beastmaster",
            "Black Mage",
            "Necromancer",
            "Paladin",
            "Red mage",
            "Warrior",
            "White Mage",
            "Wizard"});
            this.comboBoxClass.Location = new System.Drawing.Point(132, 150);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(150, 28);
            this.comboBoxClass.Sorted = true;
            this.comboBoxClass.TabIndex = 16;
            this.comboBoxClass.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateClass);
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Items.AddRange(new object[] {
            "Dark Elf",
            "Dwarf",
            "High Elf",
            "Human",
            "Karen",
            "LizardMan",
            "Orc"});
            this.comboBoxRace.Location = new System.Drawing.Point(132, 202);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(150, 28);
            this.comboBoxRace.Sorted = true;
            this.comboBoxRace.TabIndex = 17;
            this.comboBoxRace.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateRace);
            // 
            // txtPointsRemaining
            // 
            this.txtPointsRemaining.Location = new System.Drawing.Point(447, 432);
            this.txtPointsRemaining.Name = "txtPointsRemaining";
            this.txtPointsRemaining.ReadOnly = true;
            this.txtPointsRemaining.Size = new System.Drawing.Size(60, 26);
            this.txtPointsRemaining.TabIndex = 23;
            this.txtPointsRemaining.Text = "50";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(56, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Name:";
            // 
            // btnPlusStr
            // 
            this.btnPlusStr.Location = new System.Drawing.Point(612, 150);
            this.btnPlusStr.Name = "btnPlusStr";
            this.btnPlusStr.Size = new System.Drawing.Size(32, 28);
            this.btnPlusStr.TabIndex = 25;
            this.btnPlusStr.Text = "+";
            this.btnPlusStr.UseVisualStyleBackColor = true;
            this.btnPlusStr.Click += new System.EventHandler(this.PlusStr);
            // 
            // btnMinStr
            // 
            this.btnMinStr.Location = new System.Drawing.Point(648, 150);
            this.btnMinStr.Name = "btnMinStr";
            this.btnMinStr.Size = new System.Drawing.Size(32, 28);
            this.btnMinStr.TabIndex = 26;
            this.btnMinStr.Text = "-";
            this.btnMinStr.UseVisualStyleBackColor = true;
            this.btnMinStr.Click += new System.EventHandler(this.MinusStr);
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(554, 154);
            this.txtStr.Name = "txtStr";
            this.txtStr.ReadOnly = true;
            this.txtStr.Size = new System.Drawing.Size(38, 26);
            this.txtStr.TabIndex = 27;
            this.txtStr.Text = "50";
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(554, 197);
            this.txtInt.Name = "txtInt";
            this.txtInt.ReadOnly = true;
            this.txtInt.Size = new System.Drawing.Size(38, 26);
            this.txtInt.TabIndex = 28;
            this.txtInt.Text = "50";
            // 
            // txtAgi
            // 
            this.txtAgi.Location = new System.Drawing.Point(554, 243);
            this.txtAgi.Name = "txtAgi";
            this.txtAgi.ReadOnly = true;
            this.txtAgi.Size = new System.Drawing.Size(38, 26);
            this.txtAgi.TabIndex = 29;
            this.txtAgi.Text = "50";
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(554, 290);
            this.txtCon.Name = "txtCon";
            this.txtCon.ReadOnly = true;
            this.txtCon.Size = new System.Drawing.Size(38, 26);
            this.txtCon.TabIndex = 30;
            this.txtCon.Text = "50";
            // 
            // txtCha
            // 
            this.txtCha.Location = new System.Drawing.Point(554, 334);
            this.txtCha.Name = "txtCha";
            this.txtCha.ReadOnly = true;
            this.txtCha.Size = new System.Drawing.Size(38, 26);
            this.txtCha.TabIndex = 31;
            this.txtCha.Text = "50";
            // 
            // btnPlusInt
            // 
            this.btnPlusInt.Location = new System.Drawing.Point(612, 194);
            this.btnPlusInt.Name = "btnPlusInt";
            this.btnPlusInt.Size = new System.Drawing.Size(32, 28);
            this.btnPlusInt.TabIndex = 32;
            this.btnPlusInt.Text = "+";
            this.btnPlusInt.UseVisualStyleBackColor = true;
            this.btnPlusInt.Click += new System.EventHandler(this.PlusInt);
            // 
            // btnPlusAgi
            // 
            this.btnPlusAgi.Location = new System.Drawing.Point(612, 240);
            this.btnPlusAgi.Name = "btnPlusAgi";
            this.btnPlusAgi.Size = new System.Drawing.Size(32, 28);
            this.btnPlusAgi.TabIndex = 33;
            this.btnPlusAgi.Text = "+";
            this.btnPlusAgi.UseVisualStyleBackColor = true;
            this.btnPlusAgi.Click += new System.EventHandler(this.PlusAgi);
            // 
            // btnPlusCon
            // 
            this.btnPlusCon.Location = new System.Drawing.Point(612, 288);
            this.btnPlusCon.Name = "btnPlusCon";
            this.btnPlusCon.Size = new System.Drawing.Size(32, 28);
            this.btnPlusCon.TabIndex = 34;
            this.btnPlusCon.Text = "+";
            this.btnPlusCon.UseVisualStyleBackColor = true;
            this.btnPlusCon.Click += new System.EventHandler(this.PlusCon);
            // 
            // btnPlusCha
            // 
            this.btnPlusCha.Location = new System.Drawing.Point(612, 330);
            this.btnPlusCha.Name = "btnPlusCha";
            this.btnPlusCha.Size = new System.Drawing.Size(32, 28);
            this.btnPlusCha.TabIndex = 35;
            this.btnPlusCha.Text = "+";
            this.btnPlusCha.UseVisualStyleBackColor = true;
            this.btnPlusCha.Click += new System.EventHandler(this.PlusCha);
            // 
            // btnMinInt
            // 
            this.btnMinInt.Location = new System.Drawing.Point(648, 194);
            this.btnMinInt.Name = "btnMinInt";
            this.btnMinInt.Size = new System.Drawing.Size(32, 28);
            this.btnMinInt.TabIndex = 36;
            this.btnMinInt.Text = "-";
            this.btnMinInt.UseVisualStyleBackColor = true;
            this.btnMinInt.Click += new System.EventHandler(this.MinusInt);
            // 
            // btnMinAgi
            // 
            this.btnMinAgi.Location = new System.Drawing.Point(648, 240);
            this.btnMinAgi.Name = "btnMinAgi";
            this.btnMinAgi.Size = new System.Drawing.Size(32, 28);
            this.btnMinAgi.TabIndex = 37;
            this.btnMinAgi.Text = "-";
            this.btnMinAgi.UseVisualStyleBackColor = true;
            this.btnMinAgi.Click += new System.EventHandler(this.MinusAgi);
            // 
            // btnMinCon
            // 
            this.btnMinCon.Location = new System.Drawing.Point(648, 288);
            this.btnMinCon.Name = "btnMinCon";
            this.btnMinCon.Size = new System.Drawing.Size(32, 28);
            this.btnMinCon.TabIndex = 38;
            this.btnMinCon.Text = "-";
            this.btnMinCon.UseVisualStyleBackColor = true;
            this.btnMinCon.Click += new System.EventHandler(this.MinusCon);
            // 
            // btnMinCha
            // 
            this.btnMinCha.Location = new System.Drawing.Point(648, 330);
            this.btnMinCha.Name = "btnMinCha";
            this.btnMinCha.Size = new System.Drawing.Size(32, 28);
            this.btnMinCha.TabIndex = 39;
            this.btnMinCha.Text = "-";
            this.btnMinCha.UseVisualStyleBackColor = true;
            this.btnMinCha.Click += new System.EventHandler(this.MinusCha);
            // 
            // _errors
            // 
            this._errors.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._errors.ContainerControl = this;
            // 
            // CharacterCreatorForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(837, 572);
            this.Controls.Add(this.btnMinCha);
            this.Controls.Add(this.btnMinCon);
            this.Controls.Add(this.btnMinAgi);
            this.Controls.Add(this.btnMinInt);
            this.Controls.Add(this.btnPlusCha);
            this.Controls.Add(this.btnPlusCon);
            this.Controls.Add(this.btnPlusAgi);
            this.Controls.Add(this.btnPlusInt);
            this.Controls.Add(this.txtCha);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.txtAgi);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.btnMinStr);
            this.Controls.Add(this.btnPlusStr);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPointsRemaining);
            this.Controls.Add(this.comboBoxRace);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.richTextBio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(859, 628);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(859, 628);
            this.Name = "CharacterCreatorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.Load += new System.EventHandler(this.CharacterCreatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBio;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.TextBox txtPointsRemaining;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnPlusStr;
        private System.Windows.Forms.Button btnMinStr;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtAgi;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.TextBox txtCha;
        private System.Windows.Forms.Button btnPlusInt;
        private System.Windows.Forms.Button btnPlusAgi;
        private System.Windows.Forms.Button btnPlusCon;
        private System.Windows.Forms.Button btnPlusCha;
        private System.Windows.Forms.Button btnMinInt;
        private System.Windows.Forms.Button btnMinAgi;
        private System.Windows.Forms.Button btnMinCon;
        private System.Windows.Forms.Button btnMinCha;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}