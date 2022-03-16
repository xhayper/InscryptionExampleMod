using BepInEx;

namespace InscryptionExampleMod
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {

        private void Start() {
            Logger.LogInfo("Hello, World!");
        }

    }
}
