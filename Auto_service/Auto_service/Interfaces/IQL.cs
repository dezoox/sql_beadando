using Auto_service.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_service.Interfaces
{
    interface IQL
    {
        List<Record> Select();
        Record Select(Record record);
    }
}
