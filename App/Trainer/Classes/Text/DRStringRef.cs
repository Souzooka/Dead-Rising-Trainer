using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Trainer.ComponentUtil;

namespace Trainer.Classes.Text
{
    public enum CharWidth
    {
        Default
    }

    public struct DRStringRef
    {
        private IntPtr ptr;

        public DRStringRef(IntPtr pPtr)
        {
            ptr = pPtr;
        }

        public string Deref(Process process)
        {
            IntPtr addr = ptr;
            StringBuilder sb = new StringBuilder();
            DRChar character = process.ReadValue<DRChar>(addr);

            while (!character.Terminator)
            {
                sb.Append(character.ToChar());
                addr += 6;
                character = process.ReadValue<DRChar>(addr);
            }

            return sb.ToString();
        }

        public void Write(Process process, string value, CharWidth width = CharWidth.Default)
        {
            IntPtr addr = ptr;
            for (int i = 0; i < value.Length; ++i)
            {
                process.WriteValue<DRChar>(addr, new DRChar(value[i], false, width));
                addr += 6;
            }
            process.WriteValue<DRChar>(addr, DRChar.StringTerminator);
        }
    }
}
