﻿namespace Kliniken
{
    partial class ctrMitarbeiterEinfügen
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtpEingestelltAm = new System.Windows.Forms.DateTimePicker();
            this.txtSteuerID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErstelltBeiUser = new System.Windows.Forms.Label();
            this.lblMitarbeiterID = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVersichertBei = new System.Windows.Forms.ComboBox();
            this.gbMitarbeiterInfo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMitarbeiterZustand = new System.Windows.Forms.ComboBox();
            this.txtGefeuertAm = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbMitarbeiterInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEingestelltAm
            // 
            this.dtpEingestelltAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEingestelltAm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEingestelltAm.Location = new System.Drawing.Point(191, 190);
            this.dtpEingestelltAm.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEingestelltAm.Name = "dtpEingestelltAm";
            this.dtpEingestelltAm.Size = new System.Drawing.Size(789, 31);
            this.dtpEingestelltAm.TabIndex = 52;
            // 
            // txtSteuerID
            // 
            this.txtSteuerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteuerID.Location = new System.Drawing.Point(191, 98);
            this.txtSteuerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSteuerID.MaxLength = 12;
            this.txtSteuerID.Name = "txtSteuerID";
            this.txtSteuerID.Size = new System.Drawing.Size(789, 31);
            this.txtSteuerID.TabIndex = 50;
            this.txtSteuerID.Validating += new System.ComponentModel.CancelEventHandler(this.txtSteuerID_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(62, 241);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "GefeuertAm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 199);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "EingestelltAm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "SteuerID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "VersichertBei:";
            // 
            // lblErstelltBeiUser
            // 
            this.lblErstelltBeiUser.AutoSize = true;
            this.lblErstelltBeiUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErstelltBeiUser.ForeColor = System.Drawing.Color.Red;
            this.lblErstelltBeiUser.Location = new System.Drawing.Point(695, 27);
            this.lblErstelltBeiUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblErstelltBeiUser.Name = "lblErstelltBeiUser";
            this.lblErstelltBeiUser.Size = new System.Drawing.Size(69, 20);
            this.lblErstelltBeiUser.TabIndex = 40;
            this.lblErstelltBeiUser.Text = "[?????]";
            // 
            // lblMitarbeiterID
            // 
            this.lblMitarbeiterID.AutoSize = true;
            this.lblMitarbeiterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMitarbeiterID.ForeColor = System.Drawing.Color.Red;
            this.lblMitarbeiterID.Location = new System.Drawing.Point(187, 63);
            this.lblMitarbeiterID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMitarbeiterID.Name = "lblMitarbeiterID";
            this.lblMitarbeiterID.Size = new System.Drawing.Size(49, 20);
            this.lblMitarbeiterID.TabIndex = 39;
            this.lblMitarbeiterID.Text = "[???]";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.Red;
            this.lblPersonID.Location = new System.Drawing.Point(189, 27);
            this.lblPersonID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(49, 20);
            this.lblPersonID.TabIndex = 38;
            this.lblPersonID.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "ErstelltBeiUser:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "MitarbeiterID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "PersonID:";
            // 
            // cbVersichertBei
            // 
            this.cbVersichertBei.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVersichertBei.FormattingEnabled = true;
            this.cbVersichertBei.Location = new System.Drawing.Point(191, 142);
            this.cbVersichertBei.Name = "cbVersichertBei";
            this.cbVersichertBei.Size = new System.Drawing.Size(790, 32);
            this.cbVersichertBei.TabIndex = 55;
            // 
            // gbMitarbeiterInfo
            // 
            this.gbMitarbeiterInfo.Controls.Add(this.label6);
            this.gbMitarbeiterInfo.Controls.Add(this.cbMitarbeiterZustand);
            this.gbMitarbeiterInfo.Controls.Add(this.txtGefeuertAm);
            this.gbMitarbeiterInfo.Controls.Add(this.label1);
            this.gbMitarbeiterInfo.Controls.Add(this.cbVersichertBei);
            this.gbMitarbeiterInfo.Controls.Add(this.dtpEingestelltAm);
            this.gbMitarbeiterInfo.Controls.Add(this.label2);
            this.gbMitarbeiterInfo.Controls.Add(this.label11);
            this.gbMitarbeiterInfo.Controls.Add(this.label10);
            this.gbMitarbeiterInfo.Controls.Add(this.label3);
            this.gbMitarbeiterInfo.Controls.Add(this.lblPersonID);
            this.gbMitarbeiterInfo.Controls.Add(this.lblMitarbeiterID);
            this.gbMitarbeiterInfo.Controls.Add(this.lblErstelltBeiUser);
            this.gbMitarbeiterInfo.Controls.Add(this.txtSteuerID);
            this.gbMitarbeiterInfo.Controls.Add(this.label4);
            this.gbMitarbeiterInfo.Controls.Add(this.label5);
            this.gbMitarbeiterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMitarbeiterInfo.ForeColor = System.Drawing.Color.Black;
            this.gbMitarbeiterInfo.Location = new System.Drawing.Point(15, 17);
            this.gbMitarbeiterInfo.Name = "gbMitarbeiterInfo";
            this.gbMitarbeiterInfo.Size = new System.Drawing.Size(1001, 290);
            this.gbMitarbeiterInfo.TabIndex = 56;
            this.gbMitarbeiterInfo.TabStop = false;
            this.gbMitarbeiterInfo.Text = "Mitarbeiter Info";
            this.gbMitarbeiterInfo.Enter += new System.EventHandler(this.gbMitarbeiterInfo_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(605, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Zustand:";
            // 
            // cbMitarbeiterZustand
            // 
            this.cbMitarbeiterZustand.FormattingEnabled = true;
            this.cbMitarbeiterZustand.Items.AddRange(new object[] {
            "Aktive",
            "Inaktive",
            "Gekündigt"});
            this.cbMitarbeiterZustand.Location = new System.Drawing.Point(699, 63);
            this.cbMitarbeiterZustand.Name = "cbMitarbeiterZustand";
            this.cbMitarbeiterZustand.Size = new System.Drawing.Size(186, 32);
            this.cbMitarbeiterZustand.TabIndex = 57;
            // 
            // txtGefeuertAm
            // 
            this.txtGefeuertAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGefeuertAm.Location = new System.Drawing.Point(189, 234);
            this.txtGefeuertAm.MaxLength = 10;
            this.txtGefeuertAm.Name = "txtGefeuertAm";
            this.txtGefeuertAm.Size = new System.Drawing.Size(790, 31);
            this.txtGefeuertAm.TabIndex = 56;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrMitarbeiterEinfügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMitarbeiterInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrMitarbeiterEinfügen";
            this.Size = new System.Drawing.Size(1031, 312);
            this.Load += new System.EventHandler(this.ctrMitarbeiterEinfügen_Load);
            this.gbMitarbeiterInfo.ResumeLayout(false);
            this.gbMitarbeiterInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpEingestelltAm;
        private System.Windows.Forms.TextBox txtSteuerID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErstelltBeiUser;
        private System.Windows.Forms.Label lblMitarbeiterID;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVersichertBei;
        private System.Windows.Forms.GroupBox gbMitarbeiterInfo;
        private System.Windows.Forms.TextBox txtGefeuertAm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMitarbeiterZustand;
    }
}
