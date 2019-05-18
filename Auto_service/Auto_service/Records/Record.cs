using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service.Records
{
    public class Record
    {
        private readonly long? id;
        protected bool deleted;

        public long? Id
        {
            get { return id; }
        }

        protected Record(long? id)
        {
            if (id == null)
                throw new ArgumentNullException();
            this.id = id;
        }
        protected Record()
        {
            deleted = false;
        }

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
        public bool Stored
        {
            get
            {
                return Id != null;
            }
        }
    }
}
