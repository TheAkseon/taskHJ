using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameMessage : MonoBehaviour
{
    private bool _checkMessageOutput = false;
    

    private void OnCollisionEnter(Collision collision)
    {
        if(_checkMessageOutput == false)
        {
            if(collision.gameObject.TryGetComponent(out FinishPlatform finishPlatform))
            {
                Debug.Log("Game is the ended!");
                _checkMessageOutput = true;
            }
        }
    }
}
