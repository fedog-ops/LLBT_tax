using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LBTT.Notifier
{
    public interface ITaxNotifier
    {
        public void Notify(decimal salary, decimal tax);
    }
}
