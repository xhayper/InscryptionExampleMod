using DiskCardGame;
using HarmonyLib;

// File structure inspried by [GrimoraMod](https://github.com/Arackulele/GrimoraMod/blob/main/Patches/OpponentPatches.cs)
// This patch make it so in the menu screen, after your mouse left the card, it will show '- Total misplay -' instead of the last selected text.

namespace InscryptionExampleMod
{
    [HarmonyPatch(typeof(MenuController))]
    public class MenuControllerPatches
    {
        // Patching Inscryption's `DiskCardGame.MenuController.DisplayMenuCardTitle` method.
        // See also: https://github.com/BepInEx/HarmonyX/wiki/Patch-parameters
        [HarmonyPrefix, HarmonyPatch(nameof(MenuController.DisplayMenuCardTitle))]
        public static bool DisplayMenuCardTitle(MenuCard card, MenuController __instance)
        {
            __instance.titleRenderer.sprite = null;
            if (__instance.CardInSlot || card != null && card.Slotted) return false;
            if (card != null) return true;
            Plugin.logger.LogInfo("Replacing the menu cardtitle text to \"- TOTAL MISPLAY -\"");
            __instance.titleText.gameObject.SetActive(true);
            __instance.titleTextShadow.gameObject.SetActive(true);
            var text = "- TOTAL MISPLAY -";
            __instance.titleText.SetText(text);
            __instance.titleTextShadow.SetText(text);
            __instance.titleText.SetColor(__instance.titleTextColor);
            return false;
        }


        // Patching Inscryption's `DiskCardGame.MenuController.OnCardCursorExited` method.
        // See also: https://github.com/BepInEx/HarmonyX/wiki/Patch-parameters
        [HarmonyPrefix, HarmonyPatch(nameof(MenuController.OnCardCursorExited))]
        public static bool OnCardCursorExited(MenuCard card, MenuController __instance)
        {
            Plugin.logger.LogInfo("Hello! The cursor is out of selection!");
            if (__instance.CardInSlot || card != null && card.Slotted) return false;
            __instance.DisplayMenuCardTitle(null);
            return false;
        }
    }
}