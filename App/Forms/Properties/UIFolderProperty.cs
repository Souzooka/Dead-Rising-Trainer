using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;

namespace Ascension.Settings.Properties
{
    public class UIFolderProperty : UITypeEditor
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
            FolderBrowserDialog fd;

            if (context == null || provider == null || context.Instance == null)
                return base.EditValue(provider, value);

            fd = new FolderBrowserDialog();
            fd.ShowNewFolderButton = false;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(fd.SelectedPath))
                {
                    value = fd.SelectedPath + "\\";
                }
            }

            return value;
        }
    }
}
