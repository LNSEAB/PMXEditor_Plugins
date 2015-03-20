using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeqNum
{
    public class MainClass :
        PEPlugin.PEPluginClass
    {
        private const string caption_ = "選択項目に連番を振る";

        public MainClass() :
            base()
        {
            m_option = new PEPlugin.PEPluginOption( false, true, caption_ );
        }

        private void AddNumbers<T>(IList<T> objs)
            where T : PmxE.IHasName
        {
            for ( int i = 0; i < objs.Count; ++i ) {
                objs[i].Name += ( i + 1 ).ToString();
            }
        }

        public override void Run(PEPlugin.IPERunArgs args)
        {
            try {
                base.Run( args );

                var pmx = args.Host.Connector.Pmx.GetCurrentState();
                var form = args.Host.Connector.Form;
                var tab = PmxE.Form.GetSelectedTab( args.Host.Connector );
                var pmx_view = args.Host.Connector.View.PmxView;

                switch ( tab ) {
                    case PmxE.FormTab.Info:
                    case PmxE.FormTab.Vertex:
                    case PmxE.FormTab.Face:
                        throw new Exception( "選択項目がありません" );

                    case PmxE.FormTab.Material:
                        AddNumbers( PmxE.Objects.GetSelectedMaterials( args.Host, pmx ) );
                        break;

                    case PmxE.FormTab.Bone:
                        AddNumbers( PmxE.Objects.GetSelectedBones( args.Host, pmx ) );
                        break;

                    case PmxE.FormTab.Morph:
                        throw new Exception( "モーフには対応していません" );

                    case PmxE.FormTab.Node:
                        throw new Exception( "表示枠では変更できません" );

                    case PmxE.FormTab.Body:
                        AddNumbers( PmxE.Objects.GetSelectedBodies( args.Host, pmx ) );
                        break;

                    case PmxE.FormTab.Joint:
                        AddNumbers( PmxE.Objects.GetSelectedJoints( args.Host, pmx ) );
                        break;

                    case PmxE.FormTab.SoftBody:
                        throw new Exception( "SoftBodyには対応していません" );
                }

                args.Host.Connector.Pmx.Update( pmx );
                PmxE.Form.UpdateList( args.Host.Connector, tab );
            }
            catch ( Exception e ) {
                MessageBox.Show( e.Message, caption_, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
