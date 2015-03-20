using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentRope
{
    public class ParentRopeClass :
        PEPlugin.PEPluginClass
    {
        const string caption_ = "選択ボーンを親子にする";

        public ParentRopeClass() :
            base()
        {
            m_option = new PEPlugin.PEPluginOption( false, true, caption_ );
        }

        public override void Run(PEPlugin.IPERunArgs args)
        {
            try {
                base.Run( args );

                var pmx = args.Host.Connector.Pmx.GetCurrentState();
                var bones = PmxE.Objects.GetSelectedBones( args.Host, pmx );

                for ( int i = 0; i < bones.Count - 1; ++i ) {
                    bones[i + 1].Parent = bones[i];
                    bones[i].ToBone = bones[i + 1];
                }

                args.Host.Connector.Pmx.Update( pmx );
                args.Host.Connector.View.PmxView.UpdateModel_Bone();
                PmxE.Form.UpdateList( args.Host.Connector, PmxE.FormTab.Bone );
            }
            catch ( Exception e ) {
                MessageBox.Show( e.Message, caption_, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
