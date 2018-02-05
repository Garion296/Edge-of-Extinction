//Wil be used whenever a button or something that needs this function will be used to change scenes

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenes : MonoBehaviour {

    //NO NEED FOR START OR UPDATE FUNCTIONS

    // Changes to the appropriate scene
    public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
