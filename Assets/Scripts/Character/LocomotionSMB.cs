﻿using UnityEngine;

 public class LocomotionSMB : SceneLinkedSMB<PlayerCharacter>
 {
     private static readonly int DoRun = Animator.StringToHash("doRun");
     
     public override void OnSLStateEnter (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
     {
         Debug.Log("LocomotionSMB.OnSLStateEnter");
     }

     public override void OnSLStateNoTransitionUpdate (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
     {
         Debug.Log("LocomotionSMB.OnSLStateNoTransitionUpdate");
     }
     
     public override void OnSLStateExit (Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
     {
         Debug.Log("LocomotionSMB.OnSLStateExit");
     }
 }