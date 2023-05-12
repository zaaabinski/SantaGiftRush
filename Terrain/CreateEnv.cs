using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class CreateEnv : MonoBehaviour
{
    public GameObject House1;
    public GameObject House2;
    public GameObject House3;
    public GameObject House4;
    public GameObject Snowman;
    public GameObject Tree;
    public GameObject Carrot;
    public SpriteShapeController shape;
    public CreateNewChunk CNC;
    public GameObject BirdRocket;
    public GameObject Cloud;
    int startingPoint;
    public GameObject cm1, cm2, cm3, cm4, cm5;
    public GameVariables GV;
    private void Awake()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
        shape = gameObject.GetComponent<SpriteShapeController>();
        CNC = GameObject.Find("ChunkCreator").GetComponent<CreateNewChunk>();
        if (CNC.i == 0)
        {
            startingPoint = 4;
        }
        else
        {
            startingPoint = 2;
        }
        StartCoroutine(CreateThings(gameObject));
    }
    public IEnumerator CreateThings(GameObject terrainOBJ)
    {
        shape = terrainOBJ.GetComponent<SpriteShapeController>();
        yield return new WaitForSeconds(0.05f);


        for (int i = startingPoint; i <= 16; i++)
        {
            int rand = Random.Range(3, 7);
             if (rand == 3)
            {
                //blue house
                GameObject ObjectPref = Instantiate(House1);
                ObjectPref.transform.parent = gameObject.transform;
                ObjectPref.transform.position = new Vector2(shape.spline.GetPosition(index: i).x + 13f, shape.spline.GetPosition(index: i).y - 4.82f);
            }
            else if (rand == 4)
            {
                //green house
                GameObject ObjectPref = Instantiate(House2);
                ObjectPref.transform.parent = gameObject.transform;
                ObjectPref.transform.position = new Vector2(shape.spline.GetPosition(index: i).x + 13f, shape.spline.GetPosition(index: i).y - 4.65f);
            }
            else if (rand == 5)
            {
                //orange house
                GameObject ObjectPref = Instantiate(House3);
                ObjectPref.transform.parent = gameObject.transform;
                ObjectPref.transform.position = new Vector2(shape.spline.GetPosition(index: i).x + 13f, shape.spline.GetPosition(index: i).y - 4.1f - 0.3f);
            }
            else if (rand == 6)
            {
                //red house
                GameObject ObjectPref = Instantiate(House4);
                ObjectPref.transform.parent = gameObject.transform;
                ObjectPref.transform.position = new Vector2(shape.spline.GetPosition(index: i).x + 13f, shape.spline.GetPosition(index: i).y - 4.35f);
            }
        }



        if (CNC.i == 0)
        {
            //bird
            int spawnB;
            spawnB = Random.Range(1, 2);
            if (spawnB == 1)
            {
                int point; float birdHight;
                birdHight = Random.Range(2f, 4f);
                point = Random.Range(9, 17);
                GameObject BirdPref = Instantiate(BirdRocket);
                BirdPref.transform.parent = gameObject.transform;
                BirdPref.transform.position = new Vector2(shape.spline.GetPosition(index: point).x + 13f, birdHight);
            }
            //cloud
            int pointC; float couldHight;
            couldHight = Random.Range(2f, 4.5f);
            pointC = Random.Range(7, 17);
            GameObject CludPref = Instantiate(Cloud);
            CludPref.transform.parent = gameObject.transform;
            CludPref.transform.position = new Vector2(shape.spline.GetPosition(index: pointC).x + 13f, couldHight);

            //snowman
            int pointS;
            pointS = Random.Range(7, 17);
            GameObject SnowmanPref = Instantiate(Snowman);
            SnowmanPref.transform.parent = gameObject.transform;
            SnowmanPref.transform.position = new Vector2(shape.spline.GetPosition(index: pointS).x + 11.5f, shape.spline.GetPosition(index: pointS).y-5f);

            //coins
            if (GV.minutes == 0)
            {
                int pointCoin1; float Coin1Hight;
                Coin1Hight = Random.Range(2f, 4.5f);
                pointCoin1 = Random.Range(6, 9);
                GameObject Coin1Pref = Instantiate(cm1);
                Coin1Pref.transform.parent = gameObject.transform;
                Coin1Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin1).x + 13f, Coin1Hight);

                int pointCoin2; float Coin2Hight;
                Coin2Hight = Random.Range(2f, 4.5f);
                pointCoin2 = Random.Range(9, 13);
                GameObject Coin2Pref = Instantiate(cm1);
                Coin2Pref.transform.parent = gameObject.transform;
                Coin2Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin2).x + 13f, Coin2Hight);

                int pointCoin3; float Coin3Hight;
                Coin3Hight = Random.Range(2f, 4.5f);
                pointCoin3 = Random.Range(13, 17);
                GameObject Coin3Pref = Instantiate(cm1);
                Coin3Pref.transform.parent = gameObject.transform;
                Coin3Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin3).x + 13f, Coin3Hight);
            }
        }
        else
        {
            //bird
            int point; float birdHight;
            birdHight = Random.Range(2f, 4f);
            point = Random.Range(3, 17);
            GameObject BirdPref = Instantiate(BirdRocket);
            BirdPref.transform.parent = gameObject.transform;
            BirdPref.transform.position = new Vector2(shape.spline.GetPosition(index: point).x + 13f, birdHight);

            //cloud

            int pointC; float couldHight;
            couldHight = Random.Range(3.5f, 5f);
            pointC = Random.Range(1, 17);
            GameObject CludPref = Instantiate(Cloud);
            CludPref.transform.parent = gameObject.transform;
            CludPref.transform.position = new Vector2(shape.spline.GetPosition(index: pointC).x + 13f, couldHight);

            //snowman
            int pointS;
            pointS = Random.Range(3, 17);
            GameObject SnowmanPref = Instantiate(Snowman);
            SnowmanPref.transform.parent = gameObject.transform;
            SnowmanPref.transform.position = new Vector2(shape.spline.GetPosition(index: pointS).x + 11.5f, shape.spline.GetPosition(index: pointS).y- 5f);

            //coins
            if (GV.minutes == 0)
            {
                int pointCoin1; float Coin1Hight;
                Coin1Hight = Random.Range(2f, 4.5f);
                pointCoin1 = Random.Range(6, 9);
                GameObject Coin1Pref = Instantiate(cm1);
                Coin1Pref.transform.parent = gameObject.transform;
                Coin1Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin1).x + 13f, Coin1Hight);

                int pointCoin2; float Coin2Hight;
                Coin2Hight = Random.Range(2f, 4.5f);
                pointCoin2 = Random.Range(9, 13);
                GameObject Coin2Pref = Instantiate(cm1);
                Coin2Pref.transform.parent = gameObject.transform;
                Coin2Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin2).x + 13f, Coin2Hight);

                int pointCoin3; float Coin3Hight;
                Coin3Hight = Random.Range(2f, 4.5f);
                pointCoin3 = Random.Range(12, 17);
                GameObject Coin3Pref = Instantiate(cm1);
                Coin3Pref.transform.parent = gameObject.transform;
                Coin3Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin3).x + 13f, Coin3Hight);
            }
            if (GV.minutes == 1)
            {
                int pointCoin1; float Coin1Hight;
                Coin1Hight = Random.Range(2f, 4.5f);
                pointCoin1 = Random.Range(1, 7);
                GameObject Coin1Pref = Instantiate(cm2);
                Coin1Pref.transform.parent = gameObject.transform;
                Coin1Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin1).x + 13f, Coin1Hight);

                int pointCoin2; float Coin2Hight;
                Coin2Hight = Random.Range(2f, 4.5f);
                pointCoin2 = Random.Range(7, 13);
                GameObject Coin2Pref = Instantiate(cm2);
                Coin2Pref.transform.parent = gameObject.transform;
                Coin2Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin2).x + 13f, Coin2Hight);

                int pointCoin3; float Coin3Hight;
                Coin3Hight = Random.Range(2f, 4.5f);
                pointCoin3 = Random.Range(13, 17);
                GameObject Coin3Pref = Instantiate(cm2);
                Coin3Pref.transform.parent = gameObject.transform;
                Coin3Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin3).x + 13f, Coin3Hight);
            }
            if (GV.minutes == 2)
            {
                int pointCoin1; float Coin1Hight;
                Coin1Hight = Random.Range(2f, 4.5f);
                pointCoin1 = Random.Range(1, 7);
                GameObject Coin1Pref = Instantiate(cm3);
                Coin1Pref.transform.parent = gameObject.transform;
                Coin1Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin1).x + 13f, Coin1Hight);

                int pointCoin2; float Coin2Hight;
                Coin2Hight = Random.Range(2f, 4.5f);
                pointCoin2 = Random.Range(7, 13);
                GameObject Coin2Pref = Instantiate(cm3);
                Coin2Pref.transform.parent = gameObject.transform;
                Coin2Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin2).x + 13f, Coin2Hight);

                int pointCoin3; float Coin3Hight;
                Coin3Hight = Random.Range(2f, 4.5f);
                pointCoin3 = Random.Range(13, 17);
                GameObject Coin3Pref = Instantiate(cm3);
                Coin3Pref.transform.parent = gameObject.transform;
                Coin3Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin3).x + 13f, Coin3Hight);
            }
            if (GV.minutes == 3)
            {
                int pointCoin1; float Coin1Hight;
                Coin1Hight = Random.Range(2f, 4.5f);
                pointCoin1 = Random.Range(1, 7);
                GameObject Coin1Pref = Instantiate(cm4);
                Coin1Pref.transform.parent = gameObject.transform;
                Coin1Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin1).x + 13f, Coin1Hight);

                int pointCoin2; float Coin2Hight;
                Coin2Hight = Random.Range(2f, 4.5f);
                pointCoin2 = Random.Range(7, 13);
                GameObject Coin2Pref = Instantiate(cm4);
                Coin2Pref.transform.parent = gameObject.transform;
                Coin2Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin2).x + 13f, Coin2Hight);

                int pointCoin3; float Coin3Hight;
                Coin3Hight = Random.Range(2f, 4.5f);
                pointCoin3 = Random.Range(13, 17);
                GameObject Coin3Pref = Instantiate(cm4);
                Coin3Pref.transform.parent = gameObject.transform;
                Coin3Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin3).x + 13f, Coin3Hight);
            }
            if (GV.minutes == 4)
            {
                int pointCoin1; float Coin1Hight;
                Coin1Hight = Random.Range(2f, 4.5f);
                pointCoin1 = Random.Range(1, 7);
                GameObject Coin1Pref = Instantiate(cm5);
                Coin1Pref.transform.parent = gameObject.transform;
                Coin1Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin1).x + 13f, Coin1Hight);

                int pointCoin2; float Coin2Hight;
                Coin2Hight = Random.Range(2f, 4.5f);
                pointCoin2 = Random.Range(7, 13);
                GameObject Coin2Pref = Instantiate(cm5);
                Coin2Pref.transform.parent = gameObject.transform;
                Coin2Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin2).x + 13f, Coin2Hight);

                int pointCoin3; float Coin3Hight;
                Coin3Hight = Random.Range(2f, 4.5f);
                pointCoin3 = Random.Range(13, 17);
                GameObject Coin3Pref = Instantiate(cm5);
                Coin3Pref.transform.parent = gameObject.transform;
                Coin3Pref.transform.position = new Vector2(shape.spline.GetPosition(index: pointCoin3).x + 13f, Coin3Hight);
            }

        }


    }
}
