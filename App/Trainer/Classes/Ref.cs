using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Trainer.ComponentUtil;

namespace Trainer.Classes
{
    public struct Ref<T> where T : struct
    {
        public IntPtr Ptr;

        public T Deref(Process process)
        {
            return process.ReadValue<T>(Ptr);
        }

        public bool Write(Process process, T obj)
        {
            return process.WriteValue<T>(Ptr, obj);
        }
    }
}
