﻿using BepInEx;

namespace BlasDoubleJump
{
    [BepInPlugin(MOD_ID, MOD_NAME, MOD_VERSION)]
    [BepInDependency("com.damocles.blasphemous.modding-api", "1.3.2")]
    [BepInProcess("Blasphemous.exe")]
    public class Main : BaseUnityPlugin
    {
        public const string MOD_ID = "com.damocles.blasphemous.double-jump";
        public const string MOD_NAME = "Double Jump";
        public const string MOD_VERSION = "1.0.2";

        public static JumpController JumpController { get; private set; }

        private void Start()
        {
            JumpController = new JumpController(MOD_ID, MOD_NAME, MOD_VERSION);
        }
    }
}