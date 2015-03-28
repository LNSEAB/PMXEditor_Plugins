using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameChecker
{
    public class MainClass :
        PEPlugin.PEPluginClass
    {
        private const string caption_ = "指の番号と足つま先IKを全角にする";

        public MainClass() :
            base()
        {
            m_option = new PEPlugin.PEPluginOption( false, true, caption_ );
        }

        public override void Run(PEPlugin.IPERunArgs args)
        {
            try {
                base.Run( args );

                var pmx = args.Host.Connector.Pmx.GetCurrentState();

                foreach ( var bone in pmx.Bone ) {
                    string name = CheckFinger( bone.Name );
                    if ( name != null ) {
                        bone.Name = name;
                        continue;
                    }
                    name = CheckIK( bone.Name );
                    if ( name != null ) {
                        bone.Name = name;
                        continue;
                    }
                }

                args.Host.Connector.Pmx.Update( pmx );
                args.Host.Connector.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Bone );
            }
            catch ( Exception e ) {
                MessageBox.Show( e.Message, caption_, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
        
        private string CheckFinger(string name)
        {
            string pattern = "((?:左|右).指)([1-3])";

            var m = Regex.Match( name, pattern );
            if ( !m.Success ) {
                return null;
            }

            return m.Groups[1].Value + new string( m.Groups[2].Value.Select( c => (char)( '０' + ( c - '0' ) ) ).ToArray() );
        }

        private string CheckIK(string name)
        {
            string pattern = "((?:左|右)(?:足|つま先))IK";

            var m = Regex.Match( name, pattern );
            if ( !m.Success ) {
                return null;
            }

            return m.Groups[1].Value + "ＩＫ";
        }
    }
}
