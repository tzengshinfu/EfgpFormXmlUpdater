namespace EfgpFormXmlUpdater {
    partial class frmMain {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabProcessId = new System.Windows.Forms.TabControl();
            this.tpgProcessId = new System.Windows.Forms.TabPage();
            this.txtProcessId = new System.Windows.Forms.TextBox();
            this.tabFormXml = new System.Windows.Forms.TabControl();
            this.tpgFormXml = new System.Windows.Forms.TabPage();
            this.rtxFormXml = new EfgpFormXmlUpdater.ucXmlRichTextBox();
            this.btnQueryFormXml = new System.Windows.Forms.Button();
            this.btnUpdateFormXml = new System.Windows.Forms.Button();
            this.btnQueryFormMaskXml = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.tipNotice = new System.Windows.Forms.ToolTip(this.components);
            this.tabProcessId.SuspendLayout();
            this.tpgProcessId.SuspendLayout();
            this.tabFormXml.SuspendLayout();
            this.tpgFormXml.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabProcessId
            // 
            this.tabProcessId.Controls.Add(this.tpgProcessId);
            this.tabProcessId.Location = new System.Drawing.Point(13, 13);
            this.tabProcessId.Margin = new System.Windows.Forms.Padding(4);
            this.tabProcessId.Name = "tabProcessId";
            this.tabProcessId.SelectedIndex = 0;
            this.tabProcessId.Size = new System.Drawing.Size(651, 92);
            this.tabProcessId.TabIndex = 1;
            // 
            // tpgProcessId
            // 
            this.tpgProcessId.Controls.Add(this.txtProcessId);
            this.tpgProcessId.Location = new System.Drawing.Point(4, 30);
            this.tpgProcessId.Margin = new System.Windows.Forms.Padding(4);
            this.tpgProcessId.Name = "tpgProcessId";
            this.tpgProcessId.Padding = new System.Windows.Forms.Padding(4);
            this.tpgProcessId.Size = new System.Drawing.Size(643, 58);
            this.tpgProcessId.TabIndex = 1;
            this.tpgProcessId.Text = "流程序號";
            this.tpgProcessId.UseVisualStyleBackColor = true;
            // 
            // txtProcessId
            // 
            this.txtProcessId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcessId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcessId.Font = new System.Drawing.Font("細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProcessId.Location = new System.Drawing.Point(6, 8);
            this.txtProcessId.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcessId.Name = "txtProcessId";
            this.txtProcessId.Size = new System.Drawing.Size(630, 35);
            this.txtProcessId.TabIndex = 0;
            this.txtProcessId.DoubleClick += new System.EventHandler(this.txtProcessId_DoubleClick);
            // 
            // tabFormXml
            // 
            this.tabFormXml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabFormXml.Controls.Add(this.tpgFormXml);
            this.tabFormXml.Location = new System.Drawing.Point(13, 122);
            this.tabFormXml.Margin = new System.Windows.Forms.Padding(4);
            this.tabFormXml.Name = "tabFormXml";
            this.tabFormXml.SelectedIndex = 0;
            this.tabFormXml.Size = new System.Drawing.Size(1320, 817);
            this.tabFormXml.TabIndex = 2;
            // 
            // tpgFormXml
            // 
            this.tpgFormXml.Controls.Add(this.rtxFormXml);
            this.tpgFormXml.Location = new System.Drawing.Point(4, 30);
            this.tpgFormXml.Margin = new System.Windows.Forms.Padding(4);
            this.tpgFormXml.Name = "tpgFormXml";
            this.tpgFormXml.Padding = new System.Windows.Forms.Padding(4);
            this.tpgFormXml.Size = new System.Drawing.Size(1312, 783);
            this.tpgFormXml.TabIndex = 0;
            this.tpgFormXml.Text = "查詢流程表單XML";
            this.tpgFormXml.UseVisualStyleBackColor = true;
            // 
            // rtxFormXml
            // 
            this.rtxFormXml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxFormXml.DetectUrls = false;
            this.rtxFormXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxFormXml.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxFormXml.Location = new System.Drawing.Point(4, 4);
            this.rtxFormXml.Name = "rtxFormXml";
            this.rtxFormXml.Size = new System.Drawing.Size(1304, 775);
            this.rtxFormXml.TabIndex = 0;
            this.rtxFormXml.Text = "";
            this.rtxFormXml.WordWrap = false;
            this.rtxFormXml.Xml = "";
            this.rtxFormXml.DoubleClick += new System.EventHandler(this.rtxFormXml_DoubleClick);
            // 
            // btnQueryFormXml
            // 
            this.btnQueryFormXml.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQueryFormXml.Location = new System.Drawing.Point(672, 51);
            this.btnQueryFormXml.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryFormXml.Name = "btnQueryFormXml";
            this.btnQueryFormXml.Size = new System.Drawing.Size(169, 48);
            this.btnQueryFormXml.TabIndex = 3;
            this.btnQueryFormXml.Text = "查詢流程表單XML";
            this.btnQueryFormXml.UseVisualStyleBackColor = true;
            this.btnQueryFormXml.Click += new System.EventHandler(this.btnQueryFormXml_Click);
            // 
            // btnUpdateFormXml
            // 
            this.btnUpdateFormXml.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdateFormXml.Location = new System.Drawing.Point(1073, 51);
            this.btnUpdateFormXml.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateFormXml.Name = "btnUpdateFormXml";
            this.btnUpdateFormXml.Size = new System.Drawing.Size(120, 48);
            this.btnUpdateFormXml.TabIndex = 4;
            this.btnUpdateFormXml.Text = "寫入XML";
            this.btnUpdateFormXml.UseVisualStyleBackColor = true;
            this.btnUpdateFormXml.Click += new System.EventHandler(this.btnUpdateFormXml_Click);
            // 
            // btnQueryFormMaskXml
            // 
            this.btnQueryFormMaskXml.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnQueryFormMaskXml.Location = new System.Drawing.Point(849, 51);
            this.btnQueryFormMaskXml.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryFormMaskXml.Name = "btnQueryFormMaskXml";
            this.btnQueryFormMaskXml.Size = new System.Drawing.Size(216, 48);
            this.btnQueryFormMaskXml.TabIndex = 5;
            this.btnQueryFormMaskXml.Text = "查詢流程表單遮罩XML";
            this.btnQueryFormMaskXml.UseVisualStyleBackColor = true;
            this.btnQueryFormMaskXml.Click += new System.EventHandler(this.btnQueryFormMaskXml_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(1200, 51);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(133, 48);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "取回前次XML";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 952);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnQueryFormMaskXml);
            this.Controls.Add(this.btnUpdateFormXml);
            this.Controls.Add(this.btnQueryFormXml);
            this.Controls.Add(this.tabFormXml);
            this.Controls.Add(this.tabProcessId);
            this.Font = new System.Drawing.Font("細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "EasyFlow GP流程表單XML更新程式";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabProcessId.ResumeLayout(false);
            this.tpgProcessId.ResumeLayout(false);
            this.tpgProcessId.PerformLayout();
            this.tabFormXml.ResumeLayout(false);
            this.tpgFormXml.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProcessId;
        private System.Windows.Forms.TabPage tpgProcessId;
        private System.Windows.Forms.TextBox txtProcessId;
        private System.Windows.Forms.TabControl tabFormXml;
        private System.Windows.Forms.TabPage tpgFormXml;
        private System.Windows.Forms.Button btnQueryFormXml;
        private System.Windows.Forms.Button btnUpdateFormXml;
        private System.Windows.Forms.Button btnQueryFormMaskXml;
        private ucXmlRichTextBox rtxFormXml;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ToolTip tipNotice;
    }
}