﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DataInputManager : MonoBehaviour
{
    public Text txtUserName;
    public void ShowGreetings()
    {
        Debug.Log("hola " + txtUserName.text);
    }
 public void ShowDouble()
    {
        if(txtUserName.text != "")
        {
        Debug.Log(int.Parse(txtUserName.text) * 2);
        }
        else
        {
            Debug.Log("el campo no puede estar vacio");
        }
    }
}
