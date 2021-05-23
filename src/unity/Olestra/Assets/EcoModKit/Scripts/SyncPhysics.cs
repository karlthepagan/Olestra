// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

using UnityEngine;

public enum AxisSyncMode
{
    //
    // Summary:
    //     Do not sync.
    None = 0,
    //
    // Summary:
    //     Only x axis.
    AxisX = 1,
    //
    // Summary:
    //     Only the y axis.
    AxisY = 2,
    //
    // Summary:
    //     Only the z axis.
    AxisZ = 3,
    //
    // Summary:
    //     The x and y axis.
    AxisXY = 4,
    //
    // Summary:
    //     The x and z axis.
    AxisXZ = 5,
    //
    // Summary:
    //     The y and z axis.
    AxisYZ = 6,
    //
    // Summary:
    //     The x, y and z axis.
    AxisXYZ = 7
}

// Interpolates game object physics over time from network updates
public partial class SyncPhysics : MonoBehaviour
{
    public bool ManuallyUpdated = false;

    public bool SyncPos;
    public bool SyncRot;
    public bool SyncVelocity = true;

    public AxisSyncMode RotSyncMode = AxisSyncMode.AxisXYZ;
    public bool useLocalPosition;
    public bool useLocalRotation;
    public float lockDistance = 25f;
    public float snapDistance = 5f;
    public float interpolateMovement = 1f;
    public float interpolateRotation = 1f;
    public bool syncInitialTransform = true;

    public bool debugKeyframes = false;
}
