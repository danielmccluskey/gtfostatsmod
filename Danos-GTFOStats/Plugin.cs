﻿using BepInEx.Unity.IL2CPP;
using BepInEx;
using Dissonance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using GTFOTest.Patches;

namespace GTFOTest
{
    [BepInPlugin("danos.GTFOStats", "GTFOStats", "0.5.1")]
    public class Plugin : BasePlugin
    {
        public override void Load()
        {
            // Plugin startup logic
            Log.LogInfo("GTFOStats is loaded!");

            //Set danos static store mod version
            Data.DanosStaticStore.ModVersion = "0.5.1";

            var harm =new Harmony("danos.GTFOStats");

            harm.PatchAll(typeof(GameStatePatch));

        }
    }
}