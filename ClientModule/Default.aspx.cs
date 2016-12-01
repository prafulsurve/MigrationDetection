using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MigrationServiceReference;
using System.Threading;
using System.Threading.Tasks;

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
        proxy.resetPingCounter(10);
        double[] d = proxy.reCalculateAvgLatency();
        avgLatency21.Text = "" + d[0];
        avgLatency22.Text = "" + d[1];
        avgLatency23.Text = "" + d[2];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
        proxy.setPingCounter(Int32.Parse(setPC1.Text));
        proxy.setThreshold(float.Parse(text_threshold.Text));
        proxy.setLandMark(text_LM1.Text, textLM2.Text, textLM3.Text);
        double[] avg = proxy.calculateAvgLatency();
        avgLatency11.Text = "" + avg[0] + " ms";
        avgLatency12.Text = "" + avg[1] + " ms";
        avgLatency13.Text = "" + avg[2] + " ms";
        double[] t_min = proxy.calculateMinThreshold();
        tmin1.Text = "" + t_min[0] + " ms";
        tmin2.Text = "" + t_min[1] + " ms";
        tmin3.Text = "" + t_min[2] + " ms";

        double[] t_max = proxy.calculateMaxThreshold();
        tmax1.Text = "" + t_max[0] + " ms";
        tmax2.Text = "" + t_max[1] + " ms";
        tmax3.Text = "" + t_max[2] + " ms";
        //proxy.Close();
    }
    async Task sleep()
    {
        //while(true)
            await Task.Delay(6000);
    }
    async protected void Radio_automatic_CheckedChanged(object sender, EventArgs e)
    {
        if (Radio_automatic.Checked == true)
        {
            await sleep();
            autoRecalculation();

        }
    }
}