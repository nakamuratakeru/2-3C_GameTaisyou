﻿using UnityEngine;
using System.Collections;

public class EffectLayerSetter : MonoBehaviour
{
    //エフェクト用のレイヤー名
    private string EFFECT_SORTING_LAYER_NAME = "Effect";

    private void Awake()
    {
        SetSortingLayer(transform);
    }

    private void SetSortingLayer(Transform parent)
    {

        //子がいる場合には、それにも同じ処理を行う
        foreach (Transform child in parent.transform)
        {
            SetSortingLayer(child);
        }
    }
}