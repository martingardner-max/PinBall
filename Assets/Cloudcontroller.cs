using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloudcontroller : MonoBehaviour
{
    //�ŏ��T�C�Y
    private float minimum = 0.8f;
    //�g��k���X�s�[�h
    private float magSpeed = 10.0f;
    //�g�嗦
    private float magnification = 0.07f;

    // Start is called before the first frame update
    void Start()
    {
       

    
    }

    // Update is called once per frame
    void Update()
    {
        //�_���g��k��
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);


    }
}
