using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

    public Transform target; //ターゲットへの参照
    private Vector3 offset;

    void Start()
    {
        //自分自身とTargetとの相対距離を求める
        offset = GetComponent<Transform>().position - target.position;
    }

    // Update is called once per frame
    void Update() {

        // 自分の座標に Target の座標を代入する
        GetComponent<Transform>().position = target.position + offset;
    }
}
