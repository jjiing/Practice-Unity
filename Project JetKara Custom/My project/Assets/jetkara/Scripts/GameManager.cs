using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject[] objects;

	public TextMesh scoreLabel;
	public static int score;
	public int Score
	{
		set
		{
			score = value;

			scoreLabel.text = Score.ToString();
		}
		get
		{
			return score;
		}
	}

	void Start () 
	{
		score = 0;

		InvokeRepeating("CreateObjects", 1,2);

		int objectNum = Random.Range(0, objects.Length);
		Instantiate(objects[objectNum], new Vector3(4.5f, Random.Range(-2f, 2.1f), 0), Quaternion.identity);
	}

	void CreateObjects()
	{
		int objectNum = Random.Range(0, objects.Length);
	
		Instantiate(objects[objectNum], new Vector3(6.3f, Random.Range(-2f, 2.1f), 0), Quaternion.identity);
		

	}
}


