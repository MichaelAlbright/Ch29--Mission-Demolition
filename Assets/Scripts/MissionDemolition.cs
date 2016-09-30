using UnityEngine;
using System.Collections;

public enum GameMode
{
	idle,
	playing,
	levelEnd
}

public class MissionDemolition : MonoBehaviour {
	static public MissionDemolition S;

	public GameObject[] castles;
	public GUIText gtLevel;
	public GUIText gtScore;
	public Vector3 castlePos;
	public bool _______________;
	public int level;
	public int levelMax;
	public int shotsTaken;
	public GameObject castle;
	public GameMode mode = GameMode.idle;
	public string showing = "Slingshot";

	void Start()
	{
		S = this;
		level = 0;
		levelMax = castles.Length;
		StartLevel ();
	}

	void StartLevel()
	{
		if (castle != null) {
			Destroy (castle);
		}

		gameObject[] gos = gameObject.FindGameObjectsWithTag ("Projectile");
	}
}
