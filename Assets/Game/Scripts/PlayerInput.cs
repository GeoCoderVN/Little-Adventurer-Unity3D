using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update

    public float HorizontalInput;

    public float VerticalInput;

    public bool MouseButtonDown;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!MouseButtonDown && Time.timeScale != 0)
        {
            MouseButtonDown = Input.GetMouseButtonDown(0);
        }
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
    }

    private void OnDisable()
    {
        MouseButtonDown = false;
        HorizontalInput = 0;
        VerticalInput = 0;
    }
}
