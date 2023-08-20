using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // for List functions

public class ComponentObject : ScriptableObject
{
    public string componentName;
    public int cardID;
    public string spriteName;
    public List<string> tags;
}
