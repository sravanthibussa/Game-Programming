﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      StartCoroutine("waitforplatform");
    }
    IEnumerator waitforplatform()
    {
     yield return new WaitForSeconds(8f);
    
      transform.Translate(new Vector3(0,0,-10f*Time.deltaTime));
      if(transform.position.z<=-50f)
      {
        transform.position=new Vector3(0,0,145f);
      }  
    }
}
