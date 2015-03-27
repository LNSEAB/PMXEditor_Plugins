using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmxE
{
    public class Objects
    {
        public static List<Pmx.Vertex> GetSelectedVertices(PEPlugin.IPEPluginHost host, PEPlugin.Pmx.IPXPmx pmx)
        {
            var indices = host.Connector.View.PmxView.GetSelectedVertexIndices();
            var vtx = new List< Pmx.Vertex >();

            foreach( int i in indices ) {
                vtx.Add( new Pmx.Vertex( pmx.Vertex[i]));
            }

            return vtx;
        }

        public static List<Pmx.Material> GetSelectedMaterials(PEPlugin.IPEPluginHost host, PEPlugin.Pmx.IPXPmx pmx)
        {
            var indices = host.Connector.Form.GetSelectedMaterialIndices();
            var mtrls = new List<Pmx.Material>();

            foreach ( int i in indices ) {
                mtrls.Add( new Pmx.Material( pmx.Material[i] ) );
            }

            return mtrls;
        }

        public static List<Pmx.Bone> GetSelectedBones(PEPlugin.IPEPluginHost host, PEPlugin.Pmx.IPXPmx pmx)
        {
            var indices = host.Connector.View.PmxView.GetSelectedBoneIndices();
            var bones = new List<Pmx.Bone>();

            foreach ( int i in indices ) {
                bones.Add( new Pmx.Bone( pmx.Bone[i] ) );
            }

            return bones;
        }

        public static List<Pmx.Body> GetSelectedBodies(PEPlugin.IPEPluginHost host, PEPlugin.Pmx.IPXPmx pmx)
        {
            var indices = host.Connector.View.PmxView.GetSelectedBodyIndices();
            var bodies = new List<Pmx.Body>();

            foreach ( int i in indices ) {
                bodies.Add( new Pmx.Body( pmx.Body[i] ) );
            }

            return bodies;
        }

        public static List<Pmx.Joint> GetSelectedJoints(PEPlugin.IPEPluginHost host, PEPlugin.Pmx.IPXPmx pmx)
        {
            var indices = host.Connector.View.PmxView.GetSelectedJointIndices();
            var joints = new List<Pmx.Joint>();

            foreach ( int i in indices ) {
                joints.Add( new Pmx.Joint( pmx.Joint[i] ) );

            }

            return joints;
        }
    }
}
