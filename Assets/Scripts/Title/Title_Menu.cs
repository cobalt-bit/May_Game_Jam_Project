using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title_Menu : MonoBehaviour
{
	public string SceneName;

	[SerializeField] private GameObject Panel;

	private void Start()
	{

	}

    public void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
			Application.Quit();
	}

    public void changeShene(string name)
	{
		if (name != "")
			SceneName = name;

		if(SceneName != "")
			SceneManager.LoadScene(SceneName);
	}


	public void FinishGame()
	{
		Application.Quit();
	}
}
