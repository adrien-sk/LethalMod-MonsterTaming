using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace MonsterTaming;

[BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    private const string PLUGIN_GUID = "mod.monster.taming";
    private const string PLUGIN_NAME = "Monster Taming";
    private const string PLUGIN_VERSION = "0.0.1";

    public static Plugin Instance { get; set; }
    public static ManualLogSource Log => Instance.Logger;
    private readonly Harmony _harmony = new(PLUGIN_GUID);
    //public TemplateService Service;

    public Plugin()
    {
        Instance = this;
    }

    private void Awake()
    {
        //Service = new TemplateService();

        Log.LogInfo($"Loading Monster Taming Mod...");
        Log.LogInfo($"Applying patches...");
        ApplyPluginPatch();
        Log.LogInfo($"Patches applied");
    }

    /// <summary>
    /// Applies the patch to the game.
    /// </summary>
    private void ApplyPluginPatch()
    {
        //_harmony.PatchAll(typeof(ShipLightsPatch));
        //_harmony.PatchAll(typeof(PlayerControllerBPatch));
    }
}
