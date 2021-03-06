﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmxE
{
    namespace Pmx
    {
        public class Vertex :
            IHasPosition
        {
            private PEPlugin.Pmx.IPXVertex vtx_;

            public Vertex(PEPlugin.Pmx.IPXVertex vtx)
            {
                vtx_ = vtx;
            }

            public PEPlugin.SDX.V3 Position
            {
                get { return vtx_.Position; }
                set { vtx_.Position = value; }
            }

            public PEPlugin.Pmx.IPXVertex Data
            {
                get { return vtx_; }
            }
        }

        public class Face
        {
            private PEPlugin.Pmx.IPXFace face_;

            public Face(PEPlugin.Pmx.IPXFace face)
            {
                face_ = face;
            }
        }

        public class Material :
            IHasName
        {
            private PEPlugin.Pmx.IPXMaterial mtrl_;

            public Material(PEPlugin.Pmx.IPXMaterial mtrl)
            {
                mtrl_ = mtrl;
            }

            public string Name
            {
                get { return mtrl_.Name; }
                set { mtrl_.Name = value; }
            }

            public string NameE
            {
                get { return mtrl_.NameE; }
                set { mtrl_.NameE = value; }
            }

            public PEPlugin.Pmx.IPXMaterial Data
            {
                get { return mtrl_; }
            }
        }

        public class Bone :
            IHasName, IHasPosition
        {
            private PEPlugin.Pmx.IPXBone bone_;

            public Bone(PEPlugin.Pmx.IPXBone bone)
            {
                bone_ = bone;
            }

            public string Name
            {
                get { return bone_.Name; }
                set { bone_.Name = value; }
            }

            public string NameE
            {
                get { return bone_.NameE; }
                set { bone_.NameE = value; }
            }

            public PEPlugin.SDX.V3 Position
            {
                get { return bone_.Position; }
                set { bone_.Position = value; }
            }

            public Bone Parent
            {
                get { return new Bone( bone_.Parent ); }
                set { bone_.Parent = value.bone_; }
            }

            public Bone ToBone
            {
                get { return new Bone( bone_.ToBone ); }
                set { bone_.ToBone = value.bone_; }
            }

            public PEPlugin.Pmx.IPXBone Data
            {
                get { return bone_; }
            }
        }

        public class Morph :
            IHasName
        {
            private PEPlugin.Pmx.IPXMorph morph_;

            public Morph(PEPlugin.Pmx.IPXMorph morph)
            {
                morph_ = morph;
            }

            public string Name
            {
                get { return morph_.Name; }
                set { morph_.Name = value; }
            }

            public string NameE
            {
                get { return morph_.NameE; }
                set { morph_.NameE = value; }
            }

            public PEPlugin.Pmx.IPXMorph Data
            {
                get { return morph_; }
            }
        }

        public class Node :
            IHasName
        {
            private PEPlugin.Pmx.IPXNode node_;

            public Node(PEPlugin.Pmx.IPXNode node)
            {
                node_ = node;
            }

            public string Name
            {
                get { return node_.Name; }
                set { node_.Name = value; }
            }

            public string NameE
            {
                get { return node_.NameE; }
                set { node_.NameE = value; }
            }

            public PEPlugin.Pmx.IPXNode Data
            {
                get { return node_; }
            }
        }

        public class Body :
            IHasName, IHasPosition, IHasRotation
        {
            private PEPlugin.Pmx.IPXBody body_;

            public Body(PEPlugin.Pmx.IPXBody body)
            {
                body_ = body;
            }

            public string Name
            {
                get { return body_.Name; }
                set { body_.Name = value; }
            }

            public string NameE
            {
                get { return body_.NameE; }
                set { body_.NameE = value; }
            }

            public PEPlugin.SDX.V3 Position
            {
                get { return body_.Position; }
                set { body_.Position = value; }
            }

            public PEPlugin.SDX.V3 Rotation
            {
                get { return body_.Rotation; }
                set { body_.Rotation = value; }
            }

            public PEPlugin.Pmx.IPXBody Data
            {
                get { return body_; }
            }
        }

        public class Joint :
            IHasName, IHasPosition, IHasRotation
        {
            private PEPlugin.Pmx.IPXJoint joint_;

            public Joint(PEPlugin.Pmx.IPXJoint joint)
            {
                joint_ = joint;
            }

            public string Name
            {
                get { return joint_.Name; }
                set { joint_.Name = value; }
            }

            public string NameE
            {
                get { return joint_.NameE; }
                set { joint_.NameE = value; }
            }

            public PEPlugin.SDX.V3 Position
            {
                get { return joint_.Position; }
                set { joint_.Position = value; }
            }

            public PEPlugin.SDX.V3 Rotation
            {
                get { return joint_.Rotation; }
                set { joint_.Rotation = value; }
            }

            public PEPlugin.Pmx.IPXJoint Data
            {
                get { return joint_; }
            }
        }

        public class SoftBody :
            IHasName
        {
            private PEPlugin.Pmx.IPXSoftBody sb_;

            public SoftBody(PEPlugin.Pmx.IPXSoftBody sb)
            {
                sb_ = sb;
            }

            public string Name
            {
                get { return sb_.Name; }
                set { sb_.Name = value; }
            }

            public string NameE
            {
                get { return sb_.NameE; }
                set { sb_.NameE = value; }
            }

            public PEPlugin.Pmx.IPXSoftBody Data
            {
                get { return sb_; }
            }
        }
    }
}
