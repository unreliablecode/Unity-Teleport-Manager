# TeleportManager

## Overview

`TeleportManager` is a Unity `MonoBehaviour` script that provides runtime controls for teleporting and manipulating a `GameObject` in the scene. It includes options for adjusting the position, rotation, scale, gravity, time scale, and Rigidbody component of the target `GameObject`. The script also features a simple GUI for easy interaction during development.

## Features

- **Teleport Position:** Move the `GameObject` to a specified position.
- **Teleport Rotation (Euler Angles):** Set the rotation of the `GameObject` using Euler angles.
- **Teleport Rotation (Quaternion):** Set the rotation of the `GameObject` using a Quaternion.
- **Change Scale:** Modify the scale of the `GameObject`.
- **Change Gravity:** Adjust the gravity scale affecting the `GameObject`'s Rigidbody.
- **Change Time Scale:** Modify the global time scale of the game.
- **Add/Remove Rigidbody:** Add or remove a Rigidbody component from the `GameObject`.

## Usage

### Setup

1. **Attach the Script:**
   - Add the `TeleportManager` script to any `GameObject` in your Unity scene.

2. **Assign Target Object:**
   - In the Unity Inspector, assign the `targetObject` field to the `GameObject` you want to manipulate.

### Controls

- **Teleport Position:**
  - Input X, Y, Z coordinates in the "Teleport Position" section.
  - Click the "Teleport Position" button to move the target `GameObject` to the specified position.

- **Teleport Rotation (Euler Angles):**
  - Input X, Y, Z rotation angles in degrees in the "Teleport Rotation (Euler)" section.
  - Click the "Teleport Rotation" button to rotate the target `GameObject` to the specified Euler angles.

- **Teleport Rotation (Quaternion):**
  - Input X, Y, Z, W values for a Quaternion in the "Teleport Rotation (Quaternion)" section.
  - Click the "Teleport Quaternion" button to set the target `GameObject`'s rotation to the specified Quaternion.

- **Change Scale:**
  - Input X, Y, Z scale values in the "Change Scale" section.
  - Click the "Change Scale" button to modify the target `GameObject`'s scale.

- **Change Gravity:**
  - Input the new gravity scale value in the "Change Gravity" section.
  - Click the "Change Gravity" button to adjust the gravity affecting the target `GameObject`'s Rigidbody.

- **Change Time Scale:**
  - Input the new global time scale in the "Change Time Scale" section.
  - Click the "Change Time Scale" button to modify the global time scale of the game.

- **Add/Remove Rigidbody:**
  - Toggle the "Add Rigidbody" option to add or remove the Rigidbody component.
  - Click the corresponding button to perform the action.
