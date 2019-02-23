using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    // 良いゴーストか悪いゴーストか
    public enum type
    {
        good,
        bad
    }
    // ゴーストの位置情報
    public int[] pos = new int[2];

    // 活性非活性判定フラグ
    public bool active = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // 初期位置設定
    public void SetPos()
    {

    }

    // ゴーストを動かす
    public void MovePosition()
    {

    }

    // ゴーストの活性・非活性変換
    public void ChangeActive()
    {

    }

    public void testClick()
    {
        Debug.Log("test");
    }


}
