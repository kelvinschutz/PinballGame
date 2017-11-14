using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class ThemeScript : MonoBehaviour
{
    public BallDropper ballDropper;
    public TextAsset TextFile;

	// Use this for initialization
	void Start () {
		foreach(var theme in LoadThemes())
		{
		    ballDropper.DropBall(theme);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private List<string> LoadThemes()
    {
        List<string> themes = new List<string>();
        string textLine;
        
        StreamReader sr = new StreamReader("Assets/themes.txt", Encoding.Default);
        using (sr)
        {
            do
            {
                textLine = sr.ReadLine();
                if (textLine != null)
                {
                    themes.Add(textLine);
                }
            } while (textLine != null);

            sr.Close();
            return themes;
        }
    }
}
