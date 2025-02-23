﻿namespace GymProject
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemmanufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDataSet = new GymProject.GymDataSet();
            this.equipmentTableAdapter = new GymProject.GymDataSetTableAdapters.equipmentTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Equipments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.itemquantityDataGridViewTextBoxColumn,
            this.itemmanufacturerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.equipmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(170, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 98);
            this.dataGridView1.TabIndex = 1;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "item_ID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ID of item";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "Name of Item";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            // 
            // itemquantityDataGridViewTextBoxColumn
            // 
            this.itemquantityDataGridViewTextBoxColumn.DataPropertyName = "item_quantity";
            this.itemquantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.itemquantityDataGridViewTextBoxColumn.Name = "itemquantityDataGridViewTextBoxColumn";
            // 
            // itemmanufacturerDataGridViewTextBoxColumn
            // 
            this.itemmanufacturerDataGridViewTextBoxColumn.DataPropertyName = "item_manufacturer";
            this.itemmanufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer of Item";
            this.itemmanufacturerDataGridViewTextBoxColumn.Name = "itemmanufacturerDataGridViewTextBoxColumn";
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "equipment";
            this.equipmentBindingSource.DataSource = this.gymDataSetBindingSource;
            // 
            // gymDataSetBindingSource
            // 
            this.gymDataSetBindingSource.DataSource = this.gymDataSet;
            this.gymDataSetBindingSource.Position = 0;
            // 
            // gymDataSet
            // 
            this.gymDataSet.DataSetName = "GymDataSet";
            this.gymDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentTableAdapter
            // 
            this.equipmentTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(376, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymProject.Properties.Resources.gymfoto;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gymDataSetBindingSource;
        private GymDataSet gymDataSet;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private GymDataSetTableAdapters.equipmentTableAdapter equipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemmanufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}