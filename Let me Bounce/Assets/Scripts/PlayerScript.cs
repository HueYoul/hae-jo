using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using Cinemachine;

public class PlayerScript : MonoBehaviourPunCallbacks, IPunObservable
{
    public Rigidbody2D RB;
    public SpriteRenderer SR;
    public PhotonView PV;
    public Text NickNameText;

    public bool noGravity = false;
    public bool canDoubleJump = false;

    bool isGround;
    Vector3 curPos;

    float speed = 10.0f;

    void Awake()
    {
        // �г���
        NickNameText.text = PV.IsMine ? PhotonNetwork.NickName : PV.Owner.NickName;
        NickNameText.color = PV.IsMine ? Color.green : Color.red;

        if (PV.IsMine)
        {
            // 2D ī�޶�
            var CM = GameObject.Find("CMCamera").GetComponent<CinemachineVirtualCamera>();
            CM.Follow = transform;
            CM.LookAt = transform;
        }
    }

    void Update()
    {
        if (PV.IsMine)
        {
            if (noGravity && Input.anyKeyDown)
            {
                noGravity = false;
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                gameObject.GetComponent<Rigidbody2D>().gravityScale = 5;
            }

            if (canDoubleJump)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 700));
                canDoubleJump = false;
            }

            //PC controll
            if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.Translate(new Vector3(0.02f, 0, 0));
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.Translate(new Vector3(-0.02f, 0, 0));
            }

            //Mobile controll
            Vector3 dir = Vector3.zero;
            dir.x = Input.acceleration.x;

            if (dir.sqrMagnitude > 1)
                dir.Normalize();

            dir *= Time.deltaTime;

            transform.Translate(dir * speed);

            gameObject.transform.Translate(dir * speed);

        }

        else if ((transform.position - curPos).sqrMagnitude >= 100) transform.position = curPos;
        else transform.position = Vector3.Lerp(transform.position, curPos, Time.deltaTime * 10);
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(transform.position);
        }
        else
        {
            curPos = (Vector3)stream.ReceiveNext();
        }
    }
}