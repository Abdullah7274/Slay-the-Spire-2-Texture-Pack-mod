using HarmonyLib;
using MegaCrit.Sts2.Core.Assets;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Modding;
using System;

[ModInitializer("Initialize")]
public class ModEntry
{
    private static readonly string[] _knownAtlases = new string[12]
    {
        "ui_atlas", "compressed", "epoch_atlas", "relic_atlas", "relic_outline_atlas", "power_atlas", "card_atlas", "potion_atlas", "potion_outline_atlas", "stats_screen_atlas",
        "intent_atlas", "era_atlas"
    };
    public static void Initialize()
    {

        var harmony = new Harmony("TextureReplacerMod.patch");
        harmony.PatchAll();

        try
        {
            string[] knownAtlases = _knownAtlases;
            foreach (string atlasName in knownAtlases)
            {
                AtlasManager.LoadAtlas(atlasName);
            }
            Log.Info("[TextureReplacerMod] Requested load of card_atlas via AtlasManager.");
        }
        catch (Exception ex)
        {
            Log.Info($"[TextureReplacerMod] Failed to load card_atlas: {ex}");
        }
    }
}