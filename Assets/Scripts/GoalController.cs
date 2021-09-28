using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalController : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D colInfo)
	{
		if (colInfo.CompareTag("Player"))
		{
			Debug.Log("GAME WON! :D");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}