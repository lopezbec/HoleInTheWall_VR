using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine.Windows.Speech;
using TMPro;

public class GameController : MonoBehaviour
{
    private static GameController gc;
    private static bool gameOn = false;
    private static DateTime startTime;
    private static GameObject[] levels;
    private static double speed = -2;
    private static int gameScore;
    private static int coinCount;
    private static int collisionCount;
    private static int streak;
    private static TMP_Text scoreText;
    private static int gameScoreDeductions;


    // Use this for initialization
    void Start()
    {
        Debug.Log("started");
        
        GameObject scoreTextObj = GameObject.FindWithTag("ScoreText");
        scoreText = scoreTextObj.GetComponent<TMP_Text>();
        gc = this;
        //subjectId = System.DateTime.Now.ToString().GetHashCode().ToString();
        if (!Directory.Exists("DATA"))
            Directory.CreateDirectory("DATA");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOn)
        {
            levels = GameObject.FindGameObjectsWithTag("Level");

            foreach (GameObject level in levels)
            {
                level.transform.position += new Vector3(0, 0, (float)speed * Time.deltaTime);
            }
            
            gameScore = (int)((Mathf.Abs(levels[0].transform.position.z - 10)) - gameScoreDeductions);
            if (levels[0].transform.position.z < -280) 
            {
                GameOver();
            }
        }
        scoreText.text = "Score: " + gameScore.ToString();
    }


    public void ChangeEnvironment(int input)
    {
        
    }

   





    public static void StartGame()
    {
        Grader.score = 0;
        gameOn = true;
        startTime = DateTime.Now;
        GameObject.FindWithTag("StartMenu").SetActive(false);
    }

    void GameOver()
    {
        gameOn = false;
        // writer.WriteLine("\n\n");
        //scorePanel.SetActive(false);

        //winLose.text = "Great Game!";
        //summary.text = string.Format("Score:{0}\nCoins:{1}", gameScore, GameController.coinCount);


    }

    public void AddRandomNames()
    {
        string names = "Pikachu Prof.Lopez AllyB Mario T-Pose Luigi Kermit Kirby D.Va Tom-Hanks Voldemort Harry-Potter Unity NoobMaster69";
        string[] individual = names.Split(' ');
        //foreach (var word in individual)
        //{
        //    randomNames.Add(word);
        //}
    }




    public void addPeople()
    {

    }

    //class of ScoreEntry that stores the players names and scores
    class ScoreEntry
    {
        private string name;
        private int score;

        public ScoreEntry(string name, string score)
        {
            this.name = name;
            this.score = int.Parse(score);
        }

        public int getScore()
        {
            return score;
        }

        public string getName()
        {
            return name;
        }
    }




    public static void NotifyPassed()
    {
        //passMark.GetComponent<Image>().enabled = true;
        gc.addStreak();
    }

    public static void NotifyFailed()
    {
        //failMark.GetComponent<Image>().enabled = true;
    }

    // clear the notification area of the screen
    public static void ClearNotify()
    {
        //passMark.GetComponent<Image>().enabled = false;
        //failMark.GetComponent<Image>().enabled = false;
    }

    //Achievement Checking
    public void addStreak()
    {
        streak++;
    }

    public static void minusStreak()
    {
        streak--;
    }

    public static int getStreak()
    {
        return streak;
    }

    public void enableAchievementBoard()
    {
        //int imageNumber = 0;
        //achievementBoard.SetActive(true);
        //avatarGoodMenu.SetActive(false);
        //foreach (Achievement achievement in gc.achievementList)
        //{
        //    if (achievement.getCompleted() == true)
        //    {
        //        gc.achievementColor = new Color(0.3254717f, 1f, 0.3261002f, 0.7764706f);
        //        //gc.hoverColor = Color.green;
        //    }
        //    else
        //    {
        //        gc.achievementColor = new Color(0.9568628f, 0.4352942f, 0.4392157f, 1f);
        //        //gc.hoverColor = Color.red;
        //    }
        //    gc.imageList[imageNumber].color = gc.achievementColor;
        //    imageNumber++;
        //}
    }

    public void addAchievements()
    {
        //Achievement five = new Achievement("Five in a Row!", "Pass Five Obstacles in a Row", false);
        //achievementList.Add(five);
        //Achievement ten = new Achievement("Ten in a Row!", "Pass Ten Obstacles in a Row", false);
        //achievementList.Add(ten);
        //Achievement coins = new Achievement("Coins!", "Collect 20 Coins", false);
        //achievementList.Add(coins);
        //Achievement almost = new Achievement("Almost!", "Fail an Obstacle with one collision", false);
        //achievementList.Add(almost);

        ////Set Text in game to what is determined here, syncs the in game with the code
        //AName1.text = achievementList[0].getName();
        //ADesc1.text = achievementList[0].getText();
        //AName2.text = achievementList[1].getName();
        //ADesc2.text = achievementList[1].getText();
        //AName3.text = achievementList[2].getName();
        //ADesc3.text = achievementList[2].getText();
        //AName4.text = achievementList[3].getName();
        //ADesc4.text = achievementList[3].getText();

        ////Adds images to image list to change color of achievement on enter
        //imageList.Add(a1);
        //imageList.Add(a2);
        //imageList.Add(a3);
        //imageList.Add(a4);
    }


    //Checks whether an achievement has been triggered and tells the Grader
    public void checkAchievement()
    {
        //if (achieve)
        //{
        //    if (gc.streak == 5 && achievementList[0].getCompleted() == false)
        //    {
        //        //5 In A Row! Achievement Active
        //        achievementList[0].setCompleted(true);
        //        achievementName.text = achievementList[0].getName();
        //        achievementPopup.SetActive(true);
        //        Invoke("DisableAchievements", 4f);
        //    }

        //    if (gc.streak == 10 && achievementList[1].getCompleted() == false)
        //    {
        //        //10 In A Row Achievment Active
        //        achievementList[1].setCompleted(true);
        //        achievementName.text = achievementList[1].getName();
        //        achievementPopup.SetActive(true);
        //        Invoke("DisableAchievements", 4f);
        //    }

        //    if (coinCount == 20 && achievementList[2].getCompleted() == false)
        //    {
        //        //Coins! Active
        //        achievementList[2].setCompleted(true);
        //        achievementName.text = achievementList[2].getName();
        //        achievementPopup.SetActive(true);
        //        Invoke("DisableAchievements", 4f);
        //    }

        //    if (collisions == 1 && achievementList[3].getCompleted() == false)
        //    {
        //        //Almost! Achievement Active
        //        achievementList[3].setCompleted(true);
        //        achievementName.text = achievementList[3].getName();
        //        achievementPopup.SetActive(true);
        //        Invoke("DisableAchievements", 4f);
        //    }
        //}

    }

    public static void resetCollisions()
    {
        collisionCount = 0;
    }

    void DisableAchievements()
    {
        //achievementPopup.SetActive(false);
    }

    public class LevelData
    {
        public String name;
        public List<Cube> cubes;
        public List<Coin> coins;

        public LevelData(String name)
        {
            this.name = name;
            cubes = new List<Cube>();
            coins = new List<Coin>();
        }
        

        public class Cube
        {
            public float x1;
            public float y1;
            public float z1;
            public float x2;
            public float y2;
            public float z2;

            public float xRot;
            public float yRot;
            public float zRot;

            public Cube(float x1, float y1, float z1, float x2, float y2, float z2, float xRot, float yRot, float zRot)
            {
                this.x1 = x1;
                this.y1 = y1;
                this.z1 = z1;
                this.x2 = x2;
                this.y2 = y2;
                this.z2 = z2;
                this.xRot = xRot;
                this.yRot = yRot;
                this.zRot = zRot;
            }

            public Cube(float x1, float y1, float z1, float x2, float y2, float z2) : this(x1, y1, z1, x2, y2, z2, 0, 0, 0)
            {

            }
        }

        public class Coin
        {
            public float x;
            public float y;
            public float z;
            public int type;

            public Coin(float x, float y, float z, int type)
            {
                this.x = x;
                this.y = y;
                this.z = z;
                this.type = type;
            }
        }
    }

    public class Achievement
    {
        private string name;
        private string achievementText;
        private bool completed;

        public Achievement(string name, string achievementText, bool completed)
        {
            this.name = name;
            this.achievementText = achievementText;
            this.completed = completed;
        }

        public string getText()
        {
            return achievementText;
        }

        public string getName()
        {
            return name;
        }

        public bool getCompleted()
        {
            return completed;
        }

        public void setCompleted(bool change)
        {
            completed = change;
        }
    }

    // Licheng Modification starts at line 264


    internal static int gameModeGetter()
    {
        return 0;
    }

    internal static void IncreaseSpeed()
    {
        speed *= 1.2;
    }

    internal static void DecreaseSpeed()
    {
        speed *= 1/1.2;
    }

    internal static void AddCoin()
    {
        coinCount++;
    }

    internal static void AddCollision()
    {
        collisionCount++;
    }

    internal static void DeductScore(int deduction)
    {
        gameScoreDeductions += deduction;
    }

}
