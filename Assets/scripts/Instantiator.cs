using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Instantiator : MonoBehaviour
{
    public Text txtUserCloneAmount;
    public GameObject objectToClone;
    int CloneAmount;
    GameObject clon;
    public void MultiInstantiate()
    {
        if (txtUserCloneAmount.text != "")
        {
            CloneAmount = int.Parse(txtUserCloneAmount.text);
        }

        for (int i = 0; i < CloneAmount; i++)
        {
            clon = Instantiate(objectToClone);
            Destroy(clon, 2);
        }

    }
}
