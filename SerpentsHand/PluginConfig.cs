﻿using System.ComponentModel;
using System.Collections.Generic;
using Synapse.Config;
using UnityEngine;

namespace SerpentsHand
{
    public class PluginConfig : AbstractConfigSection
    {
        [Description("If friendlyfire for serpentshand is active")]
        public bool friendlyfire = false;

        [Description("The role that serpentshand will look like")]
        public RoleType SpawnRole = RoleType.Tutorial;

        [Description("The Health of SerpentsHand members")]
        public int Health = 120;

        [Description("The Role Name that is displayed when you look at the Player")]
        public string CustomRoleName = "<color=green>SerpentsHand</color>";

        public float SpawnChance = 50f;

        [Description("The Spawnpoint where SerpentsHand spawn")]
        public SerializedMapPoint SpawnPoint = new SerializedMapPoint("Root_*&*Outside Cams", -0.4426118f, 2.159119f, 7.987663f);

        [Description("The items that Serpentshand spawn with")]
        public List<SerializedItem> Items = new List<SerializedItem>
        {
            new SerializedItem((int)ItemType.KeycardChaosInsurgency,0,0,0,0,Vector3.one),
            new SerializedItem((int)ItemType.Medkit,0,0,0,0,Vector3.one),
            new SerializedItem((int)ItemType.GunLogicer,75,0,0,0,Vector3.one),
            new SerializedItem((int)ItemType.Painkillers,0,0,0,0,Vector3.one)
        };
    }
}