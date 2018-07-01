using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

public class InputTesting : MonoBehaviour {


    //public InputAction fireAction;

    public Combo combos;

    void Awake()
    {
        //fireAction.performed += ctx => Fire();

        combos.womwom.action.performed += ctx => Fire();
    }

	// Update is called once per frame
	void Update () {
        if (Keyboard.current.spaceKey.wasJustPressed)
        {
            Debug.Log("Wow this key is just pressed");
        }
	}

    void Fire()
    {
        Debug.Log("It fires");
    }

    public void OnEnable()
    {
        combos.Enable();
    }

    public void OnDisable()
    {
        combos.Disable();
    }
    //void OnEnable()
    //{
    //    fireAction.Enable();
    //}

    //void OnDisable()
    //{
    //    fireAction.Disable();
    //}
}
