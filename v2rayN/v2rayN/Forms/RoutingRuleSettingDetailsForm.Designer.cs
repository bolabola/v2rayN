namespace v2rayN.Forms
{
    partial class RoutingRuleSettingDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutingRuleSettingDetailsForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clbInboundTag = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOutboundTag = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Controls.Add(this.clbInboundTag);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtPort);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cmbOutboundTag);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // clbInboundTag
            // 
            this.clbInboundTag.CheckOnClick = true;
            resources.ApplyResources(this.clbInboundTag, "clbInboundTag");
            this.clbInboundTag.FormattingEnabled = true;
            this.clbInboundTag.Items.AddRange(new object[] {
            resources.GetString("clbInboundTag.Items"),
            resources.GetString("clbInboundTag.Items1")});
            this.clbInboundTag.MultiColumn = true;
            this.clbInboundTag.Name = "clbInboundTag";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtPort
            // 
            resources.ApplyResources(this.txtPort, "txtPort");
            this.txtPort.Name = "txtPort";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cmbOutboundTag
            // 
            this.cmbOutboundTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutboundTag.FormattingEnabled = true;
            this.cmbOutboundTag.Items.AddRange(new object[] {
            resources.GetString("cmbOutboundTag.Items"),
            resources.GetString("cmbOutboundTag.Items1"),
            resources.GetString("cmbOutboundTag.Items2")});
            resources.ApplyResources(this.cmbOutboundTag, "cmbOutboundTag");
            this.cmbOutboundTag.Name = "cmbOutboundTag";
            // 
            // RoutingRuleSettingDetailsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "RoutingRuleSettingDetailsForm";
            this.Load += new System.EventHandler(this.RoutingRuleSettingDetailsForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOutboundTag;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.CheckedListBox clbInboundTag;
        private System.Windows.Forms.Label label2;
    }
}