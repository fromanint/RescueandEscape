﻿// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using UnityEditor;
using System.Collections;

/// A custom editor for the CardboardGaze script.  It exists to add the GazePointer
/// object selection field to the inspector with an extra layer of validation to see
/// that it implements the ICardboardGazePointer inteface.
[CustomEditor(typeof(CardboardGaze))]
public class CardboardGazeEditor : Editor {
  /// @cond
  public override void OnInspectorGUI() {
    CardboardGaze cardboardGaze = (CardboardGaze)target;
    DrawDefaultInspector();
    cardboardGaze.PointerObject =
        EditorGUILayout.ObjectField("Pointer Object", cardboardGaze.PointerObject,
        typeof(GameObject), true) as GameObject;

    EditorUtility.SetDirty(target);
  }
  /// @endcond
}
