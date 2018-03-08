using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;

namespace Ascension.Settings.Properties
{
    public class UIFileProperty : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(
            ITypeDescriptorContext context)
        {
            if (context != null)
                return UITypeEditorEditStyle.Modal;

            return UITypeEditorEditStyle.None;
        }

        [RefreshProperties(RefreshProperties.All)]
        public override object EditValue(ITypeDescriptorContext context,
            IServiceProvider provider, object value)
        {
            FileDialog fd;

            if (context == null || provider == null || context.Instance == null)
                return base.EditValue(provider, value);

            fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Title = "Select Filename";
            fd.FileName = (value as string);
            fd.Filter = "All Files (*.*)|*.*";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(fd.FileName))
                {
                    value = fd.FileName;
                }
            }

            return value;
        }
    }
}