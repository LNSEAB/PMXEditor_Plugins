using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeJoints
{
    public class MainClass :
        PEPlugin.PEPluginClass
    {
        const string caption_ = "ジョイント生成フォームを開く";

        public MainClass() :
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
