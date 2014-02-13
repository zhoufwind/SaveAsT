namespace WindowsFormsSaveObjectsAsXMLAndJSON
{
    partial class FromSaveAsXML_JSON
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
            this.buttonHydr8 = new System.Windows.Forms.Button();
            this.buttonSaveAsXML = new System.Windows.Forms.Button();
            this.buttonSaveAsJSON = new System.Windows.Forms.Button();
            this.buttonSaveAsCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHydr8
            // 
            this.buttonHydr8.Location = new System.Drawing.Point(218, 41);
            this.buttonHydr8.Name = "buttonHydr8";
            this.buttonHydr8.Size = new System.Drawing.Size(75, 23);
            this.buttonHydr8.TabIndex = 0;
            this.buttonHydr8.Text = "Initialise";
            this.buttonHydr8.UseVisualStyleBackColor = true;
            this.buttonHydr8.Click += new System.EventHandler(this.buttonHydr8_Click);
            // 
            // buttonSaveAsXML
            // 
            this.buttonSaveAsXML.Location = new System.Drawing.Point(12, 142);
            this.buttonSaveAsXML.Name = "buttonSaveAsXML";
            this.buttonSaveAsXML.Size = new System.Drawing.Size(107, 23);
            this.buttonSaveAsXML.TabIndex = 1;
            this.buttonSaveAsXML.Text = "Save As XML";
            this.buttonSaveAsXML.UseVisualStyleBackColor = true;
            this.buttonSaveAsXML.Click += new System.EventHandler(this.buttonSaveAsXML_Click);
            // 
            // buttonSaveAsJSON
            // 
            this.buttonSaveAsJSON.Location = new System.Drawing.Point(202, 142);
            this.buttonSaveAsJSON.Name = "buttonSaveAsJSON";
            this.buttonSaveAsJSON.Size = new System.Drawing.Size(107, 23);
            this.buttonSaveAsJSON.TabIndex = 2;
            this.buttonSaveAsJSON.Text = "Save As JSON";
            this.buttonSaveAsJSON.UseVisualStyleBackColor = true;
            this.buttonSaveAsJSON.Click += new System.EventHandler(this.buttonSaveAsJSON_Click);
            // 
            // buttonSaveAsCSV
            // 
            this.buttonSaveAsCSV.Location = new System.Drawing.Point(378, 142);
            this.buttonSaveAsCSV.Name = "buttonSaveAsCSV";
            this.buttonSaveAsCSV.Size = new System.Drawing.Size(107, 23);
            this.buttonSaveAsCSV.TabIndex = 3;
            this.buttonSaveAsCSV.Text = "Save As CSV";
            this.buttonSaveAsCSV.UseVisualStyleBackColor = true;
            this.buttonSaveAsCSV.Click += new System.EventHandler(this.buttonSaveAsCSV_Click);
            // 
            // FromSaveAsXML_JSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 273);
            this.Controls.Add(this.buttonSaveAsCSV);
            this.Controls.Add(this.buttonSaveAsJSON);
            this.Controls.Add(this.buttonSaveAsXML);
            this.Controls.Add(this.buttonHydr8);
            this.Name = "FromSaveAsXML_JSON";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHydr8;
        private System.Windows.Forms.Button buttonSaveAsXML;
        private System.Windows.Forms.Button buttonSaveAsJSON;
        private System.Windows.Forms.Button buttonSaveAsCSV;
    }
}

