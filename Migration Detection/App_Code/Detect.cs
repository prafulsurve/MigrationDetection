using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.NetworkInformation;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Detect" in code, svc and config file together.
[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
public class Detect : IDetect
{
    string landMark1, landMark2, landMark3;
    int pingCounter;
    int pingCounter2;
    double threshold;
    double[] avgLatency;
    double[] finalAvgLatency;
    double[] avgLatency2;
    double[] finalAvgLatency2;
    double[] minThreshold;
    double[] maxThreshold;
    public void setLandMark(string lm1, string lm2, string lm3)
    {
        landMark1 = lm1;
        landMark2 = lm2;
        landMark3 = lm3;
    }

    public void setPingCounter(int p)
    {
        pingCounter = p;
    }

    public void resetPingCounter(int p)
    {
        pingCounter2 = p;
    }

    public void setThreshold(double t)
    {
        threshold = t;
    }

    public double[] calculateAvgLatency()
    {
        finalAvgLatency = new double[3] { 0, 0, 0 };
        avgLatency = new double[3] { 0, 0, 0 };
        Ping pingSender = new Ping();
        PingOptions options = new PingOptions();
        PingReply reply;
        options.DontFragment = true;
        string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        int timeout = 120;
        byte[] buffer = Encoding.ASCII.GetBytes(data);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < pingCounter; j++)
            {
                reply = pingSender.Send(landMark1, timeout, buffer, options);
                avgLatency[0] = avgLatency[0] + reply.RoundtripTime;

                reply = pingSender.Send(landMark2, timeout, buffer, options);
                avgLatency[1] = avgLatency[1] + reply.RoundtripTime;

                reply = pingSender.Send(landMark3, timeout, buffer, options);
                avgLatency[2] = avgLatency[2] + reply.RoundtripTime;
            }
            for (int k = 0; k < 3; k++)
            {
                avgLatency[k] = avgLatency[k] / pingCounter;
                finalAvgLatency[k] = finalAvgLatency[k] + avgLatency[k];
                avgLatency[k] = 0;
            }
        }
        for (int i = 0; i < 3; i++)
            finalAvgLatency[i] = finalAvgLatency[i] / 3;
        return (finalAvgLatency);
    }

    public double[] calculateMinThreshold()
    {
        minThreshold = new double[3];
        for (int i = 0; i < 3; i++)
            minThreshold[i] = finalAvgLatency[i] - finalAvgLatency[i] * threshold;
        return (minThreshold);
    }

    public double[] calculateMaxThreshold()
    {
        maxThreshold = new double[3];
        for (int i = 0; i < 3; i++)
            maxThreshold[i] = finalAvgLatency[i] + finalAvgLatency[i] * threshold;
        return (maxThreshold);
    }

    public double[] reCalculateAvgLatency()
    {
        avgLatency2 = new double[3] { 0, 0, 0 };
        finalAvgLatency2 = new double[3] { 0, 0, 0};
        Ping pingSender = new Ping();
        PingOptions options = new PingOptions();
        PingReply reply;
        options.DontFragment = true;
        string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        int timeout = 120;
        byte[] buffer = Encoding.ASCII.GetBytes(data);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < pingCounter2; j++)
            {
                reply = pingSender.Send(landMark1, timeout, buffer, options);
                avgLatency2[0] = avgLatency2[0] + reply.RoundtripTime;

                reply = pingSender.Send(landMark2, timeout, buffer, options);
                avgLatency2[1] = avgLatency2[1] + reply.RoundtripTime;

                reply = pingSender.Send(landMark3, timeout, buffer, options);
                avgLatency2[2] = avgLatency2[2] + reply.RoundtripTime;
            }
            for (int k = 0; k < 3; k++)
            {
                avgLatency2[k] = avgLatency2[k] / pingCounter2;
                finalAvgLatency2[k] = finalAvgLatency2[k] + avgLatency2[k];
                avgLatency2[k] = 0;
            }
        }
        for (int i = 0; i < 3; i++)
            finalAvgLatency2[i] = finalAvgLatency2[i] / 3;
        return (finalAvgLatency2);
    }
}
