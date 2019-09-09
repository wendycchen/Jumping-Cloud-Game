using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //void Update()
    //{
    // if (Input.GetKeyDown(KeyCode.LeftArrow))
    //    {
    //        transform.Translate(-1.5f, 0, 0);
    //    }
    // if (Input.GetKeyDown(KeyCode.RightArrow))
    //    {
    //        transform.Translate(1.5f, 0, 0);
    //    }
    //}

    public void LButtonDown()
    {
        transform.Translate(-1.5f, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(1.5f, 0, 0);
    }
}
