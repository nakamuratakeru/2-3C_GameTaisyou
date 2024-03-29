﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class NoteController : MonoBehaviour
{
    string Type;
    float Timing;

    float Distance;
    float During;

    Vector3 firstPos;
    bool isGo;
    float GoTime;

    void OnEnable()
    {
        isGo = false;
        firstPos = this.transform.position;

        this.UpdateAsObservable()
          .Where(_ => isGo)
          .Subscribe(_ => {
              this.gameObject.transform.position = new Vector3(firstPos.x - Distance * (Time.time * 1000 - GoTime) / During, firstPos.y, firstPos.z);
          });
    }

    public void setParameter(string type, float timing)
    {
        Type = type;
        Timing = timing;
    }

    public string getType()
    {
        return Type;
    }

    public float getTiming()
    {
        return Timing;
    }

    public void go(float distance, float during)
    {
        Distance = distance;
        During = during;
        GoTime = Time.time * 1000;

        isGo = true;
    }
}