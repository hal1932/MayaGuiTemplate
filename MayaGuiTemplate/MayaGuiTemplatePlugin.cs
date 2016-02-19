#if !VIEWDEBUG
using Autodesk.Maya.OpenMaya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: ExtensionPlugin(typeof(MayaGuiTemplate.TemplateCommandPlugin), "hal1932", "1.0", "Any")]
[assembly: MPxCommandClass(typeof(MayaGuiTemplate.TemplateCommand), "template")]

namespace MayaGuiTemplate
{
    public class TemplateCommand : MPxCommand, IMPxCommand
    {
        public override void doIt(MArgList args)
        {
            new MainWindow().Show();
        }
    }

    public class TemplateCommandPlugin : IExtensionPlugin
    {
        public string GetMayaDotNetSdkBuildVersion()
        {
            return "201353";
        }

        public bool InitializePlugin()
        {
            return true;
        }

        public bool UninitializePlugin()
        {
            return true;
        }
    }
}
#endif // #if VIEWDEBUG
