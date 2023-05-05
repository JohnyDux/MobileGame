using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructionBricks : MonoBehaviour
{
    public BoxCollider2D PlayerCollider1;
    public CircleCollider2D PlayerCollider2;
    public BoxCollider2D PlayerCollider3;
    Collider2D Bricks;
    private void Start()
    {
        Bricks = GetComponent<Collider2D>();
        Physics2D.IgnoreCollision(Bricks, PlayerCollider1);
        Physics2D.IgnoreCollision(Bricks, PlayerCollider2);
        Physics2D.IgnoreCollision(Bricks, PlayerCollider3);
    }
}
