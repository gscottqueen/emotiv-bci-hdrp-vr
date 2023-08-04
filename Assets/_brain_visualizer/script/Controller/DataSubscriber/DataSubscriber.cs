using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;
using EmotivUnityPlugin;
using Zenject;


namespace dirox.emotiv.controller
{

  /// <summary>
  /// Responsible for subscribing and displaying data
  /// we support for eeg, performance metrics, motion data at this version.
  /// </summary>
  public class DataSubscriber : BaseCanvasView
  {
    DataStreamManager _dataStreamMgr = DataStreamManager.Instance;
    float _timerDataUpdate = 0;
    const float TIME_UPDATE_DATA = .01f;
    [SerializeField] private bool useVirtualDevice;
    [SerializeField] private bool usePhysicalDevice;

    [SerializeField] private GameObject motionCube;  // a simple cube we can manipulate with data

    // Quaternion values
    [SerializeField] private double qW;
    [SerializeField] private double qX;
    [SerializeField] private double qY;
    [SerializeField] private double qZ;

    // Acceleration values
    [SerializeField] private double accelerationX;
    [SerializeField] private double accelerationY;
    [SerializeField] private double accelerationZ;

    // Interactables
    [SerializeField] private GameObject interest;

    // FX
    [SerializeField] private VisualEffect lightChapel;
    private ExposedProperty m_lightChapelProperty = "LightCount";

    void Update()
    {
      if (!this.isActive)
      {
        return;
      }

      _timerDataUpdate += Time.deltaTime;
      if (_timerDataUpdate < TIME_UPDATE_DATA)
        return;

      _timerDataUpdate -= TIME_UPDATE_DATA;

      // update motion data
      if (DataStreamManager.Instance.GetNumberMotionSamples() > 0)
      {

        // get each element from within the data stream manager
        foreach (var ele in DataStreamManager.Instance.GetMotionChannels())
        {
          string chanStr = ChannelStringList.ChannelToString(ele);
          // double is similar to a float
          double[] data = DataStreamManager.Instance.GetMotionData(ele);
/*          Debug.Log(data.Length);*/

          if (usePhysicalDevice == true && data != null && data.Length > 0)
          {
            if (chanStr == "Q0") qW = data[0];
            if (chanStr == "Q1") qW = data[0];
            if (chanStr == "Q2") qX = data[0];
            if (chanStr == "Q3") qY = data[0];
            if (chanStr == "Q0") qZ = data[0];
            if (chanStr == "ACCX") accelerationX = data[0];
            if (chanStr == "ACCY") accelerationY = data[0];
            if (chanStr == "ACCZ") accelerationZ = data[0];
          }

          // Update the rotation based on quaternion values
          Quaternion rotation = new Quaternion((float)qX, (float)qY, (float)qZ, (float)qW);
          motionCube.transform.rotation = rotation;

          // Apply rotation based on acceleration values
          Vector3 acceleration = new Vector3((float)accelerationX, (float)accelerationY, (float)accelerationZ);
          motionCube.transform.Rotate(acceleration * Time.deltaTime);
        }
      }
      // update pm data
      if (DataStreamManager.Instance.GetNumberPMSamples() > 0)
      {
        foreach (var ele in DataStreamManager.Instance.GetPMLists())
        {
          string chanStr = ele;
          double data = DataStreamManager.Instance.GetPMData(ele);
          if (usePhysicalDevice == true && data > -1 || useVirtualDevice == true && data > -1)
          {
            interest.SetActive(true);

            if (chanStr == "int")
            {
              Debug.Log("data" + data * 10);
              lightChapel.SetFloat(m_lightChapelProperty, (float)data * 100);
              Debug.Log(m_lightChapelProperty);
            }
          }
          else
          {
            interest.SetActive(false);
          }
        }
      }
    }

    public override void Activate()
    {
      Debug.Log("DataSubscriber: Activate");
      base.Activate();

      // motion subscribe
      List<string> dataStreamListMotion = new List<string>() { DataStreamName.Motion };
      _dataStreamMgr.SubscribeMoreData(dataStreamListMotion);

      // performance metrics data
      List<string> dataStreamListPerformance = new List<string>() { DataStreamName.PerformanceMetrics };
      _dataStreamMgr.SubscribeMoreData(dataStreamListPerformance);
    }

    public override void Deactivate()
    {
        Debug.Log("DataSubscriber: Deactivate");
        base.Deactivate();
    }
  }
}

