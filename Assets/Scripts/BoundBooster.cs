using System;
using UnityEngine;

public class BoundBooster : MonoBehaviour
{
    public float value;
    public float ignorespeed;
    public float boostMultiplier = 1.2f; // 跳ね返り時の加速倍率

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.rigidbody;
        if (rb == null) return;
        // 衝突したオブジェクトの速度が指定した値よりも大きい場合は何もしない
        if (rb.linearVelocity.sqrMagnitude >= ignorespeed * ignorespeed) return;

        // 衝突した面の法線を取得
        Vector2 normal = collision.contacts[0].normal;

        // 現在の速度を法線で反射
        Vector2 reflectedVelocity = Vector2.Reflect(rb.linearVelocity, normal);

        // 反射後の速度に加速を加える
        rb.linearVelocity = reflectedVelocity.normalized * boostMultiplier;
    }
}
