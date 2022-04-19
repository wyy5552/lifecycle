using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUnity : MonoBehaviour
{

    /// <summary>
    ///  初始化
    /// </summary>
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    /// <summary>
    /// 编辑器
    /// </summary>
    private void Reset()
    {
        Debug.Log("Reset");
    }
    /// <summary>
    /// 初始化
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        Animator animator = this.GetComponent<Animator>();
        animator.SetInteger("AniState", 1);
        //animator.GetCurrentAnimatorStateInfo().nameHash;
    }

    /// <summary>
    /// 物理
    /// </summary>
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    // State machine update

    //
    void OnStateMachineEnter()
    {
        Debug.Log("OnStateMachineEnter");
    }

    void OnStateMachineExit()
    {
        Debug.Log("OnStateMachineExit");
    }

    // ProcessGraph
    // Fire animation events
    // StateMachineBehaviour callback

    private void OnAnimatorMove()
    {
        Debug.Log("OnAnimatorMove");
    }

    // 内部物理更新

    // ProcessAnimation

    private void OnAnimatorIK(int layerIndex)
    {
        Debug.Log("OnAnimatorIK");
    }

    // WriteTransform

    // WriteProperties

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }


    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }

    // yeild WaitForFixedUpdate
    void WaitForFixedUpdate()
    {
        Debug.Log("WaitForFixedUpdate");
    }


    /// <summary>
    /// 事件输入
    /// </summary>

    private void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
    }

    private void OnMouseOver()
    {
        Debug.Log("OnMouseOver");
    }

    private void OnMouseUp()
    {
        Debug.Log("OnMouseUp");
    }

    private void OnMouseExit()
    {
        Debug.Log("OnMouseExit");
    }

    private void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag");
    }

    /// <summary>
    /// 游戏逻辑
    /// </summary>
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    // yield null
    // yield WaitForSeconds
    // yield WWW
    // yield StartCoroutine

    //// State machine update

    ////
    //void OnStateMachineEnter()
    //{

    //}

    //void OnStateMachineExit()
    //{

    //}

    //// ProcessGraph

    //// Fire animation events


    //// StateMachineBehaviour callback

    //private void OnAnimatorMove()
    //{

    //}

    //// 内部物理更新

    //// ProcessAnimation

    //private void OnAnimatorIK(int layerIndex)
    //{

    //}

    //// WriteTransform

    //// WriteProperties
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }

    /// <summary>
    /// 场景渲染
    /// </summary>
    ///
    private void OnPreCull()
    {
        Debug.Log("OnPreCull");
    }
    private void OnWillRenderObject()
    {
        Debug.Log("OnWillRenderObject");
    }
    private void OnBecameVisible()
    {
        Debug.Log("OnBecameVisible");
    }
    private void OnBecameInvisible()
    {
        Debug.Log("OnBecameInvisible");
    }
    private void OnPreRender()
    {
        Debug.Log("OnPreRender");
    }
    private void OnRenderObject()
    {
        Debug.Log("OnRenderObject");
    }
    private void OnPostRender()
    {
        Debug.Log("OnPostRender");
    }
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Debug.Log("OnRenderImage");
    }

    ///<summary>
    /// Gizmo rendering 场景插件渲染
    /// </summary>
    ///
    private void OnDrawGizmos()
    {
        Debug.Log("OnDrawGizmos");
    }

    /// <summary>
    /// GUI rendering
    /// </summary>
    private void OnGUI()
    {
        Debug.Log("OnGUI");
    }

    ///<summary>
    /// end of frame 帧尾
    /// </summary>

    // yield WaitForEndOfFrame


    ///<summary>
    /// Pausing 停止
    /// </summary>
    ///
    private void OnApplicationPause(bool pause)
    {
        Debug.Log("OnApplicationPause");
    }

    ///<summary>
    /// Decommissioning 关闭
    /// </summary>
    ///
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }


}
