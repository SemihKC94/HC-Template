/*//////////////////////////////////////////////////////////////////////////////////////////
//      █─▄▄▄▄█▄─█─▄█─▄▄▄─█                                                               //
//      █▄▄▄▄─██─▄▀██─███▀█             Scripts created by Semih Kubilay Çetin            //
//      ▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀                                                               //
//////////////////////////////////////////////////////////////////////////////////////////*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Runner Mechanic", menuName ="SKC/Runner Mechanic Data")]
public class SKC_RunnerMechanic : ScriptableObject
{
    [Header("Movement Config")]
    public float forwardSpeed = 10f;
    public float sideSpeed = 5f;
    public Vector2 xClamp = Vector2.one;

    [Space, Header("Animator Config")]
    [SerializeField] private string idleAnimName = "Idle";
    [SerializeField] private string runAnimName = "Run";
    [SerializeField] private string victoryAnimName = "Victory";
    [SerializeField] private string lossAnimName = "Loss";

    // Accessibles
    public string IdleAnim { get { return this.idleAnimName; } }
    public string RunAnim { get { return this.runAnimName; } }
    public string VictoryAnim { get { return this.victoryAnimName; } }
    public string LossAnim { get { return this.lossAnimName; } }
}
/* Tip    #if UNITY_EDITOR
          Debug.Log("Unity Editor");
          #endif                          Tip End */