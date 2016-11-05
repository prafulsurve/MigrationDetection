using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IDetect
{ 
    [OperationContract]
    void setLandMark(string lm1, string lm2, string lm3);
    [OperationContract]
    void setPingCounter(int p);
    [OperationContract]
    void resetPingCounter(int p);
    [OperationContract]
    void setThreshold(double t);
    [OperationContract]
    double[] calculateAvgLatency();
    [OperationContract]
    double[] calculateMinThreshold();
    [OperationContract]
    double[] calculateMaxThreshold();
    [OperationContract]
    double[] reCalculateAvgLatency();
}
