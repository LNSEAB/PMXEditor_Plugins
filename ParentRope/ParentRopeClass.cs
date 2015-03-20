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
        const string caption_ = "選択ボーンを上から親子にする";

        public ParentRopeClass() :
            base()
        {
            m_option = new PEPlugin.PEPluginOption( false, true, caption_ );
        }

        public override void Run(PEPlugin.IPERunArgs args)
        {
            try {
                base.Run( args );
            }
            catch ( Exception e ) {
                MessageBox.Show( e.Message, caption_, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
