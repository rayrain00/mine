using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    #region Propertys
    public GameObject gameManager;
    #endregion

    #region Methods

    // Awake is called before loading instance
	void Awake()
    {
        if (GameManager.instance == null)
            Instantiate(gameManager);
	}

    #endregion
}
