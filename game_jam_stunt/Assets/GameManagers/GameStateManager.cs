using UnityEngine;

public class GameStateManager{
	protected GameStateManager(){}
	private static GameStateManager _instance = null;

	public static GameStateManager Instance{
		get{
			if(GameStateManager._instance == null){
				GameStateManager._instance = new GameStateManager();
			}
			return GameStateManager._instance;
		}
	}

	public GameState gameState { get; set; }

}

