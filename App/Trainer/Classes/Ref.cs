using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Trainer.ComponentUtil;

namespace Trainer.Classes
{
    public class Ref<T> where T : struct
    {
        private IntPtr ptr;

        public T Deref(Process process)
        {
            return process.ReadValue<T>(ptr);
        }

        public bool Write(Process process, T obj)
        {
            return process.WriteValue<T>(ptr, obj);
        }
    }
}
