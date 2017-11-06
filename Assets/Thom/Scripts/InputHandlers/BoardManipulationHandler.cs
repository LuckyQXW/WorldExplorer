﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using System;

public class BoardManipulationHandler : MonoBehaviour, IManipulationHandler {

    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
        BoardInteraction.Instance.StopManipulatingTable();
    }

    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
        BoardInteraction.Instance.StopManipulatingTable();
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
        BoardInteraction.Instance.StartManipulatingTable(gameObject, gameObject.name);
    }

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        if (gameObject.name == "TiltInteractable")
        {
            BoardInteraction.Instance.UpdateTableTilt(eventData);
        }
    }
}
