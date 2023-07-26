using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemUow.EntityLayer.Concrete
{
    public class CustomerProcess
    {
        public int CustomerProcessId { get; set; }
        public int CustomerProcessSenderId { get; set; }
        public int CustomerProcessReceiverId { get; set; }
        public decimal CustomerProcessAmount { get; set; }
    }
}
