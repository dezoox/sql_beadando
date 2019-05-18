using Auto_service.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service.Interfaces
{
    interface IDML
    {
        int Insert(Record record);
        int Update(Record record);
        int Delete(Record record);
    }
}
