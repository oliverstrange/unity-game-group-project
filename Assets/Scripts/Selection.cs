using UnityEngine;
using UnityEngine.UI;


public class Selection: MonoBehaviour
{
    [SerializeField] private RectTransform[] options;
    /*[SerializeField] private AudioClip changeSelection;
    [SerializeField] private AudioClip pickOption;*/
    private RectTransform rect;
    private int currentPosition;

    private void Awake()
    {
        rect = GetComponent<RectTransform>();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            ChangePosition(-1);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            ChangePosition(1);

        if (Input.GetKeyDown(KeyCode.Return))
            Choice();
    }

 

    private void ChangePosition(int _change)
    {
        currentPosition += _change;

        //if(_change != 0)
           // SoundManager.instance.PlaySound(changeSelection);

        if (currentPosition < 0)
            currentPosition = options.Length -1;
        else if (currentPosition > options.Length -1)
            currentPosition = 0;
        
        rect.position = new Vector3(rect.position.x, options[currentPosition].position.y, 0);
    }

    private void Choice()
    {
        options[currentPosition].GetComponent<Button>().onClick.Invoke();
    }
}

