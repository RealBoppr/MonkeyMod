using System.Diagnostics;
using MelonLoader;

namespace MonkeyMod
{
    public class Class : MelonMod
    {
        public override void OnApplicationStart()
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
