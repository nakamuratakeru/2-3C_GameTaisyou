using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    //SelectTextが選択されたら、カーソル移動する

    //SelectTextが選択されたら
    //SelectTextにMoveArrowToの関数の登録をする

    [SerializeField] List<SelectableText> selectabletexts = new List<SelectableText>();
    
    [SerializeField] Transform arrow = default;

    void Start()
    {
        SetMoveArrowFunction();
    }

    void SetMoveArrowFunction()
    {
        foreach(SelectableText selectabletext in selectabletexts)
        {
            selectabletext.OnSelectAction = MoveArrowTo;
        }
    }
    public void MoveArrowTo(Transform parent)
    {
        Debug.Log("カーソル移動");
        arrow.SetParent(parent);


    }
}
