﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMocinhoBebado : MoveToTouchScript {
  public ComicManager comic5;

  protected override IEnumerator TouchRoutine() {
    gm.StartTalking();
    if (gm.bucketItem.activeSelf) {
      yield return gm.Talk("Uhhh. What?", gm.MocinhoBebado);
      yield return gm.Talk("Think fast!", gm.Bro);
      yield return gm.FadeOut();
      yield return comic5.ShowComic();
      gm.BroAnim.animator.runtimeAnimatorController = gm.BroAnim.defaultController;
      gm.bucketItem.SetActive(false);

      gm.Nina.gameObject.SetActive(true);
      gm.MocinhoMolhado.gameObject.SetActive(true);
      gm.MocinhoBebado.transform.position = new Vector3(1000, 0, 0);
      yield return gm.FadeIn();
      gm.MocinhoBebado.gameObject.SetActive(false);
    } else {
      yield return gm.Talk("He's too nervous for a hug.", gm.Bro);
    }
    gm.StopTalking();
  }
}