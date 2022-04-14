using UnityEngine;
using System.Collections;
using UnityEngine.UI; // UIコンポーネントの使用

public class Menu : MonoBehaviour
{
	Button start;
	Button asobikata;
	Button title;

	void Start()
	{
		// ボタンコンポーネントの取得
		start = GameObject.Find("/Canvas/START").GetComponent<Button>();
		asobikata = GameObject.Find("/Canvas/ASOBIKATA").GetComponent<Button>();
		title = GameObject.Find("/Canvas/BACKTITLE").GetComponent<Button>();

		// 最初に選択状態にしたいボタンの設定
		start.Select();
	}
}