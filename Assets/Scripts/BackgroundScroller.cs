using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer spriteRinder;

   // [SerializeField] float speed = 1f;

    public Transform cameraTransform;
    float zValue;
    void Start()
    {
        float zValue = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        transform.position = new Vector3(cameraTransform.position.x , cameraTransform.position.y , zValue);
    }
}
