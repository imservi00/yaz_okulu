using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityOgretmen
    {
        private int ogrtid;
        public int OGRTID
        {
            get { return ogrtid; }
            set { ogrtid = value; }
        }

        private string ogrtad;
        public string OGRTAD
        {
            get { return ogrtad; }
            set { ogrtad = value; }
        }

        private int ogrtBrans;
        public int OGRTBRANS
        {
            get { return ogrtBrans; }
            set { ogrtBrans = value; }
        }
    }
}
