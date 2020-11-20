using UnityEngine;
using System.Collections;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class Init : MonoBehaviour 
{
	private bool Google_Inited = false;
	void Start () 
	{
		Screen.orientation = ScreenOrientation.LandscapeLeft;
		Screen.SetResolution(1280, 800, true);
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		Application.targetFrameRate = 60;
		QualitySettings.vSyncCount = -1;
		//Application.targetFrameRate = 120;*/
		if (!Google_Inited)
		{
			PlayGamesPlatform.Activate();
			Social.localUser.Authenticate((bool success) => 
			{
				if (success)
				{
					Debug.Log("OK");
				}
				else
				{
					Debug.Log("NEM OK");
				}
				
			}
			);
			Google_Inited = true;
		}
		
		PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkI2LvbwckBEAIQAA");		
	}
}
