using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectnc1
{
    class ExecuteGcode
    {

        public ExecuteGcode()
        {
            
        }

        public delegate void bool_handler(bool value);

        public bool GcodeExecuting = false;
        public int executingLine = 0;

        public event bool_handler GcodeLineCompletedEvent;

        private bool GlineCompleted = false;

        public bool GcodeLineCompleted
        {
            get
            {
                return GlineCompleted;
            }
            set
            {
                GlineCompleted = value;
                GcodeLineCompletedEvent(GlineCompleted);

            }
        }
    }
}
