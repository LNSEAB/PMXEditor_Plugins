using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PmxE
{
    public interface IHasName
    {
        string Name
        {
            get;
            set;
        }

        string NameE
        {
            get;
            set;
        }
    }

    public interface IHasPosition
    {
        PEPlugin.SDX.V3 Position
        {
            get;
            set;
        }
    }

    public interface IHasRotation
    {
        PEPlugin.SDX.V3 Rotation
        {
            get;
            set;
        }
    }
}
