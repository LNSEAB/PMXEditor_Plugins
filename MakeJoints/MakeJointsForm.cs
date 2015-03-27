using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeJoints
{
    public partial class MakeJointsForm : Form
    {
        PEPlugin.IPEConnector conn_;
        BodyList bl_;

        public MakeJointsForm(PEPlugin.IPERunArgs args)
        {
            InitializeComponent();

            conn_ = args.Host.Connector;
            bl_ = new BodyList();

            this.Visible = false;
        }

        private void SetSelectedIndex(ListBox lb, int index)
        {
            if ( index < lb.Items.Count ) {
                lb.SelectedIndex = index;
            }
            else if ( index == lb.Items.Count ) {
                lb.SelectedIndex = index - 1;
            }
            else {
                lb.SelectedIndex = -1;
            }
        }

        private void UpdateListBoxes()
        {
            BodyListBox.BeginUpdate();
            AppliedBodyListBox.BeginUpdate();

            BodyListBox.Items.Clear();
            AppliedBodyListBox.Items.Clear();
            foreach ( var elem in bl_ ) {
                if ( elem.Applied ) {
                    AppliedBodyListBox.Items.Add( elem.Data.Name );
                }
                else {
                    BodyListBox.Items.Add( elem.Data.Name );
                }
            }

            AppliedBodyListBox.EndUpdate();
            BodyListBox.EndUpdate();
        }

        private void MakeJointsForm_Activated(object sender, EventArgs e)
        {
            var pmx = conn_.Pmx.GetCurrentState();
            var indices = conn_.View.PmxView.GetSelectedBodyIndices();

            bl_.Update( pmx.Body );
            UpdateListBoxes();
        }

        private void MakeJointsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( e.CloseReason == CloseReason.UserClosing ) {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if ( BodyListBox.SelectedIndex == -1 ) {
                return;
            }

            var l = bl_.Where( (b) => !b.Applied ).ToList();
            foreach ( int i in BodyListBox.SelectedIndices ) {
                l[i].Applied = true;
            }

            var index = BodyListBox.SelectedIndices[0];

            UpdateListBoxes();
            SetSelectedIndex( BodyListBox, index );
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if ( AppliedBodyListBox.SelectedIndex == -1 ) {
                return;
            }

            var l = bl_.Where( (b) => b.Applied ).ToList();
            foreach ( int i in AppliedBodyListBox.SelectedIndices ) {
                l[i].Applied = false;
            }

            var index = AppliedBodyListBox.SelectedIndices[0];

            UpdateListBoxes();
            SetSelectedIndex( AppliedBodyListBox, index );
        }

        private void ApplyAllButton_Click(object sender, EventArgs e)
        {
            foreach ( var elem in bl_ ) {
                elem.Applied = true;
            }

            UpdateListBoxes();
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            foreach ( var elem in bl_ ) {
                elem.Applied = false;
            }

            UpdateListBoxes();
        }
    }
}
