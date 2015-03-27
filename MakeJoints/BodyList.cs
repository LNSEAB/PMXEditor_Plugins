using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeJoints
{
    class BodyListElement
    {
        public BodyListElement()
        { }

        public BodyListElement(PmxE.Pmx.Body data, bool applied = false)
        {
            Data = data;
            Applied = applied;
        }

        public PmxE.Pmx.Body Data
        { get; set; }

        public bool Applied
        { get; set; }
    }

    class BodyList :
        IEnumerable< BodyListElement >
    {
        List<BodyListElement> bodies_;

        public BodyList()
        {
            bodies_ = new List<BodyListElement>();
        }

        public int Count
        {
            get { return bodies_.Count; }
        }

        public void Clear()
        {
            bodies_.Clear();
        }

        public BodyListElement this[int n]
        {
            get { return bodies_[n]; }
            set { bodies_[n] = value; }
        }

        public void Update(IList<PEPlugin.Pmx.IPXBody> src)
        {
            foreach ( var b in src.Select( (val, index) => new { val, index } ) ) {
                if ( b.index >= bodies_.Count ) {
                    bodies_.Add( new BodyListElement( new PmxE.Pmx.Body( b.val ) ) );
                    continue;
                }

                if ( b.val != bodies_[b.index].Data ) {
                    bodies_.Insert( b.index, new BodyListElement( new PmxE.Pmx.Body( b.val ) ) );
                }
            }
        }

        public IEnumerator<BodyListElement> GetEnumerator()
        {
            return bodies_.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
