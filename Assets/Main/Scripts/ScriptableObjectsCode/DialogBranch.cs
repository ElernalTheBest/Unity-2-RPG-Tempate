using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Branch"
, menuName="CustomObject/Dialogue/Branch")]
public class DialogBranch : ScriptableObject
{
    public string dialogueID = "";
    public List<string> DialogueLines;
    public List<ResponseBranch> ResponseOption;
}
[System.Serializable]

public class ResponseBranch

{
        public string text;
        public DialogBranch nextBranch;

}
