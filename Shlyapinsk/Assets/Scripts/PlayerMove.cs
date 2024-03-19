using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour // - ������ �PlayerMove� ������ ���� ��� ����� �������
{
//------- �������/�����, ����������� ��� ������� ���� ---------
public Rigidbody2D rb;
void Start()
{
rb = GetComponent<Rigidbody2D>();
}
//------- �������/�����, ����������� ������ ���� � ���� ---------
void Update()
{
Walk();
}
//------- �������/����� ��� ����������� ��������� �� ����������� ---------
public float speed = 4;
public Vector2 moveVector;
void Walk ()
{
moveVector.x = Input.GetAxisRaw("Horizontal");
rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
moveVector.y = Input.GetAxisRaw("Vertical");
rb.velocity = new Vector2(rb.velocity.x, moveVector.y * speed);
}
//-----------------------------------------------------------------
}