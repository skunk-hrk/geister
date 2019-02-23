using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator test0;

    public Animation() {
        //test0 = (GameObject)Resources.Load("Animation/test_0");
    }

    // Use this for initialization
    void Start()
    {
       // test0 = (Animator)Resources.Load("Animation/test_0");
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 移動後時アニメーション
    public void AnimMove(float x = -1.41f, float y = 0.51f, float z = 0.0f)
    {
        //GameObject testanim = Instantiate(test0, new Vector3(x, y, z), Quaternion.identity);
    }
}
