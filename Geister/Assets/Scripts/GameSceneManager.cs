using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{

    // 実物
    public GameObject PlyaerScript;
    public GameObject GhostScript;
    public GameObject player;
    public GameObject canvas;
    GameObject refObj;

    // 先行後攻
    private enum Order
    {
        senkou,
        koukou
    }

    private Order order;

    // Use this for initialization
    void Start()
    {
        //player.AddComponent<PlyaerScript> ();
        SetOrder();

        refObj = GameObject.Find("Animation");

        GameObject prefabGW = (GameObject)Resources.Load("Img/GhostWhite");
        Debug.Log(prefabGW);
        GameObject test2 = Instantiate(prefabGW, new Vector3(-1.41f, 0.51f, 0.0f), Quaternion.identity);
        Debug.Log(test2.GetComponent<Button>());
        test2.GetComponent<Button>().onClick.AddListener(() => TestClick(test2));
        test2.transform.SetParent(canvas.transform, false);

        //GameObject test = Resources.Load("Scripts/Player.cs", typeof(GameObject));
        //Invoke("DelayMethod", 3.5f);
        Debug.Log(prefabGW);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void DelayMethod()
    {
        SceneManager.LoadScene("ResultScene");
    }

    // 先行後攻を決める
    public string SetOrder(){
        order = (Order)Random.Range(0, System.Enum.GetValues(typeof(Order)).Length);
        Debug.Log(order);
        return "0";
    }

    public void TestClick(GameObject obj){
        Debug.Log("test");
        Vector3 tmp = obj.transform.position;
        float x = tmp.x;
        float y = tmp.y;
        float z = tmp.z;
        Debug.Log(obj);
        Animation ani = refObj.GetComponent<Animation>();
        Debug.Log(ani);
        ani.AnimMove(x,y,z);

        obj.AddComponent(typeof(Animator));
        var anim = obj.GetComponent<Animator>();
        anim.runtimeAnimatorController = Resources.Load("Animation/test_0") as RuntimeAnimatorController;
        anim.Play("testAnim");
    }
}
