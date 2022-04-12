using System;
using System.Collections.Generic;
using System.Windows.Forms;
using v2rayN.Base;
using v2rayN.Handler;
using v2rayN.Mode;

namespace v2rayN.Forms
{
    public partial class RoutingRuleSettingDetailsForm : BaseForm
    {
        public RulesItem rulesItem
        {
            get; set;
        }

        public RoutingRuleSettingDetailsForm()
        {
            InitializeComponent();
            clbInboundTag.DataSource = config.inboundTags;

            clbOutboundTag.DataSource = config.vmess;
            clbOutboundTag.ValueMember = "remarks";
            clbOutboundTag.DisplayMember = "remarks";
        }

        private void RoutingRuleSettingDetailsForm_Load(object sender, EventArgs e)
        {
            if (Utils.IsNullOrEmpty(rulesItem.outboundTag))
            {
                ClearBind();
            }
            else
            {
                BindingData();
            }
        }

        private void EndBindingData()
        {
            if (rulesItem != null)
            {
                var inboundTag = new List<String>();
                for (int i = 0; i < clbInboundTag.Items.Count; i++)
                {
                    if (clbInboundTag.GetItemChecked(i))
                    {
                        inboundTag.Add(clbInboundTag.Items[i].ToString());
                    }
                }
                rulesItem.inboundTag = inboundTag;

                string outboundTag = string.Empty;
                for (int i = 0; i < clbOutboundTag.Items.Count; i++)
                {
                    if (clbOutboundTag.GetItemChecked(i))
                    {
                        outboundTag=((VmessItem)clbOutboundTag.Items[i]).remarks;
                    }
                }
                rulesItem.outboundTag = outboundTag;
            }
        }
        private void BindingData()
        {
            if (rulesItem != null)
            {
                if (rulesItem.outboundTag != string.Empty)
                { 
                    for (int i = 0; i < clbOutboundTag.Items.Count; i++)
                    {
                        if (rulesItem.outboundTag.Equals(((VmessItem)clbOutboundTag.Items[i]).remarks))
                        {
                            clbOutboundTag.SetItemChecked(i, true);
                        }
                    }
                }

                if (rulesItem.inboundTag != null)
                {
                    for (int i = 0; i < clbInboundTag.Items.Count; i++)
                    {
                        if (rulesItem.inboundTag.Contains(clbInboundTag.Items[i].ToString()))
                        {
                            clbInboundTag.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }
        private void ClearBind()
        {
            clbOutboundTag.Text =string.Empty;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            EndBindingData();
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
        public bool canContinue = true;
        private void clbOutboundTag_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = sender as CheckedListBox;

            //勾选原选项
            if (clb.CheckedIndices.Count > 0 && clb.CheckedIndices[0] == e.Index && canContinue)
            {
                e.NewValue = CheckState.Checked;
            }
            //第一次勾选
            else if (clb.CheckedIndices.Count == 0)
            {
                canContinue = true;
            }
            //勾选新选项
            else if (clb.CheckedIndices.Count > 0 && clb.CheckedIndices[0] != e.Index)
            {
                canContinue = false;
                clb.SetItemChecked(clb.CheckedIndices[0], false);
            }
            //勾选新选项后重置CanContinue
            else
            {
                canContinue = true;
            }
        }
    }
}
