using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{
	Rigidbody2D rb;
	public int moveSpeed = 2;

	void Start()
	{
		//GetComponentの処理をキャッシュしておく
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		//velocity: 速度
		//X方向へmoveSpeed分移動させる
		rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
	}
}