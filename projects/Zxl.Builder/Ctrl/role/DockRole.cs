﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using Zxl.Business.Model;
using Zxl.Business.Interface;
using Zxl.Business.Impl;
using Zxl.Data;

namespace Zxl.Builder
{
    public partial class DockRole : DockContent
    {
        public IUserService UserService = new UserService();
        public DockRole()
        {
            InitializeComponent();
            RefreshRoleTree();
        }

        public FormMain MainForm { get; set; }

        private ORUP_ROLE CurrRole;
        
        #region 角色树点击事件
        private void treeRole_MouseClick(object sender, MouseEventArgs e)
        {
            // 复选框控制
            TreeListHitInfo hitInfo = treeRole.CalcHitInfo(new Point(e.X, e.Y));
            TreeListNode node = hitInfo.Node;
            treeRole.FocusedNode = node;
            treeRole.UncheckAll();
            if (null != node)
                node.CheckState = CheckState.Checked;
            else
                return;

            treeRole.ContextMenuStrip = cmsRoles;
            // 加载右边的详情树
            if (null != treeRole.FocusedNode && treeRole.FocusedNode.Level != 0) // 点击的是非根节点
            {
                CurrRole = treeRole.FocusedNode.Tag as ORUP_ROLE;
                treeRole.ContextMenuStrip = cmsRole;
            }
        }

        private void treeRole_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DockRoleDetail drd = new DockRoleDetail();
            drd.CurrRole = CurrRole;
            drd.TabText = CurrRole.ROLENAME;
            drd.Show(MainForm.MainDockPanel);
        }


        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            ORUP_ROLE newRole = new ORUP_ROLE();
            newRole.CREATETIME = DateTime.Now;
            DlgEditRole dlg = new DlgEditRole();
            dlg.Role = newRole;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                try
                {
                    UserService.SaveRole(dlg.Role);
                    RefreshRoleTree();
                    MainForm.INFO("添加角色成功！");
                }
                catch (Exception ex)
                {
                    MainForm.ERROR("添加角色失败！" + ex.Message);
                }
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            DlgEditRole dlg = new DlgEditRole();
            dlg.Role = treeRole.FocusedNode.Tag as ORUP_ROLE;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                try
                {
                    UserService.SaveRole(dlg.Role);
                    RefreshRoleTree();
                    MainForm.INFO("编辑角色成功！");
                }
                catch (Exception ex)
                {
                    MainForm.ERROR("编辑角色失败！" + ex.Message);
                }
            }
        }

        private void tsmiDel_Click(object sender, EventArgs e)
        {
            TreeListNode currNode = treeRole.FocusedNode;

            ORUP_ROLE role = currNode.Tag as ORUP_ROLE;
            try
            {
                UserService.DelRole(role.ID);
                RefreshRoleTree();
                MainForm.INFO("删除角色成功！");
            }
            catch (Exception ex)
            {
                MainForm.ERROR("删除角色失败！" + ex.Message);
            }
        }

        /// <summary>
        /// 刷新角色树
        /// </summary>
        void RefreshRoleTree()
        {
            treeRole.Nodes.Clear();
            ORUP_ROLE obj = new ORUP_ROLE();
            obj.ID = -1;
            obj.ROLENAME = "角色列表";
            TreeListNode root = treeRole.AppendNode(new object[] { obj.ROLENAME }, obj.ID);
            root.Tag = obj;

            List<ORUP_ROLE> roles = UserService.Roles();
            foreach (ORUP_ROLE role in roles)
            {
                TreeListNode node = treeRole.AppendNode(new object[] { role.ROLENAME, role.DESCRIPTION }, root);
                node.Tag = role;
            }

            treeRole.ExpandAll();
        }
        #endregion 角色树点击事件
    }
}
