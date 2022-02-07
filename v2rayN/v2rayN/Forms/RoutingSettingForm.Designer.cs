namespace v2rayN.Forms
{
    partial class RoutingSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoutingSettingForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmsLv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSetDefaultRouting = new System.Windows.Forms.ToolStripMenuItem();
            this.tabNormal = new System.Windows.Forms.TabControl();
            this.tabPageRuleList = new System.Windows.Forms.TabPage();
            this.lvRoutings = new v2rayN.Base.ListViewFlickerFree();
            this.panel2.SuspendLayout();
            this.cmsLv.SuspendLayout();
            this.tabNormal.SuspendLayout();
            this.tabPageRuleList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Name = "panel2";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmsLv
            // 
            resources.ApplyResources(this.cmsLv, "cmsLv");
            this.cmsLv.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsLv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuRemove,
            this.menuSelectAll,
            this.menuSetDefaultRouting});
            this.cmsLv.Name = "cmsLv";
            // 
            // menuAdd
            // 
            resources.ApplyResources(this.menuAdd, "menuAdd");
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuRemove
            // 
            resources.ApplyResources(this.menuRemove, "menuRemove");
            this.menuRemove.Name = "menuRemove";
            this.menuRemove.Click += new System.EventHandler(this.menuRemove_Click);
            // 
            // menuSelectAll
            // 
            resources.ApplyResources(this.menuSelectAll, "menuSelectAll");
            this.menuSelectAll.Name = "menuSelectAll";
            this.menuSelectAll.Click += new System.EventHandler(this.menuSelectAll_Click);
            // 
            // menuSetDefaultRouting
            // 
            resources.ApplyResources(this.menuSetDefaultRouting, "menuSetDefaultRouting");
            this.menuSetDefaultRouting.Name = "menuSetDefaultRouting";
            this.menuSetDefaultRouting.Click += new System.EventHandler(this.menuSetDefaultRouting_Click);
            // 
            // tabNormal
            // 
            resources.ApplyResources(this.tabNormal, "tabNormal");
            this.tabNormal.Controls.Add(this.tabPageRuleList);
            this.tabNormal.Name = "tabNormal";
            this.tabNormal.SelectedIndex = 0;
            this.tabNormal.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabNormal_Selecting);
            // 
            // tabPageRuleList
            // 
            resources.ApplyResources(this.tabPageRuleList, "tabPageRuleList");
            this.tabPageRuleList.Controls.Add(this.lvRoutings);
            this.tabPageRuleList.Name = "tabPageRuleList";
            this.tabPageRuleList.UseVisualStyleBackColor = true;
            // 
            // lvRoutings
            // 
            resources.ApplyResources(this.lvRoutings, "lvRoutings");
            this.lvRoutings.ContextMenuStrip = this.cmsLv;
            this.lvRoutings.FullRowSelect = true;
            this.lvRoutings.GridLines = true;
            this.lvRoutings.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRoutings.HideSelection = false;
            this.lvRoutings.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            ((System.Windows.Forms.ListViewItem)(resources.GetObject("lvRoutings.Items")))});
            this.lvRoutings.MultiSelect = false;
            this.lvRoutings.Name = "lvRoutings";
            this.lvRoutings.UseCompatibleStateImageBehavior = false;
            this.lvRoutings.View = System.Windows.Forms.View.Details;
            this.lvRoutings.DoubleClick += new System.EventHandler(this.lvRoutings_DoubleClick);
            // 
            // RoutingSettingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.tabNormal);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RoutingSettingForm";
            this.Load += new System.EventHandler(this.RoutingSettingForm_Load);
            this.panel2.ResumeLayout(false);
            this.cmsLv.ResumeLayout(false);
            this.tabNormal.ResumeLayout(false);
            this.tabPageRuleList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip cmsLv;
        private System.Windows.Forms.ToolStripMenuItem menuRemove;
        private System.Windows.Forms.ToolStripMenuItem menuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuSetDefaultRouting;
        private System.Windows.Forms.TabControl tabNormal;
        private System.Windows.Forms.TabPage tabPageRuleList;
        private Base.ListViewFlickerFree lvRoutings;
    }
}