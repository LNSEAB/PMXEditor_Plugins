using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmxE
{
    public class Form
    {
        public static void UpdateList(PEPlugin.IPEConnector conn)
        {
            conn.Form.UpdateList( PEPlugin.Pmd.UpdateObject.All );
        }

        public static void UpdateList(PEPlugin.IPEConnector conn, FormTab tab)
        {
            switch ( tab ) {
                case FormTab.Info :
                    conn.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Header );
                    break;

                case FormTab.Vertex :
                    conn.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Vertex );
                    break;

                case FormTab.Face:
                    conn.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Face );
                    break;

                case FormTab.Material:
                    conn.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Material );
                    break;

                case FormTab.Bone:
                    conn.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Bone );
                    break;

                case FormTab.Body :
                    conn.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Body );
                    break;

                case FormTab.Joint :
                    conn.Form.UpdateList( PEPlugin.Pmd.UpdateObject.Joint );
                    break;

                default:
                    UpdateList( conn );
                    break;
            }
        }
    }
}
