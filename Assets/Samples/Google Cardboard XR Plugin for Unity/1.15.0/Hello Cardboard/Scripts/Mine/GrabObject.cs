using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    public GameObject ball;
    public GameObject hands;
    bool inHands = false;
    Vector3 ballPos;

    // Start is called before the first frame update
    void Start()
    {
        ballPos = ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1")) {
            if (!inHands) {
                ball.transform.SetParent(hands.transform);
                ball.transform.localPosition = new Vector3(0f, -.672f, 0f);
                inHands = true;
            } else if (inHands) {
                this.GetComponent<GrabObject>().enabled = false;
                ball.transform.SetParent(null);
                ball.transform.localPosition = ballPos;
                inHands = false;
            }
        }
    }
}
