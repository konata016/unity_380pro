using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLJump : MonoBehaviour
{

    bool judge = false;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(judge);
        if (other.gameObject.tag == "Stage")
        {
            judge = true;
        }
        else
        {
            judge = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        judge = false;
    }
    public bool getJudge()
    {
        return judge;
    }
}
