﻿using System;
using System.Collections.Generic;
using UnityEditor;

namespace Himeki.Build
{

    [Serializable]
    public class BuildSetupEntry
    {
        public bool enabled = true;
        public string buildName = "";
        public BuildTarget target;
        public bool debugBuild = false;
        public string scriptingDefineSymbols = "";
        public bool useDefaultBuildScenes = true;
        public List<string> customScenes;

        //VR
        public bool supportsVR = false;
        public int vrSdkFlags;

        // Advanced Options
#if UNITY_2018_3_OR_NEWER
        public ManagedStrippingLevel strippingLevel;
#endif
        public string assetBundleManifestPath = "";
        public bool strictMode = false;
        public bool iosSymlinkLibraries = false;
        public bool androidAppBundle = false;
        public ScriptingImplementation scriptingBackend;
        //PS4
        public PS4BuildSubtarget ps4BuildSubtarget;
        public PS4HardwareTarget ps4HardwareTarget;

        // GUI status
        [NonSerialized] public bool guiShowOptions = true;
        [NonSerialized] public bool guiShowCustomScenes = false;
        [NonSerialized] public bool guiShowAdvancedOptions = false;
        [NonSerialized] public bool guiShowVROptions = false;

    }

}