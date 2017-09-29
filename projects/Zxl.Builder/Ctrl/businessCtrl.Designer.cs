﻿namespace Zxl.Builder
{
    partial class businessCtrl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeBusiness = new System.Windows.Forms.TreeView();
            this.cmsBusinesses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsBusiness = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsiAddBusiness = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditBusiness = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelBusiness = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.cmsBusinesses.SuspendLayout();
            this.cmsBusiness.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeBusiness);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(993, 516);
            this.splitContainerControl1.SplitterPosition = 262;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeBusiness
            // 
            this.treeBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeBusiness.Location = new System.Drawing.Point(0, 0);
            this.treeBusiness.Name = "treeBusiness";
            this.treeBusiness.Size = new System.Drawing.Size(262, 516);
            this.treeBusiness.TabIndex = 0;
            // 
            // cmsBusinesses
            // 
            this.cmsBusinesses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsiAddBusiness});
            this.cmsBusinesses.Name = "contextMenuBd";
            this.cmsBusinesses.Size = new System.Drawing.Size(125, 26);
            // 
            // cmsBusiness
            // 
            this.cmsBusiness.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditBusiness,
            this.tsmiDelBusiness});
            this.cmsBusiness.Name = "contextMenuBd";
            this.cmsBusiness.Size = new System.Drawing.Size(153, 70);
            // 
            // cmsiAddBusiness
            // 
            this.cmsiAddBusiness.Image = global::Zxl.Builder.Properties.Resources.add1;
            this.cmsiAddBusiness.Name = "cmsiAddBusiness";
            this.cmsiAddBusiness.Size = new System.Drawing.Size(124, 22);
            this.cmsiAddBusiness.Text = "添加业务";
            this.cmsiAddBusiness.Click += new System.EventHandler(this.cmsiAddMaterial_Click);
            // 
            // tsmiEditBusiness
            // 
            this.tsmiEditBusiness.Image = global::Zxl.Builder.Properties.Resources.edit1;
            this.tsmiEditBusiness.Name = "tsmiEditBusiness";
            this.tsmiEditBusiness.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditBusiness.Text = "编辑业务";
            this.tsmiEditBusiness.Click += new System.EventHandler(this.tsmiEditBusiness_Click);
            // 
            // tsmiDelBusiness
            // 
            this.tsmiDelBusiness.Image = global::Zxl.Builder.Properties.Resources.del1;
            this.tsmiDelBusiness.Name = "tsmiDelBusiness";
            this.tsmiDelBusiness.Size = new System.Drawing.Size(152, 22);
            this.tsmiDelBusiness.Text = "删除业务";
            this.tsmiDelBusiness.Click += new System.EventHandler(this.tsmiDelBusiness_Click);
            // 
            // businessCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "businessCtrl";
            this.Size = new System.Drawing.Size(993, 516);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.cmsBusinesses.ResumeLayout(false);
            this.cmsBusiness.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ContextMenuStrip cmsBusinesses;
        private System.Windows.Forms.ToolStripMenuItem cmsiAddBusiness;
        private System.Windows.Forms.TreeView treeBusiness;
        private System.Windows.Forms.ContextMenuStrip cmsBusiness;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditBusiness;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelBusiness;
    }
}
