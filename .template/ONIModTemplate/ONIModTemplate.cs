﻿using Harmony;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedParameter.Local

namespace MightyVincent
{
    internal class ONIModTemplatePatches
    {/*caret*/
        public void OnLoad()
        {
            Debug.Log("Dev Mod");
        }
        
        [HarmonyPatch(typeof(Db), "Initialize")]
        internal class Db_Initialize
        {
            private static void Prefix(Db __instance)
            {
                //
            }
        }
    }
}