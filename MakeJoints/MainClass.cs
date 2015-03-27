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
        MakeJointsForm form_;

        public MainClass() :
            base()
        {
            m_option = new PEPlugin.PEPluginOption( true, true, caption_ );
        }

        public override void Run(PEPlugin.IPERunArgs args)
        {
            try {
                base.Run( args );

                if ( args.IsBootup ) {
                    form_ = new MakeJointsForm( args );
                }
                else {
                    form_.Visible = !form_.Visible;
                }
            }
            catch ( Exception e ) {
                MessageBox.Show( e.Message, caption_, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        public override void Dispose()
        {
            base.Dispose();
            form_.Close();
        }
    }
}
