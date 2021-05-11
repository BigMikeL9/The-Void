using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject  // https://docs.unity3d.com/Manual/class-ScriptableObject.html - Unity ScriptableObject API
{

    [TextArea(10,14)] [SerializeField] string storyText;
    [SerializeField] State[] nextState;

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextState() // Just takes the "nextState" variable and puts it in a method to make it public and use it in the "AdventureGame" class/script. Could have just made the "nextState" variable public, but I guess he wants us to get use to only using methods in other classes.
    {
        return nextState;
    }
}
