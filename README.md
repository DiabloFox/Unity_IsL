# Unity_IsL
This repository is a tool to make the exportation of Island Data from the {Root/Assets/unity/###@island_unityclient} files which the content can be extracted using [AssetRipper](https://github.com/AssetRipper/AssetRipper) 

## Worlds Adrift island data structure
Beta Island File
```
###@island_client
│  * AuxiliaryFiles
└──* ExportedProject
   ├──Assets
   │  └──improbable
   │      └──entityprefabs
   │          ├──###@island_client.asset
   │          ├──###@island_client.asset.meta
   │          ├──###@island_client.prefab
   │          └──###@island_client.prefab.meta
   │  ├──Mesh
   │  │   ├──(0.0, 0.0, 0.0)_LOD0.asset
   │  │   ├──(0.0, 0.0, 0.0)_LOD0.asset.meta
   │  │   ├──(0.0, 0.0, 0.0)_LOD1.asset
   │  │   ├──(0.0, 0.0, 0.0)_LOD1.asset.meta
   │  │   ├──(0.0, 0.0, 0.0)_LOD2.asset
   │  │   ├──(0.0, 0.0, 0.0)_LOD2.asset.meta
   │  │   ├──...
   │  │   ...
   │  ├──Scripts
   │  │   └──Assembly-CSharp
   │  │       ├──Bossa
   │  │       │  └──Travellers
   │  │       │     └──Visualisers
   │  │       │        └──Islands
   │  │       │           ├──IslandVisualiser.cs
   │  │       │           └──IslandVisualiser.cs.meta
   │  │       ├──Improbable
   │  │       │  └──CoreLibrary
   │  │       │     └──Transforms
   │  │       │        ├──Global
   │  │       │        │  ├──StaticGlobalTransformBehaviour.cs
   │  │       │        │  └──StaticGlobalTransformBehaviour.cs.meta
   │  │       │        ├──Hierarchy
   │  │       │        │  ├──TransformChildHierarchyBehaviour.cs
   │  │       │        │  ├──TransformChildHierarchyBehaviour.cs.meta
   │  │       │        │  ├──TransformParentHierarchyBehaviour.cs
   │  │       │        │  └──TransformParentHierarchyBehaviour.cs.meta
   │  │       │        ├──Local
   │  │       │        │  ├──StaticLocalTransformBehaviour.cs
   │  │       │        │  └──StaticLocalTransformBehaviour.cs.meta
   │  │       │        ├──Offsets
   │  │       │        │  ├──TransformOffsetsRegistry.cs
   │  │       │        │  └──TransformOffsetsRegistry.cs.meta
   │  │       │        ├──TransformNature.cs
   │  │       │        └──TransformNature.cs.meta
   │  │       ├──EntityLoadedVerifier.cs
   │  │       ├──EntityLoadedVerifier.cs.meta
   │  │       ├──GenerateDynamicMaterial.cs
   │  │       ├──GenerateDynamicMaterial.cs.meta
   │  │       ├──IslandAmbienceVolume.cs
   │  │       ├──IslandAmbienceVolume.cs.meta
   │  │       ├──IslandLightningTimerVisualizer.cs
   │  │       ├──IslandLightningTimerVisualizer.cs.meta
   │  │       ├──IslandMetaData.cs
   │  │       ├──IslandMetaData.cs.meta
   │  │       ├──IslandSurfaceData.cs
   │  │       ├──IslandSurfaceData.cs.meta
   │  │       ├──IslandSurfaceType.cs
   │  │       ├──IslandSurfaceType.cs.meta
   │  │       ├──LocationAnchorEntity.cs
   │  │       ├──LocationAnchorEntity.cs.meta
   │  │       ├──PopulateStaticPrefabs.cs
   │  │       └──PopulateStaticPrefabs.cs.meta
   │  ├──Shader
   │  │  ├──Worlds Adrift_Nature_Island Terrain GI (Legacy).shader
   │  │  └──Worlds Adrift_Nature_Island Terrain GI (Legacy).shader.meta
   │  └──TextAsset
   │     ├──groups.json
   │     ├──groups.json.meta
   │     ├──small_static_objects.json
   │     ├──small_static_objects.json.meta
   │     ├──static_objects.json
   │     ├──static_objects.json.meta
   │     ├──surface.json
   │     └──surface.json.meta
   ├──Packages
   │  └──manifest.json
   └──ProjectSettings
      └──ProjectVersion.txt
```
