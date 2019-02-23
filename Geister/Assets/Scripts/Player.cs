using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 実物名前
    public GameObject obj_name;

    // 実物時間
    public GameObject obj_time;

    // 実物先行後攻
    public GameObject obj_order;

    // ユーザーネーム
    private string name;

    // 考慮時間
    private DateTime date;

    // 先行後攻
    private enum order
    {
        senkou,
        koukou
    }

    // ゴースト
    public int[] ghost = new int[8];

    // 取られたゴースト
    public int[] token = new int[8];

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // 移動する駒を選択
    public void SelectGhost(int select_ghost_num)
    {

    }

    // 移動する駒の移動後の位置を設定
    public void MoveGhost(int move_ghost_num)
    {

    }

    // 駒を取られた時の処理
    public void TookGhost(int took_ghost)
    {

    }

    // 考慮時間カウントスタート
    public void CountStart()
    {

    }

    // 考慮時間カウントストップ
    public void CountStop()
    {

    }

    // 自分が取られた駒を返す
    public int[] GetToken()
    {
        return ghost;
    }

    // 降参
    public void Surrender()
    {

    }
}
