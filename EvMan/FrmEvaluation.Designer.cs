namespace Evaluation_Manager
{
    partial class FrmEvaluation
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
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.lblAktivnost = new System.Windows.Forms.Label();
            this.lblUvjetP = new System.Windows.Forms.Label();
            this.lblUvjetO = new System.Windows.Forms.Label();
            this.lblOcjenjivac = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblBodovi = new System.Windows.Forms.Label();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvaluationDate = new System.Windows.Forms.TextBox();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(22, 68);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.ReadOnly = true;
            this.txtActivityDescription.Size = new System.Drawing.Size(766, 193);
            this.txtActivityDescription.TabIndex = 0;
            this.txtActivityDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAktivnost
            // 
            this.lblAktivnost.AutoSize = true;
            this.lblAktivnost.Location = new System.Drawing.Point(19, 15);
            this.lblAktivnost.Name = "lblAktivnost";
            this.lblAktivnost.Size = new System.Drawing.Size(54, 13);
            this.lblAktivnost.TabIndex = 1;
            this.lblAktivnost.Text = "Aktivnost:";
            // 
            // lblUvjetP
            // 
            this.lblUvjetP.AutoSize = true;
            this.lblUvjetP.Location = new System.Drawing.Point(559, 26);
            this.lblUvjetP.Name = "lblUvjetP";
            this.lblUvjetP.Size = new System.Drawing.Size(80, 13);
            this.lblUvjetP.TabIndex = 2;
            this.lblUvjetP.Text = "Uvjet za potpis:";
            // 
            // lblUvjetO
            // 
            this.lblUvjetO.AutoSize = true;
            this.lblUvjetO.Location = new System.Drawing.Point(679, 26);
            this.lblUvjetO.Name = "lblUvjetO";
            this.lblUvjetO.Size = new System.Drawing.Size(84, 13);
            this.lblUvjetO.TabIndex = 3;
            this.lblUvjetO.Text = "Uvjet za ocjenu:";
            // 
            // lblOcjenjivac
            // 
            this.lblOcjenjivac.AutoSize = true;
            this.lblOcjenjivac.Location = new System.Drawing.Point(417, 275);
            this.lblOcjenjivac.Name = "lblOcjenjivac";
            this.lblOcjenjivac.Size = new System.Drawing.Size(60, 13);
            this.lblOcjenjivac.TabIndex = 4;
            this.lblOcjenjivac.Text = "Ocjenjivač:";
            this.lblOcjenjivac.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(559, 275);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(92, 13);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum evaluacije:";
            // 
            // lblBodovi
            // 
            this.lblBodovi.AutoSize = true;
            this.lblBodovi.Location = new System.Drawing.Point(697, 275);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(43, 13);
            this.lblBodovi.TabIndex = 6;
            this.lblBodovi.Text = "Bodovi:";
            // 
            // cboActivities
            // 
            this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(22, 36);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(252, 21);
            this.cboActivities.TabIndex = 7;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(562, 42);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(111, 20);
            this.txtMinForSignature.TabIndex = 8;
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(679, 42);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(109, 20);
            this.txtMinForGrade.TabIndex = 9;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(420, 291);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(136, 20);
            this.txtTeacher.TabIndex = 10;
            // 
            // txtEvaluationDate
            // 
            this.txtEvaluationDate.Location = new System.Drawing.Point(562, 291);
            this.txtEvaluationDate.Name = "txtEvaluationDate";
            this.txtEvaluationDate.ReadOnly = true;
            this.txtEvaluationDate.Size = new System.Drawing.Size(132, 20);
            this.txtEvaluationDate.TabIndex = 11;
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(700, 291);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(88, 20);
            this.numPoints.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(594, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 24);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(694, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 24);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.txtEvaluationDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.lblBodovi);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblOcjenjivac);
            this.Controls.Add(this.lblUvjetO);
            this.Controls.Add(this.lblUvjetP);
            this.Controls.Add(this.lblAktivnost);
            this.Controls.Add(this.txtActivityDescription);
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaluation";
            this.Load += new System.EventHandler(this.FrmEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.Label lblAktivnost;
        private System.Windows.Forms.Label lblUvjetP;
        private System.Windows.Forms.Label lblUvjetO;
        private System.Windows.Forms.Label lblOcjenjivac;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblBodovi;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvaluationDate;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}