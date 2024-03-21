using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;
using ModelReplacement;
using BepInEx.Configuration;
using System;
using System.Xml.Linq;

namespace ModelReplacement
{
    [BepInPlugin("com.naqibam.UltramanSkin", "Ultraman Skin", "1.3.0")]
    [BepInDependency("meow.ModelReplacementAPI", BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency("x753.More_Suits", BepInDependency.DependencyFlags.HardDependency)]
	public class Plugin : BaseUnityPlugin
    {

        private void Awake()
        {
            Assets.PopulateAssets();

            ModelReplacementAPI.RegisterSuitModelReplacement("Ultraman", typeof(ULTRAMAN));
			ModelReplacementAPI.RegisterSuitModelReplacement("Ultraseven", typeof(ULTRASEVEN));
			ModelReplacementAPI.RegisterSuitModelReplacement("Mebius", typeof(MEBIUS));
			ModelReplacementAPI.RegisterSuitModelReplacement("Tiga", typeof(TIGA));
			ModelReplacementAPI.RegisterSuitModelReplacement("Dyna", typeof(DYNA));
			ModelReplacementAPI.RegisterSuitModelReplacement("Gaia", typeof(GAIA));

			Harmony harmony = new Harmony("com.naqibam.UltramanSkin");
            harmony.PatchAll();
            Logger.LogInfo($"Plugin {"com.naqibam.UltramanSkin"} is loaded!");
        }
    }
    public static class Assets
    {
        // Replace mbundle with the Asset Bundle Name from your unity project 
        public static string mainAssetBundleName = "ultramanbundle";
        public static AssetBundle MainAssetBundle = null;

        private static string GetAssemblyName() => Assembly.GetExecutingAssembly().GetName().Name.Replace(" ","_");
        public static void PopulateAssets()
        {
            if (MainAssetBundle == null)
            {
                Console.WriteLine(GetAssemblyName() + "." + mainAssetBundleName);
                using (var assetStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetAssemblyName() + "." + mainAssetBundleName))
                {
                    MainAssetBundle = AssetBundle.LoadFromStream(assetStream);
                }

            }
        }
    }

}
