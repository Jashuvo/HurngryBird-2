using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    private bool isPulled = false;
    public Rigidbody2D ballRigid;
    public float releaseTime = 0.15f;

    void Start()
    {
        ballRigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (isPulled)
        {
            ballRigid.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void OnMouseDown()
    {
        isPulled = true;
        ballRigid.isKinematic = true;
    }

    void OnMouseUp()
    {
        isPulled = false;
        ballRigid.isKinematic = false;
        StartCoroutine(Release()) ;
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);
        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;
    }
}
