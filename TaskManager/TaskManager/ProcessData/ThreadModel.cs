using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskManager.ProcessData
{
    class ThreadModel
    {
        public string id { get; set; }
        public string priority { get; set; }

        public ThreadModel(ProcessThread thread)
        {
            try
            {
                id = thread.Id.ToString();
                priority = thread.PriorityLevel.ToString();
            }
            catch
            {

            }


        }
    }
}
