using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    public Transform Target;
    public float Cameraspeed;

    //x and y axis boundaries
    public float minX, maxX;
    public float minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        if(Target != null) {
            Vector2 newCamPostion = Vector2.Lerp(transform.position, Target.position, Time.deltaTime * Cameraspeed);
            float ClampX = Mathf.Clamp(newCamPostion.x, minX, maxX);
            float ClampY = Mathf.Clamp(newCamPostion.x, minY, maxY);
            transform.position = new Vector3(ClampX, ClampY, -10);
        }
    }
}