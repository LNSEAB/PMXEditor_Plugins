using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeqNum
{
    enum NumType
    {
        Hankaku,
        Zenkaku
    }

    class SeqNumImpl
    {
        private void AddNumbers<T>(IList< T > objs)
            where T : PmxE.IHasName
        {
            for ( int i = 0; i < objs.Count; ++i ) {
                objs[i].Name += i.ToString();
            }
        }

        private void Update(PEPlugin.IPEConnector conn, PEPlugin.Pmx.IPXPmx pmx)
        {
            conn.Pmx.Update( pmx );
            conn.Form.UpdateList( PEPlugin.Pmd.UpdateObject.All );
        }

        public void Run(PEPlugin.IPERunArgs args, NumType nt)
        {
            var pmx = args.Host.Connector.Pmx.GetCurrentState();
            var form = args.Host.Connector.Form;
            var tab = (PmxE.FormTab)form.SelectedTabPage;
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

            switch ( tab ) {
                case PmxE.FormTab.Material :
                    args.Host.Connector.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Material );
                    break;

                case PmxE.FormTab.Bone :
                    args.Host.Connector.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Bone );
                    break;

                case PmxE.FormTab.Body:
                    args.Host.Connector.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Body );
                    break;

                case PmxE.FormTab.Joint :
                    args.Host.Connector.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Joint );
                    break;
            }
        }
    }

    public class Hankaku :
        PEPlugin.PEPluginClass
    {
        private const string caption_ = "選択項目に連番を振る（半角）";

        public Hankaku() :
            base()
        {
            m_option = new PEPlugin.PEPluginOption( false, true, caption_ );
        }

        public override void Run(PEPlugin.IPERunArgs args)
        {
            try {
                base.Run( args );

                SeqNumImpl impl = new SeqNumImpl();
                impl.Run( args, NumType.Hankaku );
            }
            catch ( Exception e ) {
                MessageBox.Show( e.Message, caption_, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }

    public class Zenkaku :
        PEPlugin.PEPluginClass
    {
        private const string caption_ = "選択項目に連番を振る（全角）";

        public Zenkaku() :
            base()
        {
            m_option = new PEPlugin.PEPluginOption( false, true, caption_ );
        }

        public override void Run(PEPlugin.IPERunArgs args)
        {
            try {
                base.Run( args );

                SeqNumImpl impl = new SeqNumImpl();
                impl.Run( args, NumType.Zenkaku );
            }
            catch ( Exception e ) {
                MessageBox.Show( e.Message, caption_, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
