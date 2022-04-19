using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFsm : MonoBehaviour
{
    public Animator ani;

    void Start()
    {
        //this.Invoke("changeState", 1);
    }

    void changeState()
    {
        ani.SetInteger("player_state", (int)Player_State_Trans.ToFire);
    }
    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo info = ani.GetCurrentAnimatorStateInfo(0);
        //if(info.normalizedTime>=1.0f && info.IsName(Player_State.fire))
        //{
        //    Debug.Log(info.normalizedTime);
        //    ani.SetInteger("player_state", (int)Player_State_Trans.ToIdle);
        //}
    }
}
class Player_State
{
    internal static string idle = "idle";
    internal static string run = "run";
    internal static string fire = "fire";
    internal static string run_fire = "run_fire";
};
enum Player_State_Trans
{
    ToDie = 4,
    ToFire = 1,
    ToRun = 2,
    ToRunFire = 3,
    ToIdle = 0,
    ToReborn = 5
};
