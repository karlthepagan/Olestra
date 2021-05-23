// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

using UnityEngine;
using System;
using VoxelEngine.Materials;

[Serializable]
public partial class Block 
{
    public string Name;
    public BlockBuilder Builder;
    public Material Material;
    public Material[] Materials = new Material[0];

    public Color MinimapColor = Color.green;
    public bool IsWater = false;
    public bool Solid = true;
    public bool BuildCollider = true;
    public bool Rendered = true;
    public UnityEngine.Rendering.ShadowCastingMode ShadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
    public string Layer = "Terrain";
    public string Category = "Default";
    public int Tier = 0;

    public int BlendingPriority = 0;

    // post init, these are set to the same value for faster compares
    public int categoryID;
    public int nameID;

    public bool GenerateMeshCollider = false;

    public bool IsEmpty;
    public float PrefabHeightOffset = -.5f;

    public GameObject walkOnPrefab;

    public string AudioCategory; //This is used for tool interactions

    public string MusicCategory; //This is used for the music system

    public GameObject[] Effects = new GameObject[0];
    public string[] EffectNames = new string[0];

    [NonSerialized] public MaterialInfo MaterialInfo;
    [NonSerialized] public MaterialInfo[] MaterialInfos = Array.Empty<MaterialInfo>();
    [NonSerialized] public bool Interactable;
    [NonSerialized] public bool SticksToWalls;
    [NonSerialized] public float MoveEfficiency = 1f;
    [NonSerialized] public int Hardness = 0;
    [NonSerialized] public bool IsPlant = false;
    [NonSerialized] public int rotation = 0;

    public bool IsLadder;

#if UNITY_EDITOR
    public UnityEditor.Editor Editor;
#endif
}