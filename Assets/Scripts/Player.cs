using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MovingObject
{
    #region Propertys
    public int playerHP = 10;
    private Animator animator;
    #endregion

    #region Methods

    // Awake is called before loading instance
	void Awake()
    {
		
	}

	// Use this for initialization
	protected override void Start()
    {
        animator = GetComponent<Animator>();
        playerHP = GameManager.instance.HP;

        base.Start();
	}

	// Update is called once per frame
	void Update()
    {
        if (GameManager.instance.turn == 0) return;

        int horizontal = 0;
        int vertical = 0;

        horizontal = (int)Input.GetAxisRaw("Horizontal");
        vertical = (int)Input.GetAxisRaw("Vertical");

        if (horizontal != 0)
            vertical = 0;

        if (horizontal != 0 || vertical != 0)
            AttemptMove<Magic>(horizontal, vertical);
	}

    protected override void OnCantMove<T>(T component)
    {
        throw new System.NotImplementedException();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "")
        {
            
        }
        else if(collision.tag == "")
        {
            
        }
        else if(collision.tag == "")
        {
            
        }
    }

    private void LoseHP(int loss)
    {
        animator.SetTrigger("hoge");
        playerHP -= loss;
        CheckIfGameOver();
    }

    protected override void AttemptMove<T>(int xDir, int yDir)
    {
        base.AttemptMove<T>(xDir, yDir);
        RaycastHit2D hit;

        GameManager.instance.turn = 0;
    }

    public void CheckIfGameOver()
    {
        if (playerHP <= 0)
            GameManager.instance.GameOver();
        
    }
    #endregion
}
