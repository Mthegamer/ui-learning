using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class MegaMan : MonoBehaviour
    {

        //public float PositionX;

	
        public void Update () 
        {
            //transform.position = new Vector2(PositionX, transform.position.y);
	    
        }

        public void SetPositionX(float x)
        {
            transform.position = new Vector2(x, transform.position.y);
        }
    }
}
