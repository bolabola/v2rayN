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
                rulesItem.outboundTag = cmbOutboundTag.Text;
                rulesItem.enabled = chkEnabled.Checked;
            }
        }
        private void BindingData()
        {
            if (rulesItem != null)
            {
                cmbOutboundTag.Text = rulesItem.outboundTag;
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

                chkEnabled.Checked = rulesItem.enabled;
            }
        }
        private void ClearBind()
        {
            txtPort.Text = string.Empty;
            cmbOutboundTag.Text = Global.agentTag;
            chkEnabled.Checked = true;
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
    }
}
