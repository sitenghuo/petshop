using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnim : MonoBehaviour
{
    // 该脚本挂在遮罩物体上用于获取遮罩动画器
    public static Animator startAnim;
    // Start is called before the first frame update
    void Start()
    {
        startAnim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
