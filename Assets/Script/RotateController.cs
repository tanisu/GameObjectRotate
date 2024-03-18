using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public float rotateSpeed,rotateAngle, targetAngle;
    float currentAngle = 0.0f;
    Quaternion targetRotation;
    Rigidbody2D rb2d;
    float threshold = 0.01f;
    bool isStop;
    void Start()
    {

       // targetRotation = Quaternion.Euler(0, 0, targetAngle);
        //float power = Random.Range(0,50);

        //rotateSpeed += power;
        //if (Random.Range(0, 2) % 2 == 0) rotateSpeed *= -1 ;
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddTorque(rotateSpeed, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);
        //if (Mathf.Approximately(Quaternion.Angle(transform.rotation, targetRotation), 0f))
        //{
        //    transform.rotation = targetRotation;
        //}
        //if(targetAngle > 0)
        //{
        //    //目標に達していない場合は回転させる
        //    if (currentAngle < targetAngle)
        //    {
        //        //このフレームで回転させる角度を取得
        //        float rotateAmount = rotateSpeed * Time.deltaTime;
        //        //現在の角度に足して更新する
        //        currentAngle += rotateAmount;
        //        //現在の角度がターゲット以上になってしまった場合
        //        if (currentAngle > targetAngle)
        //        {
        //            //回転させる量から差分を引く
        //            rotateAmount -= currentAngle - targetAngle;
        //        }
        //        //オブジェクトを回転させる
        //        transform.Rotate(0, 0, rotateAmount);
        //    }
        //}
        //else
        //{
        //    if(currentAngle > targetAngle)
        //    {
        //        float rotateAmount = -rotateSpeed * Time.deltaTime;
        //        currentAngle += rotateAmount;
        //        if(currentAngle < targetAngle)
        //        {
        //            rotateAmount += targetAngle - currentAngle;
        //        }
        //        transform.Rotate(0, 0, rotateAmount);
        //    }
        //}

        //transform.Rotate(0, 0, rotateAngle *  Time.deltaTime * rotateSpeed );
        //transform.rotation *= Quaternion.Euler(0, 0, rotateAngle * Time.deltaTime * rotateSpeed);

        if (Mathf.Abs(rb2d.angularVelocity) < threshold && !isStop)
        {
            isStop = true;
            Debug.Log("stop");
            rb2d.angularVelocity = 0f;
            rb2d.velocity = Vector2.zero;
        }

    }
}
