using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labs
{
    public class SummaryForm : System.Windows.Forms.Form
    {
        private Label label1;

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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 307);
            this.Controls.Add(this.label1);
            this.Name = "SummaryForm";
            this.Text = "Summary View";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        public SummaryForm()
        {
            InitializeComponent();
            PersonDataModel.getDataModel().PersonModelChanged += new PersonModelChangedEventHandler(this.PersonModelChanged);
            updateForm();
           
        }

       
        private void PersonModelChanged(object sender, PersonDataModelChangedEventArgs e)
        {
            updateForm();
        }

        private void updateForm()
        {
            String txt = "";

            foreach (var city in PersonDataModel.getCities())
            {
                txt += $"Persons from {city.Key}: {city.Value}{Environment.NewLine}"; 
            }
            label1.Text = txt;
        }
        private void SummaryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
