using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{
   Animator myani;
   Rigidbody myrb;
    // Start is called before the first frame update
    void Start()
    {
     myani=GetComponent<Animator>();  
     myrb=GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.RightArrow)&&(transform.position.x==0)) 
      {
        transform.position=new Vector3(transform.position.x+2,0.5f,0);
      } 
      if(Input.GetKeyDown(KeyCode.LeftArrow)&&(transform.position.x==0)) 
      {
        transform.position=new Vector3(transform.position.x-2,0.5f,0);
      } 
      if(Input.GetKeyDown(KeyCode.RightArrow)&&(transform.position.x==-2)) 
      {
        transform.position=new Vector3(transform.position.x+2,0.5f,0);
      } 
      if(Input.GetKeyDown(KeyCode.LeftArrow)&&(transform.position.x==2)) 
      {
        transform.position=new Vector3(transform.position.x-2,0.5f,0);
      } 
    
    if(Input.GetKeyDown(KeyCode.DownArrow))
    {
      myani.SetTrigger("roll");
    }
    if(Input.GetKeyDown(KeyCode.UpArrow)&&myrb.velocity.y==0)
    {
      myani.SetTrigger("jump");
      myrb.velocity=new Vector3(0,5f,0);
    }
}
private void OnTriggerEnter(Collider other)
{
  if(other.gameObject.tag=="coin")
  {
    Destroy(other.gameObject);
  }
}
}

