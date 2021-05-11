using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdventureGame : MonoBehaviour
{

    // Ctrl+R+R, Lets you rename all the words with the same variable at the same time.

    [SerializeField] Text gameText;
    [SerializeField] State startingState;

    // private State stateScript; // added this just to avoid confucion from using the "state" variable for everything. DONT NEED THE "stateScript" VARIABLE THO. THIS DOESNT WORK (NO IDEA WHY).
    private State state; // This is the "State" script.


    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        gameText.text = (state.GetStateStory()); // Because the "GetStateStory()" method is public in the state script. It can be accessed from the state script by using "(state.GetStateStory())".
    }

    // Update is called once per frame
    void Update()
    {
        ManageNextState();
        RestartGame();
    }

    private void ManageNextState()
    {
        var nextState = state.GetNextState(); // "var" automatically gets the variable type of a variable if its already declared somewhere. Not need to write "State[]" again, it automatically gets it.
        for (int index = 0; index < nextState.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextState[index];
            }
        }
        gameText.text = state.GetStateStory();


        /* if (Input.GetKeyDown(KeyCode.Alpha1))
         {
             state = nextState[0];
         }
         else if (Input.GetKeyDown(KeyCode.Alpha2))
         {
             state = nextState[1];
         }
         else if (Input.GetKeyDown(KeyCode.Alpha3))
         {
             state = nextState[2];
         }
         */
    }

    void RestartGame()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
