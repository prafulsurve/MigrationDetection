using ServiceReferenceMigration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DetectClient proxy = new DetectClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        /*//if (IsPostBack)
        {
            //if (Radio_automatic.Checked == true)
            {
                
               // var funcCaller = new Func<bool>(autoRecalculation);
               // var asyncResult = funcCaller.BeginInvoke(null, null);
              //  asyncResult.AsyncWaitHandle.WaitOne();
              //  if (funcCaller.EndInvoke(asyncResult))
                {
                    
                }
                //autoRecalculation(min);
            }
        }*/
    }

    void autoRecalculation()
    {
        proxy.resetPingCounter(Int32.Parse(setPC1.Text));
        double[] d = proxy.reCalculateAvgLatency();
        avgLatency21.Text = "" + Math.Round(d[0],2) + " ms";
        avgLatency22.Text = "" + Math.Round(d[1],2) + " ms";
        avgLatency23.Text = "" + Math.Round(d[2],2) + " ms";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        proxy.setPingCounter(Int32.Parse(setPC1.Text));
        latencyCalculator();
    }

    private void latencyCalculator()
    {
        proxy.setThreshold(float.Parse(text_threshold.Text));
        proxy.setLandMark(text_LM1.Text, textLM2.Text, textLM3.Text);
        double[] avg = proxy.calculateAvgLatency();
        avgLatency11.Text = "" + Math.Round(avg[0],2) + " ms";
        avgLatency12.Text = "" + Math.Round(avg[1],2) + " ms";
        avgLatency13.Text = "" + Math.Round(avg[2],2) + " ms";
        double[] t_min = proxy.calculateMinThreshold();
        tmin1.Text = "" + Math.Round(t_min[0],2) + " ms";
        tmin2.Text = "" + Math.Round(t_min[1],2) + " ms";
        tmin3.Text = "" + Math.Round(t_min[2],2) + " ms";

        double[] t_max = proxy.calculateMaxThreshold();
        tmax1.Text = "" + Math.Round(t_max[0],2) + " ms";
        tmax2.Text = "" + Math.Round(t_max[1],2) + " ms";
        tmax3.Text = "" + Math.Round(t_max[2],2) + " ms";
        //proxy.Close();
    }

    protected void Button_Recalculate(object sender, EventArgs e)
    {
        //proxy.setPingCounter(Int32.Parse(setPC1.Text));
        //latencyCalculator();
        autoRecalculation();
    }
    async Task sleep()
    {
        //while(true)
            await Task.Delay(6000);
    }
    //async protected void Radio_automatic_CheckedChanged(object sender, EventArgs e)
    //{
    //    if (Radio_automatic.Checked == true)
    //    {
    //        await sleep();
    //        autoRecalculation();

    //    }
    //}
}