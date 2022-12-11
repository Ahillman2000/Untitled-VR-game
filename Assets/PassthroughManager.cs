using System.Collections.Generic;
using UnityEngine;

public class PassthroughManager : MonoBehaviour
{
    public OVRPassthroughLayer passthrough;
    public List<Gradient> colourMapGradient;

    public void SetOpacity(float value)
    {
        passthrough.textureOpacity = value;
    }

    public void SetColourMapGradient(int index)
    {
        passthrough.colorMapEditorGradient = colourMapGradient[index];
    }

    public void SetBrightness(float value)
    {
        passthrough.colorMapEditorBrightness = value;
    }
    
    public void SetContrast(float value)
    {
        passthrough.colorMapEditorContrast = value;
    }
    
    public void SetPosterize(float value)
    {
        passthrough.colorMapEditorPosterize = value;
    }
}
