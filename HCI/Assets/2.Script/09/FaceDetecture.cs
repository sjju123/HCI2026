using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceDetecture : MonoBehaviour
{
    public GameObject positionCube;
    ARFaceManager afm;
    ARFace face = null;
    int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        afm = GetComponent<ARFaceManager>();
        positionCube.SetActive(false);
        afm.trackablesChanged.AddListener(args =>
        {
            foreach (var f in args.added) face = f;
            foreach (var kf in args.removed)
                if (kf.Value == face) face = null;
        });


    }

    public void OnClick()
    {
        if (face == null) return;
        if (face.vertices.Length < 0) return;

        positionCube.SetActive(true);
        positionCube.transform.position = face.transform.TransformPoint(face.vertices[index]);
        index++;
        if (index >= 0) ;
    }

    // Update is called once per frame

}
