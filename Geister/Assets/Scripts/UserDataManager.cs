using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // プレイヤーネームを設定
    public void SetMyname()
    {

    }

    // プレイヤーネームを取得
    public string GetMyname()
    {
        string user_name = "name";
        return user_name;
    }

    // 勝利数を更新
    public void SetWinCount()
    {

    }

    // 勝利数を取得
    public int GetWinCount()
    {
        int win_count = 0;
        return win_count;
    }

    // 敗北数を更新
    public void SetLoseCount()
    {

    }

    // 敗北数を取得
    public int GetLoseCount()
    {
        int lose_count = 0;
        return lose_count;
    }

}
