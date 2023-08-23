using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // for List functions

[CreateAssetMenu]

public class ComponentObject : ScriptableObject
{
    public int componentID;
    public string componentName;
    public string spriteName;
    public List<string> tags;

    private string tagsString = "";

    public void AddTag(string tagToAdd) {

        tags.Add(tagToAdd);
    }

    public void RemoveTag(string tagToRemove)
    {
        tags.Remove(tagToRemove);
    }

    public string CompToString()
    {
        return "Component ID: " + componentID + 
               "\nComponent Name: " + componentName +
               "\nSprite Name: " + spriteName +
               "\nAssociated Tags: " + TagsToString(tags);
    }

    private string TagsToString(List<string> tags)
    {
        tagsString = "";
        int counter = 0;

        foreach(string s in tags)
        { 
            if (counter == 0)
            {
                tagsString = s;
            }
            else 
            {
                tagsString = tagsString + ", " + s;
            }
            counter++;
        }
        
        return tagsString;
    }
}
